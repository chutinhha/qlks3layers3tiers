namespace _042082
{
    partial class frmrestore
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbthoat = new DevComponents.DotNetBar.ButtonX();
            this.btrestore = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            txtduongdan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btduongdan = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.tbthoat);
            this.panelEx1.Controls.Add(this.btrestore);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(txtduongdan);
            this.panelEx1.Controls.Add(this.btduongdan);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(560, 284);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(153, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(256, 47);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "Restore cơ sở dữ liệu";
            // 
            // tbthoat
            // 
            this.tbthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbthoat.Location = new System.Drawing.Point(290, 173);
            this.tbthoat.Name = "tbthoat";
            this.tbthoat.Size = new System.Drawing.Size(69, 27);
            this.tbthoat.TabIndex = 22;
            this.tbthoat.Text = "Thoát";
            this.tbthoat.Click += new System.EventHandler(this.tbthoat_Click);
            // 
            // btrestore
            // 
            this.btrestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btrestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btrestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrestore.Location = new System.Drawing.Point(209, 173);
            this.btrestore.Name = "btrestore";
            this.btrestore.Size = new System.Drawing.Size(69, 27);
            this.btrestore.TabIndex = 21;
            this.btrestore.Text = "Restore";
            this.btrestore.Click += new System.EventHandler(this.btrestore_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(103, 122);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 20);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Tên csdl";
            // 
            // txtduongdan
            // 
            // 
            // 
            // 
            txtduongdan.Border.Class = "TextBoxBorder";
            txtduongdan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtduongdan.Location = new System.Drawing.Point(209, 120);
            txtduongdan.Name = "txtduongdan";
            txtduongdan.Size = new System.Drawing.Size(169, 27);
            txtduongdan.TabIndex = 0;
            // 
            // btduongdan
            // 
            this.btduongdan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btduongdan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btduongdan.Location = new System.Drawing.Point(394, 122);
            this.btduongdan.Name = "btduongdan";
            this.btduongdan.Size = new System.Drawing.Size(69, 27);
            this.btduongdan.TabIndex = 2;
            this.btduongdan.Text = "Browse";
            this.btduongdan.Click += new System.EventHandler(this.btduongdan_Click);
            // 
            // frmrestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 284);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmrestore";
            this.Text = "frmrestore";
            this.Load += new System.EventHandler(this.frmrestore_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmrestore_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX tbthoat;
        private DevComponents.DotNetBar.ButtonX btrestore;
        private DevComponents.DotNetBar.LabelX labelX1;
        static public DevComponents.DotNetBar.Controls.TextBoxX txtduongdan;
        private DevComponents.DotNetBar.ButtonX btduongdan;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}