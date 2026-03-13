namespace SaleManagementWinform.Forms
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewDetailCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.contextMenuAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersTable
            // 
            this.customersTable.AllowUserToAddRows = false;
            this.customersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersTable.BackgroundColor = System.Drawing.Color.White;
            this.customersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customersTable.ColumnHeadersHeight = 45;
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Phone});
            this.customersTable.ContextMenuStrip = this.contextMenuAction;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.customersTable.EnableHeadersVisualStyles = false;
            this.customersTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.customersTable.Location = new System.Drawing.Point(20, 30);
            this.customersTable.Name = "customersTable";
            this.customersTable.RowHeadersVisible = false;
            this.customersTable.RowHeadersWidth = 62;
            this.customersTable.RowTemplate.Height = 40;
            this.customersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersTable.Size = new System.Drawing.Size(1254, 560);
            this.customersTable.TabIndex = 9;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Mã khách hàng";
            this.CustomerID.MinimumWidth = 8;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.MinimumWidth = 8;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // contextMenuAction
            // 
            this.contextMenuAction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuAction.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.btnEditCustomer,
            this.btnViewDetailCustomer,
            this.btnDeleteCustomer});
            this.contextMenuAction.Name = "contextMenuAction";
            this.contextMenuAction.Size = new System.Drawing.Size(257, 140);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnAddCustomer.Size = new System.Drawing.Size(256, 34);
            this.btnAddCustomer.Text = "Thêm mới";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnEditCustomer.Size = new System.Drawing.Size(256, 34);
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnViewDetailCustomer
            // 
            this.btnViewDetailCustomer.Name = "btnViewDetailCustomer";
            this.btnViewDetailCustomer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnViewDetailCustomer.Size = new System.Drawing.Size(256, 34);
            this.btnViewDetailCustomer.Text = "Xem chi tiết";
            this.btnViewDetailCustomer.Click += new System.EventHandler(this.btnViewDetailCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.btnDeleteCustomer.Size = new System.Drawing.Size(256, 34);
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1134, 615);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(990, 615);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(130, 45);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Thực hiện";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1294, 700);
            this.Controls.Add(this.customersTable);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.contextMenuAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView customersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.ContextMenuStrip contextMenuAction;
        private System.Windows.Forms.ToolStripMenuItem btnAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnEditCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnViewDetailCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExecute;
    }
}