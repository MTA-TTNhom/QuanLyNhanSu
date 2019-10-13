using Microsoft.Reporting.WinForms;
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
    public partial class HSNV : Form
    {
        static SqlConnection conn;
        public HSNV()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");
        }

        private void HSNV_Load(object sender, EventArgs e)
        {
            
            this.rpvNV.RefreshReport();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ThongTinnhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@MaNV", cboMaNV.Text));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            rpvNV.ProcessingMode = ProcessingMode.Local;
            rpvNV.LocalReport.ReportPath = "HSNV.rdlc";

            if ((ds.Tables[0].Rows.Count > 0))
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "SoYeuLyLich";
                rds.Value = ds.Tables[0];

                rpvNV.LocalReport.DataSources.Clear();
                rpvNV.LocalReport.DataSources.Add(rds);
                rpvNV.RefreshReport();
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}