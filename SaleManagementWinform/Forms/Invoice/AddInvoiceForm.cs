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
    public partial class AddInvoiceForm : Form
    {
        private readonly InvoiceReporitory _invoiceReporitory = new InvoiceReporitory();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly string _invoiceID;
        private bool isDataChanged = false;

        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private bool Save()
        {
            string invoiceId = tbInvoiceID.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Vul lòng nhập mã hoá đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_invoiceReporitory.GetInvoiceByID(invoiceId) != null)
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập mã và chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (invoiceDetailTable.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Phải nhập ít nhất một mặt hàng!");
                return false;
            }



            var invoice = new InvoiceEntity
            {
                InvoiceID = invoiceId,
                CustomerID = cbCustomer.SelectedValue.ToString(),
                TotalPrice = decimal.Parse(lbTotalPrice.Text.Replace(@"[^\d]", "")),
                InvoiceDetails = new List<InvoiceDetailEntity>()
            };

            foreach (DataGridViewRow row in invoiceDetailTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    var productValue = row.Cells["cbProduct"].Value;
                    var quantityValue = row.Cells["Quantity"].Value;
                    var totalValue = row.Cells["TotalPrice"].Value;

                    if (productValue == null || quantityValue == null)
                    {
                        MessageBox.Show("Có dòng chưa nhập đủ thông tin sản phẩm!", "Thông báo");
                        return false;
                    }

                    invoice.InvoiceDetails.Add(new InvoiceDetailEntity
                    {
                        ProductID = productValue.ToString(),
                        Quantity = Convert.ToInt32(quantityValue),
                        TotalPrice = decimal.Parse(totalValue.ToString().Replace(@"[^\d]", ""))
                    });
                }
            }

            if (_invoiceReporitory.AddInvoice(invoice))
            {
                MessageBox.Show("Lưu thành công!");
                return true;
            }
            else
            {
                return false;
            }
        }




        private void tbInvoiceID_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbInvoiceID.SelectionStart;
            tbInvoiceID.Text = tbInvoiceID.Text.ToUpper().Replace(" ", "");
            tbInvoiceID.SelectionStart = selectionStart;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            invoiceDetailTable.Rows.Add();
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
            decimal price = decimal.Parse(row.Cells["Price"].Value?.ToString().Replace(@"[^\d]", "") ?? "0");
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
        private void AddInvoiceForm_Load(object sender, EventArgs e)
        {
            var customers = _customerRepository.GetAllCustomers();
            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "CustomerID";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCustomer.SelectedIndex = -1;

            var products = _productRepository.GetAllProducts();
            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
            invoiceDetailTable.AllowUserToAddRows = false;

            invoiceDetailTable.CurrentCellDirtyStateChanged += invoiceDetailTable_CurrentCellDirtyStateChanged;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(isDataChanged)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            if (Save())
            {
                isDataChanged = true;

                tbInvoiceID.Clear();
                cbCustomer.SelectedIndex = -1;
                invoiceDetailTable.Rows.Clear();
                lbTotalPrice.Text = "0";
            }
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
