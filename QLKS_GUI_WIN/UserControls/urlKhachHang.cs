using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using _042082.QLKS_BUS_WebService;
namespace _042082.UserControls
{
    public partial class urlKhachHang : UserControl
    {
        /* Manager Components - Nhớ ở form nào thì gán biến này đầu tiên trước khi khởi tạo mới có hiệu lực.
         * 0 : default
         * 1 : OnLoad_frmHoaDon(...
         * 2 : OnLoad_frmKhachHang(...
         */
        
        /* Tạm thời : 
         *  Bị lỗi phần tiềm kiếm khách hàng theo tên, do không binding được trường khachangdaidien.
         *  Và các hàm như tìm kiếm theo địa chỉ và nhiều điều kiện
         *  ===> Tiếp tục viết phần thêm khách hàng
         */
        public QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        
        public static int run;
        public static int ManagerComponents;
        public static string staticMaKhachHang;
        public static string staticMaKhachHangDaiDien;
        int AddKhachHang = 0;
        int id_Search;
        //LoaiKhachHangBUS lkBUS = new LoaiKhachHangBUS();
        //KhachHangBUS kBUS = new KhachHangBUS();
        KhachHangDTO kDTO = new KhachHangDTO();
        DataTable dt = new DataTable();
        BindingSource bdSource = new BindingSource();

        public DataTable ConvertKhachHangDTOArrayToDataTable(KhachHangDTO[] DTOArr)
        {
            DataTable dt = new DataTable();
            int row = DTOArr.Length;
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("MaLoaiKH", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("KhachHangDaiDien", typeof(string));
            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(DTOArr[i].MaKhachHang, DTOArr[i].TenKhachHang, DTOArr[i].MaLoaiKH, DTOArr[i].CMND, DTOArr[i].DiaChi, DTOArr[i].KhachHangDaiDien);
            }
            return dt;
        }
        public DataTable ConvertLoaiKhachHangDTOArrayToDataTable(LoaiKhachHangDTO[] lkhDTOArr)
        {
            DataTable dt = new DataTable();
            int row = lkhDTOArr.Length;
            dt.Columns.Add("MaLoaiKH", typeof(string));
            dt.Columns.Add("TenLoaiKH", typeof(string));
            dt.Columns.Add("HeSoKH", typeof(string));

            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(lkhDTOArr[i].MaLoaiKH, lkhDTOArr[i].TenLoaiKH, lkhDTOArr[i].HeSoKH);
            }
            return dt;
        }
        public urlKhachHang()
        {
            InitializeComponent();
            // Khi load mặc định là tìm kiếm

            // Run = 1 tức là UserControl chạy hẳn hoi trên 1 form. VD form QLKH, or PT
            //- không dùng cách này khi Design thì nó load dữ liệu lên --> nặng máy.
            if (run == 1)
            {
                txt_MaKHDD.Enabled = false;
                lbl_KHDD.Enabled = false;
                chk_KHDD.Enabled = false;
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
                dt =ConvertKhachHangDTOArrayToDataTable(ws.getListKhachHang());
                dp_Bindind();
                dataGridKH.DataSource = bdSource;
                bindingNavigatorKH.BindingSource = bdSource;
                // phát huy tác dụng của biến ManagetComponets
                if (ManagerComponents == 1)
                    OnLoad_frmHoaDon();
                LoadLoaiKhachHang();
            }
        }
        private void refresh()
        {
            ckhKHMOI.Checked = false;
            chk_KHDD.Checked = false;
            dt = ConvertKhachHangDTOArrayToDataTable(ws.getListKhachHang());
            bdSource.DataSource = dt;
            dataGridKH.DataSource = bdSource;
        }
        public void dp_Bindind()
        {
            bdSource.DataSource = dt;
            txt_CMND.DataBindings.Add("Text", bdSource, "CMND");
            txt_DiaChi.DataBindings.Add("Text", bdSource, "DiaChi");
            txt_MaKHDD.DataBindings.Add("Text", bdSource, "KhachHangDaiDien");
            txt_LoaiKH.DataBindings.Add("Text", bdSource, "MaLoaiKH");
            txt_MaKH.DataBindings.Add("Text", bdSource, "MaKhachHang");
            //cmb_MaLoaiKH.DataBindings.Add("SelectedValue", bdSource, "MaKhachHang");
            txt_TenKH.DataBindings.Add("Text", bdSource, "TenKhachHang");
        }
        private void LoadLoaiKhachHang()
        {
            cmb_MaLoaiKH.DataSource = ConvertLoaiKhachHangDTOArrayToDataTable(ws.getListLoaiKhachHang());
            cmb_MaLoaiKH.DisplayMember = "TenLoaiKH";
            cmb_MaLoaiKH.ValueMember = "MaLoaiKH";
        }
        private void reset()
        {
            txt_CMND.Text = "";
            txt_DiaChi.Text = "";
            txt_MaKHDD.Text = "";
            txt_LoaiKH.Text = "";
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";

        }
        public static string getMaKhachHang()
        {
            return "";
        }
        private void ckhKHMOI_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhKHMOI.Checked == true)
            {
                chk_searchKHDD.Enabled = false;
                this.reset();
                cmbSearch.Text = "";
                txt_MaKH.Text = ws.NextID();
                cmbSearch.Enabled = false;
                btSearch.Enabled = false;
                txt_MaKHDD.Enabled = true;
                lbl_KHDD.Enabled = true;
                chk_KHDD.Enabled = true;
                txt_CMND.Enabled = true;
                txt_DiaChi.Enabled = true;
                txt_LoaiKH.Visible = false;
                cmb_MaLoaiKH.Visible = true;
                btAdd.Enabled = true;
                btDelete.Enabled = true;
                //btSearch.Enabled = true;
                btUpdate.Enabled = true;
                txt_MaKH.Enabled = false;
                txt_TenKH.Enabled = true;
                if (chk_KHDD.Checked == true)
                    chk_KHDD.Checked = false;
                if (AddKhachHang == 0)
                {
                    AddKhachHang = 1; // Đợi khi thêm thực sự mới reset biến này về 0
                    DataRow dr = dt.NewRow();
                    dr["MaKhachHang"] = txt_MaKH.Text;
                    dt.Rows.Add(dr);
                    bindingNavigatorKH.BindingSource.MoveLast();
                }
            }
            else if(ckhKHMOI.Checked == false)
            {
                //chk_searchKHDD.Enabled = true
                this.reset();
                cmbSearch.Enabled = true;
                btSearch.Enabled = true;
                // 
                txt_MaKHDD.Enabled = false;
                lbl_KHDD.Enabled = false;
                chk_KHDD.Enabled = false;
                txt_CMND.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_LoaiKH.Visible = true;

                cmb_MaLoaiKH.Visible = false;
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                //btSearch.Enabled = false;
                btUpdate.Enabled = false;
                txt_MaKH.Enabled = false;
                txt_MaKH.Text = "";
            }

        }

        private void chk_KHDD_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_KHDD.Checked == true)
            {
                lbl_KHDD.Enabled = false;
                txt_MaKHDD.Enabled = false;
                txt_MaKHDD.Text = "";
            }
            else
            {
                lbl_KHDD.Enabled = true;
                txt_MaKHDD.Enabled = true;
            }
        }

        private void plKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void OnLoad_frmHoaDon()
        {
            txt_MaKHDD.Visible = false;
            chk_KHDD.Visible = false;
            ckhKHMOI.Visible = false;
            lbl_KHDD.Visible = false;
        }
        public void OnLoad_frmKhachHang()
        {
            ckhKHMOI.Checked = true;
            //ckhKHMOI.Enabled = false;
        }
        private void cmb_MaLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_MaLoaiKH.Visible == true)
            {
                if (ckhKHMOI.Checked == false && chk_Edit.Checked==false)
                {
                    kDTO.MaLoaiKH = cmb_MaLoaiKH.SelectedValue.ToString();
                    dt.Reset();
                    dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangByKind(kDTO.MaLoaiKH));
                    bdSource.DataSource = dt;
                    dataGridKH.DataSource = bdSource;
                }
            }
        }
        private bool testVaild(int cmd)
        {
            // CMD==?1-Thêm :2-Sửa ; 3-Xóa: 
            if (txt_MaKH.Text.Equals("") && (cmd == 1 || cmd == 2 || cmd == 3))
            {
                MessageBox.Show("Mã khách hàng rỗng");
                return false;
            }
            if (ws.testExistsMaKhachHangInKHACHHANG(txt_MaKH.Text) == 0 && (cmd == 2 || cmd==3))
            {
                MessageBox.Show("Mã khách hàng không tồn tại");
                return false;
            }
            if (ws.testExistsMaKhachHangInKHACHHANG(txt_MaKH.Text) == 1 && cmd == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại" );
                return false;
            }
            if((chk_KHDD.Checked ==false && (txt_MaKHDD.Text.Equals("") || ws.testExistsMaKhachHangInKHACHHANG(txt_MaKHDD.Text)==0) && (cmd==1 || cmd==2)))
            {
                MessageBox.Show("Mã khách hàng đại diện không đúng");
                return false;
            }
            if (txt_TenKH.Text.Equals("") && (cmd == 1 || cmd==2))
            {
                MessageBox.Show("Tên khách hàng chưa có");
                return false;
            }
            if (cmb_MaLoaiKH.SelectedValue.ToString().Equals("") && cmd == 1)
            {
                MessageBox.Show("Loại khách hàng rỗng");
                return false;
            }
            if (ws.testExistsMaKhachHangInCTPHIEUTHUE(txt_MaKH.Text) > 0 && (cmd == 3 || cmd==2))
            {
                if(cmd==2)
                    MessageBox.Show("Không được sửa");
                if(cmd==3)
                    MessageBox.Show("Không được xóa");
                return false; 
            }
            if (txt_CMND.Text.Length > 9 && (cmd == 1 || cmd == 2))
            {
                MessageBox.Show("Số CMND quá 9 Ký Tự");
                return false;
            }
            if(ws.testMaKhachHangisKhachHangDaiDien(txt_MaKH.Text)==1 && (cmd==2|| cmd==3))
            {
                if(cmd==2)
                   MessageBox.Show("Khách hàng đại diện không được sửa");
                if(cmd==3)
                   MessageBox.Show("Khách hàng đại diện không được xóa");
                return false; 
            }
            return true;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if(testVaild(1))
            {
                kDTO.CMND = txt_CMND.Text;
                kDTO.DiaChi = txt_DiaChi.Text;
                kDTO.MaKhachHang = txt_MaKH.Text;
                if (chk_KHDD.Checked == false)
                    kDTO.KhachHangDaiDien = txt_MaKHDD.Text;
                else
                    kDTO.KhachHangDaiDien = "";

                kDTO.MaLoaiKH = cmb_MaLoaiKH.SelectedValue.ToString();
                kDTO.TenKhachHang = txt_TenKH.Text;
                kDTO.TenKhachHang_EN = ConvertUniCodeToANSI(txt_TenKH.Text);
                ws.InsertKhachHang(kDTO);
                MessageBox.Show("Thêm thành công");
                AddKhachHang = 0;
                refresh();
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (testVaild(3))
                {
                    kDTO.MaKhachHang = txt_MaKH.Text;
                    ws.DeleteKhachHang(kDTO.MaKhachHang);
                    refresh();
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            /*==> Cập nhật có 2 tình huống đối với Table KHACHHANG đặc biệt này
             *  1 - Cập nhật thông tin đơn thuần ( Tất cả trường ngoại trừ KhachHangDaiDien)
             *  2 - Cập nhật KhachHangDaiDien. Có các tình huống sau :
             *      + Khi khách hàng đó là KHDD : cần sửa lại là có khách hàng khác đại diện
             *        - Chưa có khách hàng nào tham chiếu tới 
             *          ---> Sửa dễ dàng chỉ cập nhật trường KHDD
             *        - Có khách hàng khác tham chiếu tới. Sẽ không cập nhật được vì lỗi khóa ngoại :
             *          ---> Hướng giải quyết 1 : Cập nhật KHDD những khách hàng nào có KHDD tham chiếu tới KH đang xét là NULL 
             *               tức là chính KH đó cũng là KHDD. Sau đó sửa lại như ý muốn.
             *          ---> Hướng giải quyết 2 : Không cho phép cập nhật
             *       + Khi khách hàng không phải là KHDD thì cứ việc cập nhật bình thường.
             *         - Chú ý : 
             *           + Khách hàng đại diện phải tồn tại.
             *                  
             * ==> Mô phỏng theo code : 
             *  XỬ LÝ ở GUI
             *  Sửa đơn thuần tất cả trường ngoài trường KHDD vs Sửa KHDD vốn dĩ không phân biệt được.
             *  Vì có 2 dạng :
             *  + Sửa đơn thuần thì cập nhật lại thông tin ngoài KHDD
             *  + Sư
             *  XỬLY1 ở DAO
              * 
             */ 
            if (testVaild(2))
            {
                kDTO.MaKhachHang = txt_MaKH.Text;
                kDTO.CMND = txt_CMND.Text;
                kDTO.DiaChi = txt_DiaChi.Text;

                // Nếu Checkbox không được chọn thì khách hàng đó không phải là khách hàng đại diện.
                if (chk_KHDD.Checked == false)
                    kDTO.KhachHangDaiDien = txt_MaKHDD.Text;
                else
                    kDTO.KhachHangDaiDien = "";

                kDTO.MaLoaiKH = cmb_MaLoaiKH.SelectedValue.ToString();
                kDTO.TenKhachHang = txt_TenKH.Text;
                kDTO.TenKhachHang_EN = ConvertUniCodeToANSI(txt_TenKH.Text);

                // Nếu trường hợp sửa gặp khách hàng chính là khách hàng đại diện.
                if (kDTO.MaKhachHang.Equals(kDTO.KhachHangDaiDien))
                    kDTO.KhachHangDaiDien = "";
                ws.UpdateKhachHang(kDTO);
                MessageBox.Show("Sửa thành công");
                refresh();
            }
        }
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reset();
            string[] strTitle={"Mã Khách Hàng","Tên Khách Hàng","Số CMND","Loại Khách Hàng","Địa Chỉ","Nhiều điều kiện","Khách hàng đại diện","Xem tất cả"};
            for (int i = 0; i < strTitle.Length; i++)
            {
                if(cmbSearch.Text.Equals(strTitle[i]))
                {
                    id_Search = i;
                    switch(i)
                    {
                        case 0:{
                            chk_searchKHDD.Enabled = true;
                            txt_MaKH.Enabled = true;
                            txt_CMND.Enabled = false;
                            txt_DiaChi.Enabled = false;
                            txt_MaKHDD.Enabled = false;
                            txt_LoaiKH.Visible = true;
                            cmb_MaLoaiKH.Visible = false;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = false;
                            
                            txt_MaKH.Focus();
                            break;
                        }
                        case 1:{
                            chk_searchKHDD.Enabled = false;
                            txt_MaKH.Enabled = false;
                            txt_CMND.Enabled = false;
                            txt_DiaChi.Enabled = false;
                            txt_MaKHDD.Enabled = false;
                            txt_LoaiKH.Visible = true;
                            cmb_MaLoaiKH.Visible = false;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = true;
                            txt_TenKH.Focus();
                            break;
                        }
                        case 2:{
                            chk_searchKHDD.Enabled = false;
                            txt_MaKH.Enabled = false;
                            txt_CMND.Enabled = true;
                            txt_DiaChi.Enabled = false;
                            txt_MaKHDD.Enabled = false;
                            txt_LoaiKH.Visible = true;
                            cmb_MaLoaiKH.Visible = false;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = false;
                            txt_CMND.Focus();
                            
                            break;
                        }
                        case 3:{
                            chk_searchKHDD.Enabled = false;
                            txt_MaKH.Enabled = false;
                            txt_CMND.Enabled = false;
                            txt_DiaChi.Enabled = false;
                            txt_MaKHDD.Enabled = false;
                            txt_LoaiKH.Visible = false;
                            cmb_MaLoaiKH.Visible = true;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = false;
                            cmb_MaLoaiKH.Focus();
                            break;
                        }
                        case 4:{
                            chk_searchKHDD.Enabled = false;
                            txt_MaKH.Enabled = false;
                            txt_CMND.Enabled = false;
                            txt_DiaChi.Enabled = true;
                            //txt_KHDD.Enabled = true;
                            txt_LoaiKH.Visible = true;
                            cmb_MaLoaiKH.Visible = false;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = false;
                            txt_DiaChi.Focus();
                            break;
                        }
                         case 5:
                         {
                            chk_searchKHDD.Enabled = false;
                            txt_MaKH.Enabled = false;
                            txt_CMND.Enabled = false;
                            txt_DiaChi.Enabled = true;
                            txt_MaKHDD.Enabled = false;
                            txt_LoaiKH.Visible = true;
                            cmb_MaLoaiKH.Visible = true;
                            txt_LoaiKH.Enabled = false;
                            txt_TenKH.Enabled = true;
                            txt_TenKH.Focus();
                             // set tabindex again
                            txt_TenKH.TabIndex = 1;
                            cmb_MaLoaiKH.TabIndex = 2;
                            txt_DiaChi.TabIndex = 3;
                            break;
                         }
                         case 6:
                         {
                             chk_searchKHDD.Enabled = false;
                             dt.Reset();
                             dt =ConvertKhachHangDTOArrayToDataTable(ws.getListKhachHangDaiDien());
                             bdSource.DataSource = dt;
                             dataGridKH.DataSource = bdSource;
                             break;
                         }
                         case 7:
                         {
                             chk_searchKHDD.Enabled = false;
                             dt.Reset();
                             dt = ConvertKhachHangDTOArrayToDataTable(ws.getListKhachHang());
                             bdSource.DataSource = dt;
                             dataGridKH.DataSource = bdSource;
                             break;
                         }
                    }

                }

            }
        }
        private string ConvertUniCodeToANSI(string str)
        {
            return str;
        }
    // "Mã Khách Hàng","Tên Khách Hàng","Số CMND","Loại Khách Hàng","Địa Chỉ","Nhiều điều kiện"};
        private void btSearch_Click(object sender, EventArgs e)
        {
            switch (id_Search)
            {
                case 0:
                    {
                        kDTO.MaKhachHang = txt_MaKH.Text;
                        dt.Reset();
                        if (chk_searchKHDD.Checked == false)
                            dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangById(kDTO.MaKhachHang));
                        else
                            dt =ConvertKhachHangDTOArrayToDataTable(ws.getListKhachHangDaiDienById(kDTO.MaKhachHang));
                        //MessageBox.Show(kBUS.getstrSQL());
                        break;
                    }
                case 1:
                    {
                        //kDTO.TenKhachHang = ConvertUniCodeToANSI(txt_TenKH.Text);
                        //dt.Reset();
                        //dt = kBUS.getListKhachHangByName("L");
                        //MessageBox.Show(kBUS.getstrSQL());
                        break;
                    }
                case 2:
                    {
                        kDTO.CMND = txt_CMND.Text;
                        dt.Reset();
                        dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangByCMND(kDTO.CMND));
                        break;

                    }
                case 3:
                    {
                        kDTO.MaLoaiKH = cmb_MaLoaiKH.SelectedValue.ToString();
                        dt.Reset();
                        dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangByKind(kDTO.MaLoaiKH));
                        break;

                    }
                case 4:
                    {
                        kDTO.DiaChi = txt_DiaChi.Text;
                        dt.Reset();
                        dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangByAddress(kDTO.DiaChi));
                        break;

                    }
                case 5:
                    {
                        kDTO.TenKhachHang = txt_TenKH.Text;
                        kDTO.MaLoaiKH = cmb_MaLoaiKH.Text;
                        kDTO.DiaChi = txt_DiaChi.Text;
                        dt.Reset();
                        dt = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangByMulti(kDTO.TenKhachHang, kDTO.MaLoaiKH, kDTO.DiaChi));
                        break;
                    }
            }// end switch
            // Gôm chung lại thay vì mỗi case phải thực hiện 2 lệnh này 
             //MessageBox.Show(kDTO.MaLoaiKH);
             bdSource.DataSource = dt;
             dataGridKH.DataSource = bdSource;
           
        }

        private void moreDetail_Click(object sender, EventArgs e)
        {
            DataTable tmp = new DataTable();
            if (txt_MaKHDD.Text.Equals(""))
                tmp = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangById(txt_MaKH.Text));
            else
                tmp = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangById(txt_MaKHDD.Text));
            if(tmp.Rows.Count>0)
                MessageBox.Show("KHÁCH HÀNG ĐẠI DIỆN : " + tmp.Rows[0]["TenKhachHang"]);
        }

        private void plKhachHang_Leave(object sender, EventArgs e)
        {
            staticMaKhachHang = txt_MaKH.Text;
            if(txt_MaKHDD.Text.Equals(""))
                staticMaKhachHangDaiDien = txt_MaKH.Text;
            else
                staticMaKhachHangDaiDien = txt_MaKHDD.Text;
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_Edit_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Edit.Checked ==true)
            {
                chk_searchKHDD.Enabled = false;
                cmbSearch.Text = "";
                cmbSearch.Enabled = false;
                btSearch.Enabled = false;
                txt_MaKHDD.Enabled = true;
                lbl_KHDD.Enabled = true;
                chk_KHDD.Enabled = true;
                txt_CMND.Enabled = true;
                txt_DiaChi.Enabled = true;
                txt_LoaiKH.Visible = false;
                cmb_MaLoaiKH.Visible = true;
                btAdd.Enabled = true;
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
                txt_MaKH.Enabled = false;
                txt_TenKH.Enabled = true;
                if (chk_KHDD.Checked == true)
                    chk_KHDD.Checked = false;
            }
            else
            {
                chk_searchKHDD.Enabled = false;
                cmbSearch.Enabled = true;
                btSearch.Enabled = true;
                txt_MaKHDD.Enabled = false;
                lbl_KHDD.Enabled = false;
                chk_KHDD.Enabled = false;
                txt_CMND.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_LoaiKH.Visible = true;

                cmb_MaLoaiKH.Visible = false;
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
                txt_MaKH.Enabled = false;
            }
        }

        private void txt_MaKHDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tmp = new DataTable();
            if (txt_MaKHDD.Text.Equals(""))
            {
                tmp =ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangById(txt_MaKH.Text));
                //txt_MaKHDD.Text = txt_MaKH.Text;
            }
            else
                tmp = ConvertKhachHangDTOArrayToDataTable(ws.getKhachHangById(txt_MaKHDD.Text));
            if (tmp.Rows.Count > 0)
                txt_TenKHDD.Text = tmp.Rows[0]["TenKhachHang"].ToString();

            //if (id_Search == 3)
            //{
            //    cmb_MaLoaiKH.Visible = false;
            //    txt_LoaiKH.Visible = true;
            //}
        }

        private void dataGridKH_MouseLeave(object sender, EventArgs e)
        {
            //if (id_Search == 3)
            //{
            //    cmb_MaLoaiKH.Visible = true;
            //    txt_LoaiKH.Visible = false;
            //}
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (id_Search == 0)
            {
                //txt_MaKH.DataBindings.Remove();
                //kDTO.MaKhachHang = txt_MaKH.Text;
                //dt.Reset();
                //if (chk_searchKHDD.Checked == false)
                //    dt = kBUS.getKhachHangById(kDTO.MaKhachHang);
                //else
                //    dt = kBUS.getListKhachHangDaiDienById(kDTO.MaKhachHang);

                //bdSource.DataSource = dt;
                //dataGridKH.DataSource = bdSource;
            }
        }
    }
}
