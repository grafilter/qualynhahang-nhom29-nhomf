using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using BUS;

namespace QLNhaHang
{
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {

        string _tenNV;
        int _maNV;
        int _mabp;

        public frmMain(string tennv, int manv, int mabp)
        {
            InitializeComponent();
            _tenNV = tennv;
            _maNV = manv;
            _mabp = mabp;
           
        }

        Ctrl_PhucVu cPhucVu;
        Ctrl_QLThucDon cQLThucDon;
        Ctrl_BaoCaoDoanhThu cBaoCao;
        Ctrl_HeThong cHeThong;

        private void Dong_CtrlPhucVu(object sender, EventArgs e)
        {
            this.CloseModalPanel(cPhucVu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void Dong_CtrlQLThucDon(object sender, EventArgs e)
        {
            this.CloseModalPanel(cQLThucDon, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void Dong_CtrlBaoCao(object sender, EventArgs e)
        {
            this.CloseModalPanel(cBaoCao, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void Dong_CtrlHeThong(object sender, EventArgs e)
        {
            this.CloseModalPanel(cHeThong, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }


        private void btnPhucVu_Click(object sender, EventArgs e)
        {
            cPhucVu = new Ctrl_PhucVu();
            cPhucVu.Menu_Clicked += Dong_CtrlPhucVu;
            this.ShowModalPanel(cPhucVu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnQLThucDon_Click(object sender, EventArgs e)
        {
            cQLThucDon = new Ctrl_QLThucDon();
            cQLThucDon.Menu_Clicked += Dong_CtrlQLThucDon;
            this.ShowModalPanel(cQLThucDon, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }


        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            cBaoCao = new Ctrl_BaoCaoDoanhThu();
            cBaoCao.Menu_Clicked += Dong_CtrlBaoCao;
            this.ShowModalPanel(cBaoCao, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            cHeThong = new Ctrl_HeThong();         
            cHeThong.Menu_Clicked += Dong_CtrlHeThong;
            this.ShowModalPanel(cHeThong, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        List<MetroTileItem> nut = new List<MetroTileItem>();

        private void DanhSachNut()
        {
            nut.Add(btnPhucVu);
            nut.Add(btnQLDuLieu);
            nut.Add(btnQLHoaDon);
            nut.Add(btnQLThucDon);
            nut.Add(btnBaoCao);
            nut.Add(btnHeThong);
        }

        private void AnNut()
        {
            btnPhucVu.Enabled = false;
            btnQLDuLieu.Enabled = false;
            btnQLHoaDon.Enabled = false;
            btnQLThucDon.Enabled = false;
            btnBaoCao.Enabled = false;
            btnHeThong.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTenNV.ForeColor = Color.Red;
            lblTenNV.Text = _tenNV;
            if (_tenNV != "Admin")
            {
                AnNut();
                DanhSachNut();
                List<string> dsQuyen = new List<string>();
                DataTable dt = BoPhanBUS.DanhSachQuyenHan(_mabp);
                foreach (DataRow dr in dt.Rows)
                {
                    dsQuyen.Add(dr["QuyenHan"].ToString());
                }
              
                foreach (string strQuyen in dsQuyen)
                {
                    foreach (MetroTileItem btn in nut)
                    {
                        if (btn.Tooltip.Contains(strQuyen))
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
        }




    }
}