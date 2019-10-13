namespace QuanLiNhanSu
{
    partial class frmVTCV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTrolai = new DevComponents.DotNetBar.ButtonX();
            this.labTimKiem = new DevComponents.DotNetBar.LabelX();
            this.txtTenVT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaVT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXoaCV = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaCV = new DevComponents.DotNetBar.ButtonX();
            this.btnThemCV = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chucvuTableAdapter1 = new QuanLiNhanSu.QuanLyNhanSu1DataSetTableAdapters.CHUCVUTableAdapter();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 420);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dgvVT);
            this.groupBox2.Location = new System.Drawing.Point(397, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 393);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgvVT
            // 
            this.dgvVT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVT.EnableHeadersVisualStyles = false;
            this.dgvVT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvVT.Location = new System.Drawing.Point(6, 9);
            this.dgvVT.Name = "dgvVT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVT.Size = new System.Drawing.Size(324, 378);
            this.dgvVT.TabIndex = 1;
            this.dgvVT.SelectionChanged += new System.EventHandler(this.dgvVT_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnTrolai);
            this.groupBox1.Controls.Add(this.labTimKiem);
            this.groupBox1.Controls.Add(this.txtTenVT);
            this.groupBox1.Controls.Add(this.txtMaVT);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.btnXoaCV);
            this.groupBox1.Controls.Add(this.btnSuaCV);
            this.groupBox1.Controls.Add(this.btnThemCV);
            this.groupBox1.Location = new System.Drawing.Point(41, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 390);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Location = new System.Drawing.Point(16, 68);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(246, 20);
            this.txtTimKiem.TabIndex = 36;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTrolai
            // 
            this.btnTrolai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrolai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrolai.Image = global::QuanLiNhanSu.Properties.Resources.backward2;
            this.btnTrolai.Location = new System.Drawing.Point(187, 311);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(75, 30);
            this.btnTrolai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrolai.TabIndex = 34;
            this.btnTrolai.Text = "Trở lại";
            // 
            // labTimKiem
            // 
            // 
            // 
            // 
            this.labTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.Image = global::QuanLiNhanSu.Properties.Resources.kappfinder2;
            this.labTimKiem.Location = new System.Drawing.Point(16, 19);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(99, 36);
            this.labTimKiem.TabIndex = 35;
            this.labTimKiem.Text = "Tìm kiếm";
            // 
            // txtTenVT
            // 
            // 
            // 
            // 
            this.txtTenVT.Border.Class = "TextBoxBorder";
            this.txtTenVT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenVT.Location = new System.Drawing.Point(16, 177);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(246, 20);
            this.txtTenVT.TabIndex = 32;
            // 
            // txtMaVT
            // 
            // 
            // 
            // 
            this.txtMaVT.Border.Class = "TextBoxBorder";
            this.txtMaVT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaVT.Location = new System.Drawing.Point(16, 122);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(246, 20);
            this.txtMaVT.TabIndex = 31;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 148);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 30;
            this.labelX2.Text = "Tên Vị Trí";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 94);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "Mã Vị Trí";
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaCV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaCV.Image = global::QuanLiNhanSu.Properties.Resources.deletered;
            this.btnXoaCV.Location = new System.Drawing.Point(187, 257);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(75, 28);
            this.btnXoaCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaCV.TabIndex = 26;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.Click += new System.EventHandler(this.btnXoaCV_Click);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaCV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaCV.Image = global::QuanLiNhanSu.Properties.Resources.settings2;
            this.btnSuaCV.Location = new System.Drawing.Point(93, 257);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(83, 29);
            this.btnSuaCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaCV.TabIndex = 24;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.Click += new System.EventHandler(this.btnSuaCV_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemCV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemCV.Image = global::QuanLiNhanSu.Properties.Resources.user_male_add23;
            this.btnThemCV.Location = new System.Drawing.Point(4, 256);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(75, 29);
            this.btnThemCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemCV.TabIndex = 23;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelX3.Location = new System.Drawing.Point(292, 22);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(194, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "VỊ TRÍ CÔNG VIỆC";
            // 
            // chucvuTableAdapter1
            // 
            this.chucvuTableAdapter1.ClearBeforeFill = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.btnHienThi.Location = new System.Drawing.Point(620, 42);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(85, 30);
            this.btnHienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThi.TabIndex = 25;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // frmVTCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnHienThi);
            this.Name = "frmVTCV";
            this.Text = "Vị Trí Công Việc";
            this.Load += new System.EventHandler(this.frmVTCV_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTrolai;
        private DevComponents.DotNetBar.LabelX labTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenVT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaVT;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXoaCV;
        private DevComponents.DotNetBar.ButtonX btnSuaCV;
        private DevComponents.DotNetBar.ButtonX btnThemCV;
        private DevComponents.DotNetBar.ButtonX btnHienThi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private QuanLyNhanSu1DataSetTableAdapters.CHUCVUTableAdapter chucvuTableAdapter1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvVT;
    }
}