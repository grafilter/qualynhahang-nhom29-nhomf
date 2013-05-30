using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BanBUS
    {
        public static DataTable DanhSachBan()
        {
            return BanDAO.DanhSachBan();
        }

        public static DataTable BanConTrong()
        {
            return BanDAO.BanConTrong();
        }

        public static DataTable BanDangSuDung()
        {
            return BanDAO.BanDangSuDung();
        }


        public static DataTable DsBanTheoKhuVuc(int maKV)
        {
            return BanDAO.DsBanTheoKhuVuc(maKV);
        }

        public static void CapNhatTinhTrangBan(string maBan, int TT)
        {
            BanDAO.CapNhatTinhTrangBan(maBan, TT);
        }

        public static void CapNhatBanGhep(string mab, string mabg)
        {
            BanDAO.CapNhatBanGhep(mab, mabg);
        }

        public static void ThemBan(BanDTO b)
        {
            BanDAO.ThemBan(b);
        }

        public static void SuaBan(BanDTO b)
        {
            BanDAO.SuaBan(b);
        }


        public static void XoaBan(string mab)
        {
            BanDAO.XoaBan(mab);
        }

        public static int SoGhe(string mab)
        {
            return BanDAO.SoGhe(mab);
        }

        public static void TachBan(string maBan)
        {
            BanDAO.TachBan(maBan);
        }

        public static void ChuyenBan(string maBanCu, string maBanMoi)
        {
            BanDAO.ChuyenBan(maBanCu, maBanMoi);
        }

        public static void HuyDatBan(int map)
        {
            BanDAO.HuyDatBan(map);
        }

        

    }
}
