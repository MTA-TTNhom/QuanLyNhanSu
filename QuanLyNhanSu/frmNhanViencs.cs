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
    public partial class frmNhanViencs : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();

            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();

        }

        private void HSNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSNV frm = new HSNV();
            frm.Show();
        }
        public void load()

        {
            this.dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = ConnectDatabase.TimKiemNhanVien(txtTimKiem.Text);
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNV frm = new frmThemNV();
            frm.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView table = sender as DataGridView;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtBangCap.Text = row.Cells[2].Value.ToString();
                txtGT.Text = row.Cells[3].Value.ToString();
                dateNS.Value = row.Cells[4].Value == null ? DateTime.Now : (DateTime)row.Cells[4].Value;
                txtDC.Text = row.Cells[5].Value.ToString();
                txtMaPB.Text = row.Cells[6].Value.ToString();
                txtCMT.Text = row.Cells[7].Value.ToString();
                txtSDT.Text = row.Cells[8].Value.ToString();
                txtDT.Text = row.Cells[9].Value.ToString();
                txtTG.Text = row.Cells[10].Value.ToString();



            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtBangCap.Text, txtGT.Text, dateNS.Value, txtDC.Text, txtMaPB.Text, txtCMT.Text, txtSDT.Text, txtDT.Text, txtTG.Text);
            ConnectDatabase.XoaNhanVien(temp);
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
            MessageBox.Show("Xóa nhân viên thành công!!");
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien(txtMaNV.Text, txtTenNV.Text, txtBangCap.Text, txtGT.Text, dateNS.Value, txtDC.Text, txtMaPB.Text, txtSDT.Text, txtCMT.Text, txtDT.Text, txtTG.Text);
            ConnectDatabase.SuaNhanVien(temp);
            dgvNhanVien.DataSource = ConnectDatabase.getAllNhanVien();
            MessageBox.Show("Sửa nhân viên thành công!!");
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}
