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
    class CongViecControllers
    {
        public static int getTienDoCV(string maCV)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var lg = (from cv in _context.CongViecNhanViens
                          where cv.MaCongViecNhanVien.Substring(0, 6) == maCV
                          select cv.TienDo).ToList();
                int count = 0;
                int j = lg.Count;
                for (int i = 0; i <= j - 1; i++)
                {
                    if (lg[i] == true)
                        count++;
                }
                return 100 * count / j;
            }
        }
        public static bool CheckCongViecHoanThanhfromDB(string macv)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecs
                          where cv.MaCongViec == macv
                          select cv).ToList();
                if (ID.Count==0) return false;
                if (ID[0].NgayHoanThanh == DateTime.Parse("01/01/2000 12:00:00 AM"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool updateTienDo(CongViec cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    cv.TienDo = getTienDoCV(cv.MaCongViec);
                    _context.CongViecs.AddOrUpdate(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static string getMaCongViecfromDB(string maCV)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecs
                          where cv.MaCongViec == maCV
                          select cv.MaCongViec).ToList();
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
        public static CongViec getCongViecfromDB(string maCV)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cv in _context.CongViecs
                          where cv.MaCongViec == maCV
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
        public static bool DeleteCongViec(CongViec cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.CongViecs.Remove(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteCongViec(string cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    var dbcv = (from u in _context.CongViecs
                                where u.MaCongViec == cv
                                select u).SingleOrDefault();
                    _context.CongViecs.Remove(dbcv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<CongViec> getListCongViecfromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from cv in _context.CongViecs.AsEnumerable()
                            select cv).Select(x => new CongViec
                            {
                                MaCongViec = x.MaCongViec,
                                TenCongViec = x.TenCongViec,
                                NoiDungCongViec = x.NoiDungCongViec,
                                ListNhomPhuTrach = x.ListNhomPhuTrach,
                                ChiPhi = x.ChiPhi,
                                DuKienHoanThanh = x.DuKienHoanThanh,
                                NgayBatDau = x.NgayBatDau,
                                TienDo = x.TienDo,
                                NgayHoanThanh = x.NgayHoanThanh,
                                // Nhom1 = x.Nhom1
                            }).ToList();
                return list;
            }
        }
        //public static List<CongViec> getListCV(string[] lstMaCV)
        //{
        //    for (int i = 0; i <= lstMaCV.Length - 1; i++)
        //    {
        //        var list = (from cv in _context.CongViecs.AsEnumerable()
        //                    select cv).Select(x => new CongViec
        //                    {
        //                        MaCongViec = x.MaCongViec,
        //                        TenCongViec = x.TenCongViec,
        //                        NoiDungCongViec = x.NoiDungCongViec,
        //                        ListNhomPhuTrach = x.ListNhomPhuTrach,
        //                        ChiPhi = x.ChiPhi,
        //                        DuKienHoanThanh = x.DuKienHoanThanh,
        //                        NgayBatDau = x.NgayBatDau,
        //                        TienDo = x.TienDo,
        //                        NgayHoanThanh = x.NgayHoanThanh,
        //                        // Nhom1 = x.Nhom1
        //                    }).ToList();
        //        return list;
        //    }
        //}
        public static int getChiPhiCV(string maCV)
        {
            int cp = 0;
            using (var _context = new QuanLyDuAnEntities1())
            {
                var lg = (from cv in _context.ChiPhis
                          where cv.MaCongViecChiTieu.Substring(0,6) == maCV.Trim()
                          select cv.ChiPhiCongViec).ToList();
                for (int i = 0; i <= lg.Count - 1; i++)
                    cp += lg[i].Value;

            }
            return cp;
        }
        public static bool updateChiPhi(CongViec cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    cv.ChiPhi = getChiPhiCV(cv.MaCongViec);
                    _context.CongViecs.AddOrUpdate(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool updateCongViec(CongViec cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    //cv.ChiPhi = getChiPhiCV(cv.MaCongViec);
                    _context.CongViecs.AddOrUpdate(cv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<CongViec> getListCongViecfromDB(string[] lcv)
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                List<CongViec> listcongviectrave = new List<CongViec>();
                foreach (var cv in lcv)
                {
                    var dbcongviec = (from congviec in _context.CongViecs
                                      where congviec.MaCongViec == cv
                                      select congviec).ToList();
                    if (dbcongviec.Count != 0)
                    listcongviectrave.Add(dbcongviec[0]);
                }
                return listcongviectrave;
            }
        }
        public static bool AddCongViec(CongViec cv)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.CongViecs.Add(cv);
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
