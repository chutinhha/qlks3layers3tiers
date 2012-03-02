namespace _042082
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cmdNgayLap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewPhieuThue = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.MaPhieuThue = new System.Windows.Forms.ColumnHeader();
            this.MaPhong = new System.Windows.Forms.ColumnHeader();
            this.TenPhong = new System.Windows.Forms.ColumnHeader();
            this.NgayTra = new System.Windows.Forms.ColumnHeader();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txt_MaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_DiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_MaHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btxem = new DevComponents.DotNetBar.ButtonX();
            this.btExit = new DevComponents.DotNetBar.ButtonX();
            this.btAdd = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_tim = new DevComponents.DotNetBar.ButtonX();
            this.checkNgayTra_ThucTe = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmd_ngaytra_thucte = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.checkmatudong = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewCTPhong = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.MaKhachHang = new System.Windows.Forms.ColumnHeader();
            this.TenKhachHang = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.MaLoaiKhach = new System.Windows.Forms.ColumnHeader();
            this.TenLoaikhach = new System.Windows.Forms.ColumnHeader();
            this.txt_tenKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNgayLap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_ngaytra_thucte)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(262, 11);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(318, 30);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "LẬP HÓA ĐƠN THANH TOÁN";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(317, 36);
            this.labelX10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(54, 16);
            this.labelX10.TabIndex = 22;
            this.labelX10.Text = "Ngày Lập";
            // 
            // cmdNgayLap
            // 
            // 
            // 
            // 
            this.cmdNgayLap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cmdNgayLap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.cmdNgayLap.ButtonDropDown.Visible = true;
            this.cmdNgayLap.Location = new System.Drawing.Point(379, 29);
            this.cmdNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // 
            // 
            this.cmdNgayLap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cmdNgayLap.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cmdNgayLap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cmdNgayLap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cmdNgayLap.MonthCalendar.DisplayMonth = new System.DateTime(2011, 5, 1, 0, 0, 0, 0);
            this.cmdNgayLap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cmdNgayLap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cmdNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cmdNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cmdNgayLap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cmdNgayLap.MonthCalendar.TodayButtonVisible = true;
            this.cmdNgayLap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cmdNgayLap.Name = "cmdNgayLap";
            this.cmdNgayLap.Size = new System.Drawing.Size(103, 21);
            this.cmdNgayLap.TabIndex = 24;
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(12, 35);
            this.labelX8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(65, 20);
            this.labelX8.TabIndex = 21;
            this.labelX8.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewPhieuThue);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(25, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 211);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng Cần Thanh Toán";
            // 
            // listViewPhieuThue
            // 
            // 
            // 
            // 
            this.listViewPhieuThue.Border.Class = "ListViewBorder";
            this.listViewPhieuThue.CheckBoxes = true;
            this.listViewPhieuThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhieuThue,
            this.MaPhong,
            this.TenPhong,
            this.NgayTra});
            this.listViewPhieuThue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPhieuThue.GridLines = true;
            this.listViewPhieuThue.Location = new System.Drawing.Point(129, 41);
            this.listViewPhieuThue.Name = "listViewPhieuThue";
            this.listViewPhieuThue.Size = new System.Drawing.Size(422, 147);
            this.listViewPhieuThue.TabIndex = 43;
            this.listViewPhieuThue.UseCompatibleStateImageBehavior = false;
            this.listViewPhieuThue.View = System.Windows.Forms.View.Details;
            this.listViewPhieuThue.SelectedIndexChanged += new System.EventHandler(this.listViewHoaDon_SelectedIndexChanged);
            // 
            // MaPhieuThue
            // 
            this.MaPhieuThue.Text = "Mã Phiếu Thuê";
            this.MaPhieuThue.Width = 135;
            // 
            // MaPhong
            // 
            this.MaPhong.Text = "Mã Phòng";
            this.MaPhong.Width = 76;
            // 
            // TenPhong
            // 
            this.TenPhong.Text = "Tên Phòng";
            this.TenPhong.Width = 98;
            // 
            // NgayTra
            // 
            this.NgayTra.Text = "Ngày Trả";
            this.NgayTra.Width = 86;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(11, 63);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(85, 22);
            this.labelX7.TabIndex = 30;
            this.labelX7.Text = "Mã Khách Hàng";
            // 
            // txt_MaKH
            // 
            // 
            // 
            // 
            this.txt_MaKH.Border.Class = "TextBoxBorder";
            this.txt_MaKH.Location = new System.Drawing.Point(102, 65);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(103, 21);
            this.txt_MaKH.TabIndex = 29;
            this.txt_MaKH.TextChanged += new System.EventHandler(this.txt_MaKH_TextChanged);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(12, 96);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 22);
            this.labelX3.TabIndex = 34;
            this.labelX3.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            // 
            // 
            // 
            this.txt_DiaChi.Border.Class = "TextBoxBorder";
            this.txt_DiaChi.Enabled = false;
            this.txt_DiaChi.Location = new System.Drawing.Point(102, 99);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(330, 21);
            this.txt_DiaChi.TabIndex = 33;
            // 
            // txt_MaHoaDon
            // 
            // 
            // 
            // 
            this.txt_MaHoaDon.Border.Class = "TextBoxBorder";
            this.txt_MaHoaDon.Enabled = false;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(102, 35);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(84, 21);
            this.txt_MaHoaDon.TabIndex = 35;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btxem);
            this.groupBox4.Controls.Add(this.btExit);
            this.groupBox4.Controls.Add(this.btAdd);
            this.groupBox4.Location = new System.Drawing.Point(495, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 140);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nút xử lý";
            // 
            // btxem
            // 
            this.btxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxem.ForeColor = System.Drawing.Color.Blue;
            this.btxem.Location = new System.Drawing.Point(17, 25);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(84, 25);
            this.btxem.TabIndex = 12;
            this.btxem.Text = "Xem";
            this.btxem.Click += new System.EventHandler(this.btxem_Click);
            // 
            // btExit
            // 
            this.btExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Blue;
            this.btExit.Location = new System.Drawing.Point(17, 93);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(84, 23);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAdd
            // 
            this.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.Red;
            this.btAdd.Location = new System.Drawing.Point(17, 60);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 25);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Lập hóa đơn";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.checkNgayTra_ThucTe);
            this.groupBox1.Controls.Add(this.cmd_ngaytra_thucte);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.checkmatudong);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_tenKH);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_MaHoaDon);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.cmdNgayLap);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(124, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(756, 660);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // bt_tim
            // 
            this.bt_tim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_tim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.Location = new System.Drawing.Point(211, 65);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(44, 23);
            this.bt_tim.TabIndex = 48;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // checkNgayTra_ThucTe
            // 
            this.checkNgayTra_ThucTe.Location = new System.Drawing.Point(345, 140);
            this.checkNgayTra_ThucTe.Name = "checkNgayTra_ThucTe";
            this.checkNgayTra_ThucTe.Size = new System.Drawing.Size(99, 23);
            this.checkNgayTra_ThucTe.TabIndex = 47;
            this.checkNgayTra_ThucTe.Text = "Sửa";
            this.checkNgayTra_ThucTe.CheckedChanged += new System.EventHandler(this.checkNgayTra_ThucTe_CheckedChanged);
            // 
            // cmd_ngaytra_thucte
            // 
            // 
            // 
            // 
            this.cmd_ngaytra_thucte.BackgroundStyle.Class = "DateTimeInputBackground";
            this.cmd_ngaytra_thucte.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.cmd_ngaytra_thucte.ButtonDropDown.Visible = true;
            this.cmd_ngaytra_thucte.Enabled = false;
            this.cmd_ngaytra_thucte.Location = new System.Drawing.Point(232, 142);
            // 
            // 
            // 
            this.cmd_ngaytra_thucte.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cmd_ngaytra_thucte.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cmd_ngaytra_thucte.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.cmd_ngaytra_thucte.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.cmd_ngaytra_thucte.MonthCalendar.DisplayMonth = new System.DateTime(2011, 6, 1, 0, 0, 0, 0);
            this.cmd_ngaytra_thucte.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.cmd_ngaytra_thucte.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.cmd_ngaytra_thucte.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.cmd_ngaytra_thucte.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.cmd_ngaytra_thucte.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.cmd_ngaytra_thucte.MonthCalendar.TodayButtonVisible = true;
            this.cmd_ngaytra_thucte.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.cmd_ngaytra_thucte.Name = "cmd_ngaytra_thucte";
            this.cmd_ngaytra_thucte.Size = new System.Drawing.Size(107, 21);
            this.cmd_ngaytra_thucte.TabIndex = 46;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Blue;
            this.labelX5.Location = new System.Drawing.Point(133, 140);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(93, 23);
            this.labelX5.TabIndex = 44;
            this.labelX5.Text = "Ngày trả thực tế";
            // 
            // checkmatudong
            // 
            this.checkmatudong.Location = new System.Drawing.Point(192, 33);
            this.checkmatudong.Name = "checkmatudong";
            this.checkmatudong.Size = new System.Drawing.Size(99, 23);
            this.checkmatudong.TabIndex = 43;
            this.checkmatudong.Text = "Lấy mã tự động";
            this.checkmatudong.CheckedChanged += new System.EventHandler(this.checkmatudong_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewCTPhong);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(24, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 210);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phòng Thuê";
            // 
            // listViewCTPhong
            // 
            // 
            // 
            // 
            this.listViewCTPhong.Border.Class = "ListViewBorder";
            this.listViewCTPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DiaChi,
            this.MaLoaiKhach,
            this.TenLoaikhach});
            this.listViewCTPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCTPhong.GridLines = true;
            this.listViewCTPhong.Location = new System.Drawing.Point(15, 29);
            this.listViewCTPhong.Name = "listViewCTPhong";
            this.listViewCTPhong.Size = new System.Drawing.Size(610, 104);
            this.listViewCTPhong.TabIndex = 43;
            this.listViewCTPhong.UseCompatibleStateImageBehavior = false;
            this.listViewCTPhong.View = System.Windows.Forms.View.Details;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Text = "Mã Khách Hàng";
            this.MaKhachHang.Width = 113;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Text = "Tên Khách Hàng";
            this.TenKhachHang.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa Chỉ";
            this.DiaChi.Width = 112;
            // 
            // MaLoaiKhach
            // 
            this.MaLoaiKhach.Text = "Mã Loại Khách";
            this.MaLoaiKhach.Width = 119;
            // 
            // TenLoaikhach
            // 
            this.TenLoaikhach.Text = "Tên Loại Khách";
            this.TenLoaikhach.Width = 117;
            // 
            // txt_tenKH
            // 
            // 
            // 
            // 
            this.txt_tenKH.Border.Class = "TextBoxBorder";
            this.txt_tenKH.Enabled = false;
            this.txt_tenKH.Location = new System.Drawing.Point(377, 63);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(103, 21);
            this.txt_tenKH.TabIndex = 40;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(286, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(85, 22);
            this.labelX4.TabIndex = 41;
            this.labelX4.Text = "Tên Khách Hàng";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 746);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDonThanhToan";
            this.Load += new System.EventHandler(this.frmHoaDonThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdNgayLap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmd_ngaytra_thucte)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cmdNgayLap;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MaKH;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_MaHoaDon;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX btExit;
        private DevComponents.DotNetBar.ButtonX btAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewPhieuThue;
        private System.Windows.Forms.ColumnHeader MaPhong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenKH;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewCTPhong;
        private System.Windows.Forms.ColumnHeader MaKhachHang;
        private System.Windows.Forms.ColumnHeader TenKhachHang;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader MaLoaiKhach;
        private System.Windows.Forms.ColumnHeader TenLoaikhach;
        private DevComponents.DotNetBar.ButtonX btxem;
        private System.Windows.Forms.ColumnHeader MaPhieuThue;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkmatudong;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.ColumnHeader TenPhong;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput cmd_ngaytra_thucte;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkNgayTra_ThucTe;
        private DevComponents.DotNetBar.ButtonX bt_tim;
        private System.Windows.Forms.ColumnHeader NgayTra;
    }
}