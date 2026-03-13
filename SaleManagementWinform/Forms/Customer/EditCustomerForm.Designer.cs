namespace SaleManagementWinform.Forms
{
    partial class EditCustomerForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCustomerID (Mã khách hàng)
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerID.Location = new System.Drawing.Point(40, 45);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(155, 28);
            this.lbCustomerID.TabIndex = 18;
            this.lbCustomerID.Text = "Mã khách hàng";
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
            this.tbCustomerID.TabIndex = 19;
            // 
            // lbCustomerName (Tên khách hàng)
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.Location = new System.Drawing.Point(40, 105);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(160, 28);
            this.lbCustomerName.TabIndex = 17;
            this.lbCustomerName.Text = "Tên khách hàng";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbCustomerName.Location = new System.Drawing.Point(210, 100);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(410, 39);
            this.tbCustomerName.TabIndex = 22;
            // 
            // label3 (Số điện thoại)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số điện thoại";
            // 
            // tbPhone
            // 
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPhone.Location = new System.Drawing.Point(210, 160);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(410, 39);
            this.tbPhone.TabIndex = 23;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // btnSave (Cập nhật - Success Green)
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(300, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 48);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose (Thoát - Secondary Gray)
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(470, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Hủy bỏ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.lbCustomerID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.EditCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label lbCustomerID;
    }
}