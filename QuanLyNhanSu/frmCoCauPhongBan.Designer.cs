namespace QuanLyNhanSu
{
    partial class frmCoCauPhongBan
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmCoCauPhongBan";

            this.cboPB = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dgvCCPB = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnHienThi = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCPB)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPB
            // 
            this.cboPB.DisplayMember = "Text";
            this.cboPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPB.FormattingEnabled = true;
            this.cboPB.ItemHeight = 14;
            this.cboPB.Location = new System.Drawing.Point(110, 83);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(152, 20);
            this.cboPB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPB.TabIndex = 18;
            this.cboPB.SelectedIndexChanged += new System.EventHandler(this.cboPB_SelectedIndexChanged);
            // 
            // dgvCCPB
            // 
            this.dgvCCPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCCPB.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCCPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCCPB.Location = new System.Drawing.Point(99, 119);
            this.dgvCCPB.Name = "dgvCCPB";
            this.dgvCCPB.Size = new System.Drawing.Size(692, 275);
            this.dgvCCPB.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(344, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(207, 43);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "CƠ CẤU PHÒNG BAN";
            // 
            // btnHienThi
            // 
            this.btnHienThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHienThi.Image = global::QuanLiNhanSu.Properties.Resources.show_property;
            this.btnHienThi.Location = new System.Drawing.Point(698, 83);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(93, 30);
            this.btnHienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHienThi.TabIndex = 63;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::QuanLiNhanSu.Properties.Resources.cancel1;
            this.buttonX1.Location = new System.Drawing.Point(689, 410);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(102, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 64;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmCoCauPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 534);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cboPB);
            this.Controls.Add(this.dgvCCPB);
            this.Name = "frmCoCauPhongBan";
            this.Text = "Cơ cấu phòng ban";
            this.Load += new System.EventHandler(this.frmCoCauPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCPB)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}