using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class PhieuGoiMonBUS
    {
        public static int MaPhieuGoi()
        {
            return PhieuGoiMonDAO.MaPhieuGoi();
        }

        public static void GoiMon(PhieuGoiMonDTO p)
        {
            PhieuGoiMonDAO.GoiMon(p);
        }

        public static DataTable DsPhieuGoi(int maPhieuGoi)
        {
            return PhieuGoiMonDAO.DsPhieuGoi(maPhieuGoi);
        }

        public static void CapNhatSoLuong(int soluong, int maCT)
        {
            PhieuGoiMonDAO.CapNhatSoLuong(soluong, maCT);
        }

        public static void XoaGoiMon(int maCT)
        {
            PhieuGoiMonDAO.XoaGoiMon(maCT);
        }

        public static int LayPhieuGoi(string maban)
        {
            return PhieuGoiMonDAO.LayPhieuGoi(maban);
        }
    }
}
