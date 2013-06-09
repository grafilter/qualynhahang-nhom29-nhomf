namespace QLNhaHang
{
    partial class Ctrl_QLBangGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_QLBangGia));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbxKhuVuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pnTraCuu = new DevComponents.DotNetBar.ExpandablePanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtTenThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.GvTraCuuTD = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGia = new DevComponents.Editors.DoubleInput();
            this.GvDsBangGia = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnGhi = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnMaThucDon = new DevComponents.DotNetBar.ButtonX();
            this.pnTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTraCuuTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDsBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 479);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 23);
            this.labelX2.TabIndex = 62;
            this.labelX2.Text = "Khu vực:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 518);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 63;
            this.labelX1.Text = "Mã thực đơn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 563);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 64;
            this.labelX3.Text = "Đơn giá:";
            // 
            // cbxKhuVuc
            // 
            this.cbxKhuVuc.DisplayMember = "Text";
            this.cbxKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxKhuVuc.FormattingEnabled = true;
            this.cbxKhuVuc.ItemHeight = 14;
            this.cbxKhuVuc.Location = new System.Drawing.Point(110, 479);
            this.cbxKhuVuc.Name = "cbxKhuVuc";
            this.cbxKhuVuc.Size = new System.Drawing.Size(135, 20);
            this.cbxKhuVuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxKhuVuc.TabIndex = 65;
            // 
            // pnTraCuu
            // 
            this.pnTraCuu.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnTraCuu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnTraCuu.Controls.Add(this.labelX4);
            this.pnTraCuu.Controls.Add(this.txtTenThucDon);
            this.pnTraCuu.Controls.Add(this.labelX7);
            this.pnTraCuu.Controls.Add(this.GvTraCuuTD);
            this.pnTraCuu.Expanded = false;
            this.pnTraCuu.ExpandedBounds = new System.Drawing.Rectangle(0, 0, 337, 341);
            this.pnTraCuu.Location = new System.Drawing.Point(0, 0);
            this.pnTraCuu.Name = "pnTraCuu";
            this.pnTraCuu.Size = new System.Drawing.Size(337, 26);
            this.pnTraCuu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnTraCuu.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.pnTraCuu.Style.BackColor2.Color = System.Drawing.Color.DodgerBlue;
            this.pnTraCuu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnTraCuu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.pnTraCuu.Style.GradientAngle = 90;
            this.pnTraCuu.TabIndex = 66;
            this.pnTraCuu.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.pnTraCuu.TitleStyle.BackColor1.Color = System.Drawing.Color.Red;
            this.pnTraCuu.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.pnTraCuu.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTraCuu.TitleStyle.ForeColor.Color = System.Drawing.Color.White;
            this.pnTraCuu.TitleStyle.GradientAngle = 90;
            this.pnTraCuu.TitleText = "Tra Cứu Thực Đơn";
            this.pnTraCuu.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.pnTraCuu_ExpandedChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelX4.Location = new System.Drawing.Point(21, 310);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(207, 23);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "Double Click: Chọn mã thực đơn";
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtTenThucDon.Border.Class = "TextBoxBorder";
            this.txtTenThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenThucDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenThucDon.Location = new System.Drawing.Point(102, 53);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(210, 20);
            this.txtTenThucDon.TabIndex = 18;
            this.txtTenThucDon.TextChanged += new System.EventHandler(this.txtTenThucDon_TextChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(21, 50);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "Tên thực đơn:";
            // 
            // GvTraCuuTD
            // 
            this.GvTraCuuTD.AllowUserToAddRows = false;
            this.GvTraCuuTD.AllowUserToDeleteRows = false;
            this.GvTraCuuTD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvTraCuuTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GvTraCuuTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvTraCuuTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvTraCuuTD.DefaultCellStyle = dataGridViewCellStyle10;
            this.GvTraCuuTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GvTraCuuTD.Location = new System.Drawing.Point(21, 95);
            this.GvTraCuuTD.MultiSelect = false;
            this.GvTraCuuTD.Name = "GvTraCuuTD";
            this.GvTraCuuTD.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvTraCuuTD.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GvTraCuuTD.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.GvTraCuuTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvTraCuuTD.Size = new System.Drawing.Size(296, 208);
            this.GvTraCuuTD.TabIndex = 16;
            this.GvTraCuuTD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvTraCuuTD_CellDoubleClick);
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
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtMaThucDon.Border.Class = "TextBoxBorder";
            this.txtMaThucDon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaThucDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaThucDon.Location = new System.Drawing.Point(110, 521);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(135, 20);
            this.txtMaThucDon.TabIndex = 67;
            this.txtMaThucDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.superValidator1.SetValidator1(this.txtMaThucDon, this.requiredFieldValidator1);
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDonGia.Increment = 1;
            this.txtDonGia.Location = new System.Drawing.Point(110, 563);
            this.txtDonGia.MinValue = 0;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ShowUpDown = true;
            this.txtDonGia.Size = new System.Drawing.Size(135, 20);
            this.txtDonGia.TabIndex = 69;
            this.superValidator1.SetValidator1(this.txtDonGia, this.requiredFieldValidator2);
            // 
            // GvDsBangGia
            // 
            this.GvDsBangGia.AllowUserToAddRows = false;
            this.GvDsBangGia.AllowUserToDeleteRows = false;
            this.GvDsBangGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvDsBangGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GvDsBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvDsBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvDsBangGia.DefaultCellStyle = dataGridViewCellStyle14;
            this.GvDsBangGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GvDsBangGia.Location = new System.Drawing.Point(0, 0);
            this.GvDsBangGia.MultiSelect = false;
            this.GvDsBangGia.Name = "GvDsBangGia";
            this.GvDsBangGia.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvDsBangGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GvDsBangGia.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.GvDsBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvDsBangGia.Size = new System.Drawing.Size(670, 473);
            this.GvDsBangGia.TabIndex = 70;
            this.GvDsBangGia.SelectionChanged += new System.EventHandler(this.GvDsBangGia_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaBangGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã bảng giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaThucDon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã thực đơn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenThucDon";
            this.Column1.HeaderText = "Tên thực đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhuVuc";
            this.Column2.HeaderText = "Khu vực";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKhuVuc";
            this.Column4.HeaderText = "MaKhuVuc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
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
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnXoa.Location = new System.Drawing.Point(565, 521);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnXoa.Size = new System.Drawing.Size(91, 33);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 59;
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
            this.btnSua.Location = new System.Drawing.Point(445, 521);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(91, 33);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 58;
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
            this.btnGhi.Location = new System.Drawing.Point(565, 479);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnGhi.Size = new System.Drawing.Size(91, 33);
            this.btnGhi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGhi.TabIndex = 57;
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
            this.btnThem.Location = new System.Drawing.Point(445, 479);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(91, 33);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMaThucDon
            // 
            this.btnMaThucDon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMaThucDon.BackColor = System.Drawing.Color.Transparent;
            this.btnMaThucDon.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnMaThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaThucDon.Image = ((System.Drawing.Image)(resources.GetObject("btnMaThucDon.Image")));
            this.btnMaThucDon.Location = new System.Drawing.Point(247, 517);
            this.btnMaThucDon.Name = "btnMaThucDon";
            this.btnMaThucDon.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnMaThucDon.Size = new System.Drawing.Size(28, 27);
            this.btnMaThucDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMaThucDon.TabIndex = 71;
            this.btnMaThucDon.TextColor = System.Drawing.Color.White;
            this.btnMaThucDon.Tooltip = "Lấy mã thực đơn";
            this.btnMaThucDon.Click += new System.EventHandler(this.btnMaThucDon_Click);
            // 
            // Ctrl_QLBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTraCuu);
            this.Controls.Add(this.btnMaThucDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbxKhuVuc);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaThucDon);
            this.Controls.Add(this.GvDsBangGia);
            this.Name = "Ctrl_QLBangGia";
            this.Size = new System.Drawing.Size(670, 605);
            this.Load += new System.EventHandler(this.Ctrl_QLBangGia_Load);
            this.pnTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvTraCuuTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDsBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxKhuVuc;
        private DevComponents.DotNetBar.ExpandablePanel pnTraCuu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenThucDon;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvTraCuuTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaThucDon;
        private DevComponents.Editors.DoubleInput txtDonGia;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvDsBangGia;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.ButtonX btnMaThucDon;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnGhi;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}
