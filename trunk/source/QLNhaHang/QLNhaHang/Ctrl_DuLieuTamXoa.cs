using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QLNhaHang
{
    public partial class Ctrl_DuLieuTamXoa : UserControl
    {
        public Ctrl_DuLieuTamXoa()
        {
            InitializeComponent();
        }

        private void Ctrl_DuLieuTamXoa_Load(object sender, EventArgs e)
        {
           
        }

        private void pnBan_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnBan.Expanded == true)
            {
                GvDsBan.AutoGenerateColumns = false;
                GvDsBan.DataSource = BanBUS.BanTamXoa();
            }
        }

        private void pnKhuVuc_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnKhuVuc.Expanded == true)
            {
                GvKhuVuc.AutoGenerateColumns = false;
                GvKhuVuc.DataSource = KhuVucBUS.KhuVucTamXoa();
            }
        }

        private void pnThucDon_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnThucDon.Expanded == true)
            {
                GvDsThucDon.AutoGenerateColumns = false;
                GvDsThucDon.DataSource = ThucDonBUS.ThucDonTamXoa();
            }
        }

        private void pnLoaiThucDon_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnLoaiThucDon.Expanded == true)
            {
                GvLoaiThucDon.AutoGenerateColumns = false;
                GvLoaiThucDon.DataSource = LoaiThucDonBUS.LTDTamXoa();
            }
        }

        private void pnBangGia_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnBangGia.Expanded == true)
            {
                GvDsBangGia.AutoGenerateColumns = false;
                GvDsBangGia.DataSource = BangGiaBUS.BangGiaTamXoa();
            }
        }

        private void pnDonVi_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (pnDonVi.Expanded == true)
            {
                GvDonVi.AutoGenerateColumns = false;
                GvDonVi.DataSource = DonViBUS.DonViTamXoa();
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (pnBan.Expanded == true)
            {
                string mab = GvDsBan.CurrentRow.Cells[0].Value.ToString();
                BanBUS.PhucHoiBan(mab);
                GvDsBan.DataSource = BanBUS.BanTamXoa();
            }

            if (pnKhuVuc.Expanded == true)
            {
                int makv = (int)GvKhuVuc.CurrentRow.Cells[0].Value;
                KhuVucBUS.PhucHoiKhuVuc(makv);
                GvKhuVuc.DataSource = KhuVucBUS.KhuVucTamXoa();
            }

            if (pnThucDon.Expanded == true)
            {
                string matd = GvDsThucDon.CurrentRow.Cells[0].Value.ToString();
                ThucDonBUS.PhucHoiThucDon(matd);
                GvDsThucDon.DataSource = ThucDonBUS.ThucDonTamXoa();
            }

            if (pnLoaiThucDon.Expanded == true)
            {
                int maltd = (int)GvLoaiThucDon.CurrentRow.Cells[0].Value;
                LoaiThucDonBUS.PhucHoiLTD(maltd);
                GvLoaiThucDon.DataSource = LoaiThucDonBUS.LTDTamXoa();
            }

            if (pnBangGia.Expanded == true)
            {
                int mabg = (int)GvDsBangGia.CurrentRow.Cells[0].Value;
                BangGiaBUS.PhucHoiBangGia(mabg);
                GvDsBangGia.DataSource = BangGiaBUS.BangGiaTamXoa();
            }

            if (pnDonVi.Expanded == true)
            {
                int madv = (int)GvDonVi.CurrentRow.Cells[0].Value;
                DonViBUS.PhucHoiDonVi(madv);
                GvDonVi.DataSource = DonViBUS.DonViTamXoa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pnBan.Expanded == true)
            {
                string mab = GvDsBan.CurrentRow.Cells[0].Value.ToString();
                BanBUS.DelBan(mab);
                GvDsBan.DataSource = BanBUS.BanTamXoa();
            }

            if (pnKhuVuc.Expanded == true)
            {
                int makv = (int)GvKhuVuc.CurrentRow.Cells[0].Value;
                KhuVucBUS.DelKhuVuc(makv);
                GvKhuVuc.DataSource = KhuVucBUS.KhuVucTamXoa();
            }

            if (pnThucDon.Expanded == true)
            {
                string matd = GvDsThucDon.CurrentRow.Cells[0].Value.ToString();
                ThucDonBUS.DelThucDon(matd);
                GvDsThucDon.DataSource = ThucDonBUS.ThucDonTamXoa();
            }

            if (pnLoaiThucDon.Expanded == true)
            {
                int maltd = (int)GvLoaiThucDon.CurrentRow.Cells[0].Value;
                LoaiThucDonBUS.DelLTD(maltd);
                GvLoaiThucDon.DataSource = LoaiThucDonBUS.LTDTamXoa();
            }

            if (pnBangGia.Expanded == true)
            {
                int mabg = (int)GvDsBangGia.CurrentRow.Cells[0].Value;
                BangGiaBUS.DelBangGia(mabg);
                GvDsBangGia.DataSource = BangGiaBUS.BangGiaTamXoa();
            }

            if (pnDonVi.Expanded == true)
            {
                int madv = (int)GvDonVi.CurrentRow.Cells[0].Value;
                DonViBUS.DelDonVi(madv);
                GvDonVi.DataSource = DonViBUS.DonViTamXoa();
            }
        }
    }
}
