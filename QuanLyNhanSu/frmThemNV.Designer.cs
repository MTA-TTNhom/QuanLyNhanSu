namespace QuanLyNhanSu
{
    partial class frmThemNV
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
            this.dgvThemNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtMaPB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNV = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtCMT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBangCap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtDC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThemNV
            // 
            this.dgvThemNV.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvThemNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemNV.Location = new System.Drawing.Point(436, 86);
            this.dgvThemNV.Name = "dgvThemNV";
            this.dgvThemNV.Size = new System.Drawing.Size(610, 406);
            this.dgvThemNV.TabIndex = 17;
            this.dgvThemNV.SelectionChanged += new System.EventHandler(this.dgvThemNV_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvThemNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 499);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Image = global::QuanLiNhanSu.Properties.Resources.preferences_contact_list__1_1;
            this.labelX9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX9.Location = new System.Drawing.Point(386, 19);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(270, 61);
            this.labelX9.TabIndex = 20;
            this.labelX9.Text = "THÊM NHÂN VIÊN MỚI";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.txtTG);
            this.groupBox2.Controls.Add(this.labelX13);
            this.groupBox2.Controls.Add(this.txtDT);
            this.groupBox2.Controls.Add(this.labelX10);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.labelX12);
            this.groupBox2.Controls.Add(this.txtMaPB);
            this.groupBox2.Controls.Add(this.dateNS);
            this.groupBox2.Controls.Add(this.btnHienThi);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.labelX8);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.txtCMT);
            this.groupBox2.Controls.Add(this.txtBangCap);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.txtDC);
            this.groupBox2.Controls.Add(this.txtGT);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Location = new System.Drawing.Point(27, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 406);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTG
            // 
            // 
            // 
            // 
            this.txtTG.Border.Class = "TextBoxBorder";
            this.txtTG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTG.Location = new System.Drawing.Point(124, 306);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(227, 22);
            this.txtTG.TabIndex = 85;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(14, 303);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(98, 23);
            this.labelX13.TabIndex = 84;
            this.labelX13.Text = "Tôn giáo";
            // 
            // txtDT
            // 
            // 
            // 
            // 
            this.txtDT.Border.Class = "TextBoxBorder";
            this.txtDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDT.Location = new System.Drawing.Point(125, 272);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(227, 22);
            this.txtDT.TabIndex = 46;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(14, 264);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(95, 33);
            this.labelX10.TabIndex = 45;
            this.labelX10.Text = "Dân tộc";
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Location = new System.Drawing.Point(124, 244);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(227, 22);
            this.txtSDT.TabIndex = 42;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(14, 241);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(70, 23);
            this.labelX12.TabIndex = 41;
            this.labelX12.Text = "SĐT";
            // 
            // txtMaPB
            // 
            // 
            // 
            // 
            this.txtMaPB.Border.Class = "TextBoxBorder";
            this.txtMaPB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaPB.Location = new System.Drawing.Point(124, 184);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(227, 22);
            this.txtMaPB.TabIndex = 40;
            // 
            // dateNS
            // 
            this.dateNS.Location = new System.Drawing.Point(123, 130);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(198, 22);
            this.dateNS.TabIndex = 39;
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.btnHienThi.Location = new System.Drawing.Point(268, 345);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(85, 43);
            this.btnHienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThi.TabIndex = 37;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Image = global::QuanLiNhanSu.Properties.Resources.list_add_user4;
            this.btnThemNV.Location = new System.Drawing.Point(177, 345);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(82, 43);
            this.btnThemNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemNV.TabIndex = 35;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 18;
            this.labelX1.Text = "Mã nhân viên";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(13, 176);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(95, 33);
            this.labelX8.TabIndex = 33;
            this.labelX8.Text = "Mã Phòng Ban";
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(123, 23);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(227, 22);
            this.txtMaNV.TabIndex = 19;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(13, 101);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(70, 23);
            this.labelX7.TabIndex = 32;
            this.labelX7.Text = "Giới Tính";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNV.Location = new System.Drawing.Point(123, 49);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(227, 22);
            this.txtTenNV.TabIndex = 21;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(70, 23);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Bằng cấp";
            // 
            // txtCMT
            // 
            // 
            // 
            // 
            this.txtCMT.Border.Class = "TextBoxBorder";
            this.txtCMT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCMT.Location = new System.Drawing.Point(123, 215);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(227, 22);
            this.txtCMT.TabIndex = 29;
            // 
            // txtBangCap
            // 
            // 
            // 
            // 
            this.txtBangCap.Border.Class = "TextBoxBorder";
            this.txtBangCap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBangCap.Location = new System.Drawing.Point(123, 75);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(227, 22);
            this.txtBangCap.TabIndex = 23;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(14, 212);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "CMTND";
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 124);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(70, 23);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Ngày Sinh";
            // 
            // txtDC
            // 
            // 
            // 
            // 
            this.txtDC.Border.Class = "TextBoxBorder";
            this.txtDC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDC.Location = new System.Drawing.Point(123, 156);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(227, 22);
            this.txtDC.TabIndex = 27;
            // 
            // txtGT
            // 
            // 
            // 
            // 
            this.txtGT.Border.Class = "TextBoxBorder";
            this.txtGT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGT.Location = new System.Drawing.Point(123, 104);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(227, 22);
            this.txtGT.TabIndex = 25;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 156);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(70, 23);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Địa chỉ";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::QuanLiNhanSu.Properties.Resources.cancel1;
            this.buttonX1.Location = new System.Drawing.Point(9, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(72, 24);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 46;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemNV";
            this.Text = "Thêm Nhân viên";
            this.Load += new System.EventHandler(this.frmThemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThemNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnThemNV;
        private DevComponents.DotNetBar.ButtonX btnHienThi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDT;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPB;
        private System.Windows.Forms.DateTimePicker dateNS;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNV;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBangCap;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGT;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTG;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}