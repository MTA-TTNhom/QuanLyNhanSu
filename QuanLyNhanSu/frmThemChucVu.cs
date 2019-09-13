using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmThemChucVu : Form
    {
        public frmThemCV()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {


        }
		
		
        #region Hien thi ComboBox

        public void HienThiComboBox(ComboBoxEx comboBox)

        {

            comboBox.DataSource = m_MonHocData.LayDsMonHoc();

            comboBox.DisplayMember = "TenMonHoc";

            comboBox.ValueMember = "MaMonHoc";
        }


        public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)

        {

            MonHocData m_MHData = new MonHocData();


            comboBox.DataSource = m_MHData.LayDsMonHoc(namHoc, lop);

            comboBox.DisplayMember = "TenMonHoc";

            comboBox.ValueMember = "MaMonHoc";

        }
        #endregion
   public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)

        {
            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();

            cmbColumn.DisplayMember = "TenMonHoc";


            cmbColumn.ValueMember = "MaMonHoc";

            cmbColumn.DataPropertyName = "MaMonHoc";

            cmbColumn.HeaderText = "Môn học";
        }

        public void HienThiDataGridViewComboBoxColumnGiaoVien(DataGridViewComboBoxColumn cmbColumn)
        {

            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();
            cmbColumn.DisplayMember = "TenMonHoc";

            cmbColumn.ValueMember = "MaMonHoc";

            cmbColumn.DataPropertyName = "MaMonHoc";

            cmbColumn.HeaderText = "Chuyên môn";


        }  
        public void HienThiDataGridViewComboBoxColumnGiaoVien(DataGridViewComboBoxColumn cmbColumn)
        {

            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();
            cmbColumn.DisplayMember = "TenMonHoc";

            cmbColumn.ValueMember = "MaMonHoc";

            cmbColumn.DataPropertyName = "MaMonHoc";

            cmbColumn.HeaderText = "Chuyên môn";


        }

        #region Hien thi ComboBox trong DataGridView

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)

        {
            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();

            cmbColumn.DisplayMember = "TenMonHoc";


            cmbColumn.ValueMember = "MaMonHoc";

            cmbColumn.DataPropertyName = "MaMonHoc";

            cmbColumn.HeaderText = "Môn học";
        }

      
        public void load()
        {
            string sql = "select *from CHUCVU";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dgvThemCV.DataSource = dt;
        }
        private void txtTenCV_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            string mapb = temp.Text;

            string sql = "select HoTen, DiaChi NgaySinh, GioiTinh, BangCap, MaCV from NHANVIEN where MaPB =@mapb";

            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mapb", mapb));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);


            }

        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            frmThemCV form = new frmThemCV();
            form.Show();

        }

        private void txtMaCV_TextChanged_1(object sender, EventArgs e)
        {

        }



        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMCV.Clear();
            txtTCV.Clear();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvThemCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNhaplai_Click_1(object sender, EventArgs e)
        {
            txtTCV.Clear();
            txtMCV.Clear();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.frm_ChucVu.Show();

        }

        private void btnThemCV_Click_2(object sender, EventArgs e)
        {
            ChucVu temp = new ChucVu(txtMCV.Text, txtTCV.Text);

            if (ConnectDatabase.checkChucVu(temp.Macv) == 1)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại. Xin mời nhập lại!!!");
                return;

            }
            ConnectDatabase.ThemChucVu(temp);
            dgvThemCV.DataSource = ConnectDatabase.getAllChucVu();
            load();

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void txtMCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmThemCV_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
