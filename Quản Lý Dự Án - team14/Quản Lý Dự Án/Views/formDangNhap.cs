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
    public partial class formDangNhap : Form
    {
        public string phanQuyen = "";
        public formDangNhap()
        {
            InitializeComponent();
        }
        public bool phanQuyenQL()
        {
            if (phanQuyen == "0")
                return true;
            else
                return false;
        }
        private void formDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
            Application.Exit();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            int qh;
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập Tên đăng nhập và mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin")
            {
                formMDIParent fMDI = new formMDIParent(txtTenDangNhap.Text, 2);
                Visible = false;
                fMDI.Show();
            }
            else
            {
                NhanVien nv = new NhanVien();
                qh = NhanVienControllers.getQuyenHanNV(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                formMDIParent fMDI = new formMDIParent(txtTenDangNhap.Text, qh);
                Visible = false;
                fMDI.Show();
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void formDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                formDangNhap fDN = new formDangNhap();
                fDN.Show();
            }    
               
            
           
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                txtMatKhau.Focus();
            }
        }

        private void formDangNhap_Enter(object sender, EventArgs e)
        {
            int qh;
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Hãy nhập Tên đăng nhập và mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin")
            {
                formMDIParent fMDI = new formMDIParent(txtTenDangNhap.Text, 2);
                Visible = false;
                fMDI.Show();
            }
            else
            {
                NhanVien nv = new NhanVien();
                qh = NhanVienControllers.getQuyenHanNV(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim());
                formMDIParent fMDI = new formMDIParent(txtTenDangNhap.Text, qh);
                Visible = false;
                fMDI.Show();
            }
        }
    }
}
