﻿namespace GUI
{
    partial class Hang
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
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.MaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaL = new System.Windows.Forms.ComboBox();
            this.txtDonVT = new System.Windows.Forms.TextBox();
            this.txtDonG = new System.Windows.Forms.TextBox();
            this.txtSLC = new System.Windows.Forms.TextBox();
            this.txtTenH = new System.Windows.Forms.TextBox();
            this.txtMaH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaH,
            this.TenH,
            this.DonVT,
            this.DonG,
            this.MaL,
            this.MaNCC,
            this.SLC});
            this.dgvHang.EnableHeadersVisualStyles = false;
            this.dgvHang.Location = new System.Drawing.Point(12, 216);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersVisible = false;
            this.dgvHang.Size = new System.Drawing.Size(964, 281);
            this.dgvHang.TabIndex = 0;
            // 
            // MaH
            // 
            this.MaH.DataPropertyName = "MaH";
            this.MaH.HeaderText = "Mã hàng";
            this.MaH.Name = "MaH";
            // 
            // TenH
            // 
            this.TenH.DataPropertyName = "TenH";
            this.TenH.HeaderText = "Tên hàng";
            this.TenH.Name = "TenH";
            // 
            // DonVT
            // 
            this.DonVT.DataPropertyName = "DonVT";
            this.DonVT.HeaderText = "Đơn vị tính";
            this.DonVT.Name = "DonVT";
            // 
            // DonG
            // 
            this.DonG.DataPropertyName = "DonG";
            this.DonG.HeaderText = "Đơn giá";
            this.DonG.Name = "DonG";
            // 
            // MaL
            // 
            this.MaL.DataPropertyName = "MaL";
            this.MaL.HeaderText = "Loại hàng";
            this.MaL.Name = "MaL";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // SLC
            // 
            this.SLC.DataPropertyName = "SLC";
            this.SLC.HeaderText = "Số lượng";
            this.SLC.Name = "SLC";
            this.SLC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SLC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.cboMaL);
            this.panel1.Controls.Add(this.txtSLC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.cboMaNCC);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnNhapLai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDonVT);
            this.panel1.Controls.Add(this.txtDonG);
            this.panel1.Controls.Add(this.txtTenH);
            this.panel1.Controls.Add(this.txtMaH);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 198);
            this.panel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(0, 172);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(80, 172);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(891, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(159, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(238, 172);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(73, 23);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng có:";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(317, 172);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(73, 23);
            this.btnNhapLai.TabIndex = 18;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "NCC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đơn giá";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(812, 172);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(73, 23);
            this.btnXem.TabIndex = 21;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã hàng:";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(644, 41);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(317, 21);
            this.cboMaNCC.TabIndex = 6;
            // 
            // cboMaL
            // 
            this.cboMaL.FormattingEnabled = true;
            this.cboMaL.Location = new System.Drawing.Point(644, 0);
            this.cboMaL.Name = "cboMaL";
            this.cboMaL.Size = new System.Drawing.Size(317, 21);
            this.cboMaL.TabIndex = 5;
            // 
            // txtDonVT
            // 
            this.txtDonVT.Location = new System.Drawing.Point(73, 93);
            this.txtDonVT.Name = "txtDonVT";
            this.txtDonVT.Size = new System.Drawing.Size(317, 20);
            this.txtDonVT.TabIndex = 4;
            // 
            // txtDonG
            // 
            this.txtDonG.Location = new System.Drawing.Point(73, 130);
            this.txtDonG.Name = "txtDonG";
            this.txtDonG.Size = new System.Drawing.Size(317, 20);
            this.txtDonG.TabIndex = 3;
            // 
            // txtSLC
            // 
            this.txtSLC.Location = new System.Drawing.Point(644, 90);
            this.txtSLC.Name = "txtSLC";
            this.txtSLC.Size = new System.Drawing.Size(317, 20);
            this.txtSLC.TabIndex = 2;
            // 
            // txtTenH
            // 
            this.txtTenH.Location = new System.Drawing.Point(73, 45);
            this.txtTenH.Name = "txtTenH";
            this.txtTenH.Size = new System.Drawing.Size(317, 20);
            this.txtTenH.TabIndex = 1;
            // 
            // txtMaH
            // 
            this.txtMaH.Location = new System.Drawing.Point(73, 3);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(317, 20);
            this.txtMaH.TabIndex = 0;
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHang);
            this.Name = "Hang";
            this.Text = "Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonG;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaL;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaL;
        private System.Windows.Forms.TextBox txtDonVT;
        private System.Windows.Forms.TextBox txtDonG;
        private System.Windows.Forms.TextBox txtSLC;
        private System.Windows.Forms.TextBox txtTenH;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}