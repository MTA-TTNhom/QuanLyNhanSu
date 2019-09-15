using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu



{
    class ConnectDatabase
    {



        static SqlConnection conn;





        public static void ConnectDB()
        {






            conn = new SqlConnection(@"Data Source=DESKTOP-UJHK73G\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True");
            conn.Open();
        }
















        //SqlCommand sqlcom;
        //SqlDataAdapter sqlda;
        //SqlDataReader sqldr;
        //void ngatketnoi()
        //{
        //    conn.Close();
        //}
        //public bool KiemTra(string dauvao, string strsql)
        //{
        //    bool ok = false;
        //    ConnectDB();
        //    sqlcom = new SqlCommand(strsql, conn);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
        //            ok = true;
        //    }
        //    ngatketnoi();
        //    return ok;
        //}







        public static bool Login(string tk, string mk)


        {



            string sql = "select * from [DANGNHAP] where TenDN=@usr and MatKhau=@pass";



            using (SqlCommand command = new SqlCommand(sql, conn))
            {


                command.Parameters.Add(new SqlParameter("@usr", tk));


                command.Parameters.Add(new SqlParameter("@pass", mk));

                using (SqlDataReader dataReader = command.ExecuteReader())
                {



                    if (dataReader.Read() == true)


                    {
                        Program.usernamelogin = tk;


                        return true;
                    }


                }

            }
            return false;
        }
        public static void thayDoiMatKhau(string tk, string mk)


        {


            string sql = "UPDATE DANGNHAP set MatKhau=@mk where TenDN=@tk";

            using (SqlCommand command = new SqlCommand(sql, conn))


            {
                command.Parameters.Add(new SqlParameter("@mk", mk));


                command.Parameters.Add(new SqlParameter("@tk", tk));


                command.ExecuteNonQuery();


                command.Cancel();
            }


        }



        //----------------------------------PHÒNG BAN-------------------------------------
        public static DataTable getAllPhongBan()


        {
            string sql = "select *from PHONGBAN";


            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);


            DataTable dt = new DataTable();


            dap.Fill(dt);
            return dt;


        }
        public static DataTable getPhongBan(string a)

        {

            string sql = "select " + a + " from PHONGBAN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable getTenPhongBan(string tenpb)
        {



            string sql = "select n.MaNV as N'Mã nhân viên', HoTen as N'Họ tên', LuongCB as N'Lương', LuongThuong as N'Thưởng', GhiChu as N'Ghi chú', TenPB as N'Tên phòng ban' from PHONGBAN p, NHANVIEN n, LUONG l where l.MaNV=n.MaNV and p.MaPB=n.MaPB and TenPB=@tenpb ";

            DataTable dt = new DataTable();

            using (SqlCommand command = new SqlCommand(sql, conn))

            {
                command.Parameters.Add(new SqlParameter("@tenpb", tenpb));


                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);



            }

            return dt;
        }







        public static DataTable timKiemPhongBan(string pb)


        {
            string sql = "select * from PHONGBAN p where ((TenPB like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(MaPB like '%' + @text + '%') or(TenTP like '%' + @text + '%') or(MaTP like '%' + @text + '%'))";

            SqlCommand cmd = new SqlCommand(sql, conn);



            cmd.Parameters.AddWithValue("text", pb);


            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable sttable = new DataTable();

            adapter.Fill(sttable);

            return sttable;
        }









        public static void ThemPhongBan(PhongBan phongban)

        {
            string sql = "insert into PHONGBAN(MaPB, TenPB, DiaChi, MaTP, TenTP) values(@mapb, @tenpb, @diachi, @matp, @tentp)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mapb", phongban.Mapb));


                command.Parameters.Add(new SqlParameter("@tenpb", phongban.Tenpb));


                command.Parameters.Add(new SqlParameter("@diachi", phongban.Diachi));

                command.Parameters.Add(new SqlParameter("@matp", phongban.Matp));


                command.Parameters.Add(new SqlParameter("@tentp", phongban.Tentp));

                int kq = command.ExecuteNonQuery();

                if (kq > 0)

                {
                    MessageBox.Show("Thêm phòng ban mới thành công!");
                }

                else MessageBox.Show("Thêm phòng ban mới thất bại!");


                command.Cancel();
            }


        }






        public static void XoaPhongBan(PhongBan pb)
        {

            string sql = "DELETE PHONGBAN  where MaPB=@mapb";


            using (SqlCommand command = new SqlCommand(sql, conn))


            {


                command.Parameters.Add(new SqlParameter("@mapb", pb.Mapb));


                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void SuaPhongBan(PhongBan pb)
        {
            string sql = "UPDATE PHONGBAN set TenPB=@tenpb, DiaChi=@diadiem,MaTP=@matp,  TenTP=@tentp where MaPB=@mapb";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {


                command.Parameters.Add(new SqlParameter("@tenpb", pb.Tenpb));


                command.Parameters.Add(new SqlParameter("@diadiem", pb.Diachi));


                command.Parameters.Add(new SqlParameter("@tentp", pb.Tentp));


                command.Parameters.Add(new SqlParameter("@matp", pb.Matp));

                command.Parameters.Add(new SqlParameter("@mapb", pb.Mapb));

                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static int checkPhongBan(string mapb)
        {

            string sql = "select * from PHONGBAN p where ((TenPB like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(MaPB like '%' + @text + '%') or(TenTP like '%' + @text + '%') or(MaTP like '%' + @text + '%'))";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", mapb));

                using (SqlDataReader dataReader = command.ExecuteReader())

                {



                    if (dataReader.Read() == true)


                    {

                        return 1;
                    }



                }
            }
            return 0;
        }
        





























    }



}
