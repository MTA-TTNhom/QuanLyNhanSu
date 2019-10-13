using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLiNhanSu
{
    public partial class frmLuong_PB : Form
    {
        public frmLuong_PB()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");

        private void cboTimKiem_PB_Luong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            string tenpb = ((temp.SelectedValue) as DataRowView).Row[0].ToString();

            string sql = "select HoTen, Luong from LUONG l, PHONGBAN p, NHANVIEN n where p.MaPB=n.MaPB and l.MaNV=n.MaNV and TenPB=@tenpb";

            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenpb", tenpb));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);


            }
            dgvLuong_pb.DataSource = dt;

        }

        private void labTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select TenPB from PHONGBAN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            


            //TextBox temp = sender as TextBox;
            //string tenpb = temp.Text;

            //string sql = "select HoTen, Luong, TenPB from LUONG l, PHONGBAN p, NHANVIEN n where p.MaPB=n.MaPB and l.MaNV=n.MaNV and TenPb like @tenpb";

            //DataTable dt = new DataTable();
            //using (SqlCommand command = new SqlCommand(sql, conn))
            //{
            //    command.Parameters.Add(new SqlParameter("@tenpb",'%' + tenpb + '%'));

            //    SqlDataAdapter da = new SqlDataAdapter(command);
            //    da.Fill(dt);


            //}
            //dgvLuong_pb.DataSource = dt;
        }

        private void frmLuong_PB_Load(object sender, EventArgs e)
        {
           this.dgvLuong_pb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.pHONGBANTableAdapter.Fill(this.quanLyNhanSuDataSet.PHONGBAN);
        //    dgvLuong_pb.DataSource = ConnectDatabase.GetAllLuong_PB();

        }
        public void load()
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT TENPB FROM PHONGBAN", conn);
            var table = new DataTable();
            dap.Fill(table);
            cboPB.DisplayMember = "TenPB";
            cboPB.ValueMember = "MaPB";
            cboPB.DataSource = table;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
        }

        private void dgvLuong_pb_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtLuong.Text = row.Cells[2].Value.ToString();
                txtLuongThuong.Text = row.Cells[3].Value.ToString();
                txtGhichu.Text = row.Cells[4].Value.ToString();
                txtSNTC.Text = row.Cells[5].Value.ToString();
                txtTongLuong.Text = row.Cells[6].Value.ToString();

            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Enabled = false;
        }

        private void txtTenPB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelX8_Click(object sender, EventArgs e)
        {
            
        }

        //private void btnHienThi_Click(object sender, EventArgs e)
        //{
        //    load();
        //    //dgvLuong_pb.DataSource = ConnectDatabase.GetAllLuong_PB();
        //}

        private void cboPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            string tenpb = ((temp.SelectedValue) as DataRowView).Row[0].ToString();

            string sql = "SELECT n.MaNV as N'Mã nhân viên', HoTen as N'Họ và tên', LuongCB as N'Lương cơ bản', LuongThuong as N'Thưởng', GhiChu as N'Ghi chú', SoNgayTangCa as N'Số ngày tăng ca',TongLuong as N'Tổng lương' "
                       + " FROM NHANVIEN n INNER JOIN LUONG l ON n.MaNV = l.MaNV INNER JOIN PHONGBAN p ON n.MaPB = p.MaPB "
                       + " where TenPB = @tenpb ";

            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenpb", tenpb));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);


            }
            dgvLuong_pb.DataSource = dt;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
           
            Luong temp = new Luong(txtMaNV.Text, txtLuong.Text, txtLuongThuong.Text, txtGhichu.Text, txtSNTC.Text, txtTongLuong.Text);
            ConnectDatabase.SuaLuong_NV(temp);
            dgvLuong_pb.DataSource= ConnectDatabase.GetAllLuong_NV();
        }

        private void dgvLuong_pb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

        }
    }
}
