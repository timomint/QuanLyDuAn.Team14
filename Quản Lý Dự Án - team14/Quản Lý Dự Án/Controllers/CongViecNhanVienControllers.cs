using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Controllers
{
    class CongViecNhanVienControllers
    {

        public static string getMaCongViecNhanVienfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecNhanViens
                          select cv.MaCongViecNhanVien).ToList();
                if (ID.Count <= 0)
                {
                    return "";
                }
                else
                {
                    return ID[0];
                }
            }
        }
        public static CongViecNhanVien getCongViecNhanVienfromDB(string macvnv)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecNhanViens
                          where cv.MaCongViecNhanVien ==macvnv
                          select cv).ToList();
                if (ID.Count <= 0)
                {
                    return null;
                }
                else
                {
                    return ID[0];
                }
            }
        }
        public static bool CheckCongViecNhanVienHoanThanhfromDB(string macvnv)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecNhanViens
                          where cv.MaCongViecNhanVien == macvnv
                          select cv).ToList();
                if (ID.Count == 0) return false;
                if (ID[0].NgayHoanThanh==DateTime.Parse("01/01/2000 12:00:00 AM"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
        public static List<CongViecNhanVien> getListCongViecNhanVienfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from cv in _context.CongViecNhanViens.AsEnumerable()
                            select cv).Select(x => new CongViecNhanVien
                            {
                                MaCongViecNhanVien = x.MaCongViecNhanVien,
                                MaNhanVienPhuTrach=x.MaNhanVienPhuTrach,
                                TenCongViec = x.TenCongViec,
                                MoTa = x.MoTa,
                                TaiLieu = x.TaiLieu,
                                LuongCongViec = x.LuongCongViec,
                                DuKienHoanThanh = x.DuKienHoanThanh,
                                NgayBatDau = x.NgayBatDau,
                                TienDo = x.TienDo,
                                NgayHoanThanh = x.NgayHoanThanh,
                                // Nhom1 = x.Nhom1
                            }).ToList();
                return list;
            }
        }
        public static int getLuongNV(string maNV)
        {
            int luong=0;
            using (var _context = new QuanLyDuAnEntities1())
            {
                var lg = (from cv in _context.CongViecNhanViens
                          where cv.MaNhanVienPhuTrach==maNV & cv.TienDo == true
                          select cv.LuongCongViec).ToList();
                for (int i = 0; i <= lg.Count - 1; i++)
                    luong += lg[i].Value;

            }
            return luong;
        }
        public static bool updateLuong(NhanVien nv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    nv.Luong = getLuongNV(nv.MaNhanVien);
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
        public static bool updateCongViecNhanVien(CongViecNhanVien nv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                  //  nv.Luong = getLuongNV(nv.MaNhanVien);
                    _context.CongViecNhanViens.AddOrUpdate(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool AddCongViecNhanVien(CongViecNhanVien cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.CongViecNhanViens.Add(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;

            }

        }
        public static bool DeleteCVNV(string macvnv)
        {
            try
            {
                using(var _context = new QuanLyDuAnEntities1())
                {
                    var dbcvnv = (from u in _context.CongViecNhanViens
                                  where u.MaCongViecNhanVien.Trim() == macvnv.Trim()
                                  select u).ToList();
                    foreach (var item in dbcvnv)
                    {
                        _context.CongViecNhanViens.Remove(item);
                        _context.SaveChanges();
                    }
                    
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
