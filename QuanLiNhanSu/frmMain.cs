using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            chenBang();
        }
        private void chenBang()
        {
            BindingSource soureTB = new BindingSource();
            soureTB.DataSource = ConnectDatabase.getAllNhanVien();
            dgwTotal.DataSource = soureTB;
        }
        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void CV_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar4_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        public static frmPhongBan form_phongban = new frmPhongBan();
        private void btnfrmMain_PB_Click(object sender, EventArgs e)
        {
            form_phongban = new frmPhongBan();
            form_phongban.Show();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNhanVien_Main_Click(object sender, EventArgs e)
        {
            frmHSNV frm = new frmHSNV();
            frm.Show();
        }
        public static frmChucVu frm_ChucVu;
        private void btnChucVu_Main_Click(object sender, EventArgs e)
        {
            frm_ChucVu = new frmChucVu();
            frm_ChucVu.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.usernamelogin = "";
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.Show();


        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void btnPhongBan_QLLuong_Click(object sender, EventArgs e)
        {
            frmLuong_PB frm = new frmLuong_PB();
            frm.Show();
        }

        private void btnCaNhan_QLLuong_Click(object sender, EventArgs e)
        {
            frmLuong_CaNhan frm = new frmLuong_CaNhan();
            frm.Show();
        }

        private void ribbonTabItem6_Click(object sender, EventArgs e)
        {
           
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.Show();
        }

        private void dgwTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan();
            frm.Show();
        }

        private void ribbonControl1_Click_2(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem5_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Program.usernamelogin = "";
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan();
            frm.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.Show();
        }

        private void trogiup_Click(object sender, EventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            frm.Show();
        }

        private void btnvtcv_Click(object sender, EventArgs e)
        {
            frmVTCV frm = new frmVTCV();
            frm.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            frmHopDong frm = new frmHopDong();
            frm.Show();
        }
    }
}
