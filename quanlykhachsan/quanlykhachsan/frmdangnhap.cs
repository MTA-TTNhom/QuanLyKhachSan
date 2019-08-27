using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace quanlykhachsan
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        
        private void trangthai( bool t)
        {
            txttaikhoan.Enabled = t;
            txtmatkhau.Enabled = t;
        }

        private void frm_load(object sender, EventArgs e)
        {
          
        }

        private void cbkhach_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkhach.Checked == true)
            {
                trangthai(false);
                txtmatkhau.Clear();
                txttaikhoan.Clear();
            }
            else
            {
                trangthai(true);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }
    }
}
