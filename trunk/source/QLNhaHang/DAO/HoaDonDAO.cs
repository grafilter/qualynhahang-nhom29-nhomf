using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        public static double TinhTien(int map, DateTime ngaylap, int khuyenmai)
        {
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_TinhTien";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhieuGoi", SqlDbType.VarChar).Value = map;
            cmd.Parameters.Add("@NgayLap", SqlDbType.Date).Value = ngaylap.Date;
            cmd.Parameters.Add("@KhuyenMai", SqlDbType.Int).Value = khuyenmai;
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            double thanhtien = double.Parse(cmd.Parameters["@ThanhTien"].Value.ToString());
            con.Close();
            return thanhtien;
        }


        public static DataTable DoanhThuTheoThoiGian(int ngaytu, int ngayden, int loai)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DoanhThuTheoThoiGian";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayTu", SqlDbType.Int).Value = ngaytu;
            cmd.Parameters.Add("@NgayDen", SqlDbType.Int).Value = ngayden;
            cmd.Parameters.Add("@Loai", SqlDbType.Int).Value = loai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public static DataTable DoanhThuTheoKhuVuc(int ngay, int makv, int loai)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DoanhThuTheoKhuVuc";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ngay", SqlDbType.Int).Value = ngay;
            cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Int).Value = makv;
            cmd.Parameters.Add("@Loai", SqlDbType.Int).Value = loai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public static DataTable DoanhThuTheoMonAn(int ngay, int loai)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DoanhThuTheoMonAn";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ngay", SqlDbType.Int).Value = ngay;
            cmd.Parameters.Add("@Loai", SqlDbType.Int).Value = loai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


    }
}
