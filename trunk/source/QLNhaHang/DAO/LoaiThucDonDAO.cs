using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class LoaiThucDonDAO
    {
        public static DataTable DanhSachLTD()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void ThemLTD(string loaithucdon)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LoaiThucDon", SqlDbType.NVarChar).Value = loaithucdon;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaLTD(int maltd, string loaithucdon)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLoaiThucDon", SqlDbType.Int).Value = maltd;
            cmd.Parameters.Add("@LoaiThucDon", SqlDbType.NVarChar).Value = loaithucdon;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaLTD(int maltd)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLoaiThucDon", SqlDbType.Int).Value = maltd;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static DataTable LTDTamXoa()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_LTDTamXoa";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void PhucHoiLTD(int maltd)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_PhucHoiLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLTD", SqlDbType.Int).Value = maltd;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void DelLTD(int maltd)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DelLTD";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLTD", SqlDbType.Int).Value = maltd;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
