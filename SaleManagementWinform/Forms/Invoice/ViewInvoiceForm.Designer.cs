namespace SaleManagementWinform.Forms.Invoice
{
    partial class ViewInvoiceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceDetailTable = new System.Windows.Forms.DataGridView();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbInvoiceDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInvoiceID.Enabled = false;
            this.tbInvoiceID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbInvoiceID.Location = new System.Drawing.Point(199, 51);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.Size = new System.Drawing.Size(415, 37);
            this.tbInvoiceID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(630, 80);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(462, 110);
            this.lbTotalPrice.TabIndex = 10;
            this.lbTotalPrice.Text = "0";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(768, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền (VNĐ)";
            // 
            // invoiceDetailTable
            // 
            this.invoiceDetailTable.AllowUserToAddRows = false;
            this.invoiceDetailTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDetailTable.BackgroundColor = System.Drawing.Color.White;
            this.invoiceDetailTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceDetailTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDetailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDetailTable.ColumnHeadersHeight = 45;
            this.invoiceDetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.invoiceDetailTable.EnableHeadersVisualStyles = false;
            this.invoiceDetailTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.invoiceDetailTable.Location = new System.Drawing.Point(32, 245);
            this.invoiceDetailTable.Name = "invoiceDetailTable";
            this.invoiceDetailTable.RowHeadersVisible = false;
            this.invoiceDetailTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.invoiceDetailTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.invoiceDetailTable.RowTemplate.Height = 40;
            this.invoiceDetailTable.Size = new System.Drawing.Size(1042, 339);
            this.invoiceDetailTable.TabIndex = 12;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCustomerName.Location = new System.Drawing.Point(199, 123);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(415, 37);
            this.tbCustomerName.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(949, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbInvoiceDate
            // 
            this.tbInvoiceDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInvoiceDate.Enabled = false;
            this.tbInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbInvoiceDate.Location = new System.Drawing.Point(199, 184);
            this.tbInvoiceDate.Name = "tbInvoiceDate";
            this.tbInvoiceDate.Size = new System.Drawing.Size(415, 37);
            this.tbInvoiceDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày lập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá sản phẩm";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Thành tiền";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // ViewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1117, 673);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.invoiceDetailTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInvoiceDate);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.ViewInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView invoiceDetailTable;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbInvoiceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}