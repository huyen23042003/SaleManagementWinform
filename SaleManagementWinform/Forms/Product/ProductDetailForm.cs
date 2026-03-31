using SaleManagementWinform.Common.Enums;
using SaleManagementWinform.Common.Helpers;
using SaleManagementWinform.Models;
using SaleManagementWinform.Repository;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SaleManagementWinform.Forms
{
    public partial class ProductDetailForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly FormMode _mode;
        private readonly string _productID;
        private bool _isDataChanged = false;

        public ProductDetailForm(FormMode mode, string productID = null)
        {
            InitializeComponent();
            _mode = mode;
            _productID = productID;
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            switch (_mode)
            {
                case FormMode.Add:
                    this.Text = "Thêm sản phẩm";
                    btnSave.Text = "Lưu";
                    btnContinue.Visible = true;
                    tbProductID.ReadOnly = false;
                    tbProductID.TabStop = true;
                    tbProductID.Focus();
                    break;

                case FormMode.Edit:
                    this.Text = "Sửa sản phẩm";
                    btnSave.Text = "Cập nhật";
                    btnContinue.Visible = false;
                    tbProductID.ReadOnly = true;
                    tbProductID.TabStop = false;
                    LoadData();
                    break;

                case FormMode.View:
                    this.Text = "Xem chi tiết sản phẩm";
                    btnSave.Visible = false;
                    btnContinue.Visible = false;

                    tbProductID.ReadOnly = true;
                    tbProductName.ReadOnly = true;
                    tbPrice.ReadOnly = true;

                    tbProductID.BackColor = Color.LightGray;
                    tbProductName.BackColor = Color.LightGray;
                    tbPrice.BackColor = Color.LightGray;

                    LoadData();
                    break;
            }
        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(_productID))
                return;

            var product = _productRepository.GetProductByID(_productID);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tbProductID.Text = product.ProductID;
            tbProductName.Text = product.ProductName;
            tbPrice.Text = FormatHelper.FormatCurrency(product.Price);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbProductID.Text) ||
                string.IsNullOrWhiteSpace(tbProductName.Text) ||
                string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_mode == FormMode.Add)
            {
                var existProduct = _productRepository.GetProductByID(tbProductID.Text.Trim());
                if (existProduct != null && !string.IsNullOrWhiteSpace(existProduct.ProductID))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbProductID.Focus();
                    return false;
                }
            }

            if (!Validator.IsValidPositivePrice(tbPrice.Text, out _))
            {
                MessageBox.Show("Giá sản phẩm phải là số lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Focus();
                return false;
            }

            return true;
        }

        private ProductEntity GetProductFromForm()
        {
            Validator.IsValidPositivePrice(tbPrice.Text, out decimal price);

            return new ProductEntity
            {
                ProductID = tbProductID.Text.Trim().ToUpper(),
                ProductName = tbProductName.Text.Trim(),
                Price = price
            };
        }

        private bool SaveData()
        {
            if (!ValidateInput())
                return false;

            var product = GetProductFromForm();
            bool result = false;

            if (_mode == FormMode.Add)
            {
                result = _productRepository.AddProduct(product);
                if (result)
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_mode == FormMode.Edit)
            {
                result = _productRepository.UpdateProduct(product);
                if (result)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!result)
            {
                MessageBox.Show("Lưu dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void ClearForm()
        {
            tbProductID.Clear();
            tbProductName.Clear();
            tbPrice.Clear();
            tbProductID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                _isDataChanged = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                _isDataChanged = true;
                ClearForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = _isDataChanged ? DialogResult.OK : DialogResult.Cancel;
            this.Close();
        }

        private void tbProductID_TextChanged(object sender, EventArgs e)
        {
            if (_mode != FormMode.Add)
                return;

            int selectionStart = tbProductID.SelectionStart;
            tbProductID.Text = tbProductID.Text.Replace(" ", "").ToUpper();
            tbProductID.SelectionStart = selectionStart <= tbProductID.Text.Length
                ? selectionStart
                : tbProductID.Text.Length;
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            tbPrice.TextChanged -= tbPrice_TextChanged;

            try
            {
                string value = tbPrice.Text.Replace(".", "").Replace(",", "").Trim();

                if (!string.IsNullOrEmpty(value) && decimal.TryParse(value, out decimal price))
                {
                    tbPrice.Text = FormatHelper.FormatCurrency(price);
                    tbPrice.SelectionStart = tbPrice.Text.Length;
                }
            }
            finally
            {
                tbPrice.TextChanged += tbPrice_TextChanged;
            }
        }
    }
}