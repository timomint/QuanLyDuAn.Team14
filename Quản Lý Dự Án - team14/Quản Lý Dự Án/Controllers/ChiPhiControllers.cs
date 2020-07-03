using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDuAn.Models;

namespace QuanLyDuAn.Controllers
{
    class ChiPhiControllers
    {
        public static string getMaCongViecChiTieufromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var ID = (from cvct in _context.ChiPhis
                          select cvct.MaCongViecChiTieu).ToList();
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
        public static List<ChiPhi> getListChiPhifromDB()
        {
            using (var _context = new QuanLyDuAnEntities1())
            {
                var list = (from cvct in _context.ChiPhis.AsEnumerable()
                            select cvct).Select(x => new ChiPhi
                            {
                                MaCongViecChiTieu = x.MaCongViecChiTieu,
                                CongViecChiTieu = x.CongViecChiTieu,
                                ChiPhiCongViec = x.ChiPhiCongViec,
                                ThucHien = x.ThucHien
                                // Nhom1 = x.Nhom1
                            }).ToList();
                return list;
            }
        }
        public static bool AddChiPhi(ChiPhi cp)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    _context.ChiPhis.Add(cp);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;

            }
        }
        public static bool updateChiPhi(ChiPhi cp)
        {
            try
            {
                using (var _context = new QuanLyDuAnEntities1())
                {
                    //cv.ChiPhi = getChiPhiCV(cv.MaCongViec);
                    _context.ChiPhis.AddOrUpdate(cp);
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
