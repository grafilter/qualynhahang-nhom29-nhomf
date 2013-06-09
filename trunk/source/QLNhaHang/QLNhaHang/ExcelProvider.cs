using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace QLNhaHang
{
    public class ExcelProvider
    {
        public static OleDbConnection ConnectDB(string chuoi)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + chuoi + ";Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static DataTable ImportToExcel(string chuoi)
        {
            OleDbConnection con = ConnectDB(chuoi);
            string sql = "select * from [ThucDon$]";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public static void ExportToExel(DataTable dt, string name, string strpath)
        {
            StreamWriter wr = new StreamWriter(strpath + "\\" + name, true, System.Text.Encoding.Unicode);

            try
            {

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    wr.Write(dt.Columns[i].ToString() + "\t");
                }

                wr.WriteLine();

                //write rows to excel file
                for (int i = 0; i < (dt.Rows.Count); i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j] != null)
                        {
                            wr.Write(dt.Rows[i][j].ToString() + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    //go to next line
                    wr.WriteLine();
                }
                //close file
                wr.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
