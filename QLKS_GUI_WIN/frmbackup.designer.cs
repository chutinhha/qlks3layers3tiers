namespace _042082
{
    partial class frmbackup
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btduongdan = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.txtduongdan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btbackup = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.btduongdan);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btthoat);
            this.panelEx1.Controls.Add(this.txtduongdan);
            this.panelEx1.Controls.Add(this.btbackup);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(572, 262);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btduongdan
            // 
            this.btduongdan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btduongdan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btduongdan.Location = new System.Drawing.Point(444, 115);
            this.btduongdan.Name = "btduongdan";
            this.btduongdan.Size = new System.Drawing.Size(69, 27);
            this.btduongdan.TabIndex = 22;
            this.btduongdan.Text = "Browse";
            this.btduongdan.Click += new System.EventHandler(this.btduongdan_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(188, 29);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(240, 41);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "Backup cơ sở dữ liệu";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(153, 117);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 20);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Tên csdl";
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(348, 170);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(66, 27);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtduongdan
            // 
            // 
            // 
            // 
            this.txtduongdan.Border.Class = "TextBoxBorder";
            this.txtduongdan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduongdan.Location = new System.Drawing.Point(269, 115);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(169, 27);
            this.txtduongdan.TabIndex = 0;
            // 
            // btbackup
            // 
            this.btbackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btbackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbackup.Location = new System.Drawing.Point(273, 170);
            this.btbackup.Name = "btbackup";
            this.btbackup.Size = new System.Drawing.Size(69, 27);
            this.btbackup.TabIndex = 2;
            this.btbackup.Text = "Backup";
            this.btbackup.Click += new System.EventHandler(this.btbackup_Click);
            // 
            // frmbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 262);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmbackup";
            this.Text = "frmbackup";
            this.Load += new System.EventHandler(this.frmbackup_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmbackup_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btduongdan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtduongdan;
        private DevComponents.DotNetBar.ButtonX btbackup;

    }
}