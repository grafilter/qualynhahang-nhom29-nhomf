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

        private void Dong_CtrlPhucVu(object sender, EventArgs e)
        {
            this.CloseModalPanel(cPhucVu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }

        private void btnPhucVu_Click(object sender, EventArgs e)
        {
            cPhucVu = new Ctrl_PhucVu();
            cPhucVu.Menu_Clicked += Dong_CtrlPhucVu;
            this.ShowModalPanel(cPhucVu, DevComponents.DotNetBar.Controls.eSlideSide.Left);
        }


    }
}