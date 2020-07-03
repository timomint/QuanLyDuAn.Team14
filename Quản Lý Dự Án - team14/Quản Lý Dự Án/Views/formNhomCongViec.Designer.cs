namespace QuanLyDuAn.Views
{
    partial class formNhomCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhomCongViec));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxListCongViec = new System.Windows.Forms.ComboBox();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.cbbNhanVIen = new System.Windows.Forms.ComboBox();
            this.lbThanhVien = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtNhomTruong = new System.Windows.Forms.TextBox();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.lbNhomTruong = new System.Windows.Forms.Label();
            this.lbMaNhom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhomTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(920, 450);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.cbxListCongViec);
            this.splitContainer2.Panel1.Controls.Add(this.btnXoaNhom);
            this.splitContainer2.Panel1.Controls.Add(this.btnSuaNhom);
            this.splitContainer2.Panel1.Controls.Add(this.btnThemNhom);
            this.splitContainer2.Panel1.Controls.Add(this.cbbNhanVIen);
            this.splitContainer2.Panel1.Controls.Add(this.lbThanhVien);
            this.splitContainer2.Panel1.Controls.Add(this.txtTenNhom);
            this.splitContainer2.Panel1.Controls.Add(this.txtNhomTruong);
            this.splitContainer2.Panel1.Controls.Add(this.txtNhom);
            this.splitContainer2.Panel1.Controls.Add(this.lbTenNhom);
            this.splitContainer2.Panel1.Controls.Add(this.lbNhomTruong);
            this.splitContainer2.Panel1.Controls.Add(this.lbMaNhom);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(747, 450);
            this.splitContainer2.SplitterDistance = 272;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 141;
            this.label1.Text = "Tên Công Việc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxListCongViec
            // 
            this.cbxListCongViec.FormattingEnabled = true;
            this.cbxListCongViec.Location = new System.Drawing.Point(566, 33);
            this.cbxListCongViec.Name = "cbxListCongViec";
            this.cbxListCongViec.Size = new System.Drawing.Size(121, 21);
            this.cbxListCongViec.TabIndex = 140;
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.BackColor = System.Drawing.Color.Red;
            this.btnXoaNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNhom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhom.Location = new System.Drawing.Point(249, 26);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(110, 34);
            this.btnXoaNhom.TabIndex = 139;
            this.btnXoaNhom.Text = "Xóa Nhóm";
            this.btnXoaNhom.UseVisualStyleBackColor = false;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.BackColor = System.Drawing.Color.Red;
            this.btnSuaNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNhom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhom.Location = new System.Drawing.Point(133, 26);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(110, 34);
            this.btnSuaNhom.TabIndex = 138;
            this.btnSuaNhom.Text = "Sửa Nhóm";
            this.btnSuaNhom.UseVisualStyleBackColor = false;
            this.btnSuaNhom.Click += new System.EventHandler(this.btnSuaNhom_Click);
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.BackColor = System.Drawing.Color.Red;
            this.btnThemNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhom.Location = new System.Drawing.Point(17, 26);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(110, 34);
            this.btnThemNhom.TabIndex = 137;
            this.btnThemNhom.Text = "Thêm Nhóm";
            this.btnThemNhom.UseVisualStyleBackColor = false;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // cbbNhanVIen
            // 
            this.cbbNhanVIen.FormattingEnabled = true;
            this.cbbNhanVIen.Location = new System.Drawing.Point(120, 208);
            this.cbbNhanVIen.Name = "cbbNhanVIen";
            this.cbbNhanVIen.Size = new System.Drawing.Size(248, 21);
            this.cbbNhanVIen.TabIndex = 136;
            // 
            // lbThanhVien
            // 
            this.lbThanhVien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThanhVien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhVien.ForeColor = System.Drawing.SystemColors.Window;
            this.lbThanhVien.Location = new System.Drawing.Point(17, 205);
            this.lbThanhVien.Name = "lbThanhVien";
            this.lbThanhVien.Size = new System.Drawing.Size(92, 29);
            this.lbThanhVien.TabIndex = 135;
            this.lbThanhVien.Text = "Thành viên";
            this.lbThanhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(120, 119);
            this.txtTenNhom.Multiline = true;
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(248, 30);
            this.txtTenNhom.TabIndex = 134;
            // 
            // txtNhomTruong
            // 
            this.txtNhomTruong.Location = new System.Drawing.Point(120, 161);
            this.txtNhomTruong.Multiline = true;
            this.txtNhomTruong.Name = "txtNhomTruong";
            this.txtNhomTruong.Size = new System.Drawing.Size(248, 30);
            this.txtNhomTruong.TabIndex = 133;
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(120, 77);
            this.txtNhom.Multiline = true;
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(248, 30);
            this.txtNhom.TabIndex = 132;
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenNhom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhom.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTenNhom.Location = new System.Drawing.Point(16, 119);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(93, 29);
            this.lbTenNhom.TabIndex = 131;
            this.lbTenNhom.Text = "Tên Nhóm";
            this.lbTenNhom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNhomTruong
            // 
            this.lbNhomTruong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNhomTruong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNhomTruong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomTruong.ForeColor = System.Drawing.Color.White;
            this.lbNhomTruong.Location = new System.Drawing.Point(17, 162);
            this.lbNhomTruong.Name = "lbNhomTruong";
            this.lbNhomTruong.Size = new System.Drawing.Size(92, 29);
            this.lbNhomTruong.TabIndex = 130;
            this.lbNhomTruong.Text = "Nhóm trưởng";
            this.lbNhomTruong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaNhom
            // 
            this.lbMaNhom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaNhom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhom.ForeColor = System.Drawing.Color.White;
            this.lbMaNhom.Location = new System.Drawing.Point(16, 77);
            this.lbMaNhom.Name = "lbMaNhom";
            this.lbMaNhom.Size = new System.Drawing.Size(93, 29);
            this.lbMaNhom.TabIndex = 129;
            this.lbMaNhom.Text = "Mã Nhóm";
            this.lbMaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNhom,
            this.clTenNhom,
            this.clNhomTruong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clMaNhom
            // 
            this.clMaNhom.HeaderText = "Mã Nhóm";
            this.clMaNhom.Name = "clMaNhom";
            // 
            // clTenNhom
            // 
            this.clTenNhom.HeaderText = "Tên nhóm";
            this.clTenNhom.Name = "clTenNhom";
            // 
            // clNhomTruong
            // 
            this.clNhomTruong.HeaderText = "Nhóm trưởng";
            this.clNhomTruong.Name = "clNhomTruong";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 142;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formNhomCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formNhomCongViec";
            this.Text = "Nhóm Công Việc";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.ComboBox cbbNhanVIen;
        private System.Windows.Forms.Label lbThanhVien;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtNhomTruong;
        private System.Windows.Forms.TextBox txtNhom;
        private System.Windows.Forms.Label lbTenNhom;
        private System.Windows.Forms.Label lbNhomTruong;
        private System.Windows.Forms.Label lbMaNhom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhomTruong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxListCongViec;
        private System.Windows.Forms.Button button1;
    }
}