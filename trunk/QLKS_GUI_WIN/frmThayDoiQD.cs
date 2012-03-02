using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _042082.QLKS_BUS_WebService;
namespace _042082
{
    public partial class frmThayDoiQD : DevComponents.DotNetBar.Office2007Form
    {
        
        
        //LoaiPhongBUS busLP = new LoaiPhongBUS();
        LoaiPhongDTO dtoLP = new LoaiPhongDTO();
        //ThamSoBUS busTS = new ThamSoBUS();
        int kt = 0;
        public frmThayDoiQD()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
           // tabControlThayDoiQD.TabItemClose(tabItemThamSo);
        }

        private void frmThayDoiQD_Load(object sender, EventArgs e)
        {
            btSave.Enabled = false;
            option_tyle.Checked = true;
            GetlistLP();
            getListTS();
            hien_nut();

        }
        public System.Data.DataTable ConvertLoaiPhongDTOToDataTable(LoaiPhongDTO[] lpDTOArr)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
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
        void GetlistLP()
        {
            DataTable dt = new DataTable();
            dt = ConvertLoaiPhongDTOToDataTable(new QLKS_BUS_WebserviceSoapClient().getListLoaiPhong());
            dataGridLP.DataSource = null;
            dataGridLP.DataSource = dt;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dataGridLP.Rows.Add(i + 1, dt.Rows[i]["MaLoaiPhong"].ToString(), dt.Rows[i]["TenLoaiPhong"].ToString(), dt.Rows[i]["DonGia"].ToString());
            //}
        }
        void info()
        {
            dtoLP.MaLoaiPhong = txt_MaLoaiphong.Text.Trim().ToString();
            dtoLP.TenLoaiPhong = txt_TenLoaiPhong.Text.Trim().ToString();
            dtoLP.DonGia = int.Parse(txt_DonGia.Text.Trim().ToString());
        }
        bool KiemTra_rong()
        {
            if (txt_MaLoaiphong.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại phòng không được rỗng!");
                txt_MaLoaiphong.Focus();
                return true;
            }
            if (txt_DonGia.Text.Trim()== "")
            {
                MessageBox.Show("Đơn giá không được rỗng!");
                txt_DonGia.Focus();
                return true;
            }
           
            return false;
        }
      
        private void an_nut()
        {
            btSave.Enabled = true;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
        }
        private void hien_nut()
        {
            btSave.Enabled = false;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            kt = 1;
            txt_MaLoaiphong.Focus();
            an_nut();
            XoaTrang();


        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            string maLP = txt_MaLoaiphong.Text.Trim().ToString();
            QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
            if (MessageBox.Show(this, "Bạn muốn xóa loại phòng "+ maLP +" này ko", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int kt_using = ws.KiemTra_Using(maLP);
                if (kt_using == 0)
                {
                    int kt_xoa = ws.delete(maLP);
                    if (kt_xoa == 1)
                    {
                        frmThayDoiQD_Load(null, null);
                        MessageBox.Show("Xóa thành công!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Mã loại phòng này không đúng");
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại phòng này đang được sử dúng");
                }
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {
            txt_MaLoaiphong.Enabled = false;
            txt_TenLoaiPhong.Enabled = false;
            kt = 2;
            an_nut();
            txt_DonGia.Focus();


        }

        private void dataGridLP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridLP_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int r = this.dataGridLP.CurrentCell.RowIndex;
                int c = this.dataGridLP.CurrentCell.ColumnIndex;
                txt_MaLoaiphong.Text = dataGridLP.Rows[r].Cells[1].Value.ToString();
                txt_TenLoaiPhong.Text = dataGridLP.Rows[r].Cells[2].Value.ToString();
                txt_DonGia.Text = dataGridLP.Rows[r].Cells[3].Value.ToString();
            }
            catch
            {
                
            }
         
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            //them
            QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
            if (kt == 1)
            {
                if (KiemTra_rong() == false)
                {
                    int kt_so = ws.KiemTra_So(txt_DonGia.Text.ToString());
                    if (kt_so == 1)
                    {
                        if (txt_DonGia.Text.Length < 15)
                        {
                            info();
                            int kt_maLP = ws.KiemTra_MaLP(dtoLP);
                            if (kt_maLP == 0)
                            {
                                ws.insertLoaiPhong(dtoLP);
                                frmThayDoiQD_Load(null, null);
                                MessageBox.Show("Thêm thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Mã loại phòng bị trùng!");
                                txt_MaLoaiphong.Focus();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số nhập vào quá lớn");
                            return;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số!");
                        txt_DonGia.Focus();
                        return;
                    }
                }
            }
            // sua
            if (kt == 2)
            {
                txt_MaLoaiphong.Enabled = false;
                
                int kiemtra_so = ws.KiemTra_So(txt_DonGia.Text.Trim().ToString());
                if (KiemTra_rong() == false)
                {
                    if (kiemtra_so == 1)
                    {
                        info();
                        ws.update(dtoLP);
                        frmThayDoiQD_Load(null, null);
                        MessageBox.Show("Sửa thành công");
                        txt_MaLoaiphong.Enabled = true;
                        txt_TenLoaiPhong.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số!");
                    }
                }
            }
            
           
        }
        private void XoaTrang()
        {
            txt_MaLoaiphong.Text = "";
            txt_TenLoaiPhong.Text = "";
            txt_DonGia.Text = "";
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            txt_MaLoaiphong.Enabled = true;
            txt_TenLoaiPhong.Enabled = true;
            hien_nut();
        }
        // BANG THAM SO


        private void getListTS()
        {
            DataTable dt = new DataTable();
            dataGridTS.DataSource = new QLKS_BUS_WebserviceSoapClient().getListThamSo();
            //dataGridTS.DataSource = dt;
        }
        private void btluu_Click(object sender, EventArgs e)
        {

            QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
            string GT = txt_giatri.Text.Trim().ToString();
            int kt_so = ws.KiemTra_So(GT);
            if (kt_so == 1)
            {
                float giatri = float.Parse(GT);
                int kt_chaylenh = 0;
                if (option_khachtoida.Checked == true)
                {
                    kt_chaylenh = ws.UpdateThamSo("1", giatri);
                }
                if (option_tyle.Checked == true)
                {
                    kt_chaylenh = ws.UpdateThamSo("2", giatri);
                }
                if (option_heso.Checked == true)
                {
                    kt_chaylenh = ws.UpdateThamSo("3", giatri);
                }
                if (kt_chaylenh == 1)
                {
                    MessageBox.Show("cập nhật thành công");
                    getListTS();
                }
                else
                {
                    MessageBox.Show("lỗi");
                }
            }
            else
            {
                MessageBox.Show("chuỗi nhập vào phải là số");
                txt_giatri.Focus();
            }
        }

        private void frmThayDoiQD_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[1] = 1;
        }
    }
}