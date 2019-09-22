using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class frmCoCauPhongBan : Form
    {
        public frmCoCauPhongBan()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");

        public void load()
        {

            SqlDataAdapter  dap = new SqlDataAdapter("SELECT TENPB FROM PHONGBAN", conn);
            var table = new DataTable();
            dap.Fill(table);
            cboPB.DisplayMember = "TenPB";
            cboPB.ValueMember = "MaPB";
            cboPB.DataSource = table;
        }

        private void cboPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox temp = sender as ComboBox;
            string tenpb = ((temp.SelectedValue) as DataRowView).Row[0].ToString();
            string sql = "select HoTen as N'Họ Tên', TenCV as N'Chức Vụ',TenVT, (year(getdate()) - year(NgaySinh)) as N'Tuổi' " 
                         + " from PHONGBAN p, NHANVIEN n, CHUCVU c, VITRICONGVIEC v, NHANVIEN_VITRI nv, NHANVIEN_CHUCVU nc "
                         + " where p.MaPB = n.MaPB and c.MaCV = nc.MaCV and TenPB = @tenpb and nv.MaVT = v.MaVT and nv.MaNV = n.MaNV and n.MaNV=nc.MaNV  ";
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenpb", tenpb));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            dgvCCPB.DataSource = dt;


        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void frmCoCauPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
