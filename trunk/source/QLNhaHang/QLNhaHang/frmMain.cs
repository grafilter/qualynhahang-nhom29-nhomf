using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using BUS;
using System.IO;

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
        Ctrl_QLHoaDon cQLHoaDon;
        Ctrl_QLDuLieu cQLDuLieu;
        Ctrl_LienHe cLienHe;

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

        private void Dong_CtrlQLHoaDon(object sender, EventArgs e)
        {
            this.CloseModalPanel(cQLHoaDon, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void Dong_CtrlQLDuLieu(object sender, EventArgs e)
        {
            this.CloseModalPanel(cQLDuLieu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void Dong_CtrlLienHe(object sender, EventArgs e)
        {
            this.CloseModalPanel(cLienHe, DevComponents.DotNetBar.Controls.eSlideSide.Left);
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

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            cQLHoaDon = new Ctrl_QLHoaDon();
            cQLHoaDon.Menu_Clicked += Dong_CtrlQLHoaDon;
            this.ShowModalPanel(cQLHoaDon, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnQLDuLieu_Click(object sender, EventArgs e)
        {
            cQLDuLieu = new Ctrl_QLDuLieu();
            cQLDuLieu.Menu_Clicked += Dong_CtrlQLDuLieu;
            this.ShowModalPanel(cQLDuLieu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }


        private void btnLienHe_Click(object sender, EventArgs e)
        {
            cLienHe = new Ctrl_LienHe();
            cLienHe.Menu_Clicked += Dong_CtrlLienHe;
            this.ShowModalPanel(cLienHe, DevComponents.DotNetBar.Controls.eSlideSide.Left);
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

        private void ThongTinNhaHang()
        {
            string duongdan = Path.Combine(Application.StartupPath, "Images");
            pcLogo.SizeMode = PictureBoxSizeMode.Zoom;
            DataTable dt = ThamSoBUS.ThongTinNhaHang();
            lblTenNH.Text = dt.Rows[0]["TenNhaHang"].ToString();
            lblDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();

            string hinh = Path.Combine(duongdan, dt.Rows[0]["Logo"].ToString());

            Image image1 = null;

            using (FileStream stream = new FileStream(hinh, FileMode.Open))
            {
                image1 = Image.FromStream(stream);
            }
            pcLogo.Image = image1;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTenNV.ForeColor = Color.Red;
            tableLayoutPanel1.BackColor = Color.ForestGreen;
            lblHeThong.ForeColor = Color.Yellow;
            lblTenNH.ForeColor = Color.White;
            lblDiaChi.ForeColor = Color.Yellow;

            ThongTinNhaHang();

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