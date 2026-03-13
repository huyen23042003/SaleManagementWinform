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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
