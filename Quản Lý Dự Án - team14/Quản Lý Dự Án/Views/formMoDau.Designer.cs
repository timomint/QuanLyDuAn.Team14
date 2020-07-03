using System.Drawing;

namespace QuanLyDuAn.Views
{
    partial class formMoDau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMoDau));
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThuGon = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDangNhap.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(685, 71);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(103, 35);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "LOGIN";
            this.btDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDangNhap.UseCompatibleTextRendering = true;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThuGon
            // 
            this.btThuGon.BackColor = System.Drawing.Color.Red;
            this.btThuGon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThuGon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThuGon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThuGon.Location = new System.Drawing.Point(738, 42);
            this.btThuGon.Name = "btThuGon";
            this.btThuGon.Size = new System.Drawing.Size(24, 23);
            this.btThuGon.TabIndex = 2;
            this.btThuGon.Text = "--";
            this.btThuGon.UseVisualStyleBackColor = false;
            this.btThuGon.Click += new System.EventHandler(this.btThuGon_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(764, 42);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(24, 23);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "X";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // formMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDuAn.Properties.Resources.backgroundMoDau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.btThuGon);
            this.Controls.Add(this.btThoat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMoDau";
            this.Text = "formMoDau";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMoDau_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMoDau_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formMoDau_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThuGon;
        private System.Windows.Forms.Button btThoat;
    }
}