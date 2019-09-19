namespace QuanLyNhanSu
{
    partial class frmHopDong
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.tbnXoa = new DevComponents.DotNetBar.ButtonX();
            this.tbnThoat = new DevComponents.DotNetBar.ButtonX();
            this.tbnGiaHan = new DevComponents.DotNetBar.ButtonX();
            this.tbnSua = new DevComponents.DotNetBar.ButtonX();
            this.tbnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtTenHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtMaHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.dateKT = new System.Windows.Forms.DateTimePicker();
            this.btnTV = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(287, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(351, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "HỢP ĐỒNG LÀM VIỆC CỦA NHÂN VIÊN";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(270, 87);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(655, 358);
            this.dgvHienThi.TabIndex = 1;
            this.dgvHienThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellContentClick);
            this.dgvHienThi.SelectionChanged += new System.EventHandler(this.dgvHienThi_SelectionChanged);
            // 
            // tbnXoa
            // 
            this.tbnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnXoa.Location = new System.Drawing.Point(24, 372);
            this.tbnXoa.Name = "tbnXoa";
            this.tbnXoa.Size = new System.Drawing.Size(75, 23);
            this.tbnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbnXoa.TabIndex = 2;
            this.tbnXoa.Text = "Xóa";
            this.tbnXoa.Click += new System.EventHandler(this.tbnXoa_Click);
        }

         // 
            // tbnThoat
            // 
            this.tbnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnThoat.Location = new System.Drawing.Point(145, 416);
            this.tbnThoat.Name = "tbnThoat";
            this.tbnThoat.Size = new System.Drawing.Size(75, 23);
            this.tbnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbnThoat.TabIndex = 4;
            this.tbnThoat.Text = "Thoát";
            this.tbnThoat.Click += new System.EventHandler(this.tbnThoat_Click);
            // 
            // tbnGiaHan
            // 
            this.tbnGiaHan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnGiaHan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnGiaHan.Location = new System.Drawing.Point(145, 372);
            this.tbnGiaHan.Name = "tbnGiaHan";
            this.tbnGiaHan.Size = new System.Drawing.Size(75, 23);
            this.tbnGiaHan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbnGiaHan.TabIndex = 5;
            this.tbnGiaHan.Text = "Gia hạn";
            this.tbnGiaHan.Click += new System.EventHandler(this.tbnGiaHan_Click);
            // 
            // tbnSua
            // 
            this.tbnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnSua.Location = new System.Drawing.Point(145, 327);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(75, 23);
            this.tbnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbnSua.TabIndex = 6;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.Click += new System.EventHandler(this.tbnSua_Click);
            // 
            // tbnThem
            // 
            this.tbnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tbnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tbnThem.Location = new System.Drawing.Point(24, 327);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(75, 23);
            this.tbnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbnThem.TabIndex = 7;
            this.tbnThem.Text = "Thêm";
            this.tbnThem.Click += new System.EventHandler(this.tbnThem_Click);
        // 
        // labelX2
        // 
        // 
        // 
        // 
        this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 85);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Tên Hợp Đồng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 117);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Tên Nhân Viên";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(24, 146);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Ngày Bắt Đầu";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(24, 175);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Ngày Kết Thúc";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(24, 204);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "Mã Nhân Viên";

            // 
            // txtTenHD
            // 
            // 
            // 
            // 
            this.txtTenHD.Border.Class = "TextBoxBorder";
            this.txtTenHD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHD.Location = new System.Drawing.Point(120, 87);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(100, 20);
            this.txtTenHD.TabIndex = 13;
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.Class = "TextBoxBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenNV.Location = new System.Drawing.Point(120, 120);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 14;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Location = new System.Drawing.Point(120, 207);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 17;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(24, 233);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "Mã Hợp Đồng";
            // 
            // txtMaHD
            // 
            // 
            // 
            // 
            this.txtMaHD.Border.Class = "TextBoxBorder";
            this.txtMaHD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHD.Location = new System.Drawing.Point(120, 236);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 21;

            // 
            // dateBD
            // 
            this.dateBD.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(120, 148);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(100, 20);
            this.dateBD.TabIndex = 22;
            this.dateBD.ValueChanged += new System.EventHandler(this.dateBD_ValueChanged);
            // 
            // dateKT
            // 
            this.dateKT.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateKT.CustomFormat = "dd/MM/yyyy";
            this.dateKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKT.Location = new System.Drawing.Point(120, 175);
            this.dateKT.Name = "dateKT";
            this.dateKT.Size = new System.Drawing.Size(100, 20);
            this.dateKT.TabIndex = 23;
            // 
            // btnTV
            // 
            this.btnTV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTV.Location = new System.Drawing.Point(24, 416);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(75, 23);
            this.btnTV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTV.TabIndex = 24;
            this.btnTV.Text = "Thoát Tác vụ";
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(944, 451);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.dateKT);
            this.Controls.Add(this.dateBD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbnThem);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.tbnGiaHan);
            this.Controls.Add(this.tbnThoat);
            this.Controls.Add(this.tbnXoa);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.labelX1);
            this.Name = "frmHopDong";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
        #endregion
    }
    }