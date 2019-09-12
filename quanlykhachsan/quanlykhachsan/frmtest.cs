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
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap a = new frmdangnhap();
            a.Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmmainquanlykhachsan a = new frmmainquanlykhachsan();
            a.FormClosed();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormClosing();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.VisibleChanged = true;
            button3.Enabled = true;
            button4.Visible = false;
            button5.Enabled = true;
            button6.UseVisualStyleBackColor.Equals();
        }
    }
}
