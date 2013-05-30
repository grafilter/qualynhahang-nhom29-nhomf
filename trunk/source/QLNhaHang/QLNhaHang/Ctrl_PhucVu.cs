using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevComponents.DotNetBar;

namespace QLNhaHang
{
    public partial class Ctrl_PhucVu : UserControl
    {
        public Ctrl_PhucVu()
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


        private void uPhucVu_Load(object sender, EventArgs e)
        {
            DanhSachBan();

        }

        private string TinhTrangBan(int TT)
        {
            string tinhtrang = "";
            if (TT == 0)
                tinhtrang =  "Bàn còn trống";
            if (TT == 1)
                tinhtrang = "Bàn đang sử dụng";
            if (TT == 2)
                tinhtrang = "Bàn đang ghép";
            if (TT == 3)
                tinhtrang = "Bàn được đặt trước";
            return tinhtrang;
        }

        private void DanhSachBan()
        {
            LvDsBan.Items.Clear();
            DataTable dtKhuVuc = KhuVucBUS.DanhSachKhuVuc();
            for (int i = 0; i < dtKhuVuc.Rows.Count; i++)
            {
                ListViewGroup listG = new ListViewGroup(dtKhuVuc.Rows[i]["TenKhuVuc"].ToString());
                LvDsBan.Groups.Add(listG);
                int maKV = int.Parse(dtKhuVuc.Rows[i]["MaKhuVuc"].ToString());
                DataTable dtBan = BanBUS.DsBanTheoKhuVuc(maKV);
                for (int j = 0; j < dtBan.Rows.Count; j++)
                {
                    ListViewItem item = new ListViewItem(dtBan.Rows[j]["MaBan"].ToString(), listG);
                    item.SubItems.Add(maKV.ToString());
                    item.SubItems.Add(dtBan.Rows[j]["SoGhe"].ToString());
                    int tt = int.Parse(dtBan.Rows[j]["TinhTrang"].ToString());
                    item.SubItems.Add(tt.ToString());
                    item.ImageIndex = tt;
                    LvDsBan.Items.Add(item);
                }
            }
        }


        private void LvDsBan_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(LvDsBan, "");
        }

        private void LvDsBan_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem thisItem = LvDsBan.GetItemAt(e.X, e.Y);
            string tinhtrang = "";
            if (thisItem != null)
            {
                int tt = int.Parse(thisItem.SubItems[3].Text);
                tinhtrang = TinhTrangBan(tt);
                toolTip1.SetToolTip(LvDsBan, "Tình trạng: " + tinhtrang + " \n" +
                                          "Số ghế: " + thisItem.SubItems[2].Text);
            }
            else
            {
                toolTip1.SetToolTip(LvDsBan, "");
            }
        }

        Ctrl_GoiMon ctrlGoiMon;

        private void Home_Clicked(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            pnPhucVu.Controls.Add(pnDanhSachBan);
            DanhSachBan();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
           
            pnPhucVu.Controls.Clear();
            ctrlGoiMon = new Ctrl_GoiMon(null,0,0);
            ctrlGoiMon.Dock = DockStyle.Fill;
            ctrlGoiMon.Menu_Clicked += Menu_Clicked;
            ctrlGoiMon.Home_Clicked += Home_Clicked;
            pnPhucVu.Controls.Add(ctrlGoiMon);
        }

        private void LvDsBan_DoubleClick(object sender, EventArgs e)
        {
            string maban = LvDsBan.SelectedItems[0].SubItems[0].Text;
            int maKV = int.Parse(LvDsBan.SelectedItems[0].SubItems[1].Text);
            int tt = int.Parse(LvDsBan.SelectedItems[0].SubItems[3].Text);
            
            pnPhucVu.Controls.Clear();
            ctrlGoiMon = new Ctrl_GoiMon(maban,maKV,tt);
            ctrlGoiMon.Dock = DockStyle.Fill;
            ctrlGoiMon.Menu_Clicked += Menu_Clicked;
            ctrlGoiMon.Home_Clicked += Home_Clicked;
            pnPhucVu.Controls.Add(ctrlGoiMon);
        }

        private void Button_DsBan(object sender, EventArgs e)
        {
            DanhSachBan();
        }

        private void btnGhepBan_Click(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            Ctrl_GhepBan c = new Ctrl_GhepBan();
            c.Dock = DockStyle.Fill;
            c.Menu_Clicked += Menu_Clicked;
            c.Home_Clicked += Home_Clicked;
            pnPhucVu.Controls.Add(c);
            
        }

        private void btnTachBan_Click(object sender, EventArgs e)
        {
            if (LvDsBan.SelectedItems.Count > 0)
            {
                int tt = int.Parse(LvDsBan.SelectedItems[0].SubItems[3].Text);
                if (tt != 2)
                {
                    MessageBoxEx.Show("Xin chọn bàn đang ở trạng thái ghép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string maban = LvDsBan.SelectedItems[0].SubItems[0].Text;
                BanBUS.TachBan(maban);

                DanhSachBan();
            }
            else
            {
                MessageBoxEx.Show("Xin chọn bàn đang ở trạng thái ghép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Home_Clicked(sender, e);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            Ctrl_ChuyenBan c = new Ctrl_ChuyenBan();
            c.Dock = DockStyle.Fill;
            c.Menu_Clicked += Menu_Clicked;
            c.Home_Clicked += Home_Clicked;
            pnPhucVu.Controls.Add(c);
        }

        private void btnPhucVu_Click(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            DanhSachBan();
            pnPhucVu.Controls.Add(LvDsBan);
            btnTachBan.Enabled = true;
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            Ctrl_QLBan c = new Ctrl_QLBan();
            c.Dock = DockStyle.Fill;
            c.Home_Clicked += Home_Clicked;
            c.Menu_Clicked += Menu_Clicked;
            pnPhucVu.Controls.Add(c);

        }

        private void btnQLKhuVuc_Click(object sender, EventArgs e)
        {
            pnPhucVu.Controls.Clear();
            Ctrl_QLKhuVuc c = new Ctrl_QLKhuVuc();
            c.Dock = DockStyle.Fill;
            c.Home_Clicked += Home_Clicked;
            c.Menu_Clicked += Menu_Clicked;
            pnPhucVu.Controls.Add(c);
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (LvDsBan.SelectedItems.Count > 0)
            {
                string maban = LvDsBan.SelectedItems[0].SubItems[0].Text;
                BanBUS.CapNhatTinhTrangBan(maban,3);

                DanhSachBan();
            }
            else
            {
                MessageBoxEx.Show("Xin chọn bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Home_Clicked(sender, e);
            }
        }

        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            if (LvDsBan.SelectedItems.Count > 0)
            {
                
                string maban = LvDsBan.SelectedItems[0].SubItems[0].Text;
                int p = PhieuGoiMonBUS.LayPhieuGoi(maban);
                if (p != 0)
                {
                    BanBUS.HuyDatBan(p);
                    BanBUS.CapNhatTinhTrangBan(maban, 0);
                }
                else
                {
                    BanBUS.CapNhatTinhTrangBan(maban, 0);
                }
                DanhSachBan();
            }
            else
            {
                MessageBoxEx.Show("Xin chọn bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Home_Clicked(sender, e);
            }
            
        }

       
       

    }
}
