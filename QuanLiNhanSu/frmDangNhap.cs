﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap close = new frmDangNhap();
            frmDangKy open = new frmDangKy();
            open.Show();
            close.Hide();
            close.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
