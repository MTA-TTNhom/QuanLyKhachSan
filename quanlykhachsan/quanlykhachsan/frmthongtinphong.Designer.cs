﻿namespace quanlykhachsan
{
    partial class frmthongtinphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongiaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.btnsuaphong = new System.Windows.Forms.Button();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.btnluuphong = new System.Windows.Forms.Button();
            this.btnthoatphong = new System.Windows.Forms.Button();
            this.cbloaiphong = new System.Windows.Forms.ComboBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "THÔNG TIN PHÒNG";
            // 
            // txtphong
            // 
            this.txtphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtphong.Location = new System.Drawing.Point(188, 272);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(159, 26);
            this.txtphong.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Loại phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(454, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tình trạng phòng :";
            // 
            // txtdongiaphong
            // 
            this.txtdongiaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdongiaphong.Location = new System.Drawing.Point(588, 334);
            this.txtdongiaphong.Name = "txtdongiaphong";
            this.txtdongiaphong.Size = new System.Drawing.Size(159, 26);
            this.txtdongiaphong.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(454, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Đơn giá :";
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Items.AddRange(new object[] {
            "Rỗi",
            "Bận"});
            this.cbtinhtrang.Location = new System.Drawing.Point(588, 274);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(159, 27);
            this.cbtinhtrang.TabIndex = 46;
            // 
            // btnthemphong
            // 
            this.btnthemphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemphong.Location = new System.Drawing.Point(124, 398);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(73, 31);
            this.btnthemphong.TabIndex = 47;
            this.btnthemphong.Text = "Thêm";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuaphong.Location = new System.Drawing.Point(251, 398);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(73, 31);
            this.btnsuaphong.TabIndex = 48;
            this.btnsuaphong.Text = "Sửa";
            this.btnsuaphong.UseVisualStyleBackColor = true;
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoaphong.Location = new System.Drawing.Point(373, 398);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(73, 31);
            this.btnxoaphong.TabIndex = 49;
            this.btnxoaphong.Text = "Xóa";
            this.btnxoaphong.UseVisualStyleBackColor = true;
        }

        #endregion
    }
}