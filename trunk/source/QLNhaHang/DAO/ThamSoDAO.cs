using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ThamSoDAO
    {
        public static DataTable ThongTinNhaHang()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThongTinNH";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void CapNhatNhaHang(string tennh,string diachi,string logo)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_CapNhatNhaHang";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenNhaHang", SqlDbType.NVarChar).Value = tennh;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@Logo", SqlDbType.VarChar).Value = logo;
            cmd.ExecuteNonQuery();
            con.Close();
        }

      
    }
}
