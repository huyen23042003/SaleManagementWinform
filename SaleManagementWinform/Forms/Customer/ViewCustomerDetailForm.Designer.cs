namespace SaleManagementWinform.Forms
{
    partial class ViewCustomerDetailForm
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1 (Mã khách hàng)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã khách hàng";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerID.Enabled = false;
            this.tbCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbCustomerID.Location = new System.Drawing.Point(210, 40);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(410, 39);
            this.tbCustomerID.TabIndex = 27;
            // 
            // label2 (Tên khách hàng)
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên khách hàng";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbCustomerName.Location = new System.Drawing.Point(210, 100);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.Size = new System.Drawing.Size(410, 39);
            this.tbCustomerName.TabIndex = 29;
            // 
            // label3 (Số điện thoại)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số điện thoại";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.Enabled = false;
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPhone.Location = new System.Drawing.Point(210, 160);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(410, 39);
            this.tbPhone.TabIndex = 30;
            // 
            // btnClose (Đóng - Secondary Gray)
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(470, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 48);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewCustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewCustomerDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHI TIẾT KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.ViewCustomerDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label1;
    }
}