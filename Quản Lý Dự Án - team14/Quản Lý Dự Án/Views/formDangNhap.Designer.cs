namespace QuanLyDuAn.Views
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btMatKhau = new System.Windows.Forms.Button();
            this.btTenDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btDangNhap
            // 
            this.btDangNhap.AllowDrop = true;
            this.btDangNhap.BackColor = System.Drawing.Color.Red;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(120, 106);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(97, 36);
            this.btDangNhap.TabIndex = 23;
            this.btDangNhap.Text = "Login";
            this.btDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btMatKhau
            // 
            this.btMatKhau.AllowDrop = true;
            this.btMatKhau.BackColor = System.Drawing.Color.Black;
            this.btMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatKhau.ForeColor = System.Drawing.Color.White;
            this.btMatKhau.Location = new System.Drawing.Point(45, 77);
            this.btMatKhau.Name = "btMatKhau";
            this.btMatKhau.Size = new System.Drawing.Size(97, 23);
            this.btMatKhau.TabIndex = 22;
            this.btMatKhau.Text = "Password";
            this.btMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btMatKhau.UseVisualStyleBackColor = false;
            // 
            // btTenDangNhap
            // 
            this.btTenDangNhap.AllowDrop = true;
            this.btTenDangNhap.BackColor = System.Drawing.Color.Black;
            this.btTenDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.btTenDangNhap.Location = new System.Drawing.Point(45, 51);
            this.btTenDangNhap.Name = "btTenDangNhap";
            this.btTenDangNhap.Size = new System.Drawing.Size(97, 23);
            this.btTenDangNhap.TabIndex = 21;
            this.btTenDangNhap.Text = "User Name";
            this.btTenDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btTenDangNhap.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(148, 79);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(141, 20);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(148, 53);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(141, 20);
            this.txtTenDangNhap.TabIndex = 20;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDuAn.Properties.Resources.backgroundForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(389, 210);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btMatKhau);
            this.Controls.Add(this.btTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formDangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.Enter += new System.EventHandler(this.formDangNhap_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btMatKhau;
        private System.Windows.Forms.Button btTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
    }
}