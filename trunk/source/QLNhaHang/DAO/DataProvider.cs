using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;


public class DataProvider
{

    public static SqlConnection ConnectDB()
    {
        //Get connection string from web.conf or app.conf
        string strConnection = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|App_data\\QuanLyNhaHang.mdf;Integrated Security=True;User Instance=True ";
        SqlConnection con = new SqlConnection(strConnection);
        con.Open();
        return con;
    }

}