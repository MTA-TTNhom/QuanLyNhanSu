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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }
		   public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)

        {
            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();

        }
		
    }
}
