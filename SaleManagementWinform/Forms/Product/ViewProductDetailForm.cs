using SaleManagementWinform.Repository;
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
    public partial class ViewProductDetailForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly string _productID;
        public ViewProductDetailForm(string productID)
        {
            InitializeComponent();
            _productID = productID;

            tbProductID.ReadOnly = true;
            tbProductName.ReadOnly = true;
            tbPrice.ReadOnly = true;

            tbProductID.BackColor = Color.LightGray;
            tbProductName.BackColor = Color.LightGray;
            tbPrice.BackColor = Color.LightGray;

        }


        private void ViewProductDetailForm_Load(object sender, EventArgs e)
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
