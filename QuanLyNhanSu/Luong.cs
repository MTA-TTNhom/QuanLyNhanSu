using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Luong
    {
        private string LuongNV;
        private string LuongThuong;
        private string MaNV;
        private string SoNgayTangCa;
        private string Chichu;
        private string TongLuong;
        public string LuongNV1

        {
            get
            {
                return LuongNV;
            }

            set
            {
                LuongNV = value;
            }
        }

        public string LuongThuong1
        {
            get
            {
                return LuongThuong;
            }

            set
            {
                LuongThuong = value;
            }
        }

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }

        public string Chichu1
        {
            get
            {
                return Chichu;
            }

            set
            {
                Chichu = value;
            }
        }

        public string SoNgayTangCa1
        {
            get
            {
                return SoNgayTangCa;
            }

            set
            {
                SoNgayTangCa = value;
            }
        }

        public string TongLuong1
        {
            get
            {
                return TongLuong;
            }

            set
            {
                TongLuong = value;
            }
        }
        
        public Sua_Luong(NhanVien a,string manv, string luong, string luongthuong, string ghichu, string songaytangca, string tongluong)
        {
            
            this.a.MaNV = manv;
            this.a.LuongNV = luong;
            this.a.LuongThuong = luongthuong;
            this.a.Chichu = ghichu;
            this.a.SoNgayTangCa = songaytangca;
            this.a.TongLuong = tongluong;
        }
        public Them_Luong(string manv, string luong, string luongthuong, string ghichu, string songaytangca, string tongluong)
        {
            this.a.MaNV = manv;
            this.a.LuongNV = luong;
            this.a.LuongThuong = luongthuong;
            this.a.Chichu = ghichu;
            this.a.SoNgayTangCa = songaytangca;
            this.a.TongLuong = tongluong;
        }
        public Xoa_Luong(string manv, string luong, string luongthuong, string ghichu, string songaytangca, string tongluong)
        {
            this.a.MaNV = manv;
            this.a.LuongNV = 0;
            this.a.LuongThuong = 0;
            this.a.Chichu = '';
            this.a.SoNgayTangCa = 0;
            this.a.TongLuong = 0;
        }
        public Luong(string manv, string luong, string luongthuong, string ghichu, string songaytangca, string tongluong)
        {
            this.MaNV = manv;
            this.LuongNV = luong;
            this.LuongThuong = luongthuong;
            this.Chichu = ghichu;
            this.SoNgayTangCa = songaytangca;
            this.TongLuong = tongluong;
        }
    }
}
