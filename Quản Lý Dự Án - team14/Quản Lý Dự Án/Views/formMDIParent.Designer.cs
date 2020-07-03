namespace QuanLyDuAn.Views
{
    partial class formMDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDIParent));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.DuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CongViecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhomCongViecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CongViecNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiPhiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMDI = new System.Windows.Forms.TabControl();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DuAnToolStripMenuItem,
            this.CongViecToolStripMenuItem,
            this.NhanVienToolStripMenuItem,
            this.NhomCongViecToolStripMenuItem,
            this.CongViecNhanVienToolStripMenuItem,
            this.ChiPhiToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(1370, 24);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // DuAnToolStripMenuItem
            // 
            this.DuAnToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DuAnToolStripMenuItem.Name = "DuAnToolStripMenuItem";
            this.DuAnToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.DuAnToolStripMenuItem.Text = "&Dự án";
            this.DuAnToolStripMenuItem.Click += new System.EventHandler(this.DuAnToolStripMenuItem_Click);
            // 
            // CongViecToolStripMenuItem
            // 
            this.CongViecToolStripMenuItem.Name = "CongViecToolStripMenuItem";
            this.CongViecToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.CongViecToolStripMenuItem.Text = "&Công việc";
            this.CongViecToolStripMenuItem.Click += new System.EventHandler(this.CongViecToolStripMenuItem_Click);
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.NhanVienToolStripMenuItem.Text = "&Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // NhomCongViecToolStripMenuItem
            // 
            this.NhomCongViecToolStripMenuItem.Name = "NhomCongViecToolStripMenuItem";
            this.NhomCongViecToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.NhomCongViecToolStripMenuItem.Text = "&Nhóm Công Việc";
            this.NhomCongViecToolStripMenuItem.Click += new System.EventHandler(this.NhomToolStripMenuItem_Click);
            // 
            // CongViecNhanVienToolStripMenuItem
            // 
            this.CongViecNhanVienToolStripMenuItem.Name = "CongViecNhanVienToolStripMenuItem";
            this.CongViecNhanVienToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.CongViecNhanVienToolStripMenuItem.Text = "Công việc nhân viên";
            this.CongViecNhanVienToolStripMenuItem.Click += new System.EventHandler(this.CongViecNhanVienToolStripMenuItem_Click);
            // 
            // ChiPhiToolStripMenuItem
            // 
            this.ChiPhiToolStripMenuItem.Name = "ChiPhiToolStripMenuItem";
            this.ChiPhiToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ChiPhiToolStripMenuItem.Text = "Chi Phí";
            this.ChiPhiToolStripMenuItem.Click += new System.EventHandler(this.ChiPhiToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.LogOutToolStripMenuItem.Text = "Log out";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // tabMDI
            // 
            this.tabMDI.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMDI.Location = new System.Drawing.Point(0, 24);
            this.tabMDI.Name = "tabMDI";
            this.tabMDI.SelectedIndex = 0;
            this.tabMDI.Size = new System.Drawing.Size(1370, 22);
            this.tabMDI.TabIndex = 2;
            this.tabMDI.SelectedIndexChanged += new System.EventHandler(this.tabMDI_SelectedIndexChanged);
            // 
            // formMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabMDI);
            this.Controls.Add(this.menuStripMDI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Name = "formMDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dự Án - 3OX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMDIParent_FormClosing);
            this.Load += new System.EventHandler(this.formMDIParent_Load);
            this.MdiChildActivate += new System.EventHandler(this.formMDIParent_MdiChildActivate);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem DuAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CongViecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhomCongViecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMDI;
        private System.Windows.Forms.ToolStripMenuItem CongViecNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChiPhiToolStripMenuItem;
    }
}



