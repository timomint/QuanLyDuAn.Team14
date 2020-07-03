using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Controllers
{
    class NhanVienControllers
    {
        public static string getMaNhanVienfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from nv in _context.NhanViens
                          select nv.MaNhanVien).ToList();
                if(ID.Count <= 0)
                {
                    return "";
                }
                else
                {
                    return ID[0];
                }
            }
        }

        public static bool DeleteNhanVien(NhanVien nv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    var dbnv = (from nhanvien in _context.NhanViens
                                where nhanvien.MaNhanVien.Trim() == nv.MaNhanVien.Trim()
                                select nhanvien).SingleOrDefault();


                    _context.NhanViens.Remove(dbnv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool AddNhanVien(NhanVien nv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.NhanViens.Add(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;

            }

        }
        public static NhanVien getNhanVienfromDB(string manhanvien)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var NV = (from nv in _context.NhanViens
                          where manhanvien == nv.MaNhanVien
                          select nv).ToList();
                if (NV.Count <= 0)
                {
                    return null;
                }
                else
                {
                    return NV[0];
                }
            }
        }
        public static List<NhanVien> getListNhanVienfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from nv in _context.NhanViens.AsEnumerable()
                          select nv).Select(x => new NhanVien
                          {
                              MaNhanVien = x.MaNhanVien,
                              HoTen = x.HoTen,
                              NgaySinh = x.NgaySinh,
                              SoDienThoai = x.SoDienThoai,
                              DiaChi = x.DiaChi,
                              ChucVu = x.ChucVu,
                              Luong = x.Luong,
                              Nhoms = x.Nhoms,
                              MatKhau = x.MatKhau,
                              Nhom = x.Nhom,
                              Nhom1 = x.Nhom1
                          }).ToList() ;
                return list;

            }
        }
        public static List<NhanVien> getListNhanVienCuaNhomfromDB(string MaNhom)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from nv in _context.NhanViens.AsEnumerable()
                            where nv.Nhom == MaNhom
                            select nv).Select(x => new NhanVien
                            {
                                HoTen = x.HoTen
                            }).ToList();
                return list;
            }
        }
        public static int getQuyenHanNV(string MaNV, string MatKhau)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var chucVu = (from nv in _context.NhanViens
                          where MaNV == nv.MaNhanVien & MatKhau ==nv.MatKhau
                          select nv.ChucVu).ToString();
                if (chucVu == "Truong Phong")
                    return 1;
                else
                    return 0;
            }
        }

        public static bool UpdateNhanVien(NhanVien nv)
        {
            try
            {
                using( var _context = new QuanLyDuAnEntities1())
                {
                    _context.NhanViens.AddOrUpdate(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
