namespace QuanLyDuAn.Views
{
    partial class formChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChiPhi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cMaCVChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCongViecChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCongViec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeNgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.txtMaCongViec = new System.Windows.Forms.TextBox();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.lbNgayThucHien = new System.Windows.Forms.Label();
            this.Mã = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.txtCongViec);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimeNgayThucHien);
            this.splitContainer1.Panel2.Controls.Add(this.txtChiPhi);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaCongViec);
            this.splitContainer1.Panel2.Controls.Add(this.lbChiPhi);
            this.splitContainer1.Panel2.Controls.Add(this.lbNgayThucHien);
            this.splitContainer1.Panel2.Controls.Add(this.Mã);
            this.splitContainer1.Size = new System.Drawing.Size(800, 406);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaCVChiTieu,
            this.cCongViecChiTieu,
            this.cNgayThucHien,
            this.cChiPhi});
            this.dataGridView1.Location = new System.Drawing.Point(3, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 215);
            this.dataGridView1.TabIndex = 123;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cMaCVChiTieu
            // 
            this.cMaCVChiTieu.HeaderText = "Mã công việc chi tiêu";
            this.cMaCVChiTieu.Name = "cMaCVChiTieu";
            // 
            // cCongViecChiTieu
            // 
            this.cCongViecChiTieu.HeaderText = "Công việc";
            this.cCongViecChiTieu.Name = "cCongViecChiTieu";
            // 
            // cNgayThucHien
            // 
            this.cNgayThucHien.HeaderText = "Ngày thực hiện";
            this.cNgayThucHien.Name = "cNgayThucHien";
            // 
            // cChiPhi
            // 
            this.cChiPhi.HeaderText = "Chi phí";
            this.cChiPhi.Name = "cChiPhi";
            // 
            // txtCongViec
            // 
            this.txtCongViec.Location = new System.Drawing.Point(156, 71);
            this.txtCongViec.Multiline = true;
            this.txtCongViec.Name = "txtCongViec";
            this.txtCongViec.Size = new System.Drawing.Size(303, 30);
            this.txtCongViec.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 121;
            this.label1.Text = "Công việc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeNgayThucHien
            // 
            this.dateTimeNgayThucHien.Location = new System.Drawing.Point(156, 112);
            this.dateTimeNgayThucHien.Name = "dateTimeNgayThucHien";
            this.dateTimeNgayThucHien.Size = new System.Drawing.Size(303, 20);
            this.dateTimeNgayThucHien.TabIndex = 114;
            this.dateTimeNgayThucHien.ValueChanged += new System.EventHandler(this.dateTimeNgayThucHien_ValueChanged);
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(156, 143);
            this.txtChiPhi.Multiline = true;
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(303, 30);
            this.txtChiPhi.TabIndex = 113;
            // 
            // txtMaCongViec
            // 
            this.txtMaCongViec.Location = new System.Drawing.Point(156, 30);
            this.txtMaCongViec.Multiline = true;
            this.txtMaCongViec.Name = "txtMaCongViec";
            this.txtMaCongViec.Size = new System.Drawing.Size(303, 30);
            this.txtMaCongViec.TabIndex = 113;
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChiPhi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.ForeColor = System.Drawing.Color.White;
            this.lbChiPhi.Location = new System.Drawing.Point(21, 144);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(129, 29);
            this.lbChiPhi.TabIndex = 111;
            this.lbChiPhi.Text = "Chi phí";
            this.lbChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayThucHien
            // 
            this.lbNgayThucHien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNgayThucHien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNgayThucHien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThucHien.ForeColor = System.Drawing.Color.White;
            this.lbNgayThucHien.Location = new System.Drawing.Point(21, 106);
            this.lbNgayThucHien.Name = "lbNgayThucHien";
            this.lbNgayThucHien.Size = new System.Drawing.Size(129, 29);
            this.lbNgayThucHien.TabIndex = 112;
            this.lbNgayThucHien.Text = "Ngày thực hiện";
            this.lbNgayThucHien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNgayThucHien.Click += new System.EventHandler(this.lbNgayThucHien_Click);
            // 
            // Mã
            // 
            this.Mã.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mã.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mã.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mã.ForeColor = System.Drawing.Color.White;
            this.Mã.Location = new System.Drawing.Point(21, 30);
            this.Mã.Name = "Mã";
            this.Mã.Size = new System.Drawing.Size(129, 29);
            this.Mã.TabIndex = 111;
            this.Mã.Text = "Mã công việc";
            this.Mã.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formChiPhi";
            this.Text = "formChiPhi";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimeNgayThucHien;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.TextBox txtMaCongViec;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.Label lbNgayThucHien;
        private System.Windows.Forms.Label Mã;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaCVChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCongViecChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChiPhi;
        private System.Windows.Forms.TextBox txtCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}