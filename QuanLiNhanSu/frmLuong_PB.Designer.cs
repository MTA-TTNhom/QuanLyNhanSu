namespace QuanLyNhanSu
{
    partial class frmLuong_PB
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvLuong_pb = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnThuong = new DevComponents.DotNetBar.ButtonX();
            this.labTimKiem = new DevComponents.DotNetBar.LabelX();
            this.pHONGBANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet = new QuanLiNhanSu.QuanLyNhanSuDataSet();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new QuanLiNhanSu.QuanLyNhanSuDataSetTableAdapters.PHONGBANTableAdapter();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cboPB = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTongLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtSNTC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnTongLuong = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(392, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(420, 27);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "QUẢN LÝ LƯƠNG CỦA PHÒNG BAN";
            // 
            // dgvLuong_pb
            // 
            this.dgvLuong_pb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong_pb.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong_pb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLuong_pb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuong_pb.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLuong_pb.EnableHeadersVisualStyles = false;
            this.dgvLuong_pb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLuong_pb.Location = new System.Drawing.Point(34, 101);
            this.dgvLuong_pb.Name = "dgvLuong_pb";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong_pb.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLuong_pb.Size = new System.Drawing.Size(681, 330);
            this.dgvLuong_pb.TabIndex = 3;
            this.dgvLuong_pb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuong_pb_CellContentClick);
            this.dgvLuong_pb.SelectionChanged += new System.EventHandler(this.dgvLuong_pb_SelectionChanged);
            // 
            // btnThuong
            // 
            this.btnThuong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThuong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThuong.Image = global::QuanLiNhanSu.Properties.Resources.money;
            this.btnThuong.Location = new System.Drawing.Point(941, 386);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(116, 45);
            this.btnThuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThuong.TabIndex = 15;
            this.btnThuong.Text = "Thưởng";
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // labTimKiem
            // 
            // 
            // 
            // 
            this.labTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.Image = global::QuanLiNhanSu.Properties.Resources.home3;
            this.labTimKiem.Location = new System.Drawing.Point(34, 48);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(169, 42);
            this.labTimKiem.TabIndex = 2;
            this.labTimKiem.Text = "Phòng Ban";
            this.labTimKiem.Click += new System.EventHandler(this.labTimKiem_Click);
            // 
            // pHONGBANBindingSource1
            // 
            this.pHONGBANBindingSource1.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.quanLyNhanSuDataSet;
            // 
            // quanLyNhanSuDataSetBindingSource
            // 
            this.quanLyNhanSuDataSetBindingSource.DataSource = this.quanLyNhanSuDataSet;
            this.quanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.buttonX1.Location = new System.Drawing.Point(531, 65);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(93, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 66;
            this.buttonX1.Text = "Hiển thị";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // cboPB
            // 
            this.cboPB.DisplayMember = "Text";
            this.cboPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPB.FormattingEnabled = true;
            this.cboPB.ItemHeight = 16;
            this.cboPB.Location = new System.Drawing.Point(187, 59);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(152, 22);
            this.cboPB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPB.TabIndex = 64;
            this.cboPB.SelectedIndexChanged += new System.EventHandler(this.cboPB_SelectedIndexChanged);
            // 
            // txtTongLuong
            // 
            // 
            // 
            // 
            this.txtTongLuong.Border.Class = "TextBoxBorder";
            this.txtTongLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongLuong.Location = new System.Drawing.Point(877, 341);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(177, 22);
            this.txtTongLuong.TabIndex = 80;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(770, 337);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(87, 27);
            this.labelX9.TabIndex = 79;
            this.labelX9.Text = "Tổng Lương";
            // 
            // txtSNTC
            // 
            // 
            // 
            // 
            this.txtSNTC.Border.Class = "TextBoxBorder";
            this.txtSNTC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSNTC.Location = new System.Drawing.Point(877, 301);
            this.txtSNTC.Name = "txtSNTC";
            this.txtSNTC.Size = new System.Drawing.Size(177, 22);
            this.txtSNTC.TabIndex = 78;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(770, 297);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 27);
            this.labelX8.TabIndex = 77;
            this.labelX8.Text = "Số ngày tăng ca";
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNV.Location = new System.Drawing.Point(877, 155);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(177, 22);
            this.txtTenNV.TabIndex = 76;
            // 
            // txtLuong
            // 
            // 
            // 
            // 
            this.txtLuong.Border.Class = "TextBoxBorder";
            this.txtLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLuong.Location = new System.Drawing.Point(877, 191);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(177, 22);
            this.txtLuong.TabIndex = 75;
            // 
            // txtLuongThuong
            // 
            // 
            // 
            // 
            this.txtLuongThuong.Border.Class = "TextBoxBorder";
            this.txtLuongThuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLuongThuong.Location = new System.Drawing.Point(877, 224);
            this.txtLuongThuong.Name = "txtLuongThuong";
            this.txtLuongThuong.Size = new System.Drawing.Size(177, 22);
            this.txtLuongThuong.TabIndex = 74;
            // 
            // txtGhichu
            // 
            // 
            // 
            // 
            this.txtGhichu.Border.Class = "TextBoxBorder";
            this.txtGhichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhichu.Location = new System.Drawing.Point(877, 264);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(177, 22);
            this.txtGhichu.TabIndex = 73;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(877, 111);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(177, 22);
            this.txtMaNV.TabIndex = 72;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(770, 155);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 27);
            this.labelX6.TabIndex = 71;
            this.labelX6.Text = "Tên nhân viên";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(770, 188);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 27);
            this.labelX5.TabIndex = 70;
            this.labelX5.Text = "Lương ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(770, 221);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 27);
            this.labelX4.TabIndex = 69;
            this.labelX4.Text = "Lương thưởng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(770, 264);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 27);
            this.labelX3.TabIndex = 68;
            this.labelX3.Text = "Ghi chú";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(770, 111);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 27);
            this.labelX7.TabIndex = 67;
            this.labelX7.Text = "Mã nhân viên";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Image = global::QuanLiNhanSu.Properties.Resources.cancel1;
            this.buttonX2.Location = new System.Drawing.Point(630, 65);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(85, 30);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 81;
            this.buttonX2.Text = "Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTongLuong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTongLuong.Image = global::QuanLiNhanSu.Properties.Resources.printer_2;
            this.btnTongLuong.Location = new System.Drawing.Point(811, 386);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(114, 45);
            this.btnTongLuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTongLuong.TabIndex = 82;
            this.btnTongLuong.Text = "Tổng Lương";
            // 
            // frmLuong_PB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 472);
            this.Controls.Add(this.btnTongLuong);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtSNTC);
            this.Controls.Add(this.labelX8);
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
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.cboPB);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.dgvLuong_pb);
            this.Controls.Add(this.labTimKiem);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLuong_PB";
            this.Text = "Lương theo phòng ban";
            this.Load += new System.EventHandler(this.frmLuong_PB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labTimKiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLuong_pb;
        private DevComponents.DotNetBar.ButtonX btnThuong;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSetBindingSource;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private QuanLyNhanSuDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongLuong;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSNTC;
        private DevComponents.DotNetBar.LabelX labelX8;
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
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnTongLuong;
    }
}