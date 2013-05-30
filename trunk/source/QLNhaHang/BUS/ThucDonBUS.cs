using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ThucDonBUS
    {
        public static DataTable DanhSachThucDon()
        {
            return ThucDonDAO.DanhSachThucDon();
        }

        public static DataTable TraCuuThucDon(ThucDonDTO td)
        {
            return ThucDonDAO.TraCuuThucDon(td);
        }

    }
}
