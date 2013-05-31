using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BUS;
using DevComponents.DotNetBar;
using Microsoft.Office.Interop;

namespace QLNhaHang
{
    public partial class Ctrl_QLDuLieu : UserControl
    {
        public Ctrl_QLDuLieu()
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

        string duongdan = Path.Combine(Application.StartupPath, "Images");
        string logo = "";
        string del = "";
        private void Ctrl_QLDuLieu_Load(object sender, EventArgs e)
        {
            ThongTinNhaHang();
        }

        private void ThongTinNhaHang()
        {
            HinhAnh.SizeMode = PictureBoxSizeMode.CenterImage;
            DataTable dt = ThamSoBUS.ThongTinNhaHang();
            txtTenNH.Text = dt.Rows[0]["TenNhaHang"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            logo = dt.Rows[0]["Logo"].ToString();
            del = logo;
            string hinh = Path.Combine(duongdan, logo);

            Image image1 = null;

            using (FileStream stream = new FileStream(hinh, FileMode.Open))
            {
                image1 = Image.FromStream(stream);
            }
            HinhAnh.Image = image1;
        }

        private void btnDuLieuTamXoa_Click(object sender, EventArgs e)
        {
            pnDuLieuTamXoa.Controls.Clear();
            Ctrl_DuLieuTamXoa c = new Ctrl_DuLieuTamXoa();
            pnDuLieuTamXoa.Controls.Add(c);
        }

       

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            txtTenNH.Enabled = true;
            txtDiaChi.Enabled = true;
            pnDoiAnh.Visible = true;
            ThongTinNhaHang();
        }

        private void lnkDoiAnh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.ShowDialog();
            op.Filter = "txt file|*.txt";

            Image image1 = null;

            using (FileStream stream = new FileStream(op.FileName, FileMode.Open))
            {
                image1 = Image.FromStream(stream);
            }

            HinhAnh.Image = image1;
            HinhAnh.Tag = op.FileName;

            

            string strCopy = Path.Combine(duongdan, Path.GetFileName(HinhAnh.Tag.ToString()));
            
            File.Copy(HinhAnh.Tag.ToString(), strCopy, true);
            
            logo = Path.GetFileName(HinhAnh.Tag.ToString());
            
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThamSoBUS.CapNhatNhaHang(txtTenNH.Text, txtDiaChi.Text, logo);

            if (del != "")
            {
                string strDel = Path.Combine(duongdan, del);
                File.Delete(strDel);
            }
            txtTenNH.Enabled = false;
            txtDiaChi.Enabled = false;
            pnDoiAnh.Visible = false;
        }

        private void btnDDSaoLuu_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //op.Multiselect = false;
            //op.ShowDialog();
            //op.Filter = "txt file|*.txt";
            //txtSaoLuu.Text = "";
        }

       

        private void btnSaoLuuDL_Click(object sender, EventArgs e)
        {
          
        }

        private void btnXuatDL_Click(object sender, EventArgs e)
        {

        }


        

    }
}
