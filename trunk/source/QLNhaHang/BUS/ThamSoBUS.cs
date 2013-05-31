using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;

namespace BUS
{
    public class ThamSoBUS
    {
        public static DataTable ThongTinNhaHang()
        {
            return ThamSoDAO.ThongTinNhaHang();
        }

        public static void CapNhatNhaHang(string tennh, string diachi, string logo)
        {
            ThamSoDAO.CapNhatNhaHang(tennh, diachi, logo);
        }

       

    }
}
