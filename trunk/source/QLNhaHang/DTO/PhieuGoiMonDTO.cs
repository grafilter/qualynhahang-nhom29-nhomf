using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuGoiMonDTO
    {
        private int _maPhieuGoi;

        public int MaPhieuGoi
        {
            get { return _maPhieuGoi; }
            set { _maPhieuGoi = value; }
        }

        private string _maBan;

        public string MaBan
        {
            get { return _maBan; }
            set { _maBan = value; }
        }
        private string _maThucDon;

        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private int _maKhuVuc;

        public int MaKhuVuc
        {
            get { return _maKhuVuc; }
            set { _maKhuVuc = value; }
        }



    }
}
