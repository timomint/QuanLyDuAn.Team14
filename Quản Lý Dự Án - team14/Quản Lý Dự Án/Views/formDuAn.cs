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
    public partial class formDuAn : Form
    {
        public string maNV;
        public int qh;
        public formDuAn(string maNV, int qh)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.qh = qh;
            tinhChiPhiDA();
            tinhTienDoDA();
            dahoanthanh();
            display();
        }


        public void dahoanthanh()
        {
            List<DuAn> lda = DuAnControllers.getListDuAnfromDB();
            foreach (DuAn da in lda)
            {
                int flag = 0;
                if (da.CongViecDuAn != null)
                {
                    string[] lcongviecda = da.CongViecDuAn.Trim().Split(',');
                    List<CongViec> lstcv = new List<CongViec>();
                    foreach (var item in lcongviecda)
                    {
                        if (CongViecControllers.CheckCongViecHoanThanhfromDB(item) == false)
                        {
                            flag = 1;
                            break;
                        }
                        else
                        {
                            lstcv.Add(CongViecControllers.getCongViecfromDB(item));
                        }
                    }
                    if (flag == 0)
                    {
                        da.NgayHoanThanh = checkmaxtime(lstcv);
                    }
                    DuAnControllers.updateDA(da);
                }
            }
        }
        public DateTime checkmaxtime(List<CongViec> lstcvnv)
        {
            DateTime Max = lstcvnv[0].NgayHoanThanh.Value;
            foreach (var item in lstcvnv)
            {
                if (item.NgayHoanThanh.Value > Max)
                    Max = item.NgayHoanThanh.Value;
            }
            return Max;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chlbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            this.clMaDuAn.DataPropertyName = nameof(DuAn.MaDuAn);
            this.clTenDuAn.DataPropertyName = nameof(DuAn.TenDuAn);
            this.clMucTieuDuAn.DataPropertyName = nameof(DuAn.MucTieuDuAn);
            this.clChiPhiDuAn.DataPropertyName = nameof(DuAn.ChiPhiDuAn);
            this.clCongViecDuAn.DataPropertyName = nameof(DuAn.CongViecDuAn);
            this.clNhomPhuTrach.DataPropertyName = nameof(DuAn.NhomPhuTrach);
            this.clDuKienHoanThanh.DataPropertyName = nameof(DuAn.DuKienHoanThanh);
            this.clNgayBatDau.DataPropertyName = nameof(DuAn.NgayBatDau);
            this.clTienDo.DataPropertyName = nameof(DuAn.TienDo);
            this.clNgayHoanThanh.DataPropertyName = nameof(DuAn.NgayHoanThanh);

            List<DuAn> lstDuAn = DuAnControllers.getListDuAnfromDB();
            BindingSource src = new BindingSource();
            src.DataSource = lstDuAn;
            dataGridViewDuAn.DataSource = src;
            dataGridViewDuAn.Columns[10].Visible = false;
            dataGridViewDuAn.Columns[11].Visible = false;
            dataGridViewDuAn.Columns[4].Visible = false;
            dataGridViewDuAn.Columns[5].Visible = false;
            if (qh == 0)
            {
                btnThemDuAn.Visible = false;
                btnSuaDuAn.Visible = false;
            }
            dataGridViewDuAn.Columns[10].Visible = false;
            dataGridViewDuAn.Columns[11].Visible = false;
        }
        public void tinhChiPhiDA()
        {
            List<DuAn> lstDuAn = DuAnControllers.getListDuAnfromDB();
            foreach (DuAn da in lstDuAn)
            {
                if (da.CongViecDuAn != null)
                {
                    string macongviec = da.CongViecDuAn.Trim();
                    macongviec = macongviec.Trim();
                    string[] listtencongviec = macongviec.Split(',');
                    List<CongViec> lcv = CongViecControllers.getListCongViecfromDB(listtencongviec);
                    int cp = 0;
                    foreach (CongViec cv in lcv)
                    {
                        if (cv.ChiPhi != null)
                            cp += cv.ChiPhi.Value;
                    }
                    da.ChiPhiDuAn = cp;
                    DuAnControllers.updateDA(da);
                }
            }

        }
        private void dataGridViewDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chlbCongViec.Items.Clear();
            tinhChiPhiDA();
            tinhTienDoDA();
            dahoanthanh();
            
            cbxNhom.DataSource = null;
            if(true)
            {
                
                if (this.dataGridViewDuAn.Columns[e.ColumnIndex].DataPropertyName != nameof(DuAn.MaDuAn))
                    if (this.dataGridViewDuAn.CurrentRow.Cells[0].Value == null)
                    {
                        MessageBox.Show("Chua nhap Ma Du An");
                        return;
                    }
                if (dataGridViewDuAn.CurrentRow.Cells[3].Value == null) txtChiPhiDuAn.Text = "0";
                else txtChiPhiDuAn.Text = dataGridViewDuAn.CurrentRow.Cells[3].Value.ToString();
                txtMaDuAn.Text = dataGridViewDuAn.CurrentRow.Cells[0].Value.ToString();
                txtTenDuAn.Text = dataGridViewDuAn.CurrentRow.Cells[1].Value.ToString();
                dateTimeBatDauDuAn.Value = DateTime.Parse(dataGridViewDuAn.CurrentRow.Cells[7].Value.ToString());
                dateNgayDuKienHoanThanh.Value = DateTime.Parse(dataGridViewDuAn.CurrentRow.Cells[6].Value.ToString());
                if (dataGridViewDuAn.CurrentRow.Cells[9].Value== null) 
                    dateTimeNgayHoanThanh.Value = DateTime.Parse("01/01/2000 12:00:00 AM");
                else 
                    dateTimeNgayHoanThanh.Value = DateTime.Parse(dataGridViewDuAn.CurrentRow.Cells[9].Value.ToString());

                if(dataGridViewDuAn.CurrentRow.Cells[2].Value!=null)
                    rtxtMucTieu.Text = dataGridViewDuAn.CurrentRow.Cells[2].Value.ToString();
                if (dataGridViewDuAn.CurrentRow.Cells[8].Value == null|| int.Parse(dataGridViewDuAn.CurrentRow.Cells[8].Value.ToString()) == -2147483648)
                    pgbTienDoDuAn.Value = 0;
                else 
                    pgbTienDoDuAn.Value = int.Parse(dataGridViewDuAn.CurrentRow.Cells[8].Value.ToString());
                //cho ma cong viec vao => list cong viec setitemchecked
                List<DuAn> da = DuAnControllers.getListDuAnfromDB();
                if (da[dataGridViewDuAn.CurrentRow.Index].CongViecDuAn == null) 
                    return;
                
                string macongviec = da[dataGridViewDuAn.CurrentRow.Index].CongViecDuAn;
                macongviec = macongviec.Trim();
                string[] listtencongviec = macongviec.Trim().Split(',');
                List<CongViec> lcv = CongViecControllers.getListCongViecfromDB(listtencongviec);

               foreach (var item in listtencongviec)
                {
                    chlbCongViec.Items.Add(item.Trim());
                }
                foreach (var item in lcv)
                {
                    if (item.TienDo == 100)
                    {
                        for(int i=0;i<chlbCongViec.Items.Count;i++)
                        {
                            if(chlbCongViec.Items[i].ToString()==item.MaCongViec.ToString().Trim())
                            {
                                chlbCongViec.SetItemChecked(i, true);
                            }
                        }
                    }
                }
                List<string> listnhom = new List<string>();
                
                foreach (var item in listtencongviec)
                {
                    if (NhomControllers.getListNhomfromDB(item) != null)
                    {
                        string[] lstnhom = NhomControllers.getListNhomfromDB(item).Split(',');
                        foreach (var nhom in lstnhom)
                        {
                            listnhom.Add(nhom);
                        }
                    }
                }
                cbxNhom.DataSource = listnhom;
                

            }
            else
            {
                return;
            }
        }

      

        private void btnSuaDuAn_Click(object sender, EventArgs e)
        {
            if (this.txtTenDuAn.Text.Trim().Length <= 0 || this.txtMaDuAn.Text.Trim().Length <= 0 || this.dateNgayDuKienHoanThanh.Value > DateTime.Now || this.dateTimeBatDauDuAn.Value > DateTime.Now || this.dateNgayDuKienHoanThanh.Value > DateTime.Now)
            {
                if (this.txtMaDuAn.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaDuAn, "Ma du an khong duoc trong");
                    return;
                }
                this.errorProvider1.Clear();
                if (this.txtTenDuAn.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenDuAn, "nhap ten du an");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeBatDauDuAn.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeBatDauDuAn, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateNgayDuKienHoanThanh.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateNgayDuKienHoanThanh, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();

            }
            DuAn da = new DuAn();
            da.MaDuAn = txtMaDuAn.Text.Trim();
            da.TenDuAn = txtTenDuAn.Text.Trim();
            da.NgayBatDau = DateTime.Parse(dateTimeBatDauDuAn.Value.ToString());
            da.DuKienHoanThanh = DateTime.Parse(dateNgayDuKienHoanThanh.Value.ToString());
            da.MucTieuDuAn = rtxtMucTieu.Text.Trim();
            var lsda = DuAnControllers.getListDuAnfromDB();
            da.TienDo = lsda[dataGridViewDuAn.CurrentRow.Index].TienDo;
            da.ChiPhiDuAn = Int32.Parse(txtChiPhiDuAn.Text.Trim());
            da.NhomPhuTrach = lsda[dataGridViewDuAn.CurrentRow.Index].NhomPhuTrach;
            da.CongViec = lsda[dataGridViewDuAn.CurrentRow.Index].CongViec;
            da.NgayHoanThanh = lsda[dataGridViewDuAn.CurrentRow.Index].NgayHoanThanh;
            da.CongViecDuAn = lsda[dataGridViewDuAn.CurrentRow.Index].CongViecDuAn;
            da.Nhom = lsda[dataGridViewDuAn.CurrentRow.Index].Nhom;
            
            DuAnControllers.updateDA(da);
            BindingSource source = new BindingSource();
            source.DataSource = DuAnControllers.getListDuAnfromDB();
            this.dataGridViewDuAn.DataSource = source;
        }
    

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            if (this.txtTenDuAn.Text.Trim().Length <= 0 || this.txtMaDuAn.Text.Trim().Length <= 0 ||  this.dateNgayDuKienHoanThanh.Value > DateTime.Now || this.dateTimeBatDauDuAn.Value > DateTime.Now || this.dateNgayDuKienHoanThanh.Value > DateTime.Now )
            {
                if (this.txtMaDuAn.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtMaDuAn, "Ma du an khong duoc trong");
                    return;
                }
                else if (DuAnControllers.getMaDuAnfromDB(this.txtMaDuAn.Text.Trim()) != null)
                {
                    this.errorProvider1.SetError(this.txtMaDuAn, "Ma du an da ton tai");
                    return;
                }
                this.errorProvider1.Clear();
                if (this.txtTenDuAn.Text.Trim().Length <= 0)
                {
                    this.errorProvider1.SetError(this.txtTenDuAn, "nhap ten du an");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateTimeBatDauDuAn.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateTimeBatDauDuAn, "nhap ngay bat dau");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                if (this.dateNgayDuKienHoanThanh.Value <= DateTime.Now)
                {
                    this.errorProvider1.SetError(this.dateNgayDuKienHoanThanh, "nhap ngay du kien hoan thanh");
                    return;
                }
                else
                    this.errorProvider1.Clear();
                
            }
            DuAn da = new DuAn();
            da.MaDuAn = txtMaDuAn.Text.Trim();
            da.TenDuAn = txtTenDuAn.Text.Trim();
            da.NgayBatDau = DateTime.Parse(dateTimeBatDauDuAn.Value.ToString());
            da.DuKienHoanThanh = DateTime.Parse(dateNgayDuKienHoanThanh.Value.ToString());
            da.MucTieuDuAn = rtxtMucTieu.Text.Trim();
            da.TienDo = 0;
            da.NgayHoanThanh = DateTime.Parse("01/01/2000 12:00:00 AM");


            DuAnControllers.AddDuAn(da);
            BindingSource source = new BindingSource();
            source.DataSource = DuAnControllers.getListDuAnfromDB();
            this.dataGridViewDuAn.DataSource = source;
        }

      
        public void tinhTienDoDA()
        {
            List<DuAn> lstDuAn = DuAnControllers.getListDuAnfromDB();
            foreach (DuAn da in lstDuAn)
            {
                
                if (da.CongViecDuAn != null)
                {
                    string macongviec = da.CongViecDuAn;
                    macongviec = macongviec.Trim();
                    string[] listtencongviec = macongviec.Split(',');
                    List<CongViec> lcv = CongViecControllers.getListCongViecfromDB(listtencongviec);
                    int td = 0;
                    int k = lcv.Count;
                    foreach (CongViec cv in lcv)
                    {
                        if (cv.TienDo == 100)
                        {
                            td += 1;
                        }
                    }
                    float ht = 100;
                    float h = (float)td / k;
                    da.TienDo = (int)(h * ht);
                    DuAnControllers.updateDA(da);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
