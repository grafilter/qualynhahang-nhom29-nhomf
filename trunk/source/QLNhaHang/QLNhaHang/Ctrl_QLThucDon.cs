using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhaHang
{
    public partial class Ctrl_QLThucDon : UserControl
    {
        public Ctrl_QLThucDon()
        {
            InitializeComponent();
        }

        public event EventHandler Menu_Clicked;

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Clicked != null)
            {
                Menu_Clicked(sender, e);
            }
        }

        private void Ctrl_QLThucDon_Load(object sender, EventArgs e)
        {
            Ctrl_TraCuuThucDon c = new Ctrl_TraCuuThucDon();
            pnTraCuu.Controls.Clear();
            pnTraCuu.Controls.Add(c);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Ctrl_TraCuuThucDon c = new Ctrl_TraCuuThucDon();
            pnTraCuu.Controls.Clear();
            pnTraCuu.Controls.Add(c);
        }

        private void btnDsThucDon_Click(object sender, EventArgs e)
        {
            Ctrl_DanhSachThucDon c = new Ctrl_DanhSachThucDon();
            pnThucDon.Controls.Clear();
            pnThucDon.Controls.Add(c);
        }

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            Ctrl_QLBangGia c = new Ctrl_QLBangGia();
            pnBangGia.Controls.Clear();
            pnBangGia.Controls.Add(c);
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            Ctrl_QLDonVi c = new Ctrl_QLDonVi();
            pnDV.Controls.Clear();
            pnDV.Controls.Add(c);
        }

        private void btnLTD_Click(object sender, EventArgs e)
        {
            Ctrl_QLLoaiThucDon c = new Ctrl_QLLoaiThucDon();
            pnLTD.Controls.Clear();
            pnLTD.Controls.Add(c);
        }

        


    }
}
