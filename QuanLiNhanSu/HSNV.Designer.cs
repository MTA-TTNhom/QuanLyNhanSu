namespace QuanLiNhanSu
{
    partial class HSNV
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
            this.rpvNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyNhanSu1DataSet = new QuanLiNhanSu.QuanLyNhanSu1DataSet();
            this.quanLyNhanSu1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinnhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinnhanVienTableAdapter = new QuanLiNhanSu.QuanLyNhanSu1DataSetTableAdapters.ThongTinnhanVienTableAdapter();
            this.thongTinnhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinnhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinnhanVienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinnhanVienBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cboMaNV = new System.Windows.Forms.TextBox();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSu1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSu1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvNV
            // 
            this.rpvNV.Location = new System.Drawing.Point(73, 84);
            this.rpvNV.Name = "rpvNV";
            this.rpvNV.Size = new System.Drawing.Size(730, 472);
            this.rpvNV.TabIndex = 0;
            // 
            // quanLyNhanSu1DataSet
            // 
            this.quanLyNhanSu1DataSet.DataSetName = "QuanLyNhanSu1DataSet";
            this.quanLyNhanSu1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSu1DataSetBindingSource
            // 
            this.quanLyNhanSu1DataSetBindingSource.DataSource = this.quanLyNhanSu1DataSet;
            this.quanLyNhanSu1DataSetBindingSource.Position = 0;
            // 
            // thongTinnhanVienBindingSource
            // 
            this.thongTinnhanVienBindingSource.DataMember = "ThongTinnhanVien";
            this.thongTinnhanVienBindingSource.DataSource = this.quanLyNhanSu1DataSet;
            // 
            // thongTinnhanVienTableAdapter
            // 
            this.thongTinnhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinnhanVienBindingSource1
            // 
            this.thongTinnhanVienBindingSource1.DataMember = "ThongTinnhanVien";
            this.thongTinnhanVienBindingSource1.DataSource = this.quanLyNhanSu1DataSetBindingSource;
            // 
            // thongTinnhanVienBindingSource2
            // 
            this.thongTinnhanVienBindingSource2.DataMember = "ThongTinnhanVien";
            this.thongTinnhanVienBindingSource2.DataSource = this.quanLyNhanSu1DataSetBindingSource;
            // 
            // thongTinnhanVienBindingSource3
            // 
            this.thongTinnhanVienBindingSource3.DataMember = "ThongTinnhanVien";
            this.thongTinnhanVienBindingSource3.DataSource = this.quanLyNhanSu1DataSet;
            // 
            // thongTinnhanVienBindingSource4
            // 
            this.thongTinnhanVienBindingSource4.DataMember = "ThongTinnhanVien";
            this.thongTinnhanVienBindingSource4.DataSource = this.quanLyNhanSu1DataSet;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Location = new System.Drawing.Point(73, 58);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(140, 20);
            this.cboMaNV.TabIndex = 39;
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.btnHienThi.Location = new System.Drawing.Point(661, 25);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(112, 53);
            this.btnHienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThi.TabIndex = 38;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // HSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 568);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.rpvNV);
            this.Name = "HSNV";
            this.Text = "Hồ sơ nhân viên";
            this.Load += new System.EventHandler(this.HSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSu1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSu1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinnhanVienBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNV;
        private System.Windows.Forms.BindingSource thongTinnhanVienBindingSource;
        private QuanLyNhanSu1DataSet quanLyNhanSu1DataSet;
        private System.Windows.Forms.BindingSource quanLyNhanSu1DataSetBindingSource;
        private QuanLyNhanSu1DataSetTableAdapters.ThongTinnhanVienTableAdapter thongTinnhanVienTableAdapter;
        private DevComponents.DotNetBar.ButtonX btnHienThi;
        private System.Windows.Forms.BindingSource thongTinnhanVienBindingSource3;
        private System.Windows.Forms.BindingSource thongTinnhanVienBindingSource2;
        private System.Windows.Forms.BindingSource thongTinnhanVienBindingSource1;
        private System.Windows.Forms.BindingSource thongTinnhanVienBindingSource4;
        private System.Windows.Forms.TextBox cboMaNV;
    }
}