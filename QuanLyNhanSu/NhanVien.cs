using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class NhanVien
    {
        public string Manv { get; set; }
        public string Tennv { get; set; }
        public string Diachi { get; set; }
        private DateTime ngaysinh;
        private string bangcap;
        private string gt;
        private string mapb;
        private string tongiao;
        private string dantoc;
        private string sdt;
        private string cmt;



        public string Bangcap
        {
            get
            {
                return bangcap;
            }

            set
            {
                bangcap = value;
            }
        }

        public string Gt
        {
            get
            {
                return gt;
            }

            set
            {
                gt = value;
            }
        }
        public string Macv
        {
            get
         {
               return macv;
           }

           set
           {
               macv = value;
           }
        }
        public string Manv
        {
            get
            {
                return Manv;
            }

            set
            {
                Manv = value;
            }
        }
        public string Tennv
        {
            get
            {
                return Tennv;
            }

            set
            {
                Tennv = value;
            }
        }
        public string Diachi
        {
            get
            {
                return Diachi;
            }

            set
            {
                Diachi = value;
            }
        }
        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Bangcap
        {
            get
            {
                return bangcap;
            }

            set
            {
                bangcap = value;
            }
        }

        public string Gt
        {
            get
            {
                return gt;
            }

            set
            {
                gt = value;
            }
        }



        public string Tongiao
        {
            get
            {
                return tongiao;
            }

            set
            {
                tongiao = value;
            }
        }

        public string Dantoc
        {
            get
            {
                return dantoc;
            }

            set
            {
                dantoc = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Cmt
        {
            get
            {
                return cmt;
            }

            set
            {
                cmt = value;
            }
        }

        public string Mapb
        {
            get
            {
                return mapb;
            }

            set
            {
                mapb = value;
            }
        }

        public Them_NhanVien(string manv, string tennv, string bangcap, string gt, DateTime ngaysinh, string diachi, string mapb, string sdt, string cmt, string dantoc, string tongiao)
        {
            NhanVien a = new NhanVien();
            this.a.Manv = manv;
            this.a.Tennv = tennv;
            this.a.Bangcap = bangcap;
            this.a.Gt = gt;
            this.a.Ngaysinh = ngaysinh;
            this.a.Diachi = diachi;
            this.a.Mapb = mapb;
            this.a.Tongiao = tongiao;
            this.a.Dantoc = dantoc;
            this.a.Sdt = sdt;
            this.a.Cmt = cmt;

        }
        public Sua_NhanVien(NhanVien a,string manv1, string tennv1, string bangcap1, string gt1, DateTime ngaysinh1, string diachi1, string mapb1, string sdt1, string cmt1, string dantoc1, string tongiao1)
        {
           
            this.a.Manv = manv1;
            this.a.Tennv = tennv1;
            this.a.Bangcap = bangcap1;
            this.a.Gt = gt1;
            this.a.Ngaysinh = ngaysinh1;
            this.a.Diachi = diachi1;
            this.a.Mapb = mapb1;
            this.a.Tongiao = tongiao1;
            this.a.Dantoc = dantoc1;
            this.a.Sdt = sdt1;
            this.a.Cmt = cmt1;

        }
        public Xoa_NhanVien(NhanVien a)
        {

            this.a.Manv = '';
            this.a.Tennv = '';
            this.a.Bangcap = '';
            this.a.Gt = '';
            this.a.Ngaysinh = ''; 
            this.a.Diachi = '';
            this.a.Mapb = '';
            this.a.Tongiao = '';
            this.a.Dantoc = '';
            this.a.Sdt = '';
            this.a.Cmt = '';

        }
        public NhanVien(string manv, string tennv, string bangcap, string gt, DateTime ngaysinh, string diachi, string mapb, string sdt, string cmt, string dantoc, string tongiao)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Bangcap = bangcap;
            this.Gt = gt;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Mapb = mapb;
            this.Tongiao = tongiao;
            this.Dantoc = dantoc;
            this.Sdt = sdt;
            this.Cmt = cmt;

        }
    }
}
