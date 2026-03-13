namespace SaleManagementWinform.Forms
{
    partial class ViewProductDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã sản phẩm";
            // 
            // tbProductID
            // 
            this.tbProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProductID.Enabled = false;
            this.tbProductID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbProductID.Location = new System.Drawing.Point(200, 40);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(420, 39);
            this.tbProductID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá sản phẩm";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPrice.Location = new System.Drawing.Point(200, 160);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(420, 39);
            this.tbPrice.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(470, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProductName.Enabled = false;
            this.tbProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbProductName.Location = new System.Drawing.Point(200, 100);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(420, 39);
            this.tbProductName.TabIndex = 22;
            // 
            // ViewProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(660, 330);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewProductDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT SẢN PHẨM";
            this.Load += new System.EventHandler(this.ViewProductDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbProductName;
    }
}