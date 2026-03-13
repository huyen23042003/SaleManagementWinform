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
    public partial class ViewInvoiceForm : Form
    {
        private readonly InvoiceReporitory _invoiceReporitory = new InvoiceReporitory();
        private readonly string _invoiceID;
        public ViewInvoiceForm(string invoiceID)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
        }
        public void LoadData()
        {
            var invoice = _invoiceReporitory.GetInvoiceByID(_invoiceID);
            if (invoice != null)
            {
                tbInvoiceID.Text = invoice.InvoiceID;
                tbCustomerName.Text = invoice.CustomerName;
                tbInvoiceDate.Text = invoice.InvoiceDate.ToString("dd/MM/yyyy");
                lbTotalPrice.Text = invoice.TotalPrice.ToString("N0");

                List<InvoiceDetailEntity> invoiceDetails = invoice.InvoiceDetails;
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ProductName");
                dataTable.Columns.Add("Price");
                dataTable.Columns.Add("Quantity");
                dataTable.Columns.Add("TotalPrice");

                foreach (var invoiceDetail in invoiceDetails)
                {
                    var row = dataTable.NewRow();
                    row["ProductName"] = invoiceDetail.ProductName;
                    row["Price"] = invoiceDetail.Price.ToString("N0");
                    row["Quantity"] = invoiceDetail.Quantity;
                    row["TotalPrice"] = invoiceDetail.TotalPrice.ToString("N0");

                    dataTable.Rows.Add(row);   
                }
                invoiceDetailTable.DataSource = dataTable;
                invoiceDetailTable.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ViewInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadData();
            invoiceDetailTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            invoiceDetailTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            invoiceDetailTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }


    }
}
