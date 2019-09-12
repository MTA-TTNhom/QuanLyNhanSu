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

        }

        #endregion
    }
}