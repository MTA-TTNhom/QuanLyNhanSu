using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class DangNhap
    {
        private string tenDN;
        private string matKhau;
        private string maNV;

        public string TenDN
        {
            get
            {
                return tenDN;
            }

            set
            {
                tenDN = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
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
        public DangNhap(string TenDN,string MatKhau, string MaNV)
        {
            this.tenDN = TenDN;
            this.matKhau = MatKhau;
            this.maNV = MaNV;
        }
    }
}
