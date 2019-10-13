using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Data.OleDb;

namespace QuanLiNhanSu
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



        //----------------------------------------NHÂN VIÊN ---------------------------------------------
        public static DataTable DSNV()
        {
            string sql = "select n.MaNV as N'Mã nhân viên', HoTen as N'Họ tên',GioiTinh as N'Giới tính', n.DiaChi as N'Địa chỉ', NgaySinh as N'Ngày sinh', TenCV as N'Tên chức vụ',TenVT as N'Tên vị trí' ,TenPB as N'Tên phòng ban'"
                         + " from NHANVIEN n, PHONGBAN p, CHUCVU c, VITRICONGVIEC v, NHANVIEN_VITRI nv, NHANVIEN_CHUCVU nc "
                         + " where nc.MaCV = c.MaCV and n.MaPB = p.MaPB and v.MaVT = nv.MaVT and n.MaNV = nv.MaNV and nc.MaNV = n.MaNV ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public static string getTenTruongPhongTuMaTruongPhong(string matp)
        {
            if (matp == "") return "";
            string sql = "select NHANVIEN.HoTen from NHANVIEN where NHANVIEN.MaNV = @matp";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@matp", matp));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return dataReader[0].ToString();
                    }
                }
            }
            return "Không tồn tại";
        }
        public static string getTenNhanVienTuMaNhanVien(string manv)
        {
            if (manv == "") return "";
            string sql = "select NHANVIEN.HoTen from NHANVIEN where NHANVIEN.MaNV = @manv";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", manv));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return dataReader[0].ToString();
                    }



                }
            }
            return "Không tồn tại";
        }
        public static string getTenPhongBanTuMaPhongBan(string mapb)
        {
            if (mapb == "") return "";
            string sql = "select TenPB from PhongBan where MaPB = @mapb";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mapb", mapb));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return dataReader[0].ToString();
                    }



                }
            }
            return "Không tồn tại";
        }


        public static DataTable getAllNhanVien()
        {
            string sql = "select * from NHANVIEN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable TimKiemNhanVien(string nv)
        {
            string sql = "select * from NHANVIEN n where ((MaNV like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(HoTen like '%' + @text + '%'))";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", nv);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;
        }


        public static void ThemNhanVien(NhanVien nhanvien)
        {

            string sql = "insert into NHANVIEN(MaNV, HoTen, BangCap, GioiTinh, NgaySinh, DiaChi, MaPB, CMTND, SDT, DanToc, TonGiao) values(@manv, @tennv, @bangcap, @gioitinh, CONVERT(date, @ngaysinh, 111), @diachi, @mapb, @cmt, @sdt, @dt, @tg)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", nhanvien.Manv));
                command.Parameters.Add(new SqlParameter("@tennv", nhanvien.Tennv));
                command.Parameters.Add(new SqlParameter("@bangcap", nhanvien.Bangcap));
                command.Parameters.Add(new SqlParameter("@gioitinh", nhanvien.Gt));
                command.Parameters.Add(new SqlParameter("@ngaysinh", nhanvien.Ngaysinh.GetDateTimeFormats()[6]));
                command.Parameters.Add(new SqlParameter("@diachi", nhanvien.Diachi));
                command.Parameters.Add(new SqlParameter("@mapb", nhanvien.Mapb));
                command.Parameters.Add(new SqlParameter("@cmt", nhanvien.Cmt));
                command.Parameters.Add(new SqlParameter("@sdt", nhanvien.Sdt));
                command.Parameters.Add(new SqlParameter("@dt", nhanvien.Dantoc));
                command.Parameters.Add(new SqlParameter("@tg", nhanvien.Tongiao));




                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!");
                }
                else MessageBox.Show("Thêm nhân viên mới thất bại!");
                command.Cancel();


            }
        }


        public static void SuaNhanVien(NhanVien nhanvien)
        {
            string sql = "UPDATE NHANVIEN set HoTen=@tennv, DiaChi=@diadiem, CMTND=@cmt, SDT=@sdt, DanToc=@dt, TonGiao=@tg, BangCap=@bangcap, MaPB=@mapb, GioiTinh=@gioitinh, NgaySinh=CONVERT(date, @ngaysinh, 111) where MaNV=@manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", nhanvien.Manv));
                command.Parameters.Add(new SqlParameter("@tennv", nhanvien.Tennv));
                command.Parameters.Add(new SqlParameter("@bangcap", nhanvien.Bangcap));
                command.Parameters.Add(new SqlParameter("@gioitinh", nhanvien.Gt));
                command.Parameters.Add(new SqlParameter("@ngaysinh", nhanvien.Ngaysinh.GetDateTimeFormats()[6]));
                command.Parameters.Add(new SqlParameter("@diadiem", nhanvien.Diachi));
                command.Parameters.Add(new SqlParameter("@mapb", nhanvien.Mapb));
                command.Parameters.Add(new SqlParameter("@cmt", nhanvien.Cmt));
                command.Parameters.Add(new SqlParameter("@sdt", nhanvien.Sdt));
                command.Parameters.Add(new SqlParameter("@dt", nhanvien.Dantoc));
                command.Parameters.Add(new SqlParameter("@tg", nhanvien.Tongiao));

                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void XoaNhanVien(NhanVien nv)
        {

            string sql = "DELETE NHANVIEN  where MaNV=@manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", nv.Manv));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static int checkNhanVien(string manv)
        {

            string sql = "select * from NHANVIEN n where ((MaNV like '%' + @text + '%'))";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", manv));
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

        //---------------------------------LƯƠNG--------------------------------------------

        public static DataTable TimKiemLuong_NhanVien(string nv)
        {

            string sql = "select NHANVIEN n,LUONG l where (MaNV like '%' + @text + '%') or (HoTen like '%' + @text + '%') and n.MaNV=l.MaNV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", nv);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;
        }
        public static void SuaLuong_NV(Luong luong)
        {
            string sql = "UPDATE LUONG set LuongCB=@luongCB, LuongThuong=@luongthuong, GhiChu=@ghichu, SoNgayTangCa = @SNTC, TongLuong = @TongLuong where MaNV=@manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@luongCB", luong.LuongNV1));
                command.Parameters.Add(new SqlParameter("@luongthuong", luong.LuongThuong1));
                command.Parameters.Add(new SqlParameter("@ghichu", luong.Chichu1));
                command.Parameters.Add(new SqlParameter("@SNTC", luong.SoNgayTangCa1));
                command.Parameters.Add(new SqlParameter("@TongLuong", luong.TongLuong1));
                command.Parameters.Add(new SqlParameter("@manv", luong.MaNV1));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void SuaLuong_PB(Luong luong)
        {
            string sql = "UPDATE LUONG set LuongCB=@luongCB, LuongThuong=@luongthuong, GhiChu=@ghichu, SoNgayTangCa = @SNTC, TongLuong = @TongLuong where MaNV=@manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@luongCB", luong.LuongNV1));
                command.Parameters.Add(new SqlParameter("@luongthuong", luong.LuongThuong1));
                command.Parameters.Add(new SqlParameter("@ghichu", luong.Chichu1));
                command.Parameters.Add(new SqlParameter("@SNTC", luong.SoNgayTangCa1));
                command.Parameters.Add(new SqlParameter("@TongLuong", luong.TongLuong1));
                command.Parameters.Add(new SqlParameter("@manv", luong.MaNV1));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void TongLuong_NV(Luong luong)
        {
            string sql = "update LUONG set TongLuong = SoNgayTangCa * 50000 + LuongCB + LuongThuong where MaNV = @manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@luongCB", luong.LuongNV1));
                command.Parameters.Add(new SqlParameter("@luongthuong", luong.LuongThuong1));
                command.Parameters.Add(new SqlParameter("@ghichu", luong.Chichu1));
                command.Parameters.Add(new SqlParameter("@SNTC", luong.SoNgayTangCa1));
                command.Parameters.Add(new SqlParameter("@TongLuong", luong.TongLuong1));
                command.Parameters.Add(new SqlParameter("@manv", luong.MaNV1));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static DataTable GetAllLuong()
        {
            string sql = "select * from LUONG  ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable GetAllLuong_NV()
        {
            string sql = "select n.MaNV as N'Mã nhân viên', HoTen as N'Họ và tên', LuongCB as N'Lương cơ bản', LuongThuong as N'Thưởng', GhiChu as N'Ghi chú', SoNgayTangCa as N'Số ngày tăng ca', TongLuong as N'Tổng Lương' from NHANVIEN n, LUONG l where n.MaNV=l.MaNV  ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable GetAllLuong_PB()
        {
            string sql = "SELECT n.MaNV as N'Mã nhân viên', HoTen as N'Họ và tên', LuongCB as N'Lương cơ bản', LuongThuong as N'Thưởng', GhiChu as N'Ghi chú', SoNgayTangCa as N'Số ngày tăng ca',TongLuong as N'Tổng lương' "
                       + " FROM NHANVIEN n INNER JOIN LUONG l ON n.MaNV = l.MaNV INNER JOIN PHONGBAN p ON n.MaPB = p.MaPB "
                       + " where TenPB = @tenpb ";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable timKiemLuong_PhongBan(string pb)
        {
            string sql = "select * from LUONG p where ((TenPB like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(MaPB like '%' + @text + '%') or(TenTP like '%' + @text + '%')) or(MaTP = @text) ";



            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", pb);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;
        }


        //--------------------------------CHỨC VỤ--------------------------------------
        public static DataTable getAllChucVu()
        {
            string sql = "select *from CHUCVU";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable TimKiemChucVu(string cv)
        {
            string sql = "select * from CHUCVU p where (TenCV like '%'+@text+'%') or (MaCV like '%'+@text+'%') ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", cv);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;


        }
        public static void XoaChucVu(ChucVu cv)
        {
            string sql = "DELETE FROM CHUCVU  where MaCV=@macv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@macv", cv.Macv));
                command.ExecuteNonQuery();
                command.Cancel();


            }
        }
        public static void SuaChucVu(ChucVu cv)
        {
            string sql = "UPDATE CHUCVU set TenCV=@tencv where MaCV=@macv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tencv", cv.Tencv));
                command.Parameters.Add(new SqlParameter("@macv", cv.Macv));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void ThemChucVu(ChucVu chucvu)
        {
            string sql = "insert into CHUCVU(MaCV, TenCV) values(@macv, @tencv)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@macv", chucvu.Macv));
                command.Parameters.Add(new SqlParameter("@tencv", chucvu.Tencv));


                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm chức vụ mới thành công!");
                }
                else MessageBox.Show("Thêm chức vụ mới thất bại!");
                command.Cancel();

            }
        }

        public static void SuaLuong_PhongBan(Luong l, ChucVu cv, NhanVien nv)
        {
            //string sql = "UPDATE LUONG set Luong = @luong, LuongThuong=@luongthuong, GhiChu=@ghichu where MaNV=@manv";

            //using (SqlCommand command = new SqlCommand(sql, conn))
            //{
            //    command.Parameters.Add(new SqlParameter("@tencv", cv.Tencv));
            //    command.Parameters.Add(new SqlParameter("@macv", cv.Macv));
            //    command.ExecuteNonQuery();
            //    command.Cancel();
            //}
        }
        public static int checkChucVu(string cv)
        {

            string sql = "select * from CHUCVU p where (TenCV like '%'+@text+'%') or (MaCV like '%'+@text+'%') ";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", cv));
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


        //---------------------------------------------HỢP ĐỒNG ------------------------------------------------------
        public static DataTable getAllHopDong()
        {

            string sql = "select * from HDLD";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public static void ThemHopDong(HopDong hd)
        {
            string sql = "insert into HDLD(MaHD, TenHD, MaNV, NgayKiHopDong, NgayKetThucKiHopDong) values(@mahd, @tenhd, @manv,CONVERT(date, @ngaybd, 111),CONVERT(date, @ngaykt, 111))";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mahd", hd.MaHD));
                command.Parameters.Add(new SqlParameter("@tenhd", hd.TenHD));
                command.Parameters.Add(new SqlParameter("@manv", hd.MaNV));
                command.Parameters.Add(new SqlParameter("@ngaybd", hd.DateBD.GetDateTimeFormats()[6]));
                command.Parameters.Add(new SqlParameter("@ngaykt", hd.DateKT.GetDateTimeFormats()[6]));

                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm hợp đồng mới thành công!");
                }
                else MessageBox.Show("Thêm hợp đồng mới thất bại!");
                command.Cancel();
            }




        }

        public static void SuaHopDong(HopDong hd)
        {
            string sql = "UPDATE HDLD set TenHD=@tenhd, MaNV=@manv,  NgayKiHopDong=CONVERT(date, @datebd, 111), NgayKetThucKiHopDong = CONVERT(date,@datekt, 111) where MaHD=@mahd";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mahd", hd.MaHD));
                command.Parameters.Add(new SqlParameter("@tenhd", hd.TenHD));
                command.Parameters.Add(new SqlParameter("@manv", hd.MaNV));
                command.Parameters.Add(new SqlParameter("@datebd", hd.DateBD.GetDateTimeFormats()[6]));
                command.Parameters.Add(new SqlParameter("@datekt", hd.DateKT.GetDateTimeFormats()[6]));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }

        public static void XoaHopDong(HopDong hd)
        {
            string sql = "DELETE from HDLD  where MaHD=@mahd";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mahd", hd.MaHD));

                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void ThemTaiKhoan(DangNhap dn)
        {
            string sql = "insert into DANGNHAP(TenDN, MatKhau, MaNV) values(@tendn, @mk, @manv)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tendn", dn.TenDN));
                command.Parameters.Add(new SqlParameter("@mk", dn.MatKhau));
                command.Parameters.Add(new SqlParameter("@manv", dn.MaNV));

                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm tài khoản mới thành công!");
                }
                else MessageBox.Show("Thêm tài khoản mới thất bại!");
                command.Cancel();
            }
        }


        //---------------------------VỊ TRÍ----------------------------

        public static DataTable getAllViTri()
        {
            string sql = "select *from VITRICONGVIEC";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable TimKiemViTri(string vt)
        {
            string sql = "select * from ViTRICONGVIEC v where (TenVT like '%'+@text+'%') or (MaVT like '%'+@text+'%') ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", vt);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;


        }
        public static void XoaViTri(ViTri vt)
        {
            string sql = "DELETE FROM VITRICONGVIEC  where MaVT=@mavt";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mavt", vt.Mavt));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static void SuaViTri(ViTri vt)
        {
            string sql = "UPDATE VITRICONGVIEC set TenVT=@tenvt where MaVT=@mavt";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenvt", vt.Tenvt));
                command.Parameters.Add(new SqlParameter("@mavt", vt.Mavt));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static int checkViTri(string maVT)
        {

            string sql = "select * from ViTRICONGVIEC v where (TenVT like '%'+@text+'%') or (MaVT like '%'+@text+'%') ";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", maVT));
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

        public static void ThemViTri(ViTri vt)
        {
            string sql = "insert into VITRICONGVIEC(MaVT, TenVT) values(@mavt, @tenvt)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mavt", vt.Mavt));
                command.Parameters.Add(new SqlParameter("@tenvt", vt.Tenvt));


                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm vị trí mới thành công!");
                }
                else MessageBox.Show("Thêm vị trí mới thất bại!");
                command.Cancel();

            }
        }
        public static DataTable PhanCongViTri()
        {
            string sql = "select n.MaNV, HoTen, v.MaVT, TenVT from NHANVIEN n,VITRICONGVIEC v , NHANVIEN_VITRI nv where n.MaNV=nv.MaNV and v.MaVT=nv.MaVT";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static void SuaViTri_NhanVien(PhanCong_ViTri p)
        {
            string sql = "UPDATE NHANVIEN_VITRI set MaVT=@mavt where  MaNV=@manv";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@manv", p.MaNV1));
                command.Parameters.Add(new SqlParameter("@mavt", p.MaVT1));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }
        public static string getTenViTriTuMaViTri(string mavt)
        {
            if (mavt == "") return "";
            string sql = "select TenVT from VITRICONGVIEC where MaVT = @mavt";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mavt", mavt));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return dataReader[0].ToString();
                    }



                }
            }
            return "Không tồn tại";
        }
        //public static void ThemMaNV_ViTri(PhanCong_ViTri p)
        //{
        //    string sql = "insert into NhanVien_ViTri(MaVT, MaNV) values(@mavt, @manv)";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    using (SqlCommand command = new SqlCommand(sql, conn))
        //    {
        //        command.Parameters.Add(new SqlParameter("@mavt", p.MaVT1));
        //        command.Parameters.Add(new SqlParameter("@manv", p.MaNV1));



        //        int kq = command.ExecuteNonQuery();
        //        if (kq > 0)
        //        {
        //            MessageBox.Show("Thêm mới thành công!");
        //        }
        //        else MessageBox.Show("Thêm mới thất bại!");
        //        command.Cancel();
        //    }


    }
}
