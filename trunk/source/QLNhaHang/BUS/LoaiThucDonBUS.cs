using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class LoaiThucDonBUS
    {
        public static DataTable DanhSachLTD()
        {
            return LoaiThucDonDAO.DanhSachLTD();
        }

        public static void ThemLTD(string loaithucdon)
        {
            LoaiThucDonDAO.ThemLTD(loaithucdon);
        }

        public static void SuaLTD(int maltd, string loaithucdon)
        {
            LoaiThucDonDAO.SuaLTD(maltd, loaithucdon);
        }


        public static void XoaLTD(int maltd)
        {
            LoaiThucDonDAO.XoaLTD(maltd);
        }

        public static DataTable LTDTamXoa()
        {
            return LoaiThucDonDAO.LTDTamXoa();
        }

        public static void PhucHoiLTD(int maltd)
        {
            LoaiThucDonDAO.PhucHoiLTD(maltd);
        }


        public static void DelLTD(int maltd)
        {
            LoaiThucDonDAO.DelLTD(maltd);
        }

    }
}
