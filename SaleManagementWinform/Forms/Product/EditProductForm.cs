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
    public partial class EditProductForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly string _productID;
        public EditProductForm(string productID)
        {
            InitializeComponent();
            _productID = productID;

            tbProductID.ReadOnly = true;
            tbProductID.TabStop = false;
        }


        private void EditProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var product = _productRepository.GetProductByID(_productID);
            if (product != null)
            {
                tbProductID.Text = product.ProductID;
                tbProductName.Text = product.ProductName;
                tbPrice.Text = product.Price.ToString("N0").Replace(",", ".");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cleanPrice = tbPrice.Text.Replace(".", "");

            if(string.IsNullOrWhiteSpace(tbProductName.Text) ||
              string.IsNullOrWhiteSpace(cleanPrice))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!decimal.TryParse(cleanPrice, out decimal price) ||(price < 0))
            {
                MessageBox.Show("Giá sản phẩm phải là số lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new ProductEntity
            {
                ProductID = tbProductID.Text,
                ProductName = tbProductName.Text,
                Price = price,
            };

            if (_productRepository.UpdateProduct(product))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
}
