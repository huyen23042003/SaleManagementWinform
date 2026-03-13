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

namespace SaleManagementWinform.Forms.Invoice
{
    public partial class EditInvoiceForm : Form
    {
        private readonly InvoiceReporitory _invoiceReporitory = new InvoiceReporitory();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly string _invoiceID;
        
        public EditInvoiceForm(string invoiceID)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
        }

        private void LoadData()
        {
            InvoiceEntity invoice = _invoiceReporitory.GetInvoiceByID(_invoiceID);
            if ( invoice != null){
                tbInvoiceID.Text = invoice.InvoiceID;
                cbCustomer.SelectedValue = invoice.CustomerID;

                invoiceDetailTable.Rows.Clear();

                foreach(InvoiceDetailEntity invoiceDetail in invoice.InvoiceDetails)
                {
                    int rowIndex = invoiceDetailTable.Rows.Add();
                    DataGridViewRow row = invoiceDetailTable.Rows[rowIndex];

                    row.Cells["cbProduct"].Value = invoiceDetail.ProductID;
                    row.Cells["Price"].Value = invoiceDetail.Price.ToString("N0");
                    row.Cells["Quantity"].Value = invoiceDetail.Quantity;
                    row.Cells["TotalPrice"].Value = (invoiceDetail.Quantity * invoiceDetail.Price).ToString("N0");
                }
            }
            UpdateGrandTotal();
        }



        private void EditInvoiceForm_Load(object sender, EventArgs e)
        {
            var customers = _customerRepository.GetAllCustomers();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "CustomerID" + "-"+ "CustomerName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDown; 
            cbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend; 
            cbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;

            var products = _productRepository.GetAllProducts();
            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";

            invoiceDetailTable.Columns["Price"].ReadOnly = true;
            invoiceDetailTable.Columns["TotalPrice"].ReadOnly = true;

            invoiceDetailTable.AllowUserToAddRows = false;

            invoiceDetailTable.CurrentCellDirtyStateChanged += invoiceDetailTable_CurrentCellDirtyStateChanged;

            LoadData();


        }

        private void invoiceDetailTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (invoiceDetailTable.CurrentCell is DataGridViewComboBoxCell)
            {
                if (invoiceDetailTable.IsCurrentCellDirty)
                {
                    invoiceDetailTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void invoiceDetailTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (invoiceDetailTable.Columns[e.ColumnIndex].Name == "cbProduct")
            {
                var cellValue = invoiceDetailTable.Rows[e.RowIndex].Cells["cbProduct"].Value;
                if (cellValue != null)
                {
                    string productID = cellValue.ToString();

                    for (int i = 0; i < invoiceDetailTable.Rows.Count; i++)
                    {
                        if (i != e.RowIndex && !invoiceDetailTable.Rows[i].IsNewRow)
                        {
                            var existingID = invoiceDetailTable.Rows[i].Cells["cbProduct"].Value?.ToString();
                            if (existingID == productID)
                            {
                                int currentQty = Convert.ToInt32(invoiceDetailTable.Rows[i].Cells["Quantity"].Value ?? 0);
                                invoiceDetailTable.Rows[i].Cells["Quantity"].Value = currentQty + 1;

                                UpdateRowTotalPrice(i);

                                this.BeginInvoke(new MethodInvoker(() => {
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
                        invoiceDetailTable.Rows[e.RowIndex].Cells["Price"].Value = product.Price.ToString("N0");
                        invoiceDetailTable.Rows[e.RowIndex].Cells["Quantity"].Value = 1;
                    
                        UpdateRowTotalPrice(e.RowIndex);
                    }
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
            var price = Convert.ToDecimal(row.Cells["Price"].Value?.ToString().Replace(",", "") ?? "0");
            int qty = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);

            if (qty <= 0 && row.Cells["Quantity"].Value != null)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo");
                row.Cells["Quantity"].Value = 1;
                qty = 1;
            }

            decimal total = price * qty;
            row.Cells["TotalPrice"].Value = total.ToString("N0");

            UpdateGrandTotal();
        }

        private void UpdateGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in invoiceDetailTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    grandTotal += Convert.ToDecimal(row.Cells["TotalPrice"].Value ?? 0);
                }
            }
            lbTotalPrice.Text = string.Format("{0:N0}", grandTotal);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCustomer.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (invoiceDetailTable.Rows.Count == 0)
                {
                    MessageBox.Show("Hóa đơn phải có ít nhất 1 sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var invoice = new InvoiceEntity
                {
                    InvoiceID = tbInvoiceID.Text,
                    CustomerID = cbCustomer.SelectedValue.ToString(),
                    TotalPrice = GetGrandTotalValue(),
                    InvoiceDetails = new List<InvoiceDetailEntity>()
                };

                foreach (DataGridViewRow row in invoiceDetailTable.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var productID = row.Cells["cbProduct"].Value?.ToString();
                        var quantity = row.Cells["Quantity"].Value;

                        if (string.IsNullOrEmpty(productID) || quantity == null) continue;

                        string rawTotal = row.Cells["TotalPrice"].Value.ToString();
                        decimal detailTotal = decimal.Parse(System.Text.RegularExpressions.Regex.Replace(rawTotal, @"[^\d]", ""));

                        invoice.InvoiceDetails.Add(new InvoiceDetailEntity
                        {
                            ProductID = productID,
                            Quantity = Convert.ToInt32(quantity),
                            TotalPrice = detailTotal
                        });
                    }
                }

                if (_invoiceReporitory.UpdateInvoice(invoice))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại! Vui lòng kiểm tra lại kết nối hoặc dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetGrandTotalValue()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in invoiceDetailTable.Rows)
            {
                if (!row.IsNewRow && row.Cells["TotalPrice"].Value != null)
                {
                    string val = row.Cells["TotalPrice"].Value.ToString();
                    total += decimal.Parse(System.Text.RegularExpressions.Regex.Replace(val, @"[^\d]", ""));
                }
            }
            return total;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            invoiceDetailTable.Rows.Add();

        }

        private void invoiceDetailTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && invoiceDetailTable.Columns[e.ColumnIndex].Name == "colExecute")
            {
                invoiceDetailTable.Rows.RemoveAt(e.RowIndex);
                UpdateGrandTotal();
            }
        }
    }
}
