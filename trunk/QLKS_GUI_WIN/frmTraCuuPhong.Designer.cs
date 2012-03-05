namespace _042082
{
    partial class frmTraCuuPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.urlTraCuuPhong1 = new _042082.UserControls.urlTraCuuPhong();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tra cứu phòng";
            // 
            // urlTraCuuPhong1
            // 
            this.urlTraCuuPhong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.urlTraCuuPhong1.Location = new System.Drawing.Point(3, 64);
            this.urlTraCuuPhong1.Name = "urlTraCuuPhong1";
            this.urlTraCuuPhong1.Size = new System.Drawing.Size(510, 270);
            this.urlTraCuuPhong1.TabIndex = 0;
            // 
            // frmTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTraCuuPhong1);
            this.Name = "frmTraCuuPhong";
            this.Text = "frmTraCuuPhong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuPhong_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.urlTraCuuPhong urlTraCuuPhong1;
        private System.Windows.Forms.Label label1;
    }
}