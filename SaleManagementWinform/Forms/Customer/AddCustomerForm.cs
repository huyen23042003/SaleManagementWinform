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
    public partial class AddCustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private bool isDataChanged = false;

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

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
                Clear();
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
        private bool Save()
        {
            string customerID = tbCustomerID.Text;
            if (string.IsNullOrWhiteSpace(tbCustomerID.Text) ||
               string.IsNullOrWhiteSpace(tbCustomerName.Text) ||
               string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_customerRepository.GetCustomerByID(tbCustomerID.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbPhone.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 9 chữ số", "Định dạng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPhone.Focus();
                return false;
            }
            if (!tbPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được phép chứa các chữ số (0-9)", "Định dạng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPhone.Focus();
                return false;
            }
            var customer = new CustomerEntity
            {
                CustomerID = tbCustomerID.Text,
                CustomerName = tbCustomerName.Text,
                Phone = tbPhone.Text,
            };
            if (_customerRepository.AddNewCustomer(customer))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo");
                return true;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void Clear()
        {
            tbCustomerID.Clear();
            tbCustomerName.Clear();
            tbPhone.Clear();
            tbCustomerID.Focus();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbCustomerID.SelectionStart;
            tbCustomerID.Text = tbCustomerID.Text.ToUpper().Replace(" ", "");
            tbCustomerID.SelectionStart = selectionStart;

        }
    }
}
