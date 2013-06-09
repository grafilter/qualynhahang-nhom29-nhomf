namespace QLNhaHang
{
    partial class Ctrl_QLLoaiThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_QLLoaiThucDon));
            this.txtTenLTD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.GvLoaiThucDon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnGhi = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.GvLoaiThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenLTD
            // 
            this.txtTenLTD.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenLTD.Border.Class = "TextBoxBorder";
            this.txtTenLTD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLTD.ForeColor = System.Drawing.Color.Black;
            this.txtTenLTD.Location = new System.Drawing.Point(92, 515);
            this.txtTenLTD.Name = "txtTenLTD";
            this.txtTenLTD.Size = new System.Drawing.Size(143, 20);
            this.txtTenLTD.TabIndex = 73;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(17, 514);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 23);
            this.labelX2.TabIndex = 68;
            this.labelX2.Text = "Tên đơn vị:";
            // 
            // GvLoaiThucDon
            // 
            this.GvLoaiThucDon.AllowUserToAddRows = false;
            this.GvLoaiThucDon.AllowUserToDeleteRows = false;
            this.GvLoaiThucDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvLoaiThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvLoaiThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLoaiThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvLoaiThucDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvLoaiThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.GvLoaiThucDon.Location = new System.Drawing.Point(0, 0);
            this.GvLoaiThucDon.MultiSelect = false;
            this.GvLoaiThucDon.Name = "GvLoaiThucDon";
            this.GvLoaiThucDon.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvLoaiThucDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GvLoaiThucDon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GvLoaiThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvLoaiThucDon.Size = new System.Drawing.Size(670, 508);
            this.GvLoaiThucDon.TabIndex = 67;
            this.GvLoaiThucDon.SelectionChanged += new System.EventHandler(this.GvLoaiThucDon_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLoaiThucDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã loại thực đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LoaiThucDon";
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại thực đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
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
            this.btnXoa.Location = new System.Drawing.Point(563, 553);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnXoa.Size = new System.Drawing.Size(91, 33);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 78;
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
            this.btnSua.Location = new System.Drawing.Point(443, 553);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(91, 33);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 77;
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
            this.btnGhi.Location = new System.Drawing.Point(563, 514);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnGhi.Size = new System.Drawing.Size(91, 33);
            this.btnGhi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGhi.TabIndex = 76;
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
            this.btnThem.Location = new System.Drawing.Point(443, 514);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(91, 33);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Ctrl_QLLoaiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLTD);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.GvLoaiThucDon);
            this.Name = "Ctrl_QLLoaiThucDon";
            this.Size = new System.Drawing.Size(670, 605);
            this.Load += new System.EventHandler(this.Ctrl_QLLoaiThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvLoaiThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLTD;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvLoaiThucDon;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnGhi;
        private DevComponents.DotNetBar.ButtonX btnThem;
    }
}
