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

namespace QuanLyNhanSu
{
    public partial class frmLuong_CaNhan : Form
    {
        public frmLuong_CaNhan()
        {
            InitializeComponent();
        }
        //   SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLuong_CaNhan.DataSource = ConnectDatabase.TimKiemLuong_NhanVien(txtTimKiem.Text);
        }

        private void dgvLuong_CaNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
        }



        private void frmLuong_CaNhan_Load_2(object sender, EventArgs e)
        {
            this.dgvLuong_CaNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuong_CaNhan.DataSource = ConnectDatabase.GetAllLuong_NV();
        }

        private void dgvLuong_CaNhan_SelectionChanged(object sender, EventArgs e)
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

        private void btnThuong_Click(object sender, EventArgs e)
        {
            Luong temp = new Luong(txtMaNV.Text, txtLuong.Text, txtLuongThuong.Text, txtGhichu.Text, txtSNTC.Text, txtTongLuong.Text);
            ConnectDatabase.SuaLuong_NV(temp);
            dgvLuong_CaNhan.DataSource = ConnectDatabase.GetAllLuong_NV();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Enabled = false;
        }

        private void dgvLuong_CaNhan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            Luong temp = new Luong(txtMaNV.Text, txtLuong.Text, txtLuongThuong.Text, txtGhichu.Text, txtSNTC.Text, txtTongLuong.Text);
            ConnectDatabase.TongLuong_NV(temp);
            dgvLuong_CaNhan.DataSource = ConnectDatabase.GetAllLuong_NV();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
