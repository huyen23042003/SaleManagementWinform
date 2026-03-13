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
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        public CustomerForm()
        {
            InitializeComponent();
            GetCustomers();
        }


        private void GetCustomers()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CustomerID");
            dataTable.Columns.Add("CustomerName");
            dataTable.Columns.Add("Phone");

            List<CustomerEntity>  customers = _customerRepository.GetAllCustomers();

            foreach(CustomerEntity customer in customers)
            {
                var row = dataTable.NewRow();
                row["CustomerID"] = customer.CustomerID;
                row["CustomerName"] = customer.CustomerName;
                row["Phone"] = customer.Phone;

                dataTable.Rows.Add(row);
            }
            this.customersTable.DataSource = dataTable;

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.GetCustomers();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            if(addCustomerForm.ShowDialog() == DialogResult.OK)
            {
                this.GetCustomers();
            }
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            if (customersTable.CurrentRow == null ||
                customersTable.CurrentRow.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string customerID = customersTable.CurrentRow.Cells["CustomerID"].Value.ToString();
            string customerName = customersTable.CurrentRow.Cells["CustomerName"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm: {customerName} không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_customerRepository.IsCustomerInInvoice(customerID))
                {
                    MessageBox.Show($"{customerName} đã tồn tại trong hóa đơn, không thể xóa", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_customerRepository.DeleteCustomer(customerID))
                {
                    MessageBox.Show("Xóa thành công ", "Thông báo");
                    GetCustomers();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }


        private void btnViewDetailCustomer_Click(object sender, EventArgs e)
        {
            if (customersTable.CurrentRow == null || customersTable.CurrentRow.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xem!");
                return;
            }

            string customerID = customersTable.CurrentRow.Cells["CustomerID"].Value.ToString();
            ViewCustomerDetailForm viewCustomerDetailForm = new ViewCustomerDetailForm(customerID);
            viewCustomerDetailForm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (customersTable.CurrentRow == null || customersTable.CurrentRow.Cells["CustomerID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            string customerID = customersTable.CurrentRow.Cells["CustomerID"].Value.ToString();

            EditCustomerForm editForm = new EditCustomerForm(customerID);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                GetCustomers();
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            contextMenuAction.Show(btnExecute, new Point(0, btnExecute.Height));

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
