using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace QLNhaHang
{
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroAppForm
    {
      
        public frmMain()
        {
            InitializeComponent();
           
        }

        Ctrl_PhucVu cPhucVu;
        Ctrl_QLThucDon cQLThucDon;
        Ctrl_BaoCaoDoanhThu cBaoCao;

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

    }
}