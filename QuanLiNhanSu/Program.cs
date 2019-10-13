using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmMain frMain_main;
        public static string usernamelogin = "";
        [STAThread]
        static void Main()
        {
            ConnectDatabase.ConnectDB();
          //  Application.Run(new HSNV());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
            // Application.Run(new frmChucVu());
            //Application.Run(new FrmDanhMuc());
            //  Application.Run(new frmThemPB());
            // Application.Run(new frmPhongBan());
            //Application.Run(new frmLuong_CaNhan());
            //Application.Run(new frmHopDong());
            //Application.Run(new frmLuong_PB());
            // Application.Run(new frmNhanVien());
           // Application.Run(new frmMain());


        }
    }
}
