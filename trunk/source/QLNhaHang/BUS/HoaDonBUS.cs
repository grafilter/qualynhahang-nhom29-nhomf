using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBUS
    {
        public static double TinhTien(int map, DateTime ngaylap, int khuyenmai)
        {
            return HoaDonDAO.TinhTien(map, ngaylap, khuyenmai);
        }

       
    }
}
