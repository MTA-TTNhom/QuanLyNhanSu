namespace QuanLyNhanSu
{
    partial class frmThemChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnThemCV = new DevComponents.DotNetBar.ButtonX();
            this.txtTCV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMCV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnNhaplai = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvThemCV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(332, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(218, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "THÊM CHỨC VỤ MỚI";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgvThemCV);
            this.groupBox2.Location = new System.Drawing.Point(37, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 438);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThemCV);
            this.groupBox1.Controls.Add(this.txtTCV);
            this.groupBox1.Controls.Add(this.txtMCV);
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Image = global::QuanLiNhanSu.Properties.Resources.cancel;
            this.btnHuy.Location = new System.Drawing.Point(144, 183);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 33);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemCV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemCV.Image = global::QuanLiNhanSu.Properties.Resources.user_male_add23;
            this.btnThemCV.Location = new System.Drawing.Point(59, 178);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(75, 38);
            this.btnThemCV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemCV.TabIndex = 24;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click_2);
            // 
            // txtTCV
            // 
            // 
            // 
            // 
            this.txtTCV.Border.Class = "TextBoxBorder";
            this.txtTCV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTCV.Location = new System.Drawing.Point(109, 86);
            this.txtTCV.Name = "txtTCV";
            this.txtTCV.Size = new System.Drawing.Size(119, 20);
            this.txtTCV.TabIndex = 23;
            this.txtTCV.TextChanged += new System.EventHandler(this.txtTCV_TextChanged);
            // 
            // txtMCV
            // 
            // 
            // 
            // 
            this.txtMCV.Border.Class = "TextBoxBorder";
            this.txtMCV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMCV.Location = new System.Drawing.Point(109, 42);
            this.txtMCV.Name = "txtMCV";
            this.txtMCV.Size = new System.Drawing.Size(119, 20);
            this.txtMCV.TabIndex = 2;
            this.txtMCV.TextChanged += new System.EventHandler(this.txtMCV_TextChanged);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhaplai.Location = new System.Drawing.Point(153, 139);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhaplai.TabIndex = 22;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click_1);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên chức vụ";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã chức vụ";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // dgvThemCV
            // 
            this.dgvThemCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemCV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThemCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThemCV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThemCV.EnableHeadersVisualStyles = false;
            this.dgvThemCV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThemCV.Location = new System.Drawing.Point(295, 31);
            this.dgvThemCV.Name = "dgvThemCV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThemCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThemCV.Size = new System.Drawing.Size(486, 374);
            this.dgvThemCV.TabIndex = 6;
            this.dgvThemCV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemCV_CellContentClick);
            // 
            // frmThemCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelX3);
            this.Name = "frmThemCV";
            this.Text = "frmThemCV";
            this.Load += new System.EventHandler(this.frmThemCV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnThemCV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTCV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMCV;
        private DevComponents.DotNetBar.ButtonX btnNhaplai;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThemCV;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}