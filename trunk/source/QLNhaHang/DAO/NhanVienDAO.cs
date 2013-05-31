using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data; 

namespace DAO
{
    public class NhanVienDAO
    {
        public static void DangKy(NhanVienDTO nv)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DangKy";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = nv.TenNhanVien;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = nv.TenDangNhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = nv.MatKhau;
            cmd.Parameters.Add("@MaBoPhan", SqlDbType.Int).Value = nv.MaBoPhan;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static void DoiMatKhau(string tendn,string mkMoi)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DoiMatKhau";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tendn;           
            cmd.Parameters.Add("@MatKhauMoi", SqlDbType.VarChar).Value = mkMoi;           
            cmd.ExecuteNonQuery();          
            con.Close();
        }


        public static int DangNhap(string tendangnhap,string matkhau)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DangNhap";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tendangnhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = matkhau;
            cmd.Parameters.Add("@KT", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int kt = int.Parse(cmd.Parameters["@KT"].Value.ToString());
            con.Close();
            return kt;
        }


        public static DataTable ThongTinNhanVien(string tendangnhap, string matkhau)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_ThongTinNhanVien";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tendangnhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = matkhau;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public static int KiemTraDangKy(string tendangnhap)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_KiemTraDangKy";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tendangnhap;
            cmd.Parameters.Add("@KT", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int kt = int.Parse(cmd.Parameters["@KT"].Value.ToString());
            con.Close();
            return kt;
        }


    }
}
