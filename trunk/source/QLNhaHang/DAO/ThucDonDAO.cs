﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ThucDonDAO
    {
        public static DataTable DanhSachThucDon()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string procName = "usp_DanhSachThucDon";
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable TraCuuThucDon(ThucDonDTO td)
        {
            DataTable dt = new DataTable();
            SqlConnection con = DataProvider.ConnectDB();
            string sql = "select * ";
            sql += "from THUCDON td,BANGGIA bg,LOAITHUCDON ltd,KHUVUC kv";
            sql += " where td.MaThucDon=bg.MaThucDon and td.MaLoaiThucDon=ltd.MaLoaiThucDon";
            sql += " and bg.MaKhuVuc=kv.MaKhuVuc and td.isDel=0 ";
            if (td.MaThucDon != "")
            {
                sql += " and td.MaThucDon='" + td.MaThucDon + "'";
            }
            if (td.TenThucDon != "")
            {
                sql += " and td.TenThucDon LIKE '%" + td.TenThucDon + "%' ";
            }
            if (td.MaKhuVuc > 0)
            {
                sql += " and bg.MaKhuVuc=" + td.MaKhuVuc;
            }
            if (td.MaLoaiThucDon > 0)
            {
                sql += " and td.MaLoaiThucDon=" + td.MaLoaiThucDon;
            }
            if (td.GiaTu > 0 && td.GiaDen > 0)
            {
                sql += " and bg.DonGia between " + td.GiaTu + " and " + td.GiaDen;
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        
    }
}
