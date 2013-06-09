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

        private void btnStrNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.ShowDialog();
            txtStrNhap.Text = op.FileName;
        }

        private void btnNhapDuLieu_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(txtStrNhap.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            DataTable dt = ExcelProvider.ImportToExcel(txtStrNhap.Text);
            ThucDonBUS.NhapThucDon(dt);
            book.Close(false, txtStrNhap.Text, null);
            MessageBoxEx.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStrXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtStrXuat.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnXuatDL_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ThucDonBUS.XuatThucDon();
            ExcelProvider.ExportToExel(dt, "ThucDon.xls", txtStrXuat.Text);
            MessageBoxEx.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Template_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog2.SelectedPath;
                string p1 = Path.Combine(path, "ThucDon.xls");
                string p2 = Path.Combine(path, "LuuY.txt");
                string strCopy1 = Path.Combine(Application.StartupPath, "Template\\ThucDon.xls");
                string strCopy2 = Path.Combine(Application.StartupPath, "Template\\LuuY.txt");
                File.Copy(strCopy1, p1,true);
                File.Copy(strCopy2, p2,true);
            }
        }


        

    }
}
