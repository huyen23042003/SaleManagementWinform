using SaleManagementWinform.Common.Enums;
using SaleManagementWinform.Common.Helpers;
using SaleManagementWinform.Models;
using SaleManagementWinform.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaleManagementWinform.Forms.Customer
{
    public partial class CustomerDetailForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly FormMode _mode;
        private readonly string _customerID;
        private bool _isDataChanged = false;

        public CustomerDetailForm(FormMode mode, string customerID = null)
        {
            InitializeComponent();
            _mode = mode;
            _customerID = customerID;
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            switch (_mode)
            {
                case FormMode.Add:
                    this.Text = "Thêm khách hàng";
                    btnSave.Text = "Lưu";
                    btnContinue.Visible = true;
                    tbCustomerID.ReadOnly = false;
                    break;

                case FormMode.Edit:
                    this.Text = "Sửa khách hàng";
                    btnSave.Text = "Cập nhật";
                    btnContinue.Visible = false;
                    tbCustomerID.ReadOnly = true;
                    tbCustomerID.TabStop = false;
                    LoadData();
                    break;

                case FormMode.View:
                    this.Text = "Xem chi tiết khách hàng";
                    btnSave.Visible = false;
                    btnContinue.Visible = false;

                    tbCustomerID.ReadOnly = true;
                    tbCustomerName.ReadOnly = true;
                    tbPhone.ReadOnly = true;

                    tbCustomerID.BackColor = Color.LightGray;
                    tbCustomerName.BackColor = Color.LightGray;
                    tbPhone.BackColor = Color.LightGray;

                    LoadData();
                    break;
            }
        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(_customerID))
                return;

            var customer = _customerRepository.GetCustomerByID(_customerID);
            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tbCustomerID.Text = customer.CustomerID;
            tbCustomerName.Text = customer.CustomerName;
            tbPhone.Text = customer.Phone;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbCustomerID.Text) ||
                string.IsNullOrWhiteSpace(tbCustomerName.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_mode == FormMode.Add)
            {
                if (_customerRepository.GetCustomerByID(tbCustomerID.Text.Trim()) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCustomerID.Focus();
                    return false;
                }
            }

            if (!Validator.IsValidPhone(tbPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ, phải gồm từ 9 đến 11 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPhone.Focus();
                return false;
            }

            return true;
        }

        private CustomerEntity GetCustomerFromForm()
        {
            return new CustomerEntity
            {
                CustomerID = tbCustomerID.Text.Trim().ToUpper(),
                CustomerName = tbCustomerName.Text.Trim(),
                Phone = tbPhone.Text.Trim()
            };
        }

        private bool SaveData()
        {
            if (!ValidateInput())
                return false;

            var customer = GetCustomerFromForm();
            bool result = false;

            if (_mode == FormMode.Add)
            {
                result = _customerRepository.AddNewCustomer(customer);
                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_mode == FormMode.Edit)
            {
                result = _customerRepository.UpdateCustomer(customer);
                if (result)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbCustomerID.Clear();
            tbCustomerName.Clear();
            tbPhone.Clear();
            tbCustomerID.Focus();
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
            if (_isDataChanged)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (_mode != FormMode.Add)
                return;

            int selectionStart = tbCustomerID.SelectionStart;
            tbCustomerID.Text = tbCustomerID.Text.Replace(" ", "").ToUpper();
            tbCustomerID.SelectionStart = tbCustomerID.Text.Length >= selectionStart ? selectionStart : tbCustomerID.Text.Length;
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