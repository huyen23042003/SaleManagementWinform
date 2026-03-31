using SaleManagementWinform.Common.Enums;
using SaleManagementWinform.Common.Helpers;
using SaleManagementWinform.Forms.Invoice;
using SaleManagementWinform.Models;
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
    public partial class InvoiceForm : Form
    {
        private readonly InvoiceReporitory _invoiceReporitory = new InvoiceReporitory();
        public InvoiceForm()
        {
            InitializeComponent();
            GetAllInvoices();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void GetAllInvoices()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("InvoiceID");
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("InvoiceDate");
            dt.Columns.Add("TotalPrice");
            List<InvoiceEntity> invoices = _invoiceReporitory.GetAllInvoices();
            foreach (InvoiceEntity invoice in invoices)
            {
                var row = dt.NewRow();
                row["InvoiceID"] = invoice.InvoiceID;
                row["CustomerID"] = invoice.CustomerID;
                row["InvoiceDate"] = invoice.InvoiceDate.ToString("dd/MM/yyyy");
                row["TotalPrice"] = FormatHelper.FormatCurrency(invoice.TotalPrice);
                dt.Rows.Add(row);
            }

            this.invoicesTable.DataSource = dt;
            this.invoicesTable.Columns["InvoiceDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            

        }

        private void contextMenuAction_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            contextMenuAction.Show(btnExecute, new Point(0, btnExecute.Height));
        }

        private void btnAddInvocie_Click(object sender, EventArgs e)
        {
            InvoiceDetailForm form = new InvoiceDetailForm(FormMode.Add);
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetAllInvoices();
                return;
            }

        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (invoicesTable.CurrentRow == null ||
                invoicesTable.CurrentRow.Cells["InvoiceID"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string invoiceID = invoicesTable.CurrentRow.Cells["InvoiceID"].Value.ToString();
            InvoiceDetailForm form = new InvoiceDetailForm(FormMode.Edit, invoiceID);
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetAllInvoices();
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if(invoicesTable.CurrentRow == null ||
                invoicesTable.CurrentRow.Cells["InvoiceID"] == null)
            {
                MessageBox.Show("Vul lòng chọn hóa đơn", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string invoiceID = invoicesTable.CurrentRow.Cells["InvoiceID"].Value.ToString();
            InvoiceDetailForm form = new InvoiceDetailForm(FormMode.View, invoiceID);
            form.ShowDialog();

        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (invoicesTable.CurrentRow == null ||
                invoicesTable.CurrentRow.Cells["InvoiceID"] == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string invoiceID = invoicesTable.CurrentRow.Cells["InvoiceID"].Value.ToString();
            DialogResult confirm = MessageBox.Show($"Bạn có muốn xóa hóa đơn {invoiceID} không?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (_invoiceReporitory.DeleteInvoice(invoiceID))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    GetAllInvoices();
                    return;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xóa thất bại", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
