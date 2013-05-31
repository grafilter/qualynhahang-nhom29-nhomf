namespace QLNhaHang
{
    partial class Ctrl_DoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_DoiMatKhau));
            this.btnDoiMatKhau = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMatKhauCu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtMatKhauMoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txtDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDoiMatKhau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(107, 146);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnDoiMatKhau.Size = new System.Drawing.Size(75, 23);
            this.btnDoiMatKhau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDoiMatKhau.TabIndex = 17;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(19, 62);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(81, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "Mật khẩu cũ:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatKhauCu.Border.Class = "TextBoxBorder";
            this.txtMatKhauCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauCu.Location = new System.Drawing.Point(107, 64);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(135, 20);
            this.txtMatKhauCu.TabIndex = 14;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.txtMatKhauCu, this.requiredFieldValidator1);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(19, 101);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(81, 23);
            this.labelX6.TabIndex = 15;
            this.labelX6.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatKhauMoi.Border.Class = "TextBoxBorder";
            this.txtMatKhauMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(107, 103);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(135, 20);
            this.txtMatKhauMoi.TabIndex = 16;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.txtMatKhauMoi, this.requiredFieldValidator2);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDangNhap.Border.Class = "TextBoxBorder";
            this.txtDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtDangNhap.Location = new System.Drawing.Point(107, 26);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(135, 20);
            this.txtDangNhap.TabIndex = 19;
            this.superValidator1.SetValidator1(this.txtDangNhap, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "Tên đăng nhập:";
            // 
            // Ctrl_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Name = "Ctrl_DoiMatKhau";
            this.Size = new System.Drawing.Size(260, 197);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDoiMatKhau;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhauCu;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhauMoi;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDangNhap;
    }
}
