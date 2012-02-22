using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using _042082.QLKS_BUS_WebService;


namespace _042082.UserControls
{
    public partial class urlTraCuuPhong : UserControl
    {
        public QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        public static int run;
        public static string staticMaPhong;
        public static int OnPhieuThue;
        public static int OnTraCuuPhong;
        int Enter_Leave=0;
        // Điều kiện cần tìm kiếm. VD : 0 là tìm theo Mã Phòng; 1 Tìm theo Loại Phòng...
        int id_Search;
        PhongDTO pDTO = new PhongDTO();
        //PhongBUS pBUS = new PhongBUS();
        DataTable dt = new DataTable();
        BindingSource bdSource = new BindingSource();

        public DataTable ConvertPhongDTOtoDataTable(PhongDTO[] pDTOArr)
        {
            DataTable dt = new DataTable();
            int row = pDTOArr.Length;
            dt.Columns.Add("MaPhong", typeof(string));

            dt.Columns.Add("MaLoaiPhong", typeof(string));
            dt.Columns.Add("TinhTrang", typeof(int));
            dt.Columns.Add("GhiChu", typeof(string));
            dt.Columns.Add("DonGia", typeof(int));
            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(pDTOArr[i].MaPhong, pDTOArr[i].MaLoaiPhong, pDTOArr[i].TinhTrang, pDTOArr[i].GhiChu, pDTOArr[i].DonGia);

            }

            return dt;

        }
        public urlTraCuuPhong()
        {
            InitializeComponent();
            if (_042082.UserControls.urlTraCuuPhong.run == 1)
            {
                dt = ConvertPhongDTOtoDataTable(ws.getListPhong());
                dp_binding();
                dataGrid_DMP.DataSource = bdSource;
            }
            if (OnTraCuuPhong == 1)
            {
                this.dataGrid_DMP.Size = new System.Drawing.Size(700, 400);
            }
            
            
        }
        private void dp_binding()
        {
            bdSource.DataSource = dt;
            txt_LoaiPhong.DataBindings.Add("Text", bdSource, "MaLoaiPhong");
            txt_MaPhong.DataBindings.Add("Text", bdSource, "MaPhong");
        }
        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strTitle = {"Mã Phòng", "Loại Phòng", "Tình Trạng", "Nhiều điều kiện","Xem tất cả"};
            for (int i = 0; i < strTitle.Length; i++)
            {
                if (cmbSearch.Text==strTitle[i])
                {
                    id_Search = i;
                    switch(i)
                    {
                        case 0: {
                            txt_MaPhong.Enabled = true;
                            cmb_LoaiPhong.Enabled = false;
                            grbox_TinhTrang.Enabled = false;
                            break; 
                        }
                        case 1: {
                            this.LoadComBoBox();
                            txt_MaPhong.Enabled = false;
                            cmb_LoaiPhong.Enabled = true;
                            grbox_TinhTrang.Enabled = false;
                           // 
                            // Enable combobox
                            cmb_LoaiPhong.Visible = true;
                            txt_LoaiPhong.Visible = false;
                            break;
                        }
                        case 2:
                        {
                            txt_MaPhong.Enabled = false;
                            cmb_LoaiPhong.Enabled = false;
                            grbox_TinhTrang.Enabled = true;
                            //
                            break;
                        }
                        case 3: {
                            LoadComBoBox();
                            txt_MaPhong.Text = "";
                            txt_MaPhong.Enabled = false;
                            cmb_LoaiPhong.Enabled = true;
                            grbox_TinhTrang.Enabled = true;
                            //
                            break;
                        }
                        case 4:
                        {
                            txt_MaPhong.Text = "";
                            txt_MaPhong.Enabled = false;
                            cmb_LoaiPhong.Enabled = true;
                            grbox_TinhTrang.Enabled = true;
                            
                            dt = ConvertPhongDTOtoDataTable(ws.getListPhong());
                            bdSource.DataSource = dt;
                            dataGrid_DMP.DataSource = bdSource;
                            break;
                        }
                    }
                }
            }
        }
        private void LoadComBoBox()
        {
            cmb_LoaiPhong.DataSource = ws.getListLoaiPhong();
            cmb_LoaiPhong.DisplayMember = "MaLoaiPhong";
            cmb_LoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            switch(id_Search)
            {
                // Những thao tác này không cần nhấn nút tìm vì viết trên mỗi sự kiện của từng coponents
                case 0:
                {
                    // Do use bdSource khi nấn nút search thì datagridview bị thay đổi do dt.reset nên textbox bị xóa trắng.
                    // Gán em txtbox trước khi reset table
                    pDTO.MaPhong = txt_MaPhong.Text;
                    dt.Reset();
                    
                    dt = ConvertPhongDTOtoDataTable(ws.searchPhongById(pDTO.MaPhong));
                    bdSource.DataSource = dt;
                    dataGrid_DMP.DataSource = bdSource;
                    break;
                }
                case 1: break;
                case 2: break;
                case 3:
                {
                    dt.Reset();
                    pDTO.MaPhong = txt_MaPhong.Text;
                    pDTO.MaLoaiPhong = cmb_LoaiPhong.Text;
                    pDTO.TinhTrang = rdb_Trong.Checked == true ? 0 : 1;
                    dt = ConvertPhongDTOtoDataTable(ws.searchPhongByTuaLuaHotDua(pDTO.MaLoaiPhong, pDTO.TinhTrang));
                    bdSource.DataSource = dt;
                    dataGrid_DMP.DataSource = bdSource;
                    break;
                }

            }

        }

        private void txt_MaPhong_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void rdb_Trong_CheckedChanged(object sender, EventArgs e)
        {
            dt.Reset();
            pDTO.TinhTrang = rdb_Trong.Checked == true ? 0 : 1;
            dt = ConvertPhongDTOtoDataTable(ws.searchPhongByStatus(pDTO.TinhTrang));
            bdSource.DataSource = dt;
            dataGrid_DMP.DataSource = bdSource;
        }

        private void rdb_DangThue_CheckedChanged(object sender, EventArgs e)
        {
            /*
            dt.Reset();
            pDTO.TinhTrang = rdb_DangThue.Checked == true ? 1 : 0;
            dt = pBUS.searchPhongByStatus(pDTO.TinhTrang);
            dataGrid_DMP.DataSource = bdSource;
            */
        }

        private void cmb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] tmp = cmb_LoaiPhong.Text.Split(new string[] {"Loại"});
            dt.Reset();
            //LoadComBoBox();
            pDTO.MaLoaiPhong = cmb_LoaiPhong.Text;
            dt = ConvertPhongDTOtoDataTable(ws.searchPhongByKind(pDTO.MaLoaiPhong));
            bdSource.DataSource = dt;
            dataGrid_DMP.DataSource = bdSource;
        }

        private void  dataGrid_DMP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            // Do thuộc tính Text Change nên khi click trên lưới nó chỉ còn 1 record
            DataRow irow = dt.Rows[dataGrid_DMP.CurrentRow.Index];
            if (dataGrid_DMP.CurrentRow.Index < dataGrid_DMP.RowCount-1)
            {
                
                txt_MaPhong.Text = irow["MaPhong"].ToString();
                txt_LoaiPhong.Text = irow["MaLoaiPhong"].ToString();
                if (irow["TinhTrang"].ToString() == "0")
                    lbl_status.Text = "Trống";
                else
                    lbl_status.Text = "Đang thuê";
             }
             */
            
        }

        private void plLoaiPhong_Leave(object sender, EventArgs e)
        {
            staticMaPhong = txt_MaPhong.Text;
            if (OnPhieuThue == 1)
            {
                if (Enter_Leave == 1)
                    Enter_Leave = 0;
            }
        }

        private void urlTraCuuPhong_Enter(object sender, EventArgs e)
        {
        }

        private void plLoaiPhong_Enter(object sender, EventArgs e)
        {
        }

        private void plLoaiPhong_MouseEnter(object sender, EventArgs e)
        {


        }

        private void plLoaiPhong_MouseLeave(object sender, EventArgs e)
        {
            if(OnPhieuThue==1)
                Enter_Leave = 0;
        }

        private void dataGrid_DMP_Click(object sender, EventArgs e)
        {
            if (OnPhieuThue == 1)
            {
                if (Enter_Leave == 0)
                {
                    Enter_Leave = 1;
                    grbox_TinhTrang.Enabled = true;
                    rdb_Trong.Checked = true;
                }
            }
        }

        private void dataGrid_DMP_MouseEnter(object sender, EventArgs e)
        {
            if (id_Search == 1)
            {
                cmb_LoaiPhong.Visible = false;
                txt_LoaiPhong.Visible = true;
            }
            
        }

        private void dataGrid_DMP_MouseLeave(object sender, EventArgs e)
        {
            if (id_Search == 1)
            {
                cmb_LoaiPhong.Visible = true;
                txt_LoaiPhong.Visible = false;
            }
        }
    }
}
