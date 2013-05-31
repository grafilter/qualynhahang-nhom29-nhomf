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

        public static DataTable DoanhThuTheoThoiGian(int ngaytu, int ngayden, int loai)
        {
            return HoaDonDAO.DoanhThuTheoThoiGian(ngaytu, ngayden, loai);
        }

        public static DataTable DoanhThuTheoKhuVuc(int ngay, int makv, int loai)
        {
            return HoaDonDAO.DoanhThuTheoKhuVuc(ngay, makv, loai);
        }

        public static DataTable DoanhThuTheoMonAn(int ngay, int loai)
        {
            return HoaDonDAO.DoanhThuTheoMonAn(ngay, loai);
        }

        public static DataTable TraCuuHoaDon(DateTime ngaytu, DateTime ngayden)
        {
            return HoaDonDAO.TraCuuHoaDon(ngaytu, ngayden);
        }

        public static DataTable ChiTietHoaDon(int maPhieuGoi)
        {
            return HoaDonDAO.ChiTietHoaDon(maPhieuGoi);
        }

       
    }
}
