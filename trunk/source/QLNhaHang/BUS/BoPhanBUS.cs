using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class BoPhanBUS
    {
        public static DataTable DanhSachBoPhan()
        {
            return BoPhanDAO.DanhSachBoPhan();
        }

        public static void ThemBoPhan(string tenbp)
        {
            BoPhanDAO.ThemBoPhan(tenbp);
        }

        public static void SuaBoPhan(int mabp, string tenbp)
        {
            BoPhanDAO.SuaBoPhan(mabp, tenbp);
        }


        public static void XoaBoPhan(int mabp)
        {
            BoPhanDAO.XoaBoPhan(mabp);
        }

        public static DataTable DanhSachQuyenHan(int mabp)
        {
            return BoPhanDAO.DanhSachQuyenHan(mabp);
        }

        public static void CapNhatQuyenHan(int mabp, string quyenhan, int loai)
        {
            BoPhanDAO.CapNhatQuyenHan(mabp, quyenhan,loai);
        }

    }
}
