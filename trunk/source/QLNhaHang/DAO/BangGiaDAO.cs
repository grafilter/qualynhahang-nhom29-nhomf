using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class BangGiaDAO
    {
        public static DataTable DanhSachBangGia()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void ThemBangGia(int makv,string matd,double dongia)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThemBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = makv;
            cmd.Parameters.Add("@MaThucDon", SqlDbType.VarChar).Value = matd;
            cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = dongia;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void SuaBangGia(int mabg,int makv, string matd, double dongia)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_SuaBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBangGia", SqlDbType.Int).Value = mabg;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.VarChar).Value = makv;
            cmd.Parameters.Add("@MaThucDon", SqlDbType.VarChar).Value = matd;
            cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = dongia;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void XoaBangGia(int mabg)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_XoaBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBangGia", SqlDbType.Int).Value = mabg;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable BangGiaTamXoa()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_BangGiaTamXoa";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void PhucHoiBangGia(int mabg)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_PhucHoiBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBangGia", SqlDbType.Int).Value = mabg;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DelBangGia(int mabg)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DelBangGia";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaBangGia", SqlDbType.Int).Value = mabg;
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
