using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Controllers;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Views
{
    public partial class formCongViecDangThucHien : Form
    {
        public string maNV;
        public int qh;
        public List<CongViec> lcv = CongViecControllers.getListCongViecfromDB();
        public formCongViecDangThucHien(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            display();
        }

        private void lbMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            this.clMaCongViecNhanVien.DataPropertyName = nameof(CongViecNhanVien.MaCongViecNhanVien);
            this.clMaNhanVienPhuTrach.DataPropertyName = nameof(CongViecNhanVien.MaNhanVienPhuTrach);
            this.clTenCongViec.DataPropertyName = nameof(CongViecNhanVien.TenCongViec);
            this.clMoTa.DataPropertyName = nameof(CongViecNhanVien.MoTa);
            this.clTaiLieu.DataPropertyName = nameof(CongViecNhanVien.TaiLieu);
            this.clLuongCongViec.DataPropertyName = nameof(CongViecNhanVien.LuongCongViec);
            this.clDuKienHoanThanh.DataPropertyName = nameof(CongViec.DuKienHoanThanh);
            this.clNgayBatDau.DataPropertyName = nameof(CongViec.NgayBatDau);
            this.clTienDo.DataPropertyName = nameof(CongViec.TienDo);
            this.clNgayHoanThanh.DataPropertyName = nameof(CongViec.NgayHoanThanh);

            cbxListCongViecnv.DataSource = CongViecControllers.getListCongViecfromDB();
            cbxListCongViecnv.DisplayMember = "TenCongViec";
            List<CongViecNhanVien> lstCongViecNhanVien = CongViecNhanVienControllers.getListCongViecNhanVienfromDB();
            BindingSource src = new BindingSource();
            src.DataSource = lstCongViecNhanVien;
            dataGridViewCongViecDangThucHien.DataSource = src;
            if (qh == 0)
            {
                btnThemCongViec.Visible = false;
                //btnSuaCongViec.Visible = false;
                
            }
            else if (qh == 1)
            {

            }
            dataGridViewCongViecDangThucHien.Columns[10].Visible = false;
            //dataGridViewCongViec.Columns[10].Visible = false;

        }

        private void dataGridViewCongViecDangThucHien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhanVien.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[1].Value.ToString();
                txtMaCongViecNhanVien.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[0].Value.ToString();
                txtTenCongViecNhanVien.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[2].Value.ToString();
                txtMoTaCongViecNhanVien.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[3].Value.ToString();
                txtTaiLieu.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[4].Value.ToString();
                txtLuongCongViec.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[5].Value.ToString();
                dateTimeDuKienHoanThanhCVNV.Value = DateTime.Parse(dataGridViewCongViecDangThucHien.CurrentRow.Cells[6].Value.ToString());
                dateTimeNgayBatDauCVNV.Value = DateTime.Parse(dataGridViewCongViecDangThucHien.CurrentRow.Cells[7].Value.ToString());
                txtTienDoCongViecNhanVien.Text = dataGridViewCongViecDangThucHien.CurrentRow.Cells[8].Value.ToString();
                dateTimeNgayKetThucCVNV.Value = DateTime.Parse(dataGridViewCongViecDangThucHien.CurrentRow.Cells[9].Value.ToString());



                List<CongViec> lcv = CongViecControllers.getListCongViecfromDB();
                List<CongViecNhanVien> lcvnv = CongViecNhanVienControllers.getListCongViecNhanVienfromDB();
                int index = -1;
                for (int i = 0; i < lcv.Count; i++)
                {


                    if (lcv[i].NoiDungCongViec != null)
                    {
                        string[] check = lcv[i].NoiDungCongViec.Split(',');
                        foreach (var item2 in check)
                        {
                            if (item2.Trim() == lcvnv[dataGridViewCongViecDangThucHien.CurrentRow.Index].MaCongViecNhanVien.Trim())
                                index = i;
                        }
                        if (index != -1)
                            break;

                    }

                }
                if (index == -1) return;
                cbxListCongViecnv.SelectedIndex = index;
            }
            catch
            {
                return;
            }
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            if (this.txtMaCongViecNhanVien.Text.Trim().Length <= 0 || this.txtMaNhanVien.Text.Trim().Length <= 0 || this.dateTimeDuKienHoanThanhCVNV.Value > DateTime.Now || this.dateTimeNgayBatDauCVNV.Value > DateTime.Now || this.dateTimeNgayKetThucCVNV.Value > DateTime.Now)
            {
                if (this.txtMaCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaCongViecNhanVien, "Ma cong viec khong duoc trong");
                    return;
                }
                else if (this.txtMaNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaNhanVien, "Ma nhan vien khong duoc de trong");
                    return;
                }
                this.errorProvider1.Clear();
                if (this.txtTenCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenCongViecNhanVien, "nhap ten cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtMoTaCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMoTaCongViecNhanVien, "nhap mo ta cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtLuongCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtLuongCongViec, "nhap luong cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeNgayBatDauCVNV.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeNgayBatDauCVNV, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeDuKienHoanThanhCVNV.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeDuKienHoanThanhCVNV, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();

            }
            CongViecNhanVien cv = new CongViecNhanVien();
            cv.MaCongViecNhanVien = txtMaCongViecNhanVien.Text.Trim();
            cv.TenCongViec = txtTenCongViecNhanVien.Text.Trim();
            cv.MaNhanVienPhuTrach = txtMaNhanVien.Text.Trim();
            cv.MoTa = txtMoTaCongViecNhanVien.Text.Trim();
            cv.LuongCongViec =int.Parse( txtLuongCongViec.Text.Trim());
            cv.TaiLieu = txtTaiLieu.Text.Trim();
            cv.NgayBatDau = DateTime.Parse(dateTimeNgayBatDauCVNV.Value.ToString());
            cv.DuKienHoanThanh = DateTime.Parse(dateTimeDuKienHoanThanhCVNV.Value.ToString());
            cv.NgayHoanThanh = DateTime.Parse(dateTimeNgayKetThucCVNV.Value.ToString());
            ChiPhi cp = new ChiPhi();
            cp.ChiPhiCongViec = cv.LuongCongViec;
            cp.MaCongViecChiTieu = cv.MaCongViecNhanVien;
            cp.CongViecChiTieu = cv.TenCongViec;
            cp.ThucHien= DateTime.Parse(dateTimeNgayKetThucCVNV.Value.ToString());
            ChiPhiControllers.AddChiPhi(cp);
            CongViec congviec = CongViecControllers.getCongViecfromDB(lcv[(cbxListCongViecnv.SelectedIndex)].MaCongViec.Trim());
            if (congviec.NoiDungCongViec.Trim() == "" || congviec.NoiDungCongViec == null)
            {
                congviec.NoiDungCongViec = txtMaCongViecNhanVien.Text.Trim();
            }
            else
            {
                congviec.NoiDungCongViec = congviec.NoiDungCongViec.Trim() + "," + txtMaCongViecNhanVien.Text.Trim();
            }
            CongViecControllers.updateCongViec(congviec);

            CongViecNhanVienControllers.AddCongViecNhanVien(cv);
            BindingSource source = new BindingSource();
            source.DataSource = CongViecNhanVienControllers.getListCongViecNhanVienfromDB();
            this.dataGridViewCongViecDangThucHien.DataSource = source;
        
        }

        private void btnSuaCongViec_Click(object sender, EventArgs e)
        {
            if (this.txtMaCongViecNhanVien.Text.Trim().Length <= 0 || this.txtMaNhanVien.Text.Trim().Length <= 0 || this.dateTimeDuKienHoanThanhCVNV.Value > DateTime.Now || this.dateTimeNgayBatDauCVNV.Value > DateTime.Now || this.dateTimeNgayKetThucCVNV.Value > DateTime.Now)
            {
                if (this.txtMaCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaCongViecNhanVien, "Ma cong viec khong duoc trong");
                    return;
                }
                else if (this.txtMaNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaNhanVien, "Ma nhan vien khong duoc de trong");
                    return;
                }
                this.errorProvider1.Clear();
                if (this.txtTenCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenCongViecNhanVien, "nhap ten cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtMoTaCongViecNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMoTaCongViecNhanVien, "nhap mo ta cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtLuongCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtLuongCongViec, "nhap luong cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeNgayBatDauCVNV.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeNgayBatDauCVNV, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeDuKienHoanThanhCVNV.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeDuKienHoanThanhCVNV, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();

            }
            CongViecNhanVien cv = new CongViecNhanVien();
            cv.MaCongViecNhanVien = txtMaCongViecNhanVien.Text.Trim();
            cv.TenCongViec = txtTenCongViecNhanVien.Text.Trim();
            cv.MaNhanVienPhuTrach = txtMaNhanVien.Text.Trim();
            cv.MoTa = txtMoTaCongViecNhanVien.Text.Trim();
            cv.LuongCongViec = int.Parse(txtLuongCongViec.Text.Trim());
            cv.TaiLieu = txtTaiLieu.Text.Trim();
            cv.NgayBatDau = DateTime.Parse(dateTimeNgayBatDauCVNV.Value.ToString());
            cv.DuKienHoanThanh = DateTime.Parse(dateTimeDuKienHoanThanhCVNV.Value.ToString());
            cv.NgayHoanThanh = DateTime.Parse(dateTimeNgayKetThucCVNV.Value.ToString());
            cv.TienDo = bool.Parse(txtTienDoCongViecNhanVien.Text);

            ChiPhi cp = new ChiPhi();
            cp.ChiPhiCongViec = cv.LuongCongViec;
            cp.MaCongViecChiTieu = cv.MaCongViecNhanVien;
            cp.CongViecChiTieu = cv.TenCongViec;
            cp.ThucHien = DateTime.Parse(dateTimeNgayKetThucCVNV.Value.ToString());
            ChiPhiControllers.updateChiPhi(cp);

            CongViecNhanVienControllers.updateCongViecNhanVien(cv);
            BindingSource source = new BindingSource();
            source.DataSource = CongViecNhanVienControllers.getListCongViecNhanVienfromDB();
            this.dataGridViewCongViecDangThucHien.DataSource = source;

        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
