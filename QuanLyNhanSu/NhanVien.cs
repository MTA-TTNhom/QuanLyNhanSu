﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
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




        //public string Macv
        //{
        //    get
        //    {
        //        return macv;
        //    }

        //    set
        //    {
        //        macv = value;
        //    }
        //}









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


}
