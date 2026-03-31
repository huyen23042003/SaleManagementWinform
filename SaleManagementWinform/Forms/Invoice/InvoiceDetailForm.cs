using SaleManagementWinform.Common.Enums;
using SaleManagementWinform.Common.Helpers;
using SaleManagementWinform.Models;
using SaleManagementWinform.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaleManagementWinform.Forms.Invoice
{
    public partial class InvoiceDetailForm : Form
    {
        private readonly InvoiceReporitory _invoiceReporitory = new InvoiceReporitory();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();

        private readonly FormMode _mode;
        private readonly string _invoiceID;
        private bool _isDataChanged = false;

        public InvoiceDetailForm(FormMode mode, string invoiceID = null)
        {
            InitializeComponent();
            _mode = mode;
            _invoiceID = invoiceID;
        }

        private void InvoiceDetailForm_Load(object sender, EventArgs e)
        {
            BindCustomers();
            BindProducts();
            SetupGrid();
            SetupForm();

            invoiceDetailTable.CurrentCellDirtyStateChanged += invoiceDetailTable_CurrentCellDirtyStateChanged;
            invoiceDetailTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            invoiceDetailTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            invoiceDetailTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void SetupForm()
        {
            switch (_mode)
            {
                case FormMode.Add:
                    this.Text = "Thêm hóa đơn";
                    btnSave.Text = "Lưu";
                    btnSave.Visible = true;
                    btnContinue.Visible = true;
                    btnAdd.Visible = true;

                    tbInvoiceID.ReadOnly = false;
                    tbInvoiceID.TabStop = true;
                    tbInvoiceDate.ReadOnly = true;
                    tbInvoiceDate.BackColor = Color.LightGray;
                    tbInvoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    cbCustomer.Enabled = true;
                    invoiceDetailTable.ReadOnly = false;

                    tbInvoiceID.Focus();
                    break;

                case FormMode.Edit:
                    this.Text = "Sửa hóa đơn";
                    btnSave.Text = "Cập nhật";
                    btnSave.Visible = true;
                    btnContinue.Visible = false;
                    btnAdd.Visible = true;

                    tbInvoiceID.ReadOnly = true;
                    tbInvoiceID.TabStop = false;
                    tbInvoiceDate.ReadOnly = true;
                    tbInvoiceDate.BackColor = Color.LightGray;

                    cbCustomer.Enabled = true;
                    invoiceDetailTable.ReadOnly = false;

                    LoadData();
                    break;

                case FormMode.View:
                    this.Text = "Xem chi tiết hóa đơn";
                    btnSave.Visible = false;
                    btnContinue.Visible = false;
                    btnAdd.Visible = false;

                    tbInvoiceID.ReadOnly = true;
                    tbInvoiceDate.ReadOnly = true;
                    tbInvoiceID.BackColor = Color.LightGray;
                    tbInvoiceDate.BackColor = Color.LightGray;

                    cbCustomer.Enabled = false;
                    cbCustomer.BackColor = Color.LightGray;
                    invoiceDetailTable.ReadOnly = true;

                    LoadData();
                    break;
            }
        }

        private void BindCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "CustomerID";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCustomer.SelectedIndex = -1;
        }

        private void BindProducts()
        {
            var products = _productRepository.GetAllProducts();
            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
        }

        private void SetupGrid()
        {
            invoiceDetailTable.AllowUserToAddRows = false;

            if (invoiceDetailTable.Columns["Price"] != null)
                invoiceDetailTable.Columns["Price"].ReadOnly = true;

            if (invoiceDetailTable.Columns["TotalPrice"] != null)
                invoiceDetailTable.Columns["TotalPrice"].ReadOnly = true;
        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(_invoiceID))
                return;

            var invoice = _invoiceReporitory.GetInvoiceByID(_invoiceID);
            if (invoice == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            tbInvoiceID.Text = invoice.InvoiceID;
            tbInvoiceDate.Text = invoice.InvoiceDate.ToString("dd/MM/yyyy");
            cbCustomer.SelectedValue = invoice.CustomerID;
            invoiceDetailTable.Rows.Clear();

            foreach (InvoiceDetailEntity detail in invoice.InvoiceDetails)
            {
                int rowIndex = invoiceDetailTable.Rows.Add();
                DataGridViewRow row = invoiceDetailTable.Rows[rowIndex];

                row.Cells["cbProduct"].Value = detail.ProductID;
                row.Cells["Price"].Value = FormatHelper.FormatCurrency(detail.Price);
                row.Cells["Quantity"].Value = detail.Quantity;
                row.Cells["TotalPrice"].Value = FormatHelper.FormatCurrency(detail.Quantity * detail.Price);
            }

            lbTotalPrice.Text = FormatHelper.FormatCurrency(invoice.TotalPrice);
        }

        private bool ValidateInput()
        {
            string invoiceID = tbInvoiceID.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(invoiceID))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInvoiceID.Focus();
                return false;
            }

            if (_mode == FormMode.Add && _invoiceReporitory.GetInvoiceByID(invoiceID) != null)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInvoiceID.Focus();
                return false;
            }

            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCustomer.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbInvoiceDate.Text))
            {
                MessageBox.Show("Ngày lập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var validRows = invoiceDetailTable.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToList();

            if (!validRows.Any())
            {
                MessageBox.Show("Hóa đơn phải có ít nhất 1 sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (DataGridViewRow row in validRows)
            {
                var productValue = row.Cells["cbProduct"].Value;
                var quantityValue = row.Cells["Quantity"].Value;

                if (productValue == null || quantityValue == null)
                {
                    MessageBox.Show("Có dòng chưa nhập đủ thông tin sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!int.TryParse(quantityValue.ToString(), out int qty) || qty <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private InvoiceEntity GetInvoiceFromForm()
        {
            var invoice = new InvoiceEntity
            {
                InvoiceID = tbInvoiceID.Text.Trim().ToUpper(),
                CustomerID = cbCustomer.SelectedValue.ToString(),
                InvoiceDate = DateTime.ParseExact(tbInvoiceDate.Text, "dd/MM/yyyy", null),
                TotalPrice = GetGrandTotalValue(),
                InvoiceDetails = new List<InvoiceDetailEntity>()
            };

            foreach (DataGridViewRow row in invoiceDetailTable.Rows)
            {
                if (row.IsNewRow) continue;

                var productID = row.Cells["cbProduct"].Value?.ToString();
                var quantity = row.Cells["Quantity"].Value;
                var totalPrice = row.Cells["TotalPrice"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(productID) || quantity == null || string.IsNullOrWhiteSpace(totalPrice))
                    continue;

                invoice.InvoiceDetails.Add(new InvoiceDetailEntity
                {
                    ProductID = productID,
                    Quantity = Convert.ToInt32(quantity),
                    TotalPrice = ParseFormattedDecimal(totalPrice)
                });
            }

            return invoice;
        }

        private bool SaveData()
        {
            if (!ValidateInput())
                return false;

            var invoice = GetInvoiceFromForm();
            bool result = false;

            if (_mode == FormMode.Add)
            {
                result = _invoiceReporitory.AddInvoice(invoice);
                if (result)
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_mode == FormMode.Edit)
            {
                result = _invoiceReporitory.UpdateInvoice(invoice);
                if (result)
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tbInvoiceID.Clear();
            tbInvoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbCustomer.SelectedIndex = -1;
            invoiceDetailTable.Rows.Clear();
            lbTotalPrice.Text = "0";
            tbInvoiceID.Focus();
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
            this.DialogResult = _isDataChanged ? DialogResult.OK : DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_mode == FormMode.View)
                return;

            invoiceDetailTable.Rows.Add();
        }

        private void tbInvoiceID_TextChanged(object sender, EventArgs e)
        {
            if (_mode != FormMode.Add)
                return;

            string newValue = tbInvoiceID.Text.Replace(" ", "").ToUpper();
            if (tbInvoiceID.Text == newValue)
                return;

            int selectionStart = tbInvoiceID.SelectionStart;
            tbInvoiceID.Text = newValue;
            tbInvoiceID.SelectionStart = selectionStart > tbInvoiceID.Text.Length
                ? tbInvoiceID.Text.Length
                : selectionStart;
        }

        private void invoiceDetailTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (invoiceDetailTable.CurrentCell is DataGridViewComboBoxCell && invoiceDetailTable.IsCurrentCellDirty)
            {
                invoiceDetailTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void invoiceDetailTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_mode == FormMode.View || e.RowIndex < 0)
                return;

            if (invoiceDetailTable.Columns[e.ColumnIndex].Name == "cbProduct")
            {
                var cellValue = invoiceDetailTable.Rows[e.RowIndex].Cells["cbProduct"].Value;
                if (cellValue == null) return;

                string productID = cellValue.ToString();

                foreach (DataGridViewRow row in invoiceDetailTable.Rows)
                {
                    if (row.Index != e.RowIndex && !row.IsNewRow)
                    {
                        var existingProductID = row.Cells["cbProduct"].Value?.ToString();
                        if (existingProductID == productID)
                        {
                            int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);
                            row.Cells["Quantity"].Value = currentQty + 1;
                            UpdateRowTotalPrice(row.Index);

                            this.BeginInvoke(new MethodInvoker(() =>
                            {
                                if (invoiceDetailTable.Rows.Count > e.RowIndex)
                                {
                                    invoiceDetailTable.Rows.RemoveAt(e.RowIndex);
                                }
                            }));
                            return;
                        }
                    }
                }

                var product = _productRepository.GetProductByID(productID);
                if (product != null)
                {
                    invoiceDetailTable.Rows[e.RowIndex].Cells["Price"].Value = FormatHelper.FormatCurrency(product.Price);
                    invoiceDetailTable.Rows[e.RowIndex].Cells["Quantity"].Value = 1;
                    UpdateRowTotalPrice(e.RowIndex);
                }
            }
            else if (invoiceDetailTable.Columns[e.ColumnIndex].Name == "Quantity")
            {
                UpdateRowTotalPrice(e.RowIndex);
            }
        }

        private void UpdateRowTotalPrice(int rowIndex)
        {
            var row = invoiceDetailTable.Rows[rowIndex];
            decimal price = ParseFormattedDecimal(row.Cells["Price"].Value?.ToString());
            int qty = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);

            if (qty <= 0 && row.Cells["Quantity"].Value != null)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells["Quantity"].Value = 1;
                qty = 1;
            }

            decimal total = price * qty;
            row.Cells["TotalPrice"].Value = FormatHelper.FormatCurrency(total);
            UpdateGrandTotal();
        }

        private void UpdateGrandTotal()
        {
            lbTotalPrice.Text = FormatHelper.FormatCurrency(GetGrandTotalValue());
        }

        private decimal GetGrandTotalValue()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in invoiceDetailTable.Rows)
            {
                if (!row.IsNewRow && row.Cells["TotalPrice"].Value != null)
                {
                    total += ParseFormattedDecimal(row.Cells["TotalPrice"].Value.ToString());
                }
            }

            return total;
        }

        private decimal ParseFormattedDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;

            string clean = Regex.Replace(value, @"[^\d]", "");
            return decimal.TryParse(clean, out decimal result) ? result : 0;
        }

        private void invoiceDetailTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_mode == FormMode.View)
                return;

            if (e.RowIndex >= 0 && invoiceDetailTable.Columns[e.ColumnIndex].Name == "colExecute")
            {
                invoiceDetailTable.Rows.RemoveAt(e.RowIndex);
                UpdateGrandTotal();
            }
        }

        private void lbTotalPrice_Click(object sender, EventArgs e)
        {
        }

        private void tbInvoiceDate_TextChanged(object sender, EventArgs e)
        {
        }
    }
}