namespace QLNhaHang
{
    partial class Ctrl_DanhSachThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_DanhSachThucDon));
            this.txtTenThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.GvDsThucDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbxDonVi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxLoaiThucDon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnGhi = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.GvDsThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenThucDon.Border.Class = "TextBoxBorder";
            this.txtTenThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenThucDon.ForeColor = System.Drawing.Color.Black;
            this.txtTenThucDon.Location = new System.Drawing.Point(88, 504);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(143, 20);
            this.txtTenThucDon.TabIndex = 73;
            this.superValidator1.SetValidator1(this.txtTenThucDon, this.requiredFieldValidator2);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 501);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 23);
            this.labelX2.TabIndex = 68;
            this.labelX2.Text = "Tên thực đơn:";
            // 
            // GvDsThucDon
            // 
            this.GvDsThucDon.AllowUserToAddRows = false;
            this.GvDsThucDon.AllowUserToDeleteRows = false;
            this.GvDsThucDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvDsThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvDsThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvDsThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvDsThucDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvDsThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GvDsThucDon.Location = new System.Drawing.Point(0, 0);
            this.GvDsThucDon.MultiSelect = false;
            this.GvDsThucDon.Name = "GvDsThucDon";
            this.GvDsThucDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvDsThucDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GvDsThucDon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GvDsThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvDsThucDon.Size = new System.Drawing.Size(670, 466);
            this.GvDsThucDon.TabIndex = 67;
            this.GvDsThucDon.SelectionChanged += new System.EventHandler(this.GvDsThucDon_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaThucDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã thực đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenThucDon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên thực đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenDonVi";
            this.Column1.HeaderText = "Đơn vị";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiThucDon";
            this.Column2.HeaderText = "Loại thực đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaDonVi";
            this.Column3.HeaderText = "MaDonVi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaLoaiThucDon";
            this.Column4.HeaderText = "MaLoaiThucDon";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMaThucDon.Border.Class = "TextBoxBorder";
            this.txtMaThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaThucDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaThucDon.Location = new System.Drawing.Point(88, 475);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(143, 20);
            this.txtMaThucDon.TabIndex = 75;
            this.superValidator1.SetValidator1(this.txtMaThucDon, this.requiredFieldValidator1);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 472);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 74;
            this.labelX1.Text = "Mã thực đơn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 530);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 23);
            this.labelX3.TabIndex = 76;
            this.labelX3.Text = "Đơn vị:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(13, 559);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(69, 23);
            this.labelX4.TabIndex = 77;
            this.labelX4.Text = "Loại thực đơn:";
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.DisplayMember = "Text";
            this.cbxDonVi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.ItemHeight = 14;
            this.cbxDonVi.Location = new System.Drawing.Point(88, 533);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(141, 20);
            this.cbxDonVi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxDonVi.TabIndex = 78;
            // 
            // cbxLoaiThucDon
            // 
            this.cbxLoaiThucDon.DisplayMember = "Text";
            this.cbxLoaiThucDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLoaiThucDon.FormattingEnabled = true;
            this.cbxLoaiThucDon.ItemHeight = 14;
            this.cbxLoaiThucDon.Location = new System.Drawing.Point(88, 562);
            this.cbxLoaiThucDon.Name = "cbxLoaiThucDon";
            this.cbxLoaiThucDon.Size = new System.Drawing.Size(141, 20);
            this.cbxLoaiThucDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLoaiThucDon.TabIndex = 79;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnXoa.Location = new System.Drawing.Point(562, 514);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnXoa.Size = new System.Drawing.Size(91, 33);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 83;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(442, 514);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(91, 33);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 82;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGhi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGhi.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.Location = new System.Drawing.Point(562, 475);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnGhi.Size = new System.Drawing.Size(91, 33);
            this.btnGhi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGhi.TabIndex = 81;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnGhi.TextColor = System.Drawing.Color.White;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(442, 475);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(91, 33);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 80;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Ctrl_DanhSachThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxLoaiThucDon);
            this.Controls.Add(this.cbxDonVi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtMaThucDon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtTenThucDon);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.GvDsThucDon);
            this.Name = "Ctrl_DanhSachThucDon";
            this.Size = new System.Drawing.Size(670, 605);
            this.Load += new System.EventHandler(this.Ctrl_DanhSachThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvDsThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTenThucDon;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvDsThucDon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaThucDon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxDonVi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLoaiThucDon;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnGhi;
        private DevComponents.DotNetBar.ButtonX btnThem;
    }
}
