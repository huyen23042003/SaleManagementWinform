using SaleManagementWinform.Common.Enums;
using SaleManagementWinform.Forms;
using SaleManagementWinform.Models;
using SaleManagementWinform.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class ProductForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public ProductForm()
        {
            InitializeComponent();
            GetProducts();
        }

        public void GetProducts()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductID");
            dataTable.Columns.Add("ProductName");

            dataTable.Columns.Add("Price", typeof(decimal));

            List<ProductEntity> products = _productRepository.GetAllProducts();

            foreach (ProductEntity product in products)
            {
                var row = dataTable.NewRow();
                row["ProductID"] = product.ProductID;
                row["ProductName"] = product.ProductName;
                row["Price"] = product.Price; 

                dataTable.Rows.Add(row);
            }

            this.productsTable.DataSource = dataTable;

            this.productsTable.Columns["Price"].DefaultCellStyle.Format = "N0";
            this.productsTable.Columns["Price"].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("vi-VN");
            this.productsTable.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }



        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDetailForm form = new ProductDetailForm(FormMode.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetProducts();
            }
        }

        private void btnViewDetailProduct_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null || productsTable.CurrentRow.Cells["ProductID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            string productID = productsTable.CurrentRow.Cells["ProductID"].Value.ToString();
            ProductDetailForm form = new ProductDetailForm(FormMode.View,productID);
            form.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null || productsTable.CurrentRow.Cells["ProductID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            string productID = productsTable.CurrentRow.Cells["ProductID"].Value.ToString();

            ProductDetailForm form = new ProductDetailForm(FormMode.Edit,productID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetProducts();
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null ||
                productsTable.CurrentRow.Cells["ProductID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productID = productsTable.CurrentRow.Cells["ProductID"].Value.ToString();
            string productName = productsTable.CurrentRow.Cells["ProductName"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm: {productName} không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_productRepository.IsProductInInvoice(productID))
                {
                    MessageBox.Show($"{productName} đã tồn tại trong hóa đơn, không thể xóa", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_productRepository.DeleteProduct(productID))
                {
                    MessageBox.Show("Xóa thành công ", "Thông báo");
                    GetProducts();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            contextMenuAction.Show(btnExecute, new Point(0, btnExecute.Height));

        }
    }
}
