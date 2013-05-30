namespace QLNhaHang
{
    partial class Ctrl_ChuyenBan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_ChuyenBan));
            this.btnChuyenBan = new DevComponents.DotNetBar.ButtonX();
            this.cbxBanCD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbxBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.Menu = new DevComponents.DotNetBar.LabelX();
            this.Home = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyenBan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyenBan.Location = new System.Drawing.Point(369, 234);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnChuyenBan.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChuyenBan.TabIndex = 21;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cbxBanCD
            // 
            this.cbxBanCD.DisplayMember = "Text";
            this.cbxBanCD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBanCD.FormattingEnabled = true;
            this.cbxBanCD.ItemHeight = 14;
            this.cbxBanCD.Location = new System.Drawing.Point(377, 170);
            this.cbxBanCD.Name = "cbxBanCD";
            this.cbxBanCD.Size = new System.Drawing.Size(143, 20);
            this.cbxBanCD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxBanCD.TabIndex = 20;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(280, 170);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Bàn chuyển đến:";
            // 
            // cbxBan
            // 
            this.cbxBan.DisplayMember = "Text";
            this.cbxBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBan.FormattingEnabled = true;
            this.cbxBan.ItemHeight = 14;
            this.cbxBan.Location = new System.Drawing.Point(377, 128);
            this.cbxBan.Name = "cbxBan";
            this.cbxBan.Size = new System.Drawing.Size(143, 20);
            this.cbxBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxBan.TabIndex = 18;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(280, 128);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(91, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Bàn cần chuyển:";
            // 
            // Menu
            // 
            // 
            // 
            // 
            this.Menu.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.Menu.BackgroundStyle.Class = "";
            this.Menu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Menu.ForeColor = System.Drawing.Color.Transparent;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(765, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(32, 32);
            this.Menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.Menu.TabIndex = 36;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Home
            // 
            // 
            // 
            // 
            this.Home.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundStyle.Class = "";
            this.Home.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Home.ForeColor = System.Drawing.Color.Transparent;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(32, 32);
            this.Home.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.Home.TabIndex = 37;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Ctrl_ChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.cbxBanCD);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbxBan);
            this.Controls.Add(this.labelX3);
            this.Name = "Ctrl_ChuyenBan";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.Ctrl_ChuyenBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnChuyenBan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxBanCD;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxBan;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX Menu;
        private DevComponents.DotNetBar.LabelX Home;
    }
}
