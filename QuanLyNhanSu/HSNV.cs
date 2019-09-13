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
    public partial class HSNV : Form
    {
        public HSNV()
        {
            InitializeComponent();
        }
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

    }
}
