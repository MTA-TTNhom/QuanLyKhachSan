﻿using System;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button6.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            dataGridView1.SelectedColumns.Contains();
            DataGridViewAdvancedBorderStyle a = new DataGridViewAdvancedBorderStyle();
            a.Bottom();
            DataGridViewAutoSizeModeEventArgs test = new DataGridViewAutoSizeModeEventArgs();
            test.ToString();
            frmkhachhang open = new frmkhachhang();
            open.Visible = false;
            open.ShowIcon = true;
            open.RectangleToScreen = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox1.SelectedValue.ToString("Khach hang");
            ComboBoxStyle a = new ComboBoxStyle();
            a.Equals.FormClosing();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pictureBox1.Image.PropertyItems = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmmain a = new frmmain();
            a.AddOwnedForm();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.OnFormClosing();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
