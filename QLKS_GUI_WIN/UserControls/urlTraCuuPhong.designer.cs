namespace _042082.UserControls
{
    partial class urlTraCuuPhong
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
            this.plLoaiPhong = new DevComponents.DotNetBar.PanelEx();
            this.txt_LoaiPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grbox_TinhTrang = new System.Windows.Forms.GroupBox();
            this.rdb_DangThue = new System.Windows.Forms.RadioButton();
            this.rdb_Trong = new System.Windows.Forms.RadioButton();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmbSearch = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmb_LoaiPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_MaPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGrid_DMP = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plLoaiPhong.SuspendLayout();
            this.grbox_TinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DMP)).BeginInit();
            this.SuspendLayout();
            // 
            // plLoaiPhong
            // 
            this.plLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plLoaiPhong.CanvasColor = System.Drawing.Color.Transparent;
            this.plLoaiPhong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.plLoaiPhong.Controls.Add(this.txt_LoaiPhong);
            this.plLoaiPhong.Controls.Add(this.grbox_TinhTrang);
            this.plLoaiPhong.Controls.Add(this.btSearch);
            this.plLoaiPhong.Controls.Add(this.cmbSearch);
            this.plLoaiPhong.Controls.Add(this.labelX5);
            this.plLoaiPhong.Controls.Add(this.cmb_LoaiPhong);
            this.plLoaiPhong.Controls.Add(this.labelX3);
            this.plLoaiPhong.Controls.Add(this.labelX2);
            this.plLoaiPhong.Controls.Add(this.txt_MaPhong);
            this.plLoaiPhong.Controls.Add(this.dataGrid_DMP);
            this.plLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.plLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.plLoaiPhong.Name = "plLoaiPhong";
            this.plLoaiPhong.Size = new System.Drawing.Size(510, 270);
            this.plLoaiPhong.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.plLoaiPhong.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.plLoaiPhong.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.plLoaiPhong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.plLoaiPhong.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.plLoaiPhong.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plLoaiPhong.Style.GradientAngle = 90;
            this.plLoaiPhong.TabIndex = 2;
            this.plLoaiPhong.Enter += new System.EventHandler(this.plLoaiPhong_Enter);
            this.plLoaiPhong.Leave += new System.EventHandler(this.plLoaiPhong_Leave);
            this.plLoaiPhong.MouseEnter += new System.EventHandler(this.plLoaiPhong_MouseEnter);
            this.plLoaiPhong.MouseLeave += new System.EventHandler(this.plLoaiPhong_MouseLeave);
            // 
            // txt_LoaiPhong
            // 
            // 
            // 
            // 
            this.txt_LoaiPhong.Border.Class = "TextBoxBorder";
            this.txt_LoaiPhong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LoaiPhong.Enabled = false;
            this.txt_LoaiPhong.Location = new System.Drawing.Point(90, 63);
            this.txt_LoaiPhong.Name = "txt_LoaiPhong";
            this.txt_LoaiPhong.Size = new System.Drawing.Size(39, 20);
            this.txt_LoaiPhong.TabIndex = 18;
            // 
            // grbox_TinhTrang
            // 
            this.grbox_TinhTrang.Controls.Add(this.rdb_DangThue);
            this.grbox_TinhTrang.Controls.Add(this.rdb_Trong);
            this.grbox_TinhTrang.Enabled = false;
            this.grbox_TinhTrang.Location = new System.Drawing.Point(262, 45);
            this.grbox_TinhTrang.Name = "grbox_TinhTrang";
            this.grbox_TinhTrang.Size = new System.Drawing.Size(179, 44);
            this.grbox_TinhTrang.TabIndex = 17;
            this.grbox_TinhTrang.TabStop = false;
            // 
            // rdb_DangThue
            // 
            this.rdb_DangThue.AutoSize = true;
            this.rdb_DangThue.Location = new System.Drawing.Point(73, 15);
            this.rdb_DangThue.Name = "rdb_DangThue";
            this.rdb_DangThue.Size = new System.Drawing.Size(79, 17);
            this.rdb_DangThue.TabIndex = 1;
            this.rdb_DangThue.TabStop = true;
            this.rdb_DangThue.Text = "Đang Thuê";
            this.rdb_DangThue.UseVisualStyleBackColor = true;
            this.rdb_DangThue.CheckedChanged += new System.EventHandler(this.rdb_DangThue_CheckedChanged);
            // 
            // rdb_Trong
            // 
            this.rdb_Trong.AutoSize = true;
            this.rdb_Trong.Location = new System.Drawing.Point(7, 15);
            this.rdb_Trong.Name = "rdb_Trong";
            this.rdb_Trong.Size = new System.Drawing.Size(53, 17);
            this.rdb_Trong.TabIndex = 0;
            this.rdb_Trong.TabStop = true;
            this.rdb_Trong.Text = "Trống";
            this.rdb_Trong.UseVisualStyleBackColor = true;
            this.rdb_Trong.CheckedChanged += new System.EventHandler(this.rdb_Trong_CheckedChanged);
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Image = global::_042082.Properties.Resources.zoom_;
            this.btSearch.Location = new System.Drawing.Point(201, 23);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(31, 21);
            this.btSearch.TabIndex = 13;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.DisplayMember = "Text";
            this.cmbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.ItemHeight = 15;
            this.cmbSearch.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem4,
            this.comboItem5,
            this.comboItem3});
            this.cmbSearch.Location = new System.Drawing.Point(89, 23);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(106, 21);
            this.cmbSearch.TabIndex = 12;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Mã Phòng";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Loại Phòng";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Tình Trạng";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Nhiều điều kiện";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Xem tất cả";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(14, 23);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Tìm theo :";
            // 
            // cmb_LoaiPhong
            // 
            this.cmb_LoaiPhong.DisplayMember = "Text";
            this.cmb_LoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_LoaiPhong.Enabled = false;
            this.cmb_LoaiPhong.FormattingEnabled = true;
            this.cmb_LoaiPhong.ItemHeight = 15;
            this.cmb_LoaiPhong.Location = new System.Drawing.Point(89, 63);
            this.cmb_LoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_LoaiPhong.Name = "cmb_LoaiPhong";
            this.cmb_LoaiPhong.Size = new System.Drawing.Size(57, 21);
            this.cmb_LoaiPhong.TabIndex = 9;
            this.cmb_LoaiPhong.Visible = false;
            this.cmb_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmb_LoaiPhong_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 61);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 24);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Loại Phòng";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(264, 23);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 22);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Mã Phòng";
            // 
            // txt_MaPhong
            // 
            // 
            // 
            // 
            this.txt_MaPhong.Border.Class = "TextBoxBorder";
            this.txt_MaPhong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_MaPhong.Enabled = false;
            this.txt_MaPhong.Location = new System.Drawing.Point(335, 22);
            this.txt_MaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(106, 20);
            this.txt_MaPhong.TabIndex = 2;
            this.txt_MaPhong.TextChanged += new System.EventHandler(this.txt_MaPhong_TextChanged);
            // 
            // dataGrid_DMP
            // 
            this.dataGrid_DMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhong,
            this.MaLoaiPhong,
            this.DonGia,
            this.TinhTrang,
            this.GhiChu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_DMP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_DMP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGrid_DMP.Location = new System.Drawing.Point(12, 110);
            this.dataGrid_DMP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid_DMP.Name = "dataGrid_DMP";
            this.dataGrid_DMP.Size = new System.Drawing.Size(495, 152);
            this.dataGrid_DMP.TabIndex = 0;
            this.dataGrid_DMP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DMP_CellClick);
            this.dataGrid_DMP.Click += new System.EventHandler(this.dataGrid_DMP_Click);
            this.dataGrid_DMP.MouseEnter += new System.EventHandler(this.dataGrid_DMP_MouseEnter);
            this.dataGrid_DMP.MouseLeave += new System.EventHandler(this.dataGrid_DMP_MouseLeave);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Loại Phòng";
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            this.MaLoaiPhong.ReadOnly = true;
            this.MaLoaiPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Width = 170;
            // 
            // urlTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plLoaiPhong);
            this.Name = "urlTraCuuPhong";
            this.Size = new System.Drawing.Size(510, 270);
            this.Load += new System.EventHandler(this.urlTraCuuPhong_Load);
            this.Enter += new System.EventHandler(this.urlTraCuuPhong_Enter);
            this.plLoaiPhong.ResumeLayout(false);
            this.grbox_TinhTrang.ResumeLayout(false);
            this.grbox_TinhTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx plLoaiPhong;
        private System.Windows.Forms.GroupBox grbox_TinhTrang;
        private System.Windows.Forms.RadioButton rdb_DangThue;
        private System.Windows.Forms.RadioButton rdb_Trong;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSearch;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_LoaiPhong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGrid_DMP;
        private DevComponents.Editors.ComboItem comboItem3;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_MaPhong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}
