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
    public partial class ViewCustomerDetailForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly string _customerID;
        public ViewCustomerDetailForm(string customerID)
        {
            InitializeComponent();
            _customerID = customerID;

            tbCustomerID.ReadOnly = true;
            tbCustomerName.ReadOnly = true;
            tbPhone.ReadOnly = true;

            tbCustomerID.BackColor = Color.LightGray;
            tbCustomerName.BackColor = Color.LightGray;
            tbPhone.BackColor = Color.LightGray;

        }


        private void ViewCustomerDetailForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var customer = _customerRepository.GetCustomerByID(_customerID);
            if (customer != null)
            {
                tbCustomerID.Text = customer.CustomerID;
                tbCustomerName.Text = customer.CustomerName;
                tbPhone.Text = customer.Phone;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
