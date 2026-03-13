namespace SaleManagementWinform
{
    partial class ProductForm
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
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewDetailProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.contextMenuAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.BackgroundColor = System.Drawing.Color.White;
            this.productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsTable.ColumnHeadersHeight = 45;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price});
            this.productsTable.ContextMenuStrip = this.contextMenuAction;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsTable.EnableHeadersVisualStyles = false;
            this.productsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.productsTable.Location = new System.Drawing.Point(30, 30);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.RowHeadersWidth = 62;
            this.productsTable.RowTemplate.Height = 40;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(1160, 520);
            this.productsTable.TabIndex = 6;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.MinimumWidth = 8;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
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
            this.Price.ReadOnly = true;
            // 
            // contextMenuAction
            // 
            this.contextMenuAction.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.btnEditProduct,
            this.btnViewDetailProduct,
            this.btnDeleteProduct});
            this.contextMenuAction.Name = "contextMenuAction";
            this.contextMenuAction.Size = new System.Drawing.Size(193, 132);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnAddProduct.Size = new System.Drawing.Size(192, 32);
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnEditProduct.Size = new System.Drawing.Size(192, 32);
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnViewDetailProduct
            // 
            this.btnViewDetailProduct.Name = "btnViewDetailProduct";
            this.btnViewDetailProduct.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnViewDetailProduct.Size = new System.Drawing.Size(192, 32);
            this.btnViewDetailProduct.Text = "Xem";
            this.btnViewDetailProduct.Click += new System.EventHandler(this.btnViewDetailProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.btnDeleteProduct.Size = new System.Drawing.Size(192, 32);
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(920, 580);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(130, 45);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Thực hiện";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1060, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1222, 654);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.productsTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC SẢN PHẨM";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.contextMenuAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuAction;
        private System.Windows.Forms.ToolStripMenuItem btnAddProduct;
        private System.Windows.Forms.ToolStripMenuItem btnEditProduct;
        private System.Windows.Forms.ToolStripMenuItem btnViewDetailProduct;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteProduct;
    }
}

