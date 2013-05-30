using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class KhuVucDAO
    {
        public static DataTable DanhSachKhuVuc()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void ThemKhuVuc(string tenkv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenKhuVuc", SqlDbType.NVarChar).Value = tenkv;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaKhuVuc(int makv, string tenkv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = makv;
            cmd.Parameters.Add("@TenKhuVuc", SqlDbType.NVarChar).Value = tenkv;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaKhuVuc(int makv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = makv;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        


    }
}
