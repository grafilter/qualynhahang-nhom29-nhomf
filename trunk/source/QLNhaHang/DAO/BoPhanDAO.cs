using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data; 

namespace DAO
{
    public class BoPhanDAO
    {
        public static DataTable DanhSachBoPhan()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachBoPhan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public static void ThemBoPhan(string tenbp)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemBoPhan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenBoPhan", SqlDbType.NVarChar).Value = tenbp;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaBoPhan(int mabp, string tenbp)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaBoPhan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBoPhan", SqlDbType.Int).Value = mabp;
            cmd.Parameters.Add("@TenBoPhan", SqlDbType.NVarChar).Value = tenbp;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaBoPhan(int mabp)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaBoPhan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBoPhan", SqlDbType.Int).Value = mabp;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable DanhSachQuyenHan(int mabp)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_QuyenHan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBoPhan", SqlDbType.Int).Value = mabp;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void CapNhatQuyenHan(int mabp, string quyenhan, int loai)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_CapNhatQuyenHan";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBoPhan", SqlDbType.Int).Value = mabp;
            cmd.Parameters.Add("@QuyenHan", SqlDbType.NVarChar).Value = quyenhan;
            cmd.Parameters.Add("@Loai", SqlDbType.Int).Value = loai;
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
