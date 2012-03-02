namespace _042082
{
    partial class frmDSHoaDon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewCTHD = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.MaPhong = new System.Windows.Forms.ColumnHeader();
            this.NgayThue = new System.Windows.Forms.ColumnHeader();
            this.NgayTra_Thucte = new System.Windows.Forms.ColumnHeader();
            this.SoNgayThue = new System.Windows.Forms.ColumnHeader();
            this.DonGia = new System.Windows.Forms.ColumnHeader();
            this.HeSo = new System.Windows.Forms.ColumnHeader();
            this.PhuThu = new System.Windows.Forms.ColumnHeader();
            this.TienThue = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewHD = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.MaHoaDon = new System.Windows.Forms.ColumnHeader();
            this.TenKhachhangDaiDien = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.NgayLap = new System.Windows.Forms.ColumnHeader();
            this.TriGia = new System.Windows.Forms.ColumnHeader();
            this.ThanhToan = new System.Windows.Forms.ColumnHeader();
            this.btThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.btin = new DevComponents.DotNetBar.ButtonX();
            this.btAdd = new DevComponents.DotNetBar.ButtonX();
            this.btxoa = new DevComponents.DotNetBar.ButtonX();
            this.btrefesh = new DevComponents.DotNetBar.ButtonX();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewCTHD);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(34, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // listViewCTHD
            // 
            // 
            // 
            // 
            this.listViewCTHD.Border.Class = "ListViewBorder";
            this.listViewCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhong,
            this.NgayThue,
            this.NgayTra_Thucte,
            this.SoNgayThue,
            this.DonGia,
            this.HeSo,
            this.PhuThu,
            this.TienThue});
            this.listViewCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCTHD.GridLines = true;
            this.listViewCTHD.Location = new System.Drawing.Point(43, 40);
            this.listViewCTHD.Name = "listViewCTHD";
            this.listViewCTHD.Size = new System.Drawing.Size(801, 129);
            this.listViewCTHD.TabIndex = 1;
            this.listViewCTHD.UseCompatibleStateImageBehavior = false;
            this.listViewCTHD.View = System.Windows.Forms.View.Details;
            // 
            // MaPhong
            // 
            this.MaPhong.Text = "Phòng";
            this.MaPhong.Width = 86;
            // 
            // NgayThue
            // 
            this.NgayThue.Text = "Ngày THuê";
            this.NgayThue.Width = 91;
            // 
            // NgayTra_Thucte
            // 
            this.NgayTra_Thucte.Text = "Ngày Trả Thực Tế";
            this.NgayTra_Thucte.Width = 140;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.Text = "Số Ngày Thuê";
            this.SoNgayThue.Width = 112;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn Giá";
            this.DonGia.Width = 78;
            // 
            // HeSo
            // 
            this.HeSo.Text = "Hệ Số";
            this.HeSo.Width = 84;
            // 
            // PhuThu
            // 
            this.PhuThu.Text = "Phụ Thu";
            this.PhuThu.Width = 93;
            // 
            // TienThue
            // 
            this.TienThue.Text = "Thành Tiền";
            this.TienThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TienThue.Width = 99;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewHD);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(90, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // listViewHD
            // 
            // 
            // 
            // 
            this.listViewHD.Border.Class = "ListViewBorder";
            this.listViewHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHoaDon,
            this.TenKhachhangDaiDien,
            this.DiaChi,
            this.NgayLap,
            this.TriGia,
            this.ThanhToan});
            this.listViewHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHD.GridLines = true;
            this.listViewHD.Location = new System.Drawing.Point(25, 41);
            this.listViewHD.Name = "listViewHD";
            this.listViewHD.Size = new System.Drawing.Size(676, 212);
            this.listViewHD.TabIndex = 0;
            this.listViewHD.UseCompatibleStateImageBehavior = false;
            this.listViewHD.View = System.Windows.Forms.View.Details;
            this.listViewHD.SelectedIndexChanged += new System.EventHandler(this.listViewHD_SelectedIndexChanged);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.Text = "Mã Hóa Đơn";
            this.MaHoaDon.Width = 95;
            // 
            // TenKhachhangDaiDien
            // 
            this.TenKhachhangDaiDien.Text = "Tên Khách Hàng";
            this.TenKhachhangDaiDien.Width = 140;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa Chỉ";
            this.DiaChi.Width = 122;
            // 
            // NgayLap
            // 
            this.NgayLap.Text = "Ngày Lập";
            this.NgayLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NgayLap.Width = 87;
            // 
            // TriGia
            // 
            this.TriGia.Text = "Thành Tiền";
            this.TriGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TriGia.Width = 117;
            // 
            // ThanhToan
            // 
            this.ThanhToan.Text = "Thanh Toán";
            this.ThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhToan.Width = 97;
            // 
            // btThanhToan
            // 
            this.btThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThanhToan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btThanhToan.Location = new System.Drawing.Point(385, 391);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btThanhToan.TabIndex = 10;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btin
            // 
            this.btin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btin.ForeColor = System.Drawing.Color.Blue;
            this.btin.Location = new System.Drawing.Point(466, 391);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(75, 23);
            this.btin.TabIndex = 11;
            this.btin.Text = "In";
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // btAdd
            // 
            this.btAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.Red;
            this.btAdd.Location = new System.Drawing.Point(221, 391);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Lập hóa đơn";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btxoa
            // 
            this.btxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Red;
            this.btxoa.Location = new System.Drawing.Point(302, 391);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 13;
            this.btxoa.Text = "Xóa hóa đơn";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btrefesh
            // 
            this.btrefesh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btrefesh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btrefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefesh.ForeColor = System.Drawing.Color.Blue;
            this.btrefesh.Location = new System.Drawing.Point(547, 391);
            this.btrefesh.Name = "btrefesh";
            this.btrefesh.Size = new System.Drawing.Size(75, 23);
            this.btrefesh.TabIndex = 14;
            this.btrefesh.Text = "Refesh";
            this.btrefesh.Click += new System.EventHandler(this.btrefesh_Click);
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.Color.Blue;
            this.btthoat.Location = new System.Drawing.Point(628, 391);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 15;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(357, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(277, 37);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Danh Sách Các Hóa Đơn";
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(922, 666);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btrefesh);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDSHoaDon";
            this.Text = "frmDSHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDSHoaDon_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewHD;
        private System.Windows.Forms.ColumnHeader MaHoaDon;
        private System.Windows.Forms.ColumnHeader NgayLap;
        private System.Windows.Forms.ColumnHeader TriGia;
        private System.Windows.Forms.ColumnHeader ThanhToan;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewCTHD;
        private System.Windows.Forms.ColumnHeader MaPhong;
        private System.Windows.Forms.ColumnHeader SoNgayThue;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader TienThue;
        private DevComponents.DotNetBar.ButtonX btThanhToan;
        private DevComponents.DotNetBar.ButtonX btin;
        private DevComponents.DotNetBar.ButtonX btAdd;
        private DevComponents.DotNetBar.ButtonX btxoa;
        private DevComponents.DotNetBar.ButtonX btrefesh;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private System.Windows.Forms.ColumnHeader HeSo;
        private System.Windows.Forms.ColumnHeader PhuThu;
        private System.Windows.Forms.ColumnHeader TenKhachhangDaiDien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ColumnHeader NgayThue;
        private System.Windows.Forms.ColumnHeader NgayTra_Thucte;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}