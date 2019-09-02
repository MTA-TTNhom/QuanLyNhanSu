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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");



        private void btnThemPB_Click(object sender, EventArgs e)
        { }


        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();


        }

        private void dgvCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.DataSource = ConnectDatabase.getAllChucVu();
        }

        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenCV_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNhaplai_Click_2(object sender, EventArgs e)
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemCV_Click_1(object sender, EventArgs e)
        {
            frmThemCV form = new frmThemCV();
            form.Show();


        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
