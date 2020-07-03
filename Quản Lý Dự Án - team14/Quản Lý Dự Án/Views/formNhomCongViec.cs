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
    public partial class formNhomCongViec : Form
    {
        public string maNV;
        public int qh;
        public List<CongViec> lcv = CongViecControllers.getListCongViecfromDB();
        public formNhomCongViec(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            display();
        }
        public void display()
        {
            this.clMaNhom.DataPropertyName = nameof(Nhom.MaNhom);
            this.clTenNhom.DataPropertyName = nameof(Nhom.TenNhom);
            this.clNhomTruong.DataPropertyName = nameof(Nhom.NhomTruong);
            cbxListCongViec.DataSource = CongViecControllers.getListCongViecfromDB();
            cbxListCongViec.DisplayMember = "TenCongViec";
            
            
            List<Nhom> lstNhom = NhomControllers.getListNhomfromDB();
            BindingSource src = new BindingSource();
            src.DataSource = lstNhom;
            dataGridView1.DataSource = src;
            if(qh==0)
            {
                btnThemNhom.Visible = false;
                btnSuaNhom.Visible = false;
                btnXoaNhom.Visible = false;
            }
            else if(qh==1)
            {

            }

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhom = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNhom.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNhom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNhomTruong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            List<NhanVien> lstNhanVienCuaNhom = NhanVienControllers.getListNhanVienCuaNhomfromDB(maNhom);
            BindingSource src = new BindingSource();
            src.DataSource = lstNhanVienCuaNhom;
            cbbNhanVIen.DataSource = lstNhanVienCuaNhom;

        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (this.txtNhom.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtNhom, "nhap ten ma nhom");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (NhomControllers.getNhomfromDB(this.txtNhom.Text.Trim()) != "")
            {
                this.errorProvider1.SetError(this.txtNhom, "Ma nhom da ton tai");
                return;
            }
            this.errorProvider1.Clear();
            if (this.txtTenNhom.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtTenNhom, "nhap ten nhom");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtNhomTruong.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtNhomTruong, "nhap ma nhan vien nhom truong");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (NhanVienControllers.getNhanVienfromDB(this.txtNhomTruong.Text.Trim()) == null)
            {
                this.errorProvider1.SetError(this.txtNhom, "khong tim thay nhom truong");
                return;
            }
            this.errorProvider1.Clear();
            Nhom nh = new Nhom();
            nh.MaNhom = txtNhom.Text.Trim();
            nh.TenNhom = txtTenNhom.Text.Trim();
            nh.NhomTruong = txtNhomTruong.Text.Trim();

            NhomControllers.AddNhom(nh);
            BindingSource source = new BindingSource();
            source.DataSource = NhomControllers.getListNhomfromDB();
            this.dataGridView1.DataSource = source;
            CongViec cv = CongViecControllers.getCongViecfromDB(lcv[(cbxListCongViec.SelectedIndex)].MaCongViec.Trim());
            if (cv.ListNhomPhuTrach == "" || cv.ListNhomPhuTrach == null)
            {
                cv.ListNhomPhuTrach = txtNhom.Text.Trim();
            }
            else
            {
                cv.ListNhomPhuTrach = cv.ListNhomPhuTrach.Trim() + "," + txtNhom.Text.Trim();
            }
            CongViecControllers.updateCongViec(cv);
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell.Value == null)
            {
                return;
            }
            CongViec cv = lcv[cbxListCongViec.SelectedIndex];
            List<string> lstcv = cv.ListNhomPhuTrach.Split(',').ToList();
            foreach (var item in lstcv)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() == item.Trim())
                {
                    lstcv.Remove(item);
                    break;
                }
            }
            if (lstcv[0] != null)
                cv.ListNhomPhuTrach = lstcv[0];
            else
                cv.ListNhomPhuTrach = "";
            for (int i = 1; i < lstcv.Count; i++)
            {
                cv.ListNhomPhuTrach = cv.ListNhomPhuTrach + "," + lstcv[i];
            }
            CongViecControllers.updateCongViec(cv);
            List<NhanVien> listnv = NhanVienControllers.getListNhanVienfromDB();
            foreach (var item in listnv)
            {
                if(item.Nhom.Trim() == dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim())
                {
                    NhanVienControllers.DeleteNhanVien(item);
                }
            }
            NhomControllers.DeleteNhom(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
            BindingSource src = new BindingSource();
            src.DataSource = NhomControllers.getListNhomfromDB();
            this.dataGridView1.DataSource = src;
        }

        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            if (this.txtNhom.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtNhom, "nhap ten ma nhom");
                return;
            }
            else
                this.errorProvider1.Clear();
           
            if (this.txtTenNhom.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtTenNhom, "nhap ten nhom");
                return;
            }
            else
                this.errorProvider1.Clear();
            if (this.txtNhomTruong.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtNhomTruong, "nhap ma nhan vien nhom truong");
                return;
            }
            else
                this.errorProvider1.Clear();
            Nhom nh = new Nhom();
            nh.MaNhom = txtNhom.Text.Trim();
            nh.TenNhom = txtTenNhom.Text.Trim();
            nh.NhomTruong = txtNhomTruong.Text.Trim();

            NhomControllers.updateNhom(nh);
            BindingSource source = new BindingSource();
            source.DataSource = NhomControllers.getListNhomfromDB();
            this.dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
