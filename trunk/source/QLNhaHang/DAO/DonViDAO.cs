using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DonViDAO
    {
        public static DataTable DanhSachDonVi()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void ThemDonVi(string tendv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar).Value = tendv;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaDonVi(int madv, string tendv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDonVi", SqlDbType.Int).Value = madv;
            cmd.Parameters.Add("@TenDonVi", SqlDbType.NVarChar).Value = tendv;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaDonVi(int madv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDonVi", SqlDbType.Int).Value = madv;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable DonViTamXoa()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DonViTamXoa";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void PhucHoiDonVi(int madv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_PhucHoiDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDonVi", SqlDbType.Int).Value = madv;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void DelDonVi(int madv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DelDonVi";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDonVi", SqlDbType.Int).Value = madv;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
