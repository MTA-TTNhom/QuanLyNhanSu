using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmVTCV : Form
    {
        public frmVTCV()
        {
            InitializeComponent();
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            ViTri temp = new ViTri(txtMaVT.Text, txtTenVT.Text);
            if (ConnectDatabase.checkViTri(temp.Mavt) == 1)
            {
                MessageBox.Show("Mã vị trí đã tồn tại. Xin mời nhập mã khác!!!");
                return;

            }
            ConnectDatabase.ThemViTri(temp);
            dgvVT.DataSource = ConnectDatabase.getAllViTri();
        }
    }
}