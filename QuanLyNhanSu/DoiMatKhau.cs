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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtTenDN.ReadOnly = true;
            txtTenDN.Text = Program.usernamelogin;
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


        #region Hien thi ComboBox trong DataGridView

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


        #region Hien thi ComboBox trong DataGridView

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
     
        private void btnLuu_Click(object sender, EventArgs e)
        {
            status.ForeColor = Color.Red;
            if (ConnectDatabase.Login(txtTenDN.Text, txtmatkhaucu.Text) == false)
            {
                status.Text = "Sai mật khẩu!!";
                return;
            }
            if (txtmatkhaumoi.Text != txtnhaplaimatkhaumoi.Text)
            {
                status.Text = "Mật khẩu nhập lại không trùng khớp !!";
                return;
            }
            ConnectDatabase.thayDoiMatKhau(txtTenDN.Text, txtmatkhaumoi.Text);
            status.ForeColor = Color.Blue;
            status.Text = "Đã đổi mật khẩu!";
        }

      

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            status.ForeColor = Color.Red;
            if (ConnectDatabase.Login(txtTenDN.Text, txtmatkhaucu.Text) == false)
            {
                status.Text = "Sai mật khẩu!!";
                return;
            }
            if (txtmatkhaumoi.Text != txtnhaplaimatkhaumoi.Text)
            {
                status.Text = "Mật khẩu nhập lại không trùng khớp !!";
                return;
            }
            ConnectDatabase.thayDoiMatKhau(txtTenDN.Text, txtmatkhaumoi.Text);
            status.ForeColor = Color.Blue;
            status.Text = "Đã đổi mật khẩu!";
        }
    }
}
