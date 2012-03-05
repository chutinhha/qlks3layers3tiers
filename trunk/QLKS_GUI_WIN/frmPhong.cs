using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _042082.QLKS_BUS_WebService;
namespace _042082
{
    /* BindingNavigator. 
     *  Chưa viết các Components trên BindingNavigator.
     *  Save All
     *  Add
     *  Delete : Khi xóa tự động Focus lên hàng trên. 
     *  Làm sai dữ liệu cần xóa và bị lỗi khi Mã Phòng đó còn tồn tại bên phiếu thuê phòng
     *  Khi có đối tượng này không cần viết hàm bắt các sự kiện trên Gridview
     * 
     */
    public partial class frmPhong : DevComponents.DotNetBar.Office2007Form
    {
        QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        LoaiPhongDTO lpDTO = new LoaiPhongDTO();
        PhongDTO pDTO = new PhongDTO();
        //BUS.PhongBUS pBUS = new BUS.PhongBUS();
        //BUS.LoaiPhongBUS lpBUS = new BUS.LoaiPhongBUS();
        BindingSource bdSource = new BindingSource();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataTable ConvertLoaiPhongDTOToDataTable(LoaiPhongDTO[] lpDTOArr)
        {
            DataTable dt = new DataTable();
            int row = lpDTOArr.Length;
            dt.Columns.Add("MaLoaiPhong", typeof(string));
            dt.Columns.Add("TenLoaiPhong", typeof(string));
            dt.Columns.Add("DonGia", typeof(int));
            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(lpDTOArr[i].MaLoaiPhong, lpDTOArr[i].TenLoaiPhong, lpDTOArr[i].DonGia);
            }
            return dt;
        }
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
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmLOAIPHONG_Load(object sender, EventArgs e)
        {
            // Load ComBoBox
            cmb_LoaiPhong.DataSource = ws.getListLoaiPhong();
            cmb_LoaiPhong.DisplayMember = "MaLoaiPhong";
            cmb_LoaiPhong.ValueMember = "MaLoaiPhong";
            // Load Column MaLoaiPhong trên DataGridview
            MaLoaiPhong.DataSource = ws.getListLoaiPhong();
            MaLoaiPhong.DisplayMember = "MaLoaiPhong";
            MaLoaiPhong.ValueMember = "MaLoaiPhong";

            /* Tạo column trong datagridview ;
            DataGridViewComboBoxColumn gvcl = new DataGridViewComboBoxColumn();
            gvcl.DataSource = lpBUS.igetListLoaiPhong();
            gvcl.ValueMember = "MaLoaiPhong";
            gvcl.DisplayMember = "TenLoaiPhong";
            */
            // Actionlistener combobox MaLoaiPhong
            //this.MaLoaiPhong.Selected += new System.EventHandler(this.MaLoaiPhong_SelectedIndexChanged);


            // Binding Source
            dt = ConvertPhongDTOtoDataTable(ws.getListPhong());
            bdSource.DataSource = dt;
            txt_MaPhong.DataBindings.Add("Text", bdSource, "MaPhong");
            txt_DonGia.DataBindings.Add("Text", bdSource, "DonGia");
            txt_GhiChu.DataBindings.Add("Text", bdSource, "GhiChu");
            cmb_LoaiPhong.DataBindings.Add("SelectedValue", bdSource, "MaLoaiPhong");
            
            bindingNavigatorPhong.BindingSource = bdSource;
            dataGridDoanhMucPhong.DataSource = bdSource;
        }
        private void refresh()
        {
            dt = ConvertPhongDTOtoDataTable(ws.getListPhong());
            bdSource.DataSource = dt;
            bindingNavigatorPhong.BindingSource = bdSource;
            dataGridDoanhMucPhong.DataSource = bdSource;
        }
        private bool testAdd(PhongDTO pDTO)
        {
            pDTO.MaPhong = txt_MaPhong.Text;
            if (pDTO.MaPhong.Equals(""))
            {
                MessageBox.Show("Mã phòng không được rỗng");
                return false;
            }
            if (pDTO.MaPhong.Length > 4)
            {
                MessageBox.Show("Không vượt quá 4 ký tự");
                return false;
            }
            if (ws.testExistMaPhongInPhieuThue(pDTO.MaPhong)==1)
            {
                MessageBox.Show("Mã Phòng đã tồn tại");
                return false;
            }
            return true;
        }
        private void addPhong(PhongDTO pDTO)
        {
            if (testAdd(pDTO)) // testAdd(pDTO)==true
            {
                // MaPhong phia trên để test
                pDTO.GhiChu = txt_GhiChu.Text;
                pDTO.MaLoaiPhong = cmb_LoaiPhong.Text;

                ws.InsertPhong(pDTO);
                MessageBox.Show("OK");
                refresh();
            }

        }
        private void cmb_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lpDTO.MaLoaiPhong = cmb_LoaiPhong.Text;
            txt_DonGia.Text = ws.getDonGiaByLoaiPhong(lpDTO.MaLoaiPhong).ToString();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            this.addPhong(pDTO);
            bindingNavigatorPhong.BindingSource.MoveLast();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["MaPhong"] = "";
            dr["MaLoaiPhong"] = "";
           // dr["DonGia"] = lpBUS.getDonGiaByMaLoaiPhong(dr["MaLoaiPhong"].ToString());
            dr["GhiChu"] = "";
            //da.Update(dt);
            bindingNavigatorPhong.BindingSource.MoveLast();

            refresh();

        }

        private void dataGridDoanhMucPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int irow = e.RowIndex;
            string valMaLoaiPhong;
            //DataGridViewComboBoxCell MLP = dataGridDoanhMucPhong.Rows[irow].Cells["MaLoaiPhong"];
            valMaLoaiPhong = dataGridDoanhMucPhong.Rows[irow].Cells["MaLoaiPhong"].Value.ToString();
            dataGridDoanhMucPhong.Rows[irow].Cells["MaLoaiPhong"].Value = lpBUS.getDonGiaByMaLoaiPhong(valMaLoaiPhong).ToString();
            */
            //MaLoaiPhong.
        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[5] = 5;
            foreach (DevComponents.DotNetBar.Office2007Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            pDTO.MaPhong = txt_MaPhong.Text;
            if (ws.testExistMaPhongInPhieuThue(pDTO.MaPhong) >= 1)
            {
                MessageBox.Show(this, "Không được xóa phòng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ws.DeletePhong(pDTO.MaPhong);
                refresh();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show(this, "Bạn muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                this.Dispose();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            pDTO.MaPhong = txt_MaPhong.Text.ToString();
            //
            pDTO.MaLoaiPhong = cmb_LoaiPhong.Text.ToString();
            pDTO.GhiChu = txt_GhiChu.Text.ToString();
            pDTO.TinhTrang = 0;
            ws.UpdatePhongInfo(pDTO);
            refresh();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            pDTO.MaPhong = txt_MaPhong.Text;
            ws.DeletePhong(pDTO.MaPhong);
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            pDTO.MaPhong = txt_MaPhong.Text;
            dt = ConvertPhongDTOtoDataTable(ws.searchPhongById(pDTO.MaPhong));
            dataGridDoanhMucPhong.DataSource = dt;
        }
    }
}