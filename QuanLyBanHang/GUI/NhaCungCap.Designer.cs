﻿namespace GUI
{
    partial class NhaCungCap
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
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.bnNhapLai = new System.Windows.Forms.Button();
            this.bnThem = new System.Windows.Forms.Button();
            this.bnSua = new System.Windows.Forms.Button();
            this.bnXoa = new System.Windows.Forms.Button();
            this.bnXem = new System.Windows.Forms.Button();
            this.bnThoat = new System.Windows.Forms.Button();
            this.bnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SoDT});
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.Location = new System.Drawing.Point(9, 188);
            this.dgvNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(716, 230);
            this.dgvNCC.TabIndex = 0;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số ĐT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(119, 26);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(392, 20);
            this.txtMaNCC.TabIndex = 5;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(119, 60);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(392, 20);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(119, 100);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(392, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(119, 138);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(392, 20);
            this.txtSoDT.TabIndex = 8;
            // 
            // bnNhapLai
            // 
            this.bnNhapLai.Location = new System.Drawing.Point(548, 23);
            this.bnNhapLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnNhapLai.Name = "bnNhapLai";
            this.bnNhapLai.Size = new System.Drawing.Size(56, 28);
            this.bnNhapLai.TabIndex = 9;
            this.bnNhapLai.Text = "Nhập lại";
            this.bnNhapLai.UseVisualStyleBackColor = true;
            // 
            // bnThem
            // 
            this.bnThem.Location = new System.Drawing.Point(629, 23);
            this.bnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnThem.Name = "bnThem";
            this.bnThem.Size = new System.Drawing.Size(56, 28);
            this.bnThem.TabIndex = 10;
            this.bnThem.Text = "Thêm";
            this.bnThem.UseVisualStyleBackColor = true;
            // 
            // bnSua
            // 
            this.bnSua.Location = new System.Drawing.Point(548, 62);
            this.bnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSua.Name = "bnSua";
            this.bnSua.Size = new System.Drawing.Size(56, 28);
            this.bnSua.TabIndex = 11;
            this.bnSua.Text = "Sửa";
            this.bnSua.UseVisualStyleBackColor = true;
            // 
            // bnXoa
            // 
            this.bnXoa.Location = new System.Drawing.Point(629, 62);
            this.bnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnXoa.Name = "bnXoa";
            this.bnXoa.Size = new System.Drawing.Size(56, 28);
            this.bnXoa.TabIndex = 12;
            this.bnXoa.Text = "Xóa";
            this.bnXoa.UseVisualStyleBackColor = true;
            // 
            // bnXem
            // 
            this.bnXem.Location = new System.Drawing.Point(629, 102);
            this.bnXem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnXem.Name = "bnXem";
            this.bnXem.Size = new System.Drawing.Size(56, 28);
            this.bnXem.TabIndex = 13;
            this.bnXem.Text = "Xem";
            this.bnXem.UseVisualStyleBackColor = true;
            // 
            // bnThoat
            // 
            this.bnThoat.Location = new System.Drawing.Point(588, 140);
            this.bnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnThoat.Name = "bnThoat";
            this.bnThoat.Size = new System.Drawing.Size(56, 28);
            this.bnThoat.TabIndex = 14;
            this.bnThoat.Text = "Thoát";
            this.bnThoat.UseVisualStyleBackColor = true;
            // 
            // bnTim
            // 
            this.bnTim.Location = new System.Drawing.Point(548, 102);
            this.bnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnTim.Name = "bnTim";
            this.bnTim.Size = new System.Drawing.Size(56, 28);
            this.bnTim.TabIndex = 15;
            this.bnTim.Text = "Tìm";
            this.bnTim.UseVisualStyleBackColor = true;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 427);
            this.Controls.Add(this.bnTim);
            this.Controls.Add(this.bnThoat);
            this.Controls.Add(this.bnXem);
            this.Controls.Add(this.bnXoa);
            this.Controls.Add(this.bnSua);
            this.Controls.Add(this.bnThem);
            this.Controls.Add(this.bnNhapLai);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNCC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Button bnNhapLai;
        private System.Windows.Forms.Button bnThem;
        private System.Windows.Forms.Button bnSua;
        private System.Windows.Forms.Button bnXoa;
        private System.Windows.Forms.Button bnXem;
        private System.Windows.Forms.Button bnThoat;
        private System.Windows.Forms.Button bnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
    }
}