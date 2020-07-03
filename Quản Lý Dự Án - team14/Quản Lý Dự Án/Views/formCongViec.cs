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
    public partial class formCongViec : Form
    {
        public string maNV;
        public int qh;
        public List<DuAn> lda = DuAnControllers.getListDuAnfromDB();
        public string ht = "chua co";
        public formCongViec(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            cvhoanthanh();
            display();
        }
        public void cvhoanthanh()
        {
            List<CongViec> lcv = CongViecControllers.getListCongViecfromDB();
            foreach (CongViec cv in lcv)
            {
                int flag = 0;
                string[] lcongviennv = cv.NoiDungCongViec.Trim().Split(',');
                List<CongViecNhanVien> lstcvnv = new List<CongViecNhanVien>();
                foreach (var item in lcongviennv)
                {
                    if(CongViecNhanVienControllers.CheckCongViecNhanVienHoanThanhfromDB(item)==false)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        lstcvnv.Add(CongViecNhanVienControllers.getCongViecNhanVienfromDB(item));
                    }
                }
                if (flag == 0)
                {
                    cv.NgayHoanThanh = checkmaxtime(lstcvnv);
                }
                CongViecControllers.updateCongViec(cv);
            }
        }
        public DateTime checkmaxtime(List<CongViecNhanVien> lstcvnv)
        {
            DateTime Max = lstcvnv[0].NgayHoanThanh.Value;
            foreach (var item in lstcvnv)
            {
                if (item.NgayHoanThanh.Value > Max)
                    Max = item.NgayHoanThanh.Value;
            }
            return Max;
        }
        private void dateTimeDuKienHoanThanh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeThoiGianHoanThanh_ValueChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            this.clMaCongViec.DataPropertyName = nameof(CongViec.MaCongViec);
            this.clTenCongViec.DataPropertyName = nameof(CongViec.TenCongViec);
            this.clNoiDungCongViec.DataPropertyName = nameof(CongViec.NoiDungCongViec);
            this.clNhomPhuTrach.DataPropertyName = nameof(CongViec.ListNhomPhuTrach);
            this.clChiPhi.DataPropertyName = nameof(CongViec.ChiPhi);
            this.clDuKienHoanThanh.DataPropertyName = nameof(CongViec.DuKienHoanThanh);
            this.clNgayBatDau.DataPropertyName = nameof(CongViec.NgayBatDau);
            this.clTienDo.DataPropertyName = nameof(CongViec.TienDo);
            this.clNgayHoanThanh.DataPropertyName = nameof(CongViec.NgayHoanThanh);
            cbxListDuAn.DataSource = DuAnControllers.getListDuAnfromDB();
            cbxListDuAn.DisplayMember = "TenDuAn";
            
            List<CongViec> lstCongViec = CongViecControllers.getListCongViecfromDB();
            for(int i=0;i<=lstCongViec.Count-1;i++)
            {
                CongViecControllers.updateChiPhi(lstCongViec[i]);
                CongViecControllers.updateTienDo(lstCongViec[i]);
            }
            BindingSource src = new BindingSource();
            src.DataSource = lstCongViec;
            dataGridViewCongViec.DataSource = src;
            if (qh == 0)
            {
                btnThemCongViec.Visible = false;
                btnSuaCongViec.Visible = false;
              
            }
            else if (qh == 1)
            {

            }
            dataGridViewCongViec.Columns[9].Visible = false;
            dataGridViewCongViec.Columns[10].Visible = false;

        }

        private void dataGridViewCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CongViec> lstCongViec = CongViecControllers.getListCongViecfromDB();
            for (int i = 0; i <= lstCongViec.Count - 1; i++)
            {
                CongViecControllers.updateChiPhi(lstCongViec[i]);
                CongViecControllers.updateTienDo(lstCongViec[i]);
            }

            try
            {
                txtMaCongViec.Text = dataGridViewCongViec.CurrentRow.Cells[0].Value.ToString();
                txtTenCongViec.Text = dataGridViewCongViec.CurrentRow.Cells[1].Value.ToString();
                rtxtNoiDungCongViec.Text = dataGridViewCongViec.CurrentRow.Cells[2].Value.ToString();
                if (dataGridViewCongViec.CurrentRow.Cells[3].Value == null)
                {
                    cbbNhom.DataSource = null;
                    cbbNhom.Text = "";
                }
                else
                    cbbNhom.Text = dataGridViewCongViec.CurrentRow.Cells[3].Value.ToString();
                txtChiPhi.Text = dataGridViewCongViec.CurrentRow.Cells[4].Value.ToString();
                dateTimeDuKienHoanThanh.Value = DateTime.Parse(dataGridViewCongViec.CurrentRow.Cells[5].Value.ToString());
                dateTimeBatDauCongViec.Value = DateTime.Parse(dataGridViewCongViec.CurrentRow.Cells[6].Value.ToString());
                //cbbTienDo.Text = 
                if(dataGridViewCongViec.CurrentRow.Cells[7].Value!=null)
                {
                    progressBar1.Value = int.Parse(dataGridViewCongViec.CurrentRow.Cells[7].Value.ToString());
                }
                else
                {
                    progressBar1.Value = 0;
                }
                ///////////////
                dateTimeThoiGianHoanThanh.Value = DateTime.Parse(dataGridViewCongViec.CurrentRow.Cells[8].Value.ToString());
                var lcv = CongViecControllers.getListCongViecfromDB();
                lda = DuAnControllers.getListDuAnfromDB();
                int index = -1;
                for (int i =0;i<lda.Count; i++)
                {
                    
                    
                    if (lda[i].CongViecDuAn != null)
                    {
                        string[] check = lda[i].CongViecDuAn.Split(',');
                        foreach (var item2 in check)
                        {
                            if (item2.Trim() == lcv[dataGridViewCongViec.CurrentRow.Index].MaCongViec.Trim())
                                index = i;
                        }
                        if (index != -1)
                            break;
                        
                    }
                    
                }
                if (index == -1) return;
                cbxListDuAn.SelectedIndex = index;

            }
            catch
            {
                return;
            }
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            if (this.txtTenCongViec.Text.Trim().Length <= 0 || this.txtMaCongViec.Text.Trim().Length <= 0 || this.dateTimeDuKienHoanThanh.Value > DateTime.Now || this.dateTimeBatDauCongViec.Value > DateTime.Now || this.dateTimeDuKienHoanThanh.Value > DateTime.Now)
            {
                if (this.txtMaCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaCongViec, "Ma cong viec khong duoc trong");
                    return;
                }
                else if (CongViecControllers.getMaCongViecfromDB( this.txtMaCongViec.Text.Trim())!="")
                {
                    this.errorProvider1.SetError(this.txtMaCongViec, "Ma cong viec da ton tai");
                    return;
                }
                else
                this.errorProvider1.Clear();
                if (this.txtTenCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenCongViec, "nhap ten cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeBatDauCongViec.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeBatDauCongViec, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeDuKienHoanThanh.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeDuKienHoanThanh, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();

            }
            CongViec cv = new CongViec();
            cv.MaCongViec = txtMaCongViec.Text.Trim();
            cv.TenCongViec = txtTenCongViec.Text.Trim();
            cv.NoiDungCongViec = rtxtNoiDungCongViec.Text.Trim();
            //cv.ListNhomPhuTrach = cbbNhom.SelectedItem.ToString();
            cv.NgayBatDau = DateTime.Parse(dateTimeBatDauCongViec.Value.ToString());
            cv.DuKienHoanThanh = DateTime.Parse(dateTimeDuKienHoanThanh.Value.ToString());
            cv.NgayHoanThanh = DateTime.Parse("01/01/2000 12:00:00 AM");
            cv.TienDo = 0;
            cv.ChiPhi = 0;
            DuAn da = DuAnControllers.getDuAnfromDB(lda[(cbxListDuAn.SelectedIndex)].MaDuAn.Trim());
            if ( da.CongViecDuAn == null)
            {
                da.CongViecDuAn = txtMaCongViec.Text.Trim();
            }
            else
            {
                da.CongViecDuAn = da.CongViecDuAn.Trim() + "," + txtMaCongViec.Text.Trim();
            }
            DuAnControllers.updateDA(da);


            CongViecControllers.AddCongViec(cv);
            BindingSource source = new BindingSource();
            source.DataSource = CongViecControllers.getListCongViecfromDB();
            this.dataGridViewCongViec.DataSource = source;
        }

        private void btnSuaCongViec_Click(object sender, EventArgs e)
        {
            if (this.txtTenCongViec.Text.Trim().Length <= 0 || this.txtMaCongViec.Text.Trim().Length <= 0 || this.dateTimeDuKienHoanThanh.Value > DateTime.Now || this.dateTimeBatDauCongViec.Value > DateTime.Now || this.dateTimeDuKienHoanThanh.Value > DateTime.Now)
            {
                if (this.txtMaCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaCongViec, "Ma cong viec khong duoc trong");
                    return;
                }
                else if (CongViecControllers.getMaCongViecfromDB(this.txtMaCongViec.Text.Trim()) != "")
                {
                    this.errorProvider1.SetError(this.txtMaCongViec, "Ma cong viec da ton tai");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.txtTenCongViec.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenCongViec, "nhap ten cong viec");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeBatDauCongViec.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeBatDauCongViec, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeDuKienHoanThanh.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeDuKienHoanThanh, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();

            }
            
            var lcv = CongViecControllers.getListCongViecfromDB();
            
            CongViec cv = new CongViec();
            
            cv.MaCongViec = txtMaCongViec.Text.Trim();
            cv.TenCongViec = txtTenCongViec.Text.Trim();
            cv.NoiDungCongViec = rtxtNoiDungCongViec.Text.Trim();
            //cv.ListNhomPhuTrach = cbbNhom.SelectedItem.ToString();
            cv.NgayBatDau = DateTime.Parse(dateTimeBatDauCongViec.Value.ToString());
            cv.DuKienHoanThanh = DateTime.Parse(dateTimeDuKienHoanThanh.Value.ToString());
            cv.NgayHoanThanh = lcv[dataGridViewCongViec.CurrentRow.Index].NgayHoanThanh;
            cv.TienDo = lcv[dataGridViewCongViec.CurrentRow.Index].TienDo;
            cv.ChiPhi = lcv[dataGridViewCongViec.CurrentRow.Index].ChiPhi;
            
            


            CongViecControllers.updateCongViec(cv);
            BindingSource source = new BindingSource();
            source.DataSource = CongViecControllers.getListCongViecfromDB();
            this.dataGridViewCongViec.DataSource = source;
        }

        private void btnXoaCongViec_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCongViec.CurrentCell.Value == null)
            {
                return;
            }
            DuAn da = lda[cbxListDuAn.SelectedIndex];
            string[] lcongviec = da.CongViecDuAn.Split(',');
            List<string> lstringcv = lcongviec.ToList();
            foreach (var item in lstringcv)
            {
                if(dataGridViewCongViec.CurrentRow.Cells[0].Value.ToString().Trim()==item.Trim())
                {
                    lstringcv.Remove(item);
                    break;
                }
            }
            if (lstringcv.Count != 0)
            {
                da.CongViecDuAn = lstringcv[0].Trim();
                for (int i = 1; i < lstringcv.Count; i++)
                {
                    da.CongViecDuAn = da.CongViecDuAn + "," + lstringcv[i].Trim();
                }
                DuAnControllers.updateDA(da);
            }
            else
            {
                da.CongViecDuAn = "";
                DuAnControllers.updateDA(da);
            }
            CongViec cv = CongViecControllers.getCongViecfromDB(this.dataGridViewCongViec.CurrentRow.Cells[0].Value.ToString().Trim());
            if (cv.NoiDungCongViec.ToString().Trim() != "")
            {
                List<string> listcongviecnv = cv.NoiDungCongViec.Split(',').ToList();
                // listcongviecnv[listcongviecnv.Count - 1].Trim();
                foreach (var item in listcongviecnv)
                {
                    CongViecNhanVienControllers.DeleteCVNV(item);
                }
            }
            if (cv.ListNhomPhuTrach != null)
            {
                List<string> listnhom = cv.ListNhomPhuTrach.Split(',').ToList();
                listnhom[listnhom.Count - 1].Trim();
                foreach (var item in listnhom)
                {
                    List<NhanVien> listnv = NhanVienControllers.getListNhanVienfromDB();
                    foreach (var item2 in listnv)
                    {
                        if (item2.Nhom.Trim() == item.Trim())
                        {
                            NhanVienControllers.DeleteNhanVien(item2);
                        }
                    }
                    NhomControllers.DeleteNhom(item);
                }
            }
            CongViecControllers.DeleteCongViec(this.dataGridViewCongViec.CurrentRow.Cells[0].Value.ToString().Trim());
            BindingSource src = new BindingSource();
            src.DataSource = CongViecControllers.getListCongViecfromDB();
            this.dataGridViewCongViec.DataSource = src;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
