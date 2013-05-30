using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data; 

namespace DAO
{
    public class BanDAO
    {
        public static DataTable DanhSachBan()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable BanConTrong()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_BanConTrong";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable BanDangSuDung()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_BanDangSuDung";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DsBanTheoKhuVuc(int maKV)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DsBanTheoKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKhuVuc",SqlDbType.Int).Value = maKV;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void CapNhatTinhTrangBan(string maBan,int TT)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_CapNhatTinhTrangBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = maBan;
            cmd.Parameters.Add("@TinhTrang",SqlDbType.Int).Value = TT;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void CapNhatBanGhep(string mab,string mabg)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_CapNhatBanGhep";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = mab;
            cmd.Parameters.Add("@MaBanGhep", SqlDbType.VarChar).Value = mabg;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void ThemBan(BanDTO b)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = b.MaBan;
            cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Value = b.SoGhe;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = b.MaKhuVuc;
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Int).Value = b.TinhTrang;
            cmd.Parameters.Add("@MaBanGhep", SqlDbType.VarChar).Value = b.MaBanGhep;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaBan(BanDTO b)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = b.MaBan;
            cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Value = b.SoGhe;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = b.MaKhuVuc;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaBan(string mab)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = mab;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static int SoGhe(string mab)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SoGhe";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = mab;
            cmd.Parameters.Add("@SoGhe", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int soghe = int.Parse(cmd.Parameters["@SoGhe"].Value.ToString());
            con.Close();
            return soghe;
        }

        public static void TachBan(string maBan)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_TachBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = maBan;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void ChuyenBan(string maBanCu,string maBanMoi)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ChuyenBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBanCu", SqlDbType.VarChar).Value = maBanCu;
            cmd.Parameters.Add("@MaBanMoi", SqlDbType.VarChar).Value = maBanMoi;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void HuyDatBan(int map)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_HuyDatBan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhieuGoi", SqlDbType.Int).Value = map;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        



    }
}
