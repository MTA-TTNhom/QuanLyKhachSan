using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykhachsan
{
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        int temp;
        private void hienthi()
        {
            nhanvienBLL pbll = new nhanvienBLL();
            dataGridView1.DataSource = pbll.hienthinhanvien();
        }
        private void trangthai(bool t)
        {
            //  txtmanv.Enabled = t;
            txttennv.Enabled = t;
            txtscm.Enabled = t;
            txtsdt.Enabled = t;
            txtdiachi.Enabled = t;
            dtngaysinh.Enabled = t;
            dtngayvaolam.Enabled = t;
            cbgioitinh.Enabled = t;

        }
    }
}
