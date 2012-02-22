namespace _042082
{
    partial class frmPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhong));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridDoanhMucPhong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorPhong = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAll = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btExit = new DevComponents.DotNetBar.ButtonX();
            this.btDelete = new DevComponents.DotNetBar.ButtonX();
            this.btEdit = new DevComponents.DotNetBar.ButtonX();
            this.btAdd = new DevComponents.DotNetBar.ButtonX();
            this.cmb_LoaiPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_GhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_MaPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.plLoaiPhong = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhMucPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhong)).BeginInit();
            this.bindingNavigatorPhong.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.plLoaiPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(233, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(238, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "LẬP DANH MỤC PHÒNG";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.panelEx1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cmb_LoaiPhong);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.txt_MaPhong);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 485);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng";
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSearch.Image = global::_042082.Properties.Resources.zoom_;
            this.btSearch.Location = new System.Drawing.Point(272, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(37, 23);
            this.btSearch.TabIndex = 26;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.dataGridDoanhMucPhong);
            this.panelEx1.Controls.Add(this.bindingNavigatorPhong);
            this.panelEx1.Location = new System.Drawing.Point(10, 192);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(702, 286);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 25;
            this.panelEx1.Text = "panelEx1";
            // 
            // dataGridDoanhMucPhong
            // 
            this.dataGridDoanhMucPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoanhMucPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhong,
            this.MaLoaiPhong,
            this.DonGia,
            this.GhiChu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDoanhMucPhong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDoanhMucPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDoanhMucPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridDoanhMucPhong.Location = new System.Drawing.Point(0, 25);
            this.dataGridDoanhMucPhong.Name = "dataGridDoanhMucPhong";
            this.dataGridDoanhMucPhong.Size = new System.Drawing.Size(702, 261);
            this.dataGridDoanhMucPhong.TabIndex = 1;
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
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.DisplayStyleForCurrentCellOnly = true;
            this.MaLoaiPhong.HeaderText = "Loại Phòng";
            this.MaLoaiPhong.Name = "MaLoaiPhong";
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
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ToolTipText = "Rê chuột vào sửa và xem ghi chú";
            this.GhiChu.Width = 300;
            // 
            // bindingNavigatorPhong
            // 
            this.bindingNavigatorPhong.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorPhong.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPhong.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveAll});
            this.bindingNavigatorPhong.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPhong.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPhong.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPhong.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPhong.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPhong.Name = "bindingNavigatorPhong";
            this.bindingNavigatorPhong.PositionItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPhong.Size = new System.Drawing.Size(702, 25);
            this.bindingNavigatorPhong.TabIndex = 0;
            this.bindingNavigatorPhong.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "0";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveAll
            // 
            this.SaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAll.Image = global::_042082.Properties.Resources.SAVE_;
            this.SaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(23, 22);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btExit);
            this.groupBox4.Controls.Add(this.btDelete);
            this.groupBox4.Controls.Add(this.btEdit);
            this.groupBox4.Controls.Add(this.btAdd);
            this.groupBox4.Location = new System.Drawing.Point(119, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 57);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nút xử lý";
            // 
            // btExit
            // 
            this.btExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btExit.Location = new System.Drawing.Point(427, 24);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDelete.Location = new System.Drawing.Point(168, 24);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btEdit.Location = new System.Drawing.Point(298, 24);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Sửa";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAdd.Location = new System.Drawing.Point(46, 24);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cmb_LoaiPhong
            // 
            this.cmb_LoaiPhong.DisplayMember = "Text";
            this.cmb_LoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_LoaiPhong.FormattingEnabled = true;
            this.cmb_LoaiPhong.ItemHeight = 17;
            this.cmb_LoaiPhong.Location = new System.Drawing.Point(189, 43);
            this.cmb_LoaiPhong.Name = "cmb_LoaiPhong";
            this.cmb_LoaiPhong.Size = new System.Drawing.Size(77, 23);
            this.cmb_LoaiPhong.TabIndex = 23;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(119, 90);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(54, 24);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "Ghi Chú";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(291, 46);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(47, 20);
            this.labelX4.TabIndex = 21;
            this.labelX4.Text = "Đơn Giá";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(119, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 23);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Loại Phòng";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(119, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 23);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Mã Phòng";
            // 
            // txt_GhiChu
            // 
            // 
            // 
            // 
            this.txt_GhiChu.Border.Class = "TextBoxBorder";
            this.txt_GhiChu.Location = new System.Drawing.Point(184, 78);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(286, 48);
            this.txt_GhiChu.TabIndex = 18;
            // 
            // txt_MaPhong
            // 
            // 
            // 
            // 
            this.txt_MaPhong.Border.Class = "TextBoxBorder";
            this.txt_MaPhong.Location = new System.Drawing.Point(189, 12);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(77, 23);
            this.txt_MaPhong.TabIndex = 17;
            // 
            // txt_DonGia
            // 
            // 
            // 
            // 
            this.txt_DonGia.Border.Class = "TextBoxBorder";
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(344, 44);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(88, 23);
            this.txt_DonGia.TabIndex = 16;
            // 
            // plLoaiPhong
            // 
            this.plLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plLoaiPhong.CanvasColor = System.Drawing.Color.Transparent;
            this.plLoaiPhong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.plLoaiPhong.Controls.Add(this.groupBox1);
            this.plLoaiPhong.Controls.Add(this.labelX1);
            this.plLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.plLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plLoaiPhong.Name = "plLoaiPhong";
            this.plLoaiPhong.Size = new System.Drawing.Size(745, 539);
            this.plLoaiPhong.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.plLoaiPhong.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.plLoaiPhong.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.plLoaiPhong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.plLoaiPhong.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.plLoaiPhong.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.plLoaiPhong.Style.GradientAngle = 90;
            this.plLoaiPhong.TabIndex = 0;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 539);
            this.Controls.Add(this.plLoaiPhong);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhong";
            this.Text = "frmDoanhMucPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLOAIPHONG_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhong_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhMucPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhong)).EndInit();
            this.bindingNavigatorPhong.ResumeLayout(false);
            this.bindingNavigatorPhong.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.plLoaiPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridDoanhMucPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPhong;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btExit;
        private DevComponents.DotNetBar.ButtonX btDelete;
        private DevComponents.DotNetBar.ButtonX btEdit;
        private DevComponents.DotNetBar.ButtonX btAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_LoaiPhong;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_GhiChu;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MaPhong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DonGia;
        private DevComponents.DotNetBar.PanelEx plLoaiPhong;


    }
}