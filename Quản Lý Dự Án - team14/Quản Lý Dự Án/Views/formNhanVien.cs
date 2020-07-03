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
    public partial class formNhanVien : Form
    {
        DateTimePicker dtp;
        int rowIndex;
        public string maNV;
        public int qh;

        public formNhanVien(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            Display();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (this.txtTenNhanVien.Text.Trim().Length <= 0 || this.txtMatKhau.Text.Trim().Length <= 0 || this.txtChucVu.Text.Trim().Length <= 0 || this.txtDiaChi.Text.Trim().Length <= 0 || this.dateTimeNgaySinh.Value > DateTime.Now || this.txtLuong.Text.Trim().Length <= 0 || this.txtMaNhanVien.Text.Trim().Length <= 0 || this.txtSoDienThoai.Text.Trim().Length <= 0)
            {
                if (this.txtMaNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaNhanVien, "Ma Nhan Vien khong duoc trong");
                    return;
                }
                else if (NhanVienControllers.getNhanVienfromDB(this.txtMaNhanVien.Text.Trim()) != null)
                {
                    this.errorProvider1.SetError(this.txtMaNhanVien, "Ma Nhan Vien da ton tai");
                    return;
                }
                this.errorProvider1.Clear();
                if (this.txtTenNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenNhanVien, "nhap ten nhan vien");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtChucVu.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtChucVu, "nhap chuc vu");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeNgaySinh.Value > DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeNgaySinh, "nhap ngay sinh");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtDiaChi.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtDiaChi, "nhap dia chi");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtMatKhau.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMatKhau, "nhap mat khau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtLuong.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtLuong, "nhap luong");
                    return;
                }
                else
                    this.errorProvider1.Clear();
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text.Trim(); ;
            nv.HoTen = txtTenNhanVien.Text.Trim(); 
            nv.Luong = Int32.Parse(txtLuong.Text.Trim());
            nv.MatKhau = txtMatKhau.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.NgaySinh = dateTimeNgaySinh.Value;
            nv.ChucVu = txtChucVu.Text.Trim();
            nv.SoDienThoai = txtSoDienThoai.Text.Trim();
            NhanVienControllers.AddNhanVien(nv);
            BindingSource source = new BindingSource();
            source.DataSource = NhanVienControllers.getListNhanVienfromDB();
            this.dataNhanVien.DataSource = source;
        }
        private void Display()
        {
            this.clChucVu.DataPropertyName = nameof(NhanVien.ChucVu);
            this.clDiaChi.DataPropertyName = nameof(NhanVien.DiaChi);
            this.clHoTen.DataPropertyName = nameof(NhanVien.HoTen);
            this.clLuong.DataPropertyName = nameof(NhanVien.Luong);
            this.clMaNhanVien.DataPropertyName = nameof(NhanVien.MaNhanVien);
            this.clMatKhau.DataPropertyName = nameof(NhanVien.MatKhau);
            this.clNgaySinh.DataPropertyName = nameof(NhanVien.NgaySinh);
            this.clSoDienThoai.DataPropertyName = nameof(NhanVien.SoDienThoai);
            this.clNhom.DataPropertyName = nameof(NhanVien.Nhom);

            
            List<NhanVien> lstnhanvien = NhanVienControllers.getListNhanVienfromDB();
            for(int i=0;i<=lstnhanvien.Count-1;i++)
            {
                CongViecNhanVienControllers.updateLuong(lstnhanvien[i]);
            }    

            BindingSource src = new BindingSource();
            src.DataSource = lstnhanvien;
            dataNhanVien.DataSource = src;
            if (qh == 0)
            {
                btnThemNhanVien.Visible = false;
                btnSuaNhanVien.Visible = false;
                btnXoaNhanVien.Visible = false;
            }
            else if (qh == 1)
            {

            }
            dataNhanVien.Columns[11].Visible = false;
            dataNhanVien.Columns[10].Visible = false;
            dataNhanVien.Columns[9].Visible = false;
            dataNhanVien.Columns[8].Visible = false;
        }

        private void dataNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = this.dataNhanVien.Rows[e.RowIndex].Index;
                if(this.dataNhanVien.Columns[e.ColumnIndex].DataPropertyName != nameof(NhanVien.MaNhanVien))
                    if(this.dataNhanVien.CurrentRow.Cells[0].Value == null)
                    {
                        MessageBox.Show("Chua nhap Ma Nhan Vien");
                        return;
                    }

                txtTenNhanVien.Text = dataNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtSoDienThoai.Text = dataNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtChucVu.Text = dataNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dataNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtMaNhanVien.Text = dataNhanVien.CurrentRow.Cells[0].Value.ToString();

                txtLuong.Text = dataNhanVien.CurrentRow.Cells[6].Value.ToString();
                //btnCongVienDangLam.Text = dataNhanVien.CurrentRow.Cells[9].Value.ToString();
                dateTimeNgaySinh.Value = DateTime.Parse(dataNhanVien.CurrentRow.Cells[2].Value.ToString());
                txtNhom.Text = dataNhanVien.CurrentRow.Cells[7].Value.ToString();
                
                if (this.dataNhanVien.Columns[e.ColumnIndex].DataPropertyName == nameof(NhanVien.NgaySinh))
                {
                    dtp = new DateTimePicker();
                    dtp.Format = DateTimePickerFormat.Short;
                    dtp.Visible = true;
                    Rectangle rect = this.dataNhanVien.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Location = new Point(rect.X, rect.Y);
                    dtp.Size = new Size(rect.Width, rect.Height);
                    try
                    {
                        dtp.Value = DateTime.Parse(this.dataNhanVien.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dtp.Value = DateTime.Now;
                    }
                    dtp.CloseUp += Dtp_CloseUp;
                    dtp.TextChanged += Dtp_TextChanged;
                    this.dataNhanVien.Controls.Add(dtp);
                }
                
            }
            catch
            {
                return;
            }
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            this.dataNhanVien.CurrentCell.Value = this.dtp.Value.ToString();
            NhanVien nv = NhanVienControllers.getNhanVienfromDB(this.dataNhanVien.CurrentRow.Cells[0].Value.ToString());

            nv.NgaySinh = this.dtp.Value;
            NhanVienControllers.UpdateNhanVien(nv);
            BindingSource src = new BindingSource();
            src.DataSource = NhanVienControllers.getListNhanVienfromDB();
            this.dataNhanVien.DataSource = src;
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.dataNhanVien.CurrentCell.Value == null)
            {
                return;
            }
            NhanVien nv = NhanVienControllers.getNhanVienfromDB(this.dataNhanVien.CurrentRow.Cells[0].Value.ToString());
            NhanVienControllers.DeleteNhanVien(nv);
            BindingSource src = new BindingSource();
            src.DataSource = NhanVienControllers.getListNhanVienfromDB();
            this.dataNhanVien.DataSource = src;
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (this.txtTenNhanVien.Text.Trim().Length <= 0|| this.txtChucVu.Text.Trim().Length <= 0 || this.txtDiaChi.Text.Trim().Length <= 0 || this.dateTimeNgaySinh.Value > DateTime.Now || this.txtLuong.Text.Trim().Length <= 0 || this.txtMaNhanVien.Text.Trim().Length <= 0 || this.txtSoDienThoai.Text.Trim().Length <= 0)
            {
                if (this.txtMaNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaNhanVien, "Ma Nhan Vien khong duoc trong");
                    return;
                }
                else 
                this.errorProvider1.Clear();
                if (this.txtTenNhanVien.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenNhanVien, "nhap ten nhan vien");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtChucVu.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtChucVu, "nhap chuc vu");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeNgaySinh.Value > DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeNgaySinh, "nhap ngay sinh");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtDiaChi.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtDiaChi, "nhap dia chi");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                
                if (this.txtLuong.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtLuong, "nhap luong");
                    return;
                }
                else
                    this.errorProvider1.Clear();
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text.Trim(); ;
            nv.HoTen = txtTenNhanVien.Text.Trim();
            nv.Luong = Int32.Parse(txtLuong.Text.Trim());
            nv.MatKhau = txtMatKhau.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.NgaySinh = dateTimeNgaySinh.Value;
            nv.ChucVu = txtChucVu.Text.Trim();
            nv.SoDienThoai = txtSoDienThoai.Text.Trim();
            nv.Nhom = txtNhom.Text.Trim();
             var lsnv = NhanVienControllers.getListNhanVienfromDB();
            nv.Nhom1 = lsnv[dataNhanVien.CurrentRow.Index].Nhom1;
            nv.MatKhau = lsnv[dataNhanVien.CurrentRow.Index].MatKhau;
            //v.Nhom1 = 
            NhanVienControllers.UpdateNhanVien(nv);
            BindingSource source = new BindingSource();
            source.DataSource = NhanVienControllers.getListNhanVienfromDB();
            this.dataNhanVien.DataSource = source;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
