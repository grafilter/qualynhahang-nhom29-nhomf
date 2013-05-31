using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class BangGiaBUS
    {
        public static DataTable DanhSachBangGia()
        {
            return BangGiaDAO.DanhSachBangGia();
        }

        public static void ThemBangGia(int makv, string matd, double dongia)
        {
            BangGiaDAO.ThemBangGia(makv, matd, dongia);
        }

        public static void SuaBangGia(int mabg, int makv, string matd, double dongia)
        {
            BangGiaDAO.SuaBangGia(mabg, makv, matd, dongia);
        }


        public static void XoaBangGia(int mabg)
        {
            BangGiaDAO.XoaBangGia(mabg);
        }

        
    }
}
