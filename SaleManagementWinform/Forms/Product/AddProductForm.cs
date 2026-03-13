using SaleManagementWinform.Repository;
using SaleManagementWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform.Forms
{
    public partial class AddProductForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private bool isDataChanged = false;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            tbProductID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                isDataChanged = true;
                ClearFields();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isDataChanged)
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        

        private void tbProductID_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbProductID.SelectionStart;
            tbProductID.Text = tbProductID.Text.ToUpper().Replace(" ","");
            tbProductID.SelectionStart = selectionStart;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            tbPrice.TextChanged -= tbPrice_TextChanged;

            try
            {
                string value = tbPrice.Text.Replace(".", "").Replace(",", "").Trim();

                if (!string.IsNullOrEmpty(value))
                {
                    if (decimal.TryParse(value, out decimal price))
                    {
                        tbPrice.Text = string.Format("{0:N0}", price).Replace(",", ".");

                        tbPrice.SelectionStart = tbPrice.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            tbPrice.TextChanged += tbPrice_TextChanged;
        }

        private bool Save()
        {
            if(string.IsNullOrWhiteSpace(tbProductID.Text) ||
                string.IsNullOrWhiteSpace(tbProductID.Text) ||
                string.IsNullOrWhiteSpace(tbProductID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            ProductEntity existProduct = _productRepository.GetProductByID(tbProductID.Text);
            if (!string.IsNullOrEmpty(existProduct.ProductID))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string cleanPrice = tbPrice.Text.Replace(".", "");
            if (!decimal.TryParse(cleanPrice, out decimal price) ||
                price <= 0)
            {
                MessageBox.Show("Giá sản phẩm phải là số lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ProductEntity product = new ProductEntity
            {
                ProductID = tbProductID.Text.Trim(),
                ProductName = tbProductName.Text.Trim(),
                Price = price,
            };

            if(_productRepository.AddProduct(product))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thành công");
                return true;
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Lỗi");
                return false;
            }
        }

        public void ClearFields()
        {
            tbProductID.Clear();
            tbProductName.Clear();
            tbPrice.Clear();
            tbProductID.Focus();

        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
