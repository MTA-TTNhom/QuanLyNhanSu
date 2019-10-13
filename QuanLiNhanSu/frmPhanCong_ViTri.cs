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
    public partial class frmPhanCong_ViTri : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");

        public frmPhanCong_ViTri()
        {
            InitializeComponent();

        }
        public void load()
        {

            SqlDataAdapter dap = new SqlDataAdapter("SELECT TENVT FROM VITRICONGVIEC", conn);
            var table = new DataTable();
            dap.Fill(table);
            comboBoxEx1.DisplayMember = "TenVT";
            comboBoxEx1.ValueMember = "MaVT";
            comboBoxEx1.DataSource = table;
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvPCVT.DataSource = ConnectDatabase.PhanCongViTri();
        }

        private void frmPhanCong_ViTri_Load(object sender, EventArgs e)
        {
            this.txtTenVT.Enabled = false;
            this.txtTenNV.Enabled = false;
            this.dgvPCVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPCVT.DataSource = ConnectDatabase.PhanCongViTri();
        }

        private void dgvPCVT_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtMaVT.Text = row.Cells[2].Value.ToString();
                txtTenVT.Text = row.Cells[3].Value.ToString();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            PhanCong_ViTri temp = new PhanCong_ViTri(txtMaNV.Text, txtMaVT.Text);
            ConnectDatabase.SuaViTri_NhanVien(temp);
            dgvPCVT.DataSource = ConnectDatabase.PhanCongViTri();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = ConnectDatabase.getTenTruongPhongTuMaTruongPhong(txtMaNV.Text);
        }

        private void txtMaVT_TextChanged(object sender, EventArgs e)
        {
            txtTenVT.Text = ConnectDatabase.getTenViTriTuMaViTri(txtMaVT.Text);
        }



        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            string tenvt = ((temp.SelectedValue) as DataRowView).Row[0].ToString();
            string sql = "select n.MaNV, HoTen, v.MaVT, TenVT from NHANVIEN n,VITRICONGVIEC v , NHANVIEN_VITRI nv where n.MaNV=nv.MaNV and v.MaVT=nv.MaVT and TenVT=@tenvt ";
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenvt", tenvt));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            dgvPCVT.DataSource = dt;
        }

        private void labTimKiem_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
