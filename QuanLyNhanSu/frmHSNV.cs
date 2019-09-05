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
    public partial class frmHSNV : Form
    {
        public frmHSNV()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");

        private void txtTenNV_HSNV_TextChanged(object sender, EventArgs e)
        {
            //    TextBox temp = sender as TextBox;
            //    string tennv = temp.Text;

            //    string sql = "SELECT TenNV from NHANVIEN";
            //    DataTable dt = new DataTable();
            //    using (SqlCommand command = new SqlCommand(sql, conn))
            //    {
            //        command.Parameters.Add(new SqlParameter("@macv", ten));

            //        SqlDataAdapter da = new SqlDataAdapter(command);
            //        da.Fill(dt);


            //    }
            //    .DataSource = dt;
        }

        private void frmHSNV_Load(object sender, EventArgs e)
        {

        }

        private void reflectionImage1_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}
