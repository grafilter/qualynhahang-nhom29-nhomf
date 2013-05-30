using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class KhuVucBUS
    {
        public static DataTable DanhSachKhuVuc()
        {
            return KhuVucDAO.DanhSachKhuVuc();
        }

        public static void ThemKhuVuc(string tenkv)
        {
            KhuVucDAO.ThemKhuVuc(tenkv);
        }

        public static void SuaKhuVuc(int makv, string tenkv)
        {
            KhuVucDAO.SuaKhuVuc(makv, tenkv);
        }


        public static void XoaKhuVuc(int makv)
        {
            KhuVucDAO.XoaKhuVuc(makv);
        }

       

    }
}
