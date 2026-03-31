namespace SaleManagementWinform.Forms.Invoice
{
    partial class InvoiceDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetailForm));
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.invoiceDetailTable = new System.Windows.Forms.DataGridView();
            this.cbProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExecute = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInvoiceDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(195, 123);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(415, 38);
            this.cbCustomer.TabIndex = 35;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(672, 607);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(125, 39);
            this.btnContinue.TabIndex = 36;
            this.btnContinue.Text = "Nhập tiếp";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(803, 607);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 39);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(938, 607);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Đóng";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceDetailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.invoiceDetailTable.ColumnHeadersHeight = 45;
            this.invoiceDetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbProduct,
            this.Quantity,
            this.Price,
            this.TotalPrice,
            this.colExecute});
            this.invoiceDetailTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.invoiceDetailTable.EnableHeadersVisualStyles = false;
            this.invoiceDetailTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.invoiceDetailTable.Location = new System.Drawing.Point(28, 244);
            this.invoiceDetailTable.Name = "invoiceDetailTable";
            this.invoiceDetailTable.RowHeadersVisible = false;
            this.invoiceDetailTable.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.invoiceDetailTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.invoiceDetailTable.RowTemplate.Height = 40;
            this.invoiceDetailTable.Size = new System.Drawing.Size(1035, 339);
            this.invoiceDetailTable.TabIndex = 34;
            this.invoiceDetailTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailTable_CellContentClick);
            this.invoiceDetailTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailTable_CellValueChanged);
            this.invoiceDetailTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.invoiceDetailTable_CurrentCellDirtyStateChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DataPropertyName = "ProductName";
            this.cbProduct.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProduct.HeaderText = "Tên sản phẩm";
            this.cbProduct.MinimumWidth = 8;
            this.cbProduct.Name = "cbProduct";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá sản phẩm";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
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
            this.label2.Location = new System.Drawing.Point(773, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tổng tiền (VNĐ)";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(632, 76);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(462, 110);
            this.lbTotalPrice.TabIndex = 33;
            this.lbTotalPrice.Text = "0";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTotalPrice.Click += new System.EventHandler(this.lbTotalPrice_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1008, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 46);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 41;
            this.label4.Text = "Khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbInvoiceID.Location = new System.Drawing.Point(195, 50);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.Size = new System.Drawing.Size(415, 37);
            this.tbInvoiceID.TabIndex = 32;
            this.tbInvoiceID.Click += new System.EventHandler(this.tbInvoiceID_TextChanged);
            this.tbInvoiceID.TextChanged += new System.EventHandler(this.tbInvoiceID_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 46);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ngày lập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInvoiceDate
            // 
            this.tbInvoiceDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInvoiceDate.Enabled = false;
            this.tbInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbInvoiceDate.Location = new System.Drawing.Point(195, 182);
            this.tbInvoiceDate.Name = "tbInvoiceDate";
            this.tbInvoiceDate.Size = new System.Drawing.Size(415, 37);
            this.tbInvoiceDate.TabIndex = 43;
            this.tbInvoiceDate.TextChanged += new System.EventHandler(this.tbInvoiceDate_TextChanged);
            // 
            // InvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInvoiceDate);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.invoiceDetailTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceDetailForm";
            this.Text = "InvoiceDetailForm";
            this.Load += new System.EventHandler(this.InvoiceDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView invoiceDetailTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn colExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInvoiceDate;
    }
}