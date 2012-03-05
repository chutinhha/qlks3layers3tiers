using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _042082.UserControls;
using _042082.QLKS_BUS_WebService;
namespace _042082

{
    /* Vie61t trigger Ngaày thuê phải nhõ hơn ngày trả....
     * Viết sửa lại chức năng TextChanged bên tìm phòng để dễ việc Copy phòng qua phiếu thuê
     */

    /* - Mô tả công việc 1 tý :D
     *  1. Khi nhấn nút Lập phiếu thì ngay lậo tức phần phiếu thuê sẽ bị vô hiệu hóa
     *      + Load ThamSo maxNumberKH 
     *      
     *  2. Focus tới vùng Chi Tiết Phiếu Thuê - Nhập dữ liệu
     *      + Mỗi lần thêm thì maxNumberKH -- 
     *      + Khi xóa một khách hàng đặt thuê - tức là xóa một chi tiết phiếu thuê thì maxNumberKH ++
     *      Nếu 
     * 
     * 
     * ===============> Chưa xử lý :
     *  Khi ở các phiếu thuê chưa thanh toán, cùng 1 khách hàng đại diện, thì các khách hàng con không được giống nhau
     *  
     */
    public partial class frmPhieuThue : DevComponents.DotNetBar.Office2007Form
    {
        //QLKS_BUS_WebService.
        PhieuThueDTO ptDTO = new PhieuThueDTO();
        //PhongBUS pBUS = new PhongBUS();
        BindingSource bdSource = new BindingSource();
        DataTable dt = new DataTable();
        //ThamSoBUS tsBUS = new ThamSoBUS();
        
        CTPhieuThueDTO ctptDTO = new CTPhieuThueDTO();
        int maxNumberKH=0; // Quy định = 3 - lấy csdl lên;
        int AddPhieuThue = 0; // Đánh dấu có ý định nhưng cho nhấn nút lập phiếu - Khi nhiều lần sẽ không hiệu lực
        // CTPT
        DataTable dtCTPT = new DataTable();
        BindingSource bdSourceCTPT = new BindingSource();
        QLKS_BUS_WebserviceSoapClient ws = new QLKS_BUS_WebserviceSoapClient();
        public frmPhieuThue()
        {
            _042082.UserControls.urlKhachHang.run = 1;
            _042082.UserControls.urlTraCuuPhong.run = 1;
            _042082.UserControls.urlTraCuuPhong.OnPhieuThue = 1;
            InitializeComponent();           
        }

        private void frmPhieuThue_Load(object sender, EventArgs e)
        {

            // Load tham số số KH tối đa trong 1 phòng
            maxNumberKH = Int32.Parse(ws.getValue(1).ToString());
            //chk_datesystem.Checked = true;
            
            // Lưới PhieuThue
            dt = ConvertPhieuTHueDTOArrayToDataTable(ws.getListPhieuThue());
            bdSource.DataSource = dt;
            txt_MaPhieuThue.DataBindings.Add("Text", bdSource, "MaPhieuThue");
            txt_MaPhong.DataBindings.Add("Text", bdSource, "MaPhong");
            //txt_MaLoaiPhong.DataBindings.Add("Text", bdSource, "MaLoaiPhong");
            txt_NgayThue.DataBindings.Add("Text", bdSource, "NgayThue");
            txt_NgayTra.DataBindings.Add("Text", bdSource, "NgayTra");
            //txt_MaCTPhieuThue.DataBindings.Add("Text",bdSource,"MaCTPT");
            txt_MaKHDD.DataBindings.Add("Text", bdSource, "KhachHangDaiDien");
            bindingNavigatorPhieuThue.BindingSource = bdSource;
            dataGridViewPhieuThue.DataSource = bdSource;

            // Lưới CT Phiếu Thuê
            //dataGridViewCTPhieuThue.DataSource = BUS.CTPhieuThueBUS.getList();
            dtCTPT =ConvertCTPhieuTHueDTOArrayToDataTable(ws.getListByMaPhieuThue(txt_MaPhieuThue.Text));
            bdSourceCTPT.DataSource = dtCTPT;
            // Binding
            txt_MaCTPhieuThue.DataBindings.Add("Text", bdSourceCTPT, "MaCTPT");
            txt_MaKH.DataBindings.Add("Text", bdSourceCTPT, "MaKhachHang");
            txt_MaPT.DataBindings.Add("Text", bdSourceCTPT, "MaPhieuThue");
            //
            bindingNavigatorCTPhieuThue.BindingSource = bdSourceCTPT;
            dataGridViewCTPhieuThue.DataSource = bdSourceCTPT;

        }
        private void getDateSystem()
        {
            txt_NgayThue.Enabled = false;
            chk_datesystem.Checked = true;
            txt_NgayThue.Text=DateTime.Today.ToString().Substring(0, 9);
        }

        private string DateVN(string text)
        {
            // 10/08/1989
            string VN = "";
            string[] tmp = text.Split(new char[] { '/' });
            VN = tmp[1] + "/" + tmp[0] + "/" + tmp[2];
            return VN;
        }
        private void chk_datesystem_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_datesystem.Checked == false)
            {
                txt_NgayThue.Enabled = true;
            }
            else
            {
                getDateSystem();
                txt_NgayThue.Enabled = false;
            }
        }

        private void bt_SendPhong_Click(object sender, EventArgs e)
        {
            if (ws.getTinhTrangByMaPhong(_042082.UserControls.urlTraCuuPhong.staticMaPhong) == "1")
            {
                MessageBox.Show("Phòng đang được thuê");
                return;
            }
            else
                this.txt_MaPhong.Text = _042082.UserControls.urlTraCuuPhong.staticMaPhong;
        }

        private void txt_MaPhong_TextChanged(object sender, EventArgs e)
        {
            ptDTO.MaPhong = txt_MaPhong.Text;
            txt_MaLoaiPhong.Text = ws.getMaLoaiPhongByMaPhong(ptDTO.MaPhong);
        }
        private string getIdAuto(string TienTo)
        {
            DateTime now = DateTime.Now;
            string id = TienTo + now.Day.ToString() + now.Month.ToString() + now.Year.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + now.Millisecond.ToString();
            return id;
        }
        private bool testVaild(int cmd)
        {
            // CMD ==> 1 - Thêm | 2 - Sửa | 3 - Xóa 
            if (txt_MaPhong.Text.Equals("") && (cmd==1 || cmd==2) )
            {
                MessageBox.Show("Mã phòng rỗng");
                return false;
            }
            if (ws.testExistMaPhong(txt_MaPhong.Text) == 0 && (cmd==1 || cmd==2)  )
            {
                MessageBox.Show("Mã phòng không tồn tại");
                return false;
            }
            if (ws.testExistsMaPhieuThueInPHIEUTHUE(txt_MaPhieuThue.Text) == 1 && cmd ==1)
            {
                MessageBox.Show("Mã phiếu thuê đã tồn tại");
                return false;
            }
            if ((txt_NgayTra.Text.Equals("") || txt_NgayThue.Text.Equals("")) && (cmd == 1 || cmd == 2))
            {
                MessageBox.Show("Ngày không hợp lệ");
                return false;
            }
            else if(cmd==1 || cmd==2)
            {
                long songaythue = datediff(DateTime.Parse(txt_NgayTra.Text), DateTime.Parse(txt_NgayThue.Text));
                if (songaythue < 0 && (cmd == 1 || cmd == 2))
                {
                    MessageBox.Show("Số Ngày Thuê = " + songaythue + " --> Không Hợp Lệ");
                    return false;
                }
            }
            //BUS.CTPhieuThueBUS.testExistsMaPhieuThueInCTPhieuThue(txt_MaPhieuThue.Text) > 0 ||
            if ((ws.testExistMaPhieuThueInCTHOADON(txt_MaPhieuThue.Text) > 0) && cmd == 3)
            {
                MessageBox.Show("Không xóa được - Hóa đơn chưa xóa hoặc chưa thanh toán");
                return false;
            }
            if (txt_MaKHDD.Text.Equals("") && cmd==1)
            {
                MessageBox.Show("Khách Hàng Đại Diện Rỗng");
                return false;
            }
            if (ws.testExistsMaPhieuThueInPHIEUTHUE(txt_MaPhieuThue.Text)== 0 && cmd == 3)
            {
                MessageBox.Show("Mã PT không tồn tại");
                
                return false;
            }
            if (ws.testExistsMaPhieuThueInPHIEUTHUE(txt_MaPhieuThue.Text) > 0)
            {
                // Khi câu if trên thỏa mãn mới action tiếp câu dưới
                if (ws.getTinhTrangPhieuThue(txt_MaPhieuThue.Text) == 0 && cmd == 3)
                {
                    MessageBox.Show("Mã phiếu thuê chưa thanh toán");
                    return false;
                }
            }
            return true;
        }

        private void refresh()
        {
            dt = ConvertPhieuTHueDTOArrayToDataTable(ws.getListPhieuThue());
            bdSource.DataSource = dt;
            bindingNavigatorPhieuThue.BindingSource = bdSource;
            dataGridViewPhieuThue.DataSource = bdSource;
            bindingNavigatorPhieuThue.BindingSource.MoveLast();
        }
        private void reset()
        {
            txt_MaLoaiPhong.Text = "";
            txt_NgayTra.Text = "";
            txt_MaPhong.Text = "";
            txt_NgayThue.Text = "";
            txt_NgayTra.Text = "";
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (testVaild(1))
            {
                ptDTO.MaPhieuThue = txt_MaPhieuThue.Text;
                ptDTO.MaPhong = txt_MaPhong.Text;
               
                ptDTO.NgayThue = DateTime.Parse(txt_NgayThue.Text);
                ptDTO.NgayTra = DateTime.Parse(txt_NgayTra.Text);
                // ===> bắt buộc = 0
                ptDTO.ThanhToan = "0";
                ptDTO.KhachHangDaiDien = txt_MaKHDD.Text;
                string strSQL = "Insert Into PHIEUTHUE (MaPhieuThue,NgayThue,NgayTra,MaPhong,ThanhToan,KhachHangDaiDien) Values('" + ptDTO.MaPhieuThue + "','" + ptDTO.NgayThue + "','" + ptDTO.NgayTra + "','" + ptDTO.MaPhong + "','" + ptDTO.ThanhToan + "','" + ptDTO.KhachHangDaiDien + "')";
                MessageBox.Show(strSQL);
                ws.InsertPhieuThue(ptDTO);
                //MessageBox.Show(BUS.PhieuThueBUS.getstrSQL());
                ws.UpdatePhongStatus(ptDTO.MaPhong, "1");
               
                AddPhieuThue = 0; // ===> đánh dấu đã save rồi.
                chk_Id_PT.Checked = false;
                MessageBox.Show("Thêm thành công");
               
                /* Focus vô vùng CTPT
                 * Phát sinh Mã CTPT
                 */
                refresh();
                txt_MaCTPhieuThue.Text = ws.NextIDCTPhieuThue();
                txt_MaPT.Text = txt_MaPhieuThue.Text;
            }
        }
        private void addContinue()
        {
            groupBoxGridPhieuThue.Enabled = false;
            //groupBoxNutXulyPT.Enabled = false;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btExit.Enabled = false;
            txt_MaPhong.Enabled = false;
            txt_NgayTra.Enabled = false;
            txt_MaKH.Enabled = true;
            txt_MaKH.Focus();
        }
        private bool testExistsInCTPhieuThue(string MaPhieuThue)
        {
            if (ws.testExistsMaPhieuThueInCTPhieuThue(MaPhieuThue) > 0)
            {
                MessageBox.Show("Không được xóa");
                return true;
            }
            return false;
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            //this.btDelete.Click += new System.EventHandler(this.btDelCT_Click);
            ptDTO.MaPhieuThue = txt_MaPhieuThue.Text;
            string[] listId = ws.getListMaCTPTByMaPhieuThue(ptDTO.MaPhieuThue).Split(new char[]{','});

            if (MessageBox.Show("Bạn Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (testVaild(3))
                {
                    for (int i = 0; i < listId.Length; i++)
                        ws.DeleteCTPhieuThue(listId[i]);
                    ws.DeletePhieuThue(ptDTO.MaPhieuThue);
                    refresh();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(testVaild(2)){
                    ptDTO.MaPhieuThue = txt_MaPhieuThue.Text;
                    ptDTO.MaPhong = txt_MaPhong.Text;
                    ptDTO.NgayThue = DateTime.Parse(txt_NgayThue.Text);
                    ptDTO.NgayTra = DateTime.Parse(txt_NgayTra.Text);
                    ptDTO.KhachHangDaiDien = txt_MaKhachHangDD.Text;

                    ws.UpdatePhieuThue(ptDTO);
                    MessageBox.Show("Sửa thành công");
                    refresh();
                }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn Muốn Thoát ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void chk_Id_PT_CheckedChanged(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            if (chk_Id_PT.Checked == true && AddPhieuThue==0)
            {
                bt_getMaKHDD.Enabled = true;
                bt_SendPhong.Enabled = true;
                AddPhieuThue = 1; // Đánh dấu
                reset();
                // Phát sinh mã tự động
                txt_MaPhieuThue.Text = ws.NextIDPhieuThue();

                getDateSystem();
              
                dr["MaPhieuThue"] = txt_MaPhieuThue.Text;
                dr["NgayThue"] = txt_NgayThue.Text;
                dt.Rows.Add(dr);
                bindingNavigatorPhieuThue.BindingSource.MoveLast();               
            }
            else
                if(AddPhieuThue==0)
                {
                    bt_getMaKHDD.Enabled = false;
                    bt_SendPhong.Enabled = false;
                    //dt.Rows.Remove(dr);
                    txt_MaPhieuThue.Text = "";
                    chk_datesystem.Checked = false;
                    dataGridViewPhieuThue.Focus();
                }
        }

        private void bt_SendKH_Click(object sender, EventArgs e)
        {
            // Nếu Mã khách Hàng đại diện của khách hàng đưa(staticKHDD) qua không phải là khách hàng đại diện trên phiếu thuê && chính khách hàng đó cụng không phải khách hàng đại diện 
            if (!txt_MaKHDD.Text.Equals(_042082.UserControls.urlKhachHang.staticMaKhachHangDaiDien) && !txt_MaKhachHangDD.Text.Equals(_042082.UserControls.urlKhachHang.staticMaKhachHang))
            {
                MessageBox.Show("Khách Hàng Đại Diện Không Khớp");
                return;
            }
            if (ws.testExistsMaKhachHangInCTPHIEUTHUE2(_042082.UserControls.urlKhachHang.staticMaKhachHang,txt_MaPT.Text) == 1)
            {
                MessageBox.Show("Khách hàng đã có");
                return;
            }
            if (ws.CountMaKhachHang(txt_MaPhieuThue.Text) == maxNumberKH && chk_MaKH.Checked == false )
            {
                /* Đến tận bi h mới biết khác nhau giữa đoạn lệnh 
                 if(a>b){
                   if(a>c){
                    // Khi vào đây sẽ như chim vào lồng ----> Lối nào cho em :D
                   }
                 }
                 vs 
                 if(a>b && a>c)                         ----> Cho em một con đường
                 =============> Hài quá :))
                 
                 if(chk_MaKH.Checked == false)
                 {
                 * 
                 */
                    MessageBox.Show("Đã đủ 3 khách hàng");
                    return;
                /*}*/

            }
            else
            {
                if(chk_MaKH.Checked==false)
                    txt_MaCTPhieuThue.Text = ws.NextIDCTPhieuThue();
                // Cho CTPT Groupbox
                txt_MaKH.Text = _042082.UserControls.urlKhachHang.staticMaKhachHang;
                // Cho PHieuThue GroupBox
                txt_MaKhachHangDD.Text = _042082.UserControls.urlKhachHang.staticMaKhachHangDaiDien;
                // Ủy quyền nút Add cho nút này - Không hiệu quả lắm
                //this.bt_SendKH.Click += new System.EventHandler(this.btAddCT_Click);
            }
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            KhachHangDTO[] khDTO = new KhachHangDTO[1];
            khDTO =  ws.getKhachHangById(txt_MaKH.Text);
            if (khDTO.Length > 0)
            {
                txt_MaKhachHangDD.Text = khDTO[0].KhachHangDaiDien.ToString();
                txt_TenKH.Text = khDTO[0].TenKhachHang.ToString();
            }
            else
            {
                txt_MaKhachHangDD.Text = "...";
                txt_TenKH.Text = "...";
            }
        }

        private void txt_MaKhachHangDD_TextChanged(object sender, EventArgs e)
        {
            KhachHangDTO[] khDTO = new KhachHangDTO[1];
            khDTO =  ws.getKhachHangById(txt_MaKhachHangDD.Text);
            if (khDTO.Length > 0)
                txt_TenKHDD.Text = khDTO[0].TenKhachHang.ToString();
            else
                txt_TenKHDD.Text = "...";
        }
        // CMD==?1:Thêm - 2 Xóa - 3 sửa
        private bool testVaildCTPT(int cmd)
        {
            if (txt_MaCTPhieuThue.Text.Equals("") && (cmd == 1 || cmd == 2 || cmd == 3))
            {
                MessageBox.Show("Mã Chi tiết PT rỗng");
                return false;
            }
            if (txt_MaKH.Text.Equals("") && (cmd == 1 || cmd == 3))
            {
                MessageBox.Show("Mã khách hàng rỗng");
                return false;
            }
            if (ws.testExistMaCTPTInCTPHIEUTHUE(txt_MaCTPhieuThue.Text) == 1 && cmd == 1)
            {
                MessageBox.Show("Mã Chi tiết phiếu thuê đã tồn tại");
                return false;
            }
            if (ws.testExistMaCTPTInCTPHIEUTHUE(txt_MaCTPhieuThue.Text) == 0 && (cmd == 2 || cmd == 3))
            {
                MessageBox.Show("Mã Chi tiết phiếu thuê không tồn tại");
                return false;
            }
            if (ws.testExistsMaKhachHangInCTPHIEUTHUE2(txt_MaKH.Text, txt_MaPT.Text) == 1 && (cmd == 1 || cmd == 3))
            {
                MessageBox.Show("Khách hàng đã có");
                return false;
            }
            if (ws.CountMaKhachHang(txt_MaPhieuThue.Text) == maxNumberKH && cmd==1)
            {
                MessageBox.Show("Đã đủ 3 khách hàng");
                return false;
            }
            if ((txt_MaPT.Text.Equals("") || ws.testExistsMaPhieuThueInPHIEUTHUE(txt_MaPT.Text)==0) && (cmd == 1|| cmd==3))
            {
                MessageBox.Show("Mã phiếu thuê không hợp lệ");
                return false;
            }
            return true;
        }
        private void btAddCT_Click(object sender, EventArgs e)
        {
            
            if (testVaildCTPT(1))
            {
                ctptDTO.MaCTPT = txt_MaCTPhieuThue.Text;
                ctptDTO.MaKhachHang = txt_MaKH.Text;
                
                ctptDTO.MaPhieuThue = txt_MaPhieuThue.Text;

                ws.InsertCTPhieuThue(ctptDTO);

                MessageBox.Show("Thêm thành công");
                
                refreshCTPT();
                resetCTPT();
            }
        }
        private void resetCTPT()
        {
            txt_MaCTPhieuThue.Text = ws.NextIDCTPhieuThue();
            txt_MaKH.Text = "";
            txt_MaKH.Focus();
            DataRow dr = dtCTPT.NewRow();
            dr["MaCTPT"] = txt_MaCTPhieuThue.Text;
            dr["MaPhieuThue"] = txt_MaPT.Text;
            dtCTPT.Rows.Add(dr);
            bindingNavigatorCTPhieuThue.BindingSource.MoveLast();
        }
        private void refreshCTPT()
        {
            dtCTPT.Reset();
            dtCTPT = ConvertCTPhieuTHueDTOArrayToDataTable(ws.getListByMaPhieuThue(txt_MaPhieuThue.Text));
            bdSourceCTPT.DataSource = dtCTPT;
            bindingNavigatorCTPhieuThue.BindingSource = bdSourceCTPT;
            dataGridViewCTPhieuThue.DataSource = bdSourceCTPT;
            if (chk_MaKH.Checked == true)
                chk_MaKH.Checked = false;
        }
        private void btDelCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (testVaildCTPT(2))
                {
                    ctptDTO.MaCTPT = txt_MaCTPhieuThue.Text;
                    ws.DeleteCTPhieuThue(ctptDTO.MaCTPT);
                    refreshCTPT();
                }
            }
        }

        private void btEditCT_Click(object sender, EventArgs e)
        {
            if(testVaildCTPT(3))
            {
                ctptDTO.MaCTPT = txt_MaCTPhieuThue.Text;
                ctptDTO.MaKhachHang = txt_MaKH.Text;
                ws.UpdateCTPhieuThue(ctptDTO);
                chk_MaKH.Checked = false;
                refreshCTPT();
            }
        }

        private void chk_MaCTPT_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MaCTPT.Checked == true)
                txt_MaCTPhieuThue.Enabled = true;
            else
                txt_MaCTPhieuThue.Enabled = false;
        }

        private void chk_MaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MaKH.Checked == false)
            {
                txt_MaKH.Enabled = false;
                chk_getId.Enabled = true;
                chk_MaPhieuThue.Enabled = true;
            }
            else
            {
                chk_getId.Enabled = false;
                chk_MaPhieuThue.Enabled = false;
                txt_MaKH.Enabled = true;
            }
        }

        private void chk_MaPhieuThue_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MaPhieuThue.Checked == false)
                txt_MaPT.Enabled = false;
            else
            {
                txt_MaPT.Enabled = true;
                txt_MaPT.Text = txt_MaPhieuThue.Text;
            }
        }

        private void chk_getId_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_getId.Checked == true)
                txt_MaCTPhieuThue.Text = ws.NextIDCTPhieuThue();
            else
                txt_MaCTPhieuThue.Text = "";
        }

        private void bt_getMaKHDD_Click(object sender, EventArgs e)
        {
            if (chk_Id_PT.Checked == false)
            {
                MessageBox.Show("Chức năng thêm mới chưa kích hoạt");
                return;
            }
            txt_MaKHDD.Text = urlKhachHang.staticMaKhachHangDaiDien;
        }

        private void txt_MaKHDD_TextChanged(object sender, EventArgs e)
        {
            KhachHangDTO[] khDTO = new KhachHangDTO[1];
            khDTO = ws.getKhachHangById(txt_MaKHDD.Text);
            if (khDTO.Length > 0)
                txt_TenKHDaiDien.Text = khDTO[0].TenKhachHang.ToString();
            else
                txt_TenKHDaiDien.Text = "...";
        }

        private void txt_MaPhieuThue_TextChanged(object sender, EventArgs e)
        {
            txt_MaPT.Text = txt_MaPhieuThue.Text;
            refreshCTPT();
        }

        private void txt_MaKhachHangDD_TextChanged_1(object sender, EventArgs e)
        {
            KhachHangDTO[] khDTO = new KhachHangDTO[1];
            khDTO = ws.getKhachHangById(txt_MaKhachHangDD.Text);
            if (khDTO.Length > 0)
            {
                txt_TenKHDD.Text = khDTO[0].TenKhachHang.ToString();
            }
            else
            {
                khDTO = ws.getKhachHangById(txt_MaKH.Text);
                if (khDTO.Length > 0)
                {
                    txt_MaKhachHangDD.Text = txt_MaKH.Text;
                    txt_TenKHDD.Text = khDTO[0].TenKhachHang.ToString();
                }
                else
                    txt_TenKHDD.Text = "...";
            }
        }

        private void urlKhachHang2_Load(object sender, EventArgs e)
        {

        }
        private bool testVailDate(DateTime dStart, DateTime dEnd)
        {
            return false;
        }
        private bool KtraNamNhuan(int Year)
        {
            bool flag = false;
            if (Year % 4 == 0 && Year % 100 != 0)
                flag = true;
            if (Year % 100 == 0)
                flag = false;
            return flag;
        }
        private int STTNgayTrongNam(DateTime d)
        {
            int[] nMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (KtraNamNhuan(d.Year))
                nMonth[1] = 29;
            int STT = 0;
            for (int i = 1; i <= d.Month - 1; i++)
                STT = STT + nMonth[i - 1];
            return STT + d.Day;
        }
        private long STTTuNgay1_1_1(DateTime d)
        {
            long STT = 0;
            for (int i = 1; i < d.Year - 1; i++)
            {
                STT = STT + 365;
                DateTime StartingDay = DateTime.Parse("1 / 1 /" + i.ToString());
                if (KtraNamNhuan(StartingDay.Year))
                    STT = STT + 1;
            }
            return STT + STTNgayTrongNam(d);

        }
        private long datediff(DateTime d1, DateTime d2)
        {
            long nd1 = STTTuNgay1_1_1(d1);
            long nd2 = STTTuNgay1_1_1(d2);
            return nd1 - nd2;
        }

        private void frmPhieuThue_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Main.activeFrom[3] = 3;
        }

        private void dataGridViewPhieuThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // NHOM HAM CONVERT DTO[] Sang DataTable

        public DataTable ConvertPhieuTHueDTOArrayToDataTable(PhieuThueDTO[] ptDTOArr)
        {
            DataTable dt = new DataTable();
            int row = ptDTOArr.Length;

            dt.Columns.Add("MaPhieuThue", typeof(string));
            dt.Columns.Add("NgayThue", typeof(DateTime));
            dt.Columns.Add("NgayTra", typeof(DateTime));
            dt.Columns.Add("HeSo", typeof(float));
            dt.Columns.Add("TienPhuThu", typeof(float));
            dt.Columns.Add("TienThue", typeof(float));
            dt.Columns.Add("MaPhong", typeof(string));
            dt.Columns.Add("ThanhToan", typeof(string));
            dt.Columns.Add("KhachHangDaiDien", typeof(string));

            for (int i = 0; i < row; i++)
            {
                dt.Rows.Add(ptDTOArr[i].MaPhieuThue, ptDTOArr[i].NgayThue, ptDTOArr[i].NgayTra, ptDTOArr[i].Heso, ptDTOArr[i].Tienphuthu, ptDTOArr[i].Tienthue, ptDTOArr[i].MaPhong, ptDTOArr[i].ThanhToan, ptDTOArr[i].KhachHangDaiDien);
            }
            return dt;
        }
        public DataTable ConvertCTPhieuTHueDTOArrayToDataTable(CTPhieuThueDTO[] ctptDTOArr)
        {
            DataTable dt = new DataTable();
            int row = ctptDTOArr.Length;
            dt.Columns.Add("MaCTPT", typeof(string));
            dt.Columns.Add("MaPhieuThue", typeof(string));
            dt.Columns.Add("MaKhachHang", typeof(string));
            dt.Columns.Add("TenKhachHang", typeof(string));
            dt.Columns.Add("MaLoaiKH", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("CMND", typeof(string));

           
            for (int i = 0; i < row; i++)
            {
                 KhachHangDTO[] kDTO = new KhachHangDTO[1];
                 kDTO = ws.getKhachHangById(ctptDTOArr[i].MaKhachHang);
                 dt.Rows.Add(ctptDTOArr[i].MaCTPT, ctptDTOArr[i].MaPhieuThue, ctptDTOArr[i].MaKhachHang, kDTO[0].TenKhachHang, kDTO[0].MaLoaiKH, kDTO[0].DiaChi, kDTO[0].CMND);
            }
            return dt;
        }
    }
}