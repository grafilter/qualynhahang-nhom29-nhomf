using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BanDTO
    {
        private string _maBan;

        public string MaBan
        {
            get { return _maBan; }
            set { _maBan = value; }
        }
        private int _soGhe;

        public int SoGhe
        {
            get { return _soGhe; }
            set { _soGhe = value; }
        }
        private int _maKhuVuc;

        public int MaKhuVuc
        {
            get { return _maKhuVuc; }
            set { _maKhuVuc = value; }
        }
        private int _tinhTrang;

        public int TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        private string _maBanGhep;

        public string MaBanGhep
        {
            get { return _maBanGhep; }
            set { _maBanGhep = value; }
        }
    }
}
