using QuanLyDuAn.Controllers;
using QuanLyDuAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Views
{
    public partial class formChiPhi : Form
    {
        public string maNV;
        public int qh;
        public formChiPhi(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            display();
        }
        public void display()
        {
            this.cMaCVChiTieu.DataPropertyName = nameof(ChiPhi.MaCongViecChiTieu);
            this.cCongViecChiTieu.DataPropertyName = nameof(ChiPhi.CongViecChiTieu);
            this.cNgayThucHien.DataPropertyName = nameof(ChiPhi.ThucHien);
            this.cChiPhi.DataPropertyName = nameof(ChiPhi.ChiPhiCongViec);

            List<ChiPhi> lstChiPhi = ChiPhiControllers.getListChiPhifromDB();
            BindingSource src = new BindingSource();
            src.DataSource = lstChiPhi;
            dataGridView1.DataSource = src;

            //dataGridView1.Columns[3].Visible = false;
        }

        private void lbNgayThucHien_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeNgayThucHien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnMua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnTraCong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaCongViec.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCongViec.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimeNgayThucHien.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                txtChiPhi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnThemChiPhi_Click(object sender, EventArgs e)
        {
            if (this.txtMaCongViec.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtMaCongViec, "nhap ten ma cong viec");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtCongViec.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtCongViec, "nhap ten cong viec");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtChiPhi.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtChiPhi, "nhap chi phi");
                return;
            }
            else
                this.errorProvider1.Clear();
            ChiPhi cp = new ChiPhi();
            cp.MaCongViecChiTieu = txtMaCongViec.Text.Trim();
            cp.CongViecChiTieu = txtCongViec.Text.Trim();
            cp.ChiPhiCongViec =int.Parse( txtChiPhi.Text.Trim());
            cp.ThucHien = dateTimeNgayThucHien.Value;

            ChiPhiControllers.AddChiPhi(cp);
            BindingSource source = new BindingSource();
            source.DataSource = ChiPhiControllers.getListChiPhifromDB();
            this.dataGridView1.DataSource = source;
        }

        private void btnSuaChiPhi_Click(object sender, EventArgs e)
        {
            if (this.txtMaCongViec.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtMaCongViec, "nhap ten ma cong viec");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtCongViec.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtCongViec, "nhap ten cong viec");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtChiPhi.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtChiPhi, "nhap chi phi");
                return;
            }
            else
                this.errorProvider1.Clear();
            ChiPhi cp = new ChiPhi();
            cp.MaCongViecChiTieu = txtMaCongViec.Text.Trim();
            cp.CongViecChiTieu = txtCongViec.Text.Trim();
            cp.ChiPhiCongViec = int.Parse(txtChiPhi.Text.Trim());
            cp.ThucHien = dateTimeNgayThucHien.Value;

            ChiPhiControllers.updateChiPhi(cp);
            BindingSource source = new BindingSource();
            source.DataSource = ChiPhiControllers.getListChiPhifromDB();
            this.dataGridView1.DataSource = source;

        }
    }
}
