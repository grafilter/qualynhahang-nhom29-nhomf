namespace QLNhaHang
{
    partial class Ctrl_TraCuuThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxLoaiThucDon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxKhuVuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtMaThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenThucDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtGiaTu = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtGiaDen = new DevComponents.Editors.IntegerInput();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.GvDsThucDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDsThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLoaiThucDon
            // 
            this.cbxLoaiThucDon.DisplayMember = "Text";
            this.cbxLoaiThucDon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLoaiThucDon.FormattingEnabled = true;
            this.cbxLoaiThucDon.ItemHeight = 14;
            this.cbxLoaiThucDon.Location = new System.Drawing.Point(444, 82);
            this.cbxLoaiThucDon.Name = "cbxLoaiThucDon";
            this.cbxLoaiThucDon.Size = new System.Drawing.Size(132, 20);
            this.cbxLoaiThucDon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLoaiThucDon.TabIndex = 87;
            // 
            // cbxKhuVuc
            // 
            this.cbxKhuVuc.DisplayMember = "Text";
            this.cbxKhuVuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxKhuVuc.FormattingEnabled = true;
            this.cbxKhuVuc.ItemHeight = 14;
            this.cbxKhuVuc.Location = new System.Drawing.Point(444, 44);
            this.cbxKhuVuc.Name = "cbxKhuVuc";
            this.cbxKhuVuc.Size = new System.Drawing.Size(132, 20);
            this.cbxKhuVuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxKhuVuc.TabIndex = 86;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(360, 79);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(69, 23);
            this.labelX4.TabIndex = 85;
            this.labelX4.Text = "Loại thực đơn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(360, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 23);
            this.labelX3.TabIndex = 84;
            this.labelX3.Text = "Khu vực:";
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
            this.txtMaThucDon.Location = new System.Drawing.Point(132, 44);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(143, 20);
            this.txtMaThucDon.TabIndex = 83;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(57, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 82;
            this.labelX1.Text = "Mã thực đơn:";
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
            this.txtTenThucDon.Location = new System.Drawing.Point(132, 82);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(143, 20);
            this.txtTenThucDon.TabIndex = 81;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(57, 79);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 23);
            this.labelX2.TabIndex = 80;
            this.labelX2.Text = "Tên thực đơn:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(132, 128);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(53, 23);
            this.labelX5.TabIndex = 88;
            this.labelX5.Text = "Đơn giá";
            // 
            // txtGiaTu
            // 
            // 
            // 
            // 
            this.txtGiaTu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtGiaTu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaTu.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtGiaTu.Location = new System.Drawing.Point(230, 128);
            this.txtGiaTu.MinValue = 0;
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.ShowUpDown = true;
            this.txtGiaTu.Size = new System.Drawing.Size(110, 20);
            this.txtGiaTu.TabIndex = 89;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(203, 128);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(21, 23);
            this.labelX6.TabIndex = 90;
            this.labelX6.Text = "từ";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(376, 128);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(21, 23);
            this.labelX7.TabIndex = 91;
            this.labelX7.Text = "đến";
            // 
            // txtGiaDen
            // 
            // 
            // 
            // 
            this.txtGiaDen.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtGiaDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaDen.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtGiaDen.Location = new System.Drawing.Point(403, 128);
            this.txtGiaDen.MinValue = 0;
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.ShowUpDown = true;
            this.txtGiaDen.Size = new System.Drawing.Size(110, 20);
            this.txtGiaDen.TabIndex = 92;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(279, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(89, 29);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "Tra Cứu";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.Column2,
            this.Column1,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvDsThucDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvDsThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.GvDsThucDon.Location = new System.Drawing.Point(57, 230);
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
            this.GvDsThucDon.Size = new System.Drawing.Size(545, 357);
            this.GvDsThucDon.TabIndex = 94;
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
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiThucDon";
            this.Column2.HeaderText = "Loại thực đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenKhuVuc";
            this.Column1.HeaderText = "Tên khu vực";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // Ctrl_TraCuuThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.GvDsThucDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaDen);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtGiaTu);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cbxLoaiThucDon);
            this.Controls.Add(this.cbxKhuVuc);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtMaThucDon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtTenThucDon);
            this.Controls.Add(this.labelX2);
            this.Name = "Ctrl_TraCuuThucDon";
            this.Size = new System.Drawing.Size(670, 605);
            this.Load += new System.EventHandler(this.Ctrl_TraCuuThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDsThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLoaiThucDon;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxKhuVuc;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaThucDon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenThucDon;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.IntegerInput txtGiaTu;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.IntegerInput txtGiaDen;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvDsThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
    }
}
