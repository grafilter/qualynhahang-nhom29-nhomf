using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThucDonDTO
    {
        private string _maThucDon;

        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }
        private string _tenThucDon;

        public string TenThucDon
        {
            get { return _tenThucDon; }
            set { _tenThucDon = value; }
        }
        private int _maDonVi;

        public int MaDonVi
        {
            get { return _maDonVi; }
            set { _maDonVi = value; }
        }
        private int _maLoaiThucDon;

        public int MaLoaiThucDon
        {
            get { return _maLoaiThucDon; }
            set { _maLoaiThucDon = value; }
        }

        private int _maKhuVuc;

        public int MaKhuVuc
        {
            get { return _maKhuVuc; }
            set { _maKhuVuc = value; }
        }
        private double _giaTu;

        public double GiaTu
        {
            get { return _giaTu; }
            set { _giaTu = value; }
        }
        private double _giaDen;

        public double GiaDen
        {
            get { return _giaDen; }
            set { _giaDen = value; }
        }

    }
}
