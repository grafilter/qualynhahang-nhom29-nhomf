using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class PhieuGoiMonDAO
    {
        public static int MaPhieuGoi()
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_MaPhieuGoi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhieuGoi",SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int maPhieuGoi = int.Parse(cmd.Parameters["@MaPhieuGoi"].Value.ToString());
            con.Close();
            return maPhieuGoi;
        }

        public static void GoiMon(PhieuGoiMonDTO p)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_GoiMon";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhieuGoi", SqlDbType.Int).Value = p.MaPhieuGoi;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = p.MaBan;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = p.MaKhuVuc;
            cmd.Parameters.Add("@MaThucDon", SqlDbType.VarChar).Value = p.MaThucDon;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = p.SoLuong;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable DsPhieuGoi(int maPhieuGoi)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DsPhieuGoi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhieuGoi", SqlDbType.Int).Value = maPhieuGoi;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void CapNhatSoLuong(int soluong, int maCT)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_CapNhatSoLuong";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChiTietPhieuGoi", SqlDbType.Int).Value = maCT;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void XoaGoiMon(int maCT)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaGoiMon";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChiTietPhieuGoi", SqlDbType.Int).Value = maCT;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int LayPhieuGoi(string maban)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_LayPhieuGoi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBan", SqlDbType.VarChar).Value = maban;
            cmd.Parameters.Add("@MaPhieuGoi", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int maPhieuGoi = int.Parse(cmd.Parameters["@MaPhieuGoi"].Value.ToString());
            con.Close();
            return maPhieuGoi;
        }

    }
}
