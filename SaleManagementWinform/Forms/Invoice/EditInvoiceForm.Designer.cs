namespace SaleManagementWinform.Forms.Invoice
{
    partial class EditInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInvoiceForm));
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.invoiceDetailTable = new System.Windows.Forms.DataGridView();
            this.cbProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecute = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(191, 111);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(415, 38);
            this.cbCustomer.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(760, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 45);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(934, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Hủy bỏ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDetailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDetailTable.ColumnHeadersHeight = 45;
            this.invoiceDetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbProduct,
            this.Price,
            this.Quantity,
            this.TotalPrice,
            this.colExecute});
            this.invoiceDetailTable.EnableHeadersVisualStyles = false;
            this.invoiceDetailTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.invoiceDetailTable.Location = new System.Drawing.Point(24, 232);
            this.invoiceDetailTable.Name = "invoiceDetailTable";
            this.invoiceDetailTable.RowHeadersVisible = false;
            this.invoiceDetailTable.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.invoiceDetailTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.invoiceDetailTable.RowTemplate.Height = 40;
            this.invoiceDetailTable.Size = new System.Drawing.Size(1035, 339);
            this.invoiceDetailTable.TabIndex = 30;
            this.invoiceDetailTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailTable_CellContentClick);
            this.invoiceDetailTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailTable_CellValueChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProduct.HeaderText = "Tên sản phẩm";
            this.cbProduct.MinimumWidth = 8;
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá sản phẩm";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Tổng giá tiền";
            this.TotalPrice.MinimumWidth = 8;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // colExecute
            // 
            this.colExecute.HeaderText = "Xóa";
            this.colExecute.Image = ((System.Drawing.Image)(resources.GetObject("colExecute.Image")));
            this.colExecute.MinimumWidth = 8;
            this.colExecute.Name = "colExecute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(769, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tổng tiền (VNĐ)";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(612, 62);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(485, 109);
            this.lbTotalPrice.TabIndex = 38;
            this.lbTotalPrice.Text = "0";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 39;
            this.label4.Text = "Khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInvoiceID.Enabled = false;
            this.tbInvoiceID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbInvoiceID.Location = new System.Drawing.Point(191, 38);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.Size = new System.Drawing.Size(415, 39);
            this.tbInvoiceID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(980, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 55);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1117, 673);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.invoiceDetailTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.EditInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView invoiceDetailTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn colExecute;
        private System.Windows.Forms.Label btnAdd;
    }
}