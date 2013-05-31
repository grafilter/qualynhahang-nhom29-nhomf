using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class DonViBUS
    {
        public static DataTable DanhSachDonVi()
        {          
            return DonViDAO.DanhSachDonVi();
        }

        public static void ThemDonVi(string tendv)
        {
            DonViDAO.ThemDonVi(tendv);
        }

        public static void SuaDonVi(int madv, string tendv)
        {
            DonViDAO.SuaDonVi(madv, tendv);
        }


        public static void XoaDonVi(int madv)
        {
            DonViDAO.XoaDonVi(madv);
        }


      

    }
}
