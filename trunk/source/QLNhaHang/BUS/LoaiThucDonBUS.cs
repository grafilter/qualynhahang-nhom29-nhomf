using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class LoaiThucDonBUS
    {
        public static DataTable DanhSachLTD()
        {
            return LoaiThucDonDAO.DanhSachLTD();
        }

        
    }
}
