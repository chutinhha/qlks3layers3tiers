namespace _042082
{
    partial class frmKhachHang
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
            this.urlKhachHang1 = new _042082.UserControls.urlKhachHang();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // urlKhachHang1
            // 
            this.urlKhachHang1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlKhachHang1.Location = new System.Drawing.Point(12, 41);
            this.urlKhachHang1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlKhachHang1.Name = "urlKhachHang1";
            this.urlKhachHang1.Size = new System.Drawing.Size(517, 407);
            this.urlKhachHang1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(130, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(289, 41);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Quản lý khách hàng";
            // 
            // frmKhachHang
            // 
            this.ClientSize = new System.Drawing.Size(537, 461);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.urlKhachHang1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.urlKhachHang urlKhachHang1;
        private DevComponents.DotNetBar.LabelX labelX1;

        //private _042082.UserControls.urlKhachHang uk;
        //private DevComponents.DotNetBar.LabelX labelX1;
    }
}