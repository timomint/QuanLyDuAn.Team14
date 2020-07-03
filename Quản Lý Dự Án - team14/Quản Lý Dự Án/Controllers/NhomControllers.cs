using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Controllers
{
    class NhomControllers
    {
        public static string getMaNhomfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from nh in _context.Nhoms
                          select nh.MaNhom).ToList();
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
        public static string getNhomfromDB(string manhom)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from nh in _context.Nhoms
                          where nh.MaNhom == manhom
                          select nh.MaNhom).ToList();
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
        public static List<Nhom> getListNhomfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from nh in _context.Nhoms.AsEnumerable()
                            select nh).Select(x => new Nhom
                            {
                                MaNhom=x.MaNhom,
                                TenNhom=x.TenNhom,
                                NhomTruong=x.NhomTruong
                                // Nhom1 = x.Nhom1
                            }).ToList();
                return list;
            }
        }
        public static string getListNhomfromDB(string macv)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var nhom = (from n in _context.CongViecs
                            where n.MaCongViec == macv
                            select n.ListNhomPhuTrach).ToList();
                if (nhom.Count <= 0)
                {
                    return null;
                }
                else
                {
                    return nhom[0];
                }
            }
        }
        public static bool updateNhom(Nhom nh)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    //cv.ChiPhi = getChiPhiCV(cv.MaCongViec);
                    _context.Nhoms.AddOrUpdate(nh);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool AddNhom(Nhom nh)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.Nhoms.Add(nh);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;

            }

        }
        public static bool DeleteNhom(string manhom)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    var dbnhom = (from u in _context.Nhoms
                                  where u.MaNhom.Trim() == manhom.Trim()
                                  select u).ToList();
                    _context.Nhoms.Remove(dbnhom[0]);
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
