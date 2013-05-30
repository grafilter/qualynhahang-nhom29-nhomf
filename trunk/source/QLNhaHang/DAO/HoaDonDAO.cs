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

       
    }
}
