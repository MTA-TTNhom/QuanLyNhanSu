namespace QuanLiNhanSu
{
    partial class frmLuong_CaNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvLuong_CaNhan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLuongThuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGhichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtSNTC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTongLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnTongLuong = new DevComponents.DotNetBar.ButtonX();
            this.btnThuong = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_CaNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(467, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(290, 27);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "QUẢN LÝ LƯƠNG CÁ NHÂN";
            // 
            // dgvLuong_CaNhan
            // 
            this.dgvLuong_CaNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong_CaNhan.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvLuong_CaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuong_CaNhan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuong_CaNhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLuong_CaNhan.Location = new System.Drawing.Point(127, 139);
            this.dgvLuong_CaNhan.Name = "dgvLuong_CaNhan";
            this.dgvLuong_CaNhan.Size = new System.Drawing.Size(741, 332);
            this.dgvLuong_CaNhan.TabIndex = 1;
            this.dgvLuong_CaNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_CaNhan_CellContentClick_1);
            this.dgvLuong_CaNhan.SelectionChanged += new System.EventHandler(this.dgvLuong_CaNhan_SelectionChanged);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Location = new System.Drawing.Point(258, 91);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(390, 22);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNV.Location = new System.Drawing.Point(1005, 183);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(177, 22);
            this.txtTenNV.TabIndex = 25;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtLuong
            // 
            // 
            // 
            // 
            this.txtLuong.Border.Class = "TextBoxBorder";
            this.txtLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLuong.Location = new System.Drawing.Point(1005, 219);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(177, 22);
            this.txtLuong.TabIndex = 24;
            // 
            // txtLuongThuong
            // 
            // 
            // 
            // 
            this.txtLuongThuong.Border.Class = "TextBoxBorder";
            this.txtLuongThuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLuongThuong.Location = new System.Drawing.Point(1005, 252);
            this.txtLuongThuong.Name = "txtLuongThuong";
            this.txtLuongThuong.Size = new System.Drawing.Size(177, 22);
            this.txtLuongThuong.TabIndex = 23;
            // 
            // txtGhichu
            // 
            // 
            // 
            // 
            this.txtGhichu.Border.Class = "TextBoxBorder";
            this.txtGhichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhichu.Location = new System.Drawing.Point(1005, 292);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(177, 22);
            this.txtGhichu.TabIndex = 22;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(1005, 139);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(177, 22);
            this.txtMaNV.TabIndex = 21;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(898, 183);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 27);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "Tên nhân viên";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(898, 216);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 27);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "Lương ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(898, 249);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 27);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Lương thưởng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(898, 292);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 27);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Ghi chú";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(898, 139);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 27);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "Mã nhân viên";
            // 
            // txtSNTC
            // 
            // 
            // 
            // 
            this.txtSNTC.Border.Class = "TextBoxBorder";
            this.txtSNTC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSNTC.Location = new System.Drawing.Point(1005, 329);
            this.txtSNTC.Name = "txtSNTC";
            this.txtSNTC.Size = new System.Drawing.Size(177, 22);
            this.txtSNTC.TabIndex = 28;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(898, 325);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 27);
            this.labelX8.TabIndex = 27;
            this.labelX8.Text = "Số ngày tăng ca";
            // 
            // txtTongLuong
            // 
            // 
            // 
            // 
            this.txtTongLuong.Border.Class = "TextBoxBorder";
            this.txtTongLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongLuong.Location = new System.Drawing.Point(1005, 369);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(177, 22);
            this.txtTongLuong.TabIndex = 30;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(898, 365);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(87, 27);
            this.labelX9.TabIndex = 29;
            this.labelX9.Text = "Tổng Lương";
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTongLuong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTongLuong.Image = global::QuanLiNhanSu.Properties.Resources.printer_2;
            this.btnTongLuong.Location = new System.Drawing.Point(975, 426);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(115, 45);
            this.btnTongLuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTongLuong.TabIndex = 31;
            this.btnTongLuong.Text = "Tổng Lương";
            this.btnTongLuong.Click += new System.EventHandler(this.btnTongLuong_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThuong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThuong.Image = global::QuanLiNhanSu.Properties.Resources.money;
            this.btnThuong.Location = new System.Drawing.Point(1096, 426);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(108, 45);
            this.btnThuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThuong.TabIndex = 26;
            this.btnThuong.Text = "Thưởng";
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Image = global::QuanLiNhanSu.Properties.Resources.kappfinder3;
            this.labelX2.Location = new System.Drawing.Point(122, 91);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(114, 27);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tìm Kiếm";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::QuanLiNhanSu.Properties.Resources.cancel1;
            this.buttonX1.Location = new System.Drawing.Point(2, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(80, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 46;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmLuong_CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 497);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnTongLuong);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtSNTC);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtLuongThuong);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvLuong_CaNhan);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLuong_CaNhan";
            this.Text = "Lương nhân viên";
            this.Load += new System.EventHandler(this.frmLuong_CaNhan_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_CaNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLuong_CaNhan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnThuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLuongThuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhichu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSNTC;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongLuong;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnTongLuong;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}