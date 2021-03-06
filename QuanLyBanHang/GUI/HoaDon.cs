﻿using BUS;
using DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class HoaDon : Form
    {
        public int thanhtien;
        public int dongia;
        public int soluong;


        Lop_DAL dal = new Lop_DAL();
        HoaDon_BUS hd = new HoaDon_BUS();
        Hang_BUS hangcapnhat = new Hang_BUS();

        DataTable dtGetNamePrice, dtGetInfor, dtGetHoaDonTongHop, dtGetNameKH, dtGetNameNV, dtGetHD, dtHangCapNhat, dtLichSuHang;

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            //Hiển thị dữ liệu vào bảng giỏ hàng 
            dtGetInfor = new DataTable();
            dtGetInfor = hd.GetThongtinhang();
            dgvThongtinhang.DataSource = dtGetInfor;

            //Hiển thị dữ liệu vào bảng hóa đơn tổng hợp 
            dtGetHoaDonTongHop = new DataTable();
            dtGetHoaDonTongHop = hd.showDgvHoaDonTongHop();
            dgvHoaDonTongHop.DataSource = dtGetHoaDonTongHop;

            LoadMaHD();

            int tongtienhoadon = 0;
            foreach (DataRow r in dtGetInfor.Rows)
            {
                tongtienhoadon = tongtienhoadon + Int32.Parse(r[4].ToString().Trim());
            }
            txtTongTien.Text = tongtienhoadon.ToString();
            txtTongTien.Enabled = false;
            txtThanhtien.Enabled = false;

        }

        //Tự động điền mã hóa đơn vào ô mã hóa đơn.
        public void LoadMaHD()
        {
            DataTable dt = new DataTable();
            dt = hd.GetAmountHD();
            int numb = dt.Rows.Count;
            txtMaHD.Text = "HD" + (numb + 1).ToString();
            txtMaHD.Enabled = false;
        }

        //Khi nhập mã hàng tự động hiển thị lên tên hàng và đơn giá.
        private void txtMahang_TextChanged(object sender, EventArgs e)
        {
            dtGetNamePrice = new DataTable();
            dtGetNamePrice = hd.GetNamePrice(txtMahang.Text);
            string tenhang;

            foreach (DataRow r in dtGetNamePrice.Rows)
            {
                tenhang = r[0].ToString().Trim();
                dongia = Int32.Parse(r[1].ToString().Trim());
                txtTenhang.Text = tenhang;
                txtDongia.Text = dongia.ToString();
            }
        }

        // Tự động cập nhật lại ô thành tiền trong giỏi hàng và tổng tiền trong hóa đơn khi thay đổi số lượng.
        private void nrSoluong_ValueChanged(object sender, EventArgs e)
        {
            int numb = 0;
            int tt = 0;
            if (nrSoluong.Value == 0)
            {

                soluong = 0;
                thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
                if (dtGetHoaDonTongHop.Rows.Count > 0)
                {
                    foreach (DataRow r in dtGetHoaDonTongHop.Rows)
                    {
                        if (r["MaHD"].ToString().Trim() == txtMaHD.Text.Trim() && r["MaHang"].ToString().Trim() != txtMahang.Text.Trim())
                        {
                            int n = Int32.Parse(r["SoLuongHD"].ToString()) * Int32.Parse(r["DonGiaHD"].ToString());
                            numb = numb + n;
                        }
                    }
                    txtTongTien.Text = (tt + numb).ToString();
                }
            }
            else
            {
                soluong = Int32.Parse(nrSoluong.Value.ToString());
                thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
                tt = Int32.Parse(txtThanhtien.Text);
                if (dtGetHoaDonTongHop.Rows.Count > 0)
                {
                    foreach (DataRow r in dtGetHoaDonTongHop.Rows)
                    {
                        if (r["MaHD"].ToString().Trim() == txtMaHD.Text.Trim() && r["MaHang"].ToString().Trim() != txtMahang.Text.Trim())
                        {
                            int n = Int32.Parse(r["SoLuongHD"].ToString()) * Int32.Parse(r["DonGiaHD"].ToString());
                            numb = numb + n;
                        }
                    }
                    txtTongTien.Text = (tt + numb).ToString();
                }
            }
        }

        //Sửa hàng trong giỏ hàng.
        private void btnSuaGioHang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem != 0)
                {
                    hd.UpdateThongtinloaihang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Sửa giỏ hàng thành công");
                    HoaDon_Load(sender, e);
                    btnNhaplai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không sửa được hàng");
                }
            }
        }

        //Thêm hàng vào giỏ hàng.
        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
                MessageBox.Show("Không để trống mã hàng!");
            else if (nrSoluong.Text == "")
                MessageBox.Show("Không để trống số lượng!");
            else
            {
                int dem = 0;
                foreach (DataRow r in dtGetInfor.Rows)
                {
                    var check = r["MaH"].ToString().Trim();
                    if (txtMahang.Text.Trim() == check)
                    {
                        dem++;
                        break;
                    }
                }
                if (dem == 0)
                {
                    hd.InsertThongtinhang(txtMahang.Text, txtTenhang.Text, Int32.Parse(nrSoluong.Text), dongia, thanhtien);
                    MessageBox.Show("Thêm vào giỏ hàng thành công.");
                    HoaDon_Load(sender, e);
                    btnNhaplai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hàng đã tồn tại, chọn mua mặt hàng khác!");
                }
            }
        }

        //Xóa hàng trong giỏ hàng.
        private void btnXoaHangTrongGio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMahang.Text == "")
                {
                    MessageBox.Show("Chưa chọn mặt hàng để xóa!");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + txtTenhang.Text + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        hd.DeleteThongtinloaihang(txtMahang.Text.Trim());
                        MessageBox.Show("Xóa thành công");
                        HoaDon_Load(sender, e);
                        btnNhaplai_Click(sender, e);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa!");
            }
        }

        //Sửa hóa đơn.
        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "")
                    MessageBox.Show("Chưa nhập mã khách hàng, nhập lại!");
                else if (txtHotenKH.Text == "")
                    MessageBox.Show("Chưa nhập tên khách hàng, nhập lại!");
                else if (txtMaNV.Text == "")
                    MessageBox.Show("Chưa nhập mã nhân viên, nhập lại!");
                else if (txtTenNV.Text == "")
                    MessageBox.Show("Chưa nhập tên nhân viên, nhập lại!");
                else if (txtMahang.Text == "")
                    MessageBox.Show("Chưa nhập mã hàng, nhập lại!");
                else
                {
                    string mahd = txtMaHD.Text.Trim();
                    string makh = txtMaKH.Text;
                    string tenkh = txtHotenKH.Text;
                    string ngaylap = dpNgayLap.Value.Date.ToString("yyyy-MM-dd"); ;
                    string manv = txtMaNV.Text;
                    string tennv = txtTenNV.Text;
                    string tongtienhd = txtTongTien.Text;

                    string mahang = txtMahang.Text.Trim(), tenhang = txtTenhang.Text;
                    int dongia = Int32.Parse(txtDongia.Text);
                    int thanhtien = Int32.Parse(txtThanhtien.Text), soluong = Int32.Parse(nrSoluong.Text);

                    int dem = 0;
                    foreach (DataRow r in dtGetHoaDonTongHop.Rows)
                    {
                        var checkMaHD = r["MaHD"].ToString().Trim();
                        var checkMaHang = r["MaHang"].ToString().Trim();
                        if (mahd == checkMaHD && mahang == checkMaHang)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        hd.UpdateHoaDonTongHop(mahd, makh, tenkh, ngaylap, manv, tennv, mahang, tenhang, soluong, dongia, thanhtien, tongtienhd);
                        hd.UpdateHoaDonTongHop2(mahd, ngaylap, tongtienhd);
                        hd.UpdateHD(mahd, makh, ngaylap, manv);
                        hd.UpdateHDChiTiet(mahd, mahang, soluong);
                        MessageBox.Show("Cập nhật hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HoaDon_Load(sender, e);
                        btnNhaplai_Click(sender, e);
                        txtMahang.Enabled = true;

                        LSHang();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Không sửa được hóa đơn", "Cảnh báo");
            }
        }

        //Xóa hóa đơn.
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text.Trim();
            string mahang = txtMahang.Text;
            int dem = 0;

            foreach (DataRow r in dtGetHoaDonTongHop.Rows)
            {
                var check = r["MaHD"].ToString().Trim();
                if (mahd == check)
                {
                    dem++;
                    break;
                }
            }
            if (dem != 0)
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn xóa \"" + mahd + "\" ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    hd.DeleteHoaDonTongHop(mahd);
                    //hd.DeleteHDChiTiet(mahd);
                    //hd.DeleteHD(mahd);
                    MessageBox.Show("Xóa hóa đơn thành công.", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HoaDon_Load(sender, e);
                    btnNhaplai_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Mã mã hóa đơn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvHoaDonTongHop_Click(object sender, EventArgs e)
        {
            int r = dgvHoaDonTongHop.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHoaDonTongHop.Rows[r].Cells[0].Value.ToString();
            txtMaKH.Text = dgvHoaDonTongHop.Rows[r].Cells[1].Value.ToString();
            txtHotenKH.Text = dgvHoaDonTongHop.Rows[r].Cells[2].Value.ToString();
            dpNgayLap.Value = Convert.ToDateTime(dgvHoaDonTongHop.Rows[r].Cells[3].Value);
            txtMaNV.Text = dgvHoaDonTongHop.Rows[r].Cells[4].Value.ToString();
            txtTenNV.Text = dgvHoaDonTongHop.Rows[r].Cells[5].Value.ToString();
            txtMahang.Text = dgvHoaDonTongHop.Rows[r].Cells[6].Value.ToString();
            txtTenNV.Text = dgvHoaDonTongHop.Rows[r].Cells[7].Value.ToString();
            nrSoluong.Text = dgvHoaDonTongHop.Rows[r].Cells[8].Value.ToString();
            txtDongia.Text = dgvHoaDonTongHop.Rows[r].Cells[9].Value.ToString();
            txtThanhtien.Text = dgvHoaDonTongHop.Rows[r].Cells[10].Value.ToString();
            txtTongTien.Text = dgvHoaDonTongHop.Rows[r].Cells[11].Value.ToString();
            txtMahang.Enabled = false;
        }

        private void dgvThongtinhang_Click(object sender, EventArgs e)
        {
            int dong = dgvThongtinhang.CurrentCell.RowIndex;
            txtMahang.Text = dgvThongtinhang.Rows[dong].Cells[0].Value.ToString();
            txtTenhang.Text = dgvThongtinhang.Rows[dong].Cells[1].Value.ToString();
            nrSoluong.Text = dgvThongtinhang.Rows[dong].Cells[2].Value.ToString();
            txtDongia.Text = dgvThongtinhang.Rows[dong].Cells[3].Value.ToString();
            txtThanhtien.Text = dgvThongtinhang.Rows[dong].Cells[4].Value.ToString();
        }

        //Reset lại các ô hiển thị dữ liệu.
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHotenKH.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dpNgayLap.Value = DateTime.Now;
            txtTongTien.Text = "";
            txtMahang.Text = "";
            txtTenhang.Text = "";
            nrSoluong.Value = 0;
            txtDongia.Text = "";
            txtMahang.Enabled = true;
            HoaDon_Load(sender, e);
        }

        //In hóa đơn.
        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportHoaDon hd = new ReportHoaDon();
            hd.Show();

        }

        //Load lại dữ liệu của form.
        private void btnXem_Click(object sender, EventArgs e)
        {
            HoaDon_Load(sender, e);
        }

        //Thoát form.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Dispose();
        }

        //Tìm kiếm hóa đơn.
        private void btnTim_Click(object sender, EventArgs e)
        {
            dtGetHD = new DataTable();
            dtGetHD = hd.SearchHD(txtTim.Text);
            dgvHoaDonTongHop.DataSource = dtGetHD;
        }

        //Thêm hóa đơn.
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
                MessageBox.Show("Chưa nhập mã khách hàng, nhập lại!");
            else if (txtHotenKH.Text == "")
                MessageBox.Show("Chưa nhập tên khách hàng, nhập lại!");
            else if (txtMaNV.Text == "")
                MessageBox.Show("Chưa nhập mã nhân viên, nhập lại!");
            else if (txtTenNV.Text == "")
                MessageBox.Show("Chưa nhập tên nhân viên, nhập lại!");
            else
            {
                string mahd = txtMaHD.Text.Trim();
                string makh = txtMaKH.Text;
                string tenkh = txtHotenKH.Text;
                string ngaylap = dpNgayLap.Value.Date.ToString("yyyy-MM-dd"); ;
                string manv = txtMaNV.Text;
                string tennv = txtTenNV.Text;
                string tongtienhd = txtTongTien.Text;

                string mahang = "", tenhang = "";
                int dongia = 0;
                int thanhtien = 0, soluong = 0;

                try
                {
                    if (dtGetInfor.Rows.Count > 0)
                    {
                        int dem = 0;
                        foreach (DataRow r in dtGetHoaDonTongHop.Rows)
                        {
                            var check = r["MaHD"].ToString().Trim();
                            if (mahd == check)
                            {
                                dem++;
                                break;
                            }
                        }
                        if (dem == 0)
                        {
                            hd.InsertHD(mahd, makh, ngaylap, manv);

                            foreach (DataRow r in dtGetInfor.Rows)
                            {
                                mahang = r[0].ToString();
                                tenhang = r[1].ToString();
                                soluong = Int32.Parse(r[2].ToString());
                                dongia = Int32.Parse(r[3].ToString());
                                thanhtien = Int32.Parse(r[4].ToString());

                                hd.InsertHDChiTiet(mahd, mahang, soluong);
                                hd.InsertHoaDonTongHop(mahd, makh, tenkh, ngaylap, manv, tennv, mahang, tenhang, soluong, dongia, thanhtien, tongtienhd);
                                //hd.InsertLichSuHang(mahang,ngaylap);
                            }

                            MessageBox.Show("Tạo hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hd.DeleteAllCart();
                            HoaDon_Load(sender, e);
                            btnNhaplai_Click(sender, e);

                            LSHang();
                        }
                        else
                        {
                            MessageBox.Show("Mã hóa đơn đã tồn tại, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi, hãy mua hàng trước khi lập hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine(ex);
                    MessageBox.Show("Không tạo được hóa đơn, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Cập nhật lại bảng lịch sử hàng.
        public void LSHang()
        {
            dtHangCapNhat = hangcapnhat.ShowHang();
            dtLichSuHang = hd.getLichSuHang();

            if (dtLichSuHang.Rows.Count > 0)
            {
                foreach (DataRow r1 in dtHangCapNhat.Rows)
                {
                    string mh = r1["MaH"].ToString();
                    string th = r1["TenH"].ToString();
                    string dv = r1["DonVT"].ToString();
                    int sl = Int32.Parse(r1["SLC"].ToString());
                    string ngaycapnhat = DateTime.Now.ToString();
                    int check = 0;
                    foreach (DataRow r2 in dtLichSuHang.Rows)
                    {

                        if (r2["MaHang"].ToString().Trim() == r1["MaH"].ToString().Trim())
                        {
                            hd.UpdateLSHang(mh, th, dv, sl, ngaycapnhat);
                            check++;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        hd.InsertLSHang(mh, th, dv, sl, ngaycapnhat);
                    }
                }
            }
            else
            {
                foreach (DataRow r2 in dtHangCapNhat.Rows)
                {
                    string mh = r2["MaH"].ToString();
                    string th = r2["TenH"].ToString();
                    string dv = r2["DonVT"].ToString();
                    int sl = Int32.Parse(r2["SLC"].ToString());
                    string ngaycapnhat = DateTime.Now.ToString();
                    hd.InsertLSHang(mh, th, dv, sl, ngaycapnhat);
                }
            }
        }

        //Khi nhap vao ma nhan vien thi ten nhan vien tu dong hien thi tren o textbox.
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            dtGetNameNV = new DataTable();
            dtGetNameNV = hd.GetNameNV(txtMaNV.Text.Trim());
            if (dtGetNameNV.Rows.Count > 0)
            {
                string tennv;
                foreach (DataRow r in dtGetNameNV.Rows)
                {
                    tennv = r[0].ToString().Trim();
                    txtTenNV.Text = tennv == "" ? "" : tennv;
                }
            }
            else
            {
                txtTenNV.Text = "";
            }

        }

        //Khi nhap vao ma khach hang thi ten khach hang tu dong hien thi tren o textbox.
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            dtGetNameKH = new DataTable();
            dtGetNameKH = hd.GetNameKH(txtMaKH.Text.Trim());
            if (dtGetNameKH.Rows.Count > 0)
            {
                string tenkh;
                foreach (DataRow r in dtGetNameKH.Rows)
                {
                    tenkh = r[0].ToString().Trim();
                    txtHotenKH.Text = tenkh == "" ? "" : tenkh;
                }
            }
            else
            {
                txtHotenKH.Text = "";
            }
        }

    }
}
