using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Controllers
{
    class DuAnControllers
    {
        public static string getMaDuAnfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from da in _context.DuAns
                          select da.MaDuAn).ToList();
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
        public static DuAn getDuAnfromDB(string maduan)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from da in _context.DuAns
                          where da.MaDuAn.Trim()== maduan
                          select da).ToList();
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
        public static string getMaDuAnfromDB(string maduan)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var duan = (from da in _context.DuAns
                          where da.MaDuAn == maduan
                          select da.MaDuAn).ToList();
                if (duan.Count <= 0)
                {
                    return null;
                }
                else
                {
                    return duan[0];
                }
            }
        }
        public static List<DuAn> getListDuAnfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from da in _context.DuAns.AsEnumerable()
                            select da).Select(x => new DuAn
                            {
                                MaDuAn = x.MaDuAn,
                                TenDuAn = x.TenDuAn,
                                MucTieuDuAn = x.MucTieuDuAn,
                                ChiPhiDuAn = x.ChiPhiDuAn,
                                CongViecDuAn = x.CongViecDuAn,
                                NhomPhuTrach = x.NhomPhuTrach,
                                DuKienHoanThanh = x.DuKienHoanThanh,
                                NgayBatDau = x.NgayBatDau,
                                TienDo = x.TienDo,
                                NgayHoanThanh = x.NgayHoanThanh,
                                // Nhom1 = x.Nhom1
                            }).ToList();
                return list;
            }
        }
        public static int getChiPhiDA(string maDA)
        {
            int cp = 0;
            using (var _context = new QuanLyDuAnEntities1())
            {
                var log = (from da in _context.DuAns 
                          where da.MaDuAn == maDA
                          select da.CongViecDuAn).ToString();
                string[] s = log.Split(',');
                for (int i = 0; i <= s.Length - 1; i++)
                    cp+=CongViecControllers.getChiPhiCV(s[i]);
            }
            return cp;
        }
        public static bool updateDA(DuAn da)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    //da.ChiPhiDuAn = getChiPhiDA(da.MaDuAn);
                    _context.DuAns.AddOrUpdate(da);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool AddDuAn(DuAn da)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.DuAns.Add(da);
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
