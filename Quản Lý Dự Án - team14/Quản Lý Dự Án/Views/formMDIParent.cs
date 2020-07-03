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
    public partial class formMDIParent : Form
    {
        formDuAn fDuAn;
        formCongViec fCongViec;
        formNhanVien fNhanVien;
        formNhomCongViec fNhom;
        //formDangNhap fDangNhap;
        formCongViecDangThucHien fCongViecNhanVienDangThucHien;
        formChiPhi fChiPhi;
        public string maNV;
        public int qh;


        public formMDIParent(string maNhanVien, int qh)
        {
            InitializeComponent();
            maNV = maNhanVien;
            this.qh = qh;

        }

        private void DuAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fDuAn is null || this.fDuAn.IsDisposed)
            {
                this.fDuAn = new formDuAn(maNV, qh);
                this.fDuAn.MdiParent = this;
                this.fDuAn.Show();
            }
            else
            {
                this.fDuAn.Select();
            }
        }


        private void CongViecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fCongViec is null || this.fCongViec.IsDisposed)
            {
                this.fCongViec = new formCongViec(maNV, qh);
                this.fCongViec.MdiParent = this;
                this.fCongViec.Show();
            }
            else
            {
                this.fCongViec.Select();
            }
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fNhanVien is null || this.fNhanVien.IsDisposed)
            {
                this.fNhanVien = new formNhanVien(maNV, qh);
                this.fNhanVien.MdiParent = this;
                this.fNhanVien.Show();
            }
            else
            {
                this.fNhanVien.Select();
            }
        }

        private void formMDIParent_MdiChildActivate(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMDI;
                this.tabMDI.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMDI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMDI.SelectedTab != null && this.tabMDI.SelectedTab.Tag != null)
            {
                (this.tabMDI.SelectedTab.Tag as Form).Select();
            }
        }

        private void NhomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fNhom is null || this.fNhom.IsDisposed)
            {
                this.fNhom = new formNhomCongViec(maNV, qh);
                this.fNhom.MdiParent = this;
                this.fNhom.Show();
            }
            else
            {
                this.fNhom.Select();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formDangNhap fDangNhap = new formDangNhap();
                fDangNhap.Show();
                Visible = false;
            }
            else
            {
                return;
            }

        }
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close application ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void formMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to log out ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formDangNhap fDangNhap = new formDangNhap();
                fDangNhap.Show();
                Visible = false;
            }
            else
            {
                return;
            }


        }

        private void CongViecNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fCongViecNhanVienDangThucHien is null || this.fCongViecNhanVienDangThucHien.IsDisposed)
            {
                this.fCongViecNhanVienDangThucHien = new formCongViecDangThucHien(maNV, qh);
                this.fCongViecNhanVienDangThucHien.MdiParent = this;
                this.fCongViecNhanVienDangThucHien.Show();
            }
            else
            {
                this.fCongViecNhanVienDangThucHien.Select();
            }
        }

        private void ChiPhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fChiPhi == null || this.fChiPhi.IsDisposed)
            {
                this.fChiPhi = new formChiPhi(maNV, qh);
                this.fChiPhi.MdiParent = this;
                this.fChiPhi.Show();
            }
            else
            {
                this.fChiPhi.Select();
            }
        }

        private void formMDIParent_Load(object sender, EventArgs e)
        {

        }
    }
}