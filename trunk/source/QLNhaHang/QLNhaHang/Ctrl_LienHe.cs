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
    public partial class Ctrl_LienHe : UserControl
    {
        public Ctrl_LienHe()
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

        private void Ctrl_LienHe_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            lblPM.ForeColor = Color.Orange;
            lblNhom.ForeColor = Color.Blue;
            lblTruong.ForeColor = Color.Orange;
            lblThanhVien.ForeColor = Color.Blue;
            lblNhom1.ForeColor = Color.Blue;
            lblTruong1.ForeColor = Color.Orange;
        }
    }
}
