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
            txttennv.Enabled = t;
            txtscm.Enabled = t;
            txtsdt.Enabled = t;
            txtdiachi.Enabled = t;
            dtngaysinh.Enabled = t;
            dtngayvaolam.Enabled = t;
            cbgioitinh.Enabled = t;
        }
        private void frm_load(object sender, EventArgs e)
        {
            nhanvienBLL pbll = new nhanvienBLL();
            dataGridView1.DataSource = pbll.hienthinhanvien();
            trangthai(false);
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtmanv.Text = row.Cells["maNhanVien"].Value.ToString();
            txttennv.Text = row.Cells["hoTen"].Value.ToString();
            txtscm.Text = row.Cells["soChungMinh"].Value.ToString();
            txtsdt.Text = row.Cells["soDienThoai"].Value.ToString();
            txtdiachi.Text = row.Cells["diaChi"].Value.ToString();
            cbgioitinh.Text = row.Cells["gioiTinh"].Value.ToString();
            dtngaysinh.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value.ToString());
            dtngayvaolam.Value = Convert.ToDateTime(row.Cells["ngayVaoLam"].Value.ToString());
        }
    }
}
