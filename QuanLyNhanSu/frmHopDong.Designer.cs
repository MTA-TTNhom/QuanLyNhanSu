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

        #endregion
        }
    }