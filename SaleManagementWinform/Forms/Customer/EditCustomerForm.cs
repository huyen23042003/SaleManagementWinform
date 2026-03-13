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
    public partial class EditCustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly string _customerID;
        public EditCustomerForm(string customerID)
        {
            InitializeComponent();
            _customerID = customerID;

            tbCustomerID.ReadOnly = true;
            tbCustomerID.TabStop = false;
        }


        private void EditCustomerForm_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbCustomerName.Text) ||
              string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPhone.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 9 chữ số", "Định dạng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhone.Focus();
                return ;
            }

            var customer = new CustomerEntity
            {
                CustomerID = tbCustomerID.Text,
                CustomerName = tbCustomerName.Text,
                Phone = tbPhone.Text
            };

            if (_customerRepository.UpdateCustomer(customer))
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

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
