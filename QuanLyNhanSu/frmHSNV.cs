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

namespace QuanLiNhanSu
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
?
        private void btnEmployees_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Employees_Store info = new Employees_Store();
            info.init(idEmployees);
            showFormChild(info);
        }
        private void btnItem_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Item_Store info = new Item_Store();
            info.init(typeOfEmployees, idEmployees);
            showFormChild(info);
        }

        private void btnCustormer_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer_Store info = new Customer_Store();
            showFormChild(info);
        }

        private void btnSupplier_Store_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Supplier_Store info = new Supplier_Store();
            showFormChild(info);
        }

        private void btnInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inventory info = new Inventory();
            showFormChild(info);
        }

        private void btnStatistical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác minh", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnList_ReceiptVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListReceipt_Vou info = new ListReceipt_Vou();
            showFormChild(info);
        }

        private void btnList_IssueVou_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ListIssue_Vou info = new ListIssue_Vou();
            showFormChild(info);
        }
        #region BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

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
