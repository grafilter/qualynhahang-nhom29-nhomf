using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        public static void DangKy(NhanVienDTO nv)
        {
            NhanVienDAO.DangKy(nv);
        }


        public static void DoiMatKhau(string tendn, string mkMoi)
        {
            NhanVienDAO.DoiMatKhau(tendn,mkMoi);
        }

        public static int DangNhap(string tendangnhap, string matkhau)
        {
            return NhanVienDAO.DangNhap(tendangnhap, matkhau);
        }


        public static DataTable ThongTinNhanVien(string tendangnhap, string matkhau)
        {
            return NhanVienDAO.ThongTinNhanVien(tendangnhap, matkhau);
        }

        public static int KiemTraDangKy(string tendangnhap)
        {
            return NhanVienDAO.KiemTraDangKy(tendangnhap);
        }


    }
}
