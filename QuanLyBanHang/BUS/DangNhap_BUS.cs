﻿using DAL;
using System.Data;
namespace BUS
{
    public class DangNhap_BUS
    {

        Lop_DAL dal = new Lop_DAL();
        public DataTable DangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM DangNhap12 WHERE TenDN='" + tendangnhap + "' AND MatKhau='" + matkhau + "'";
            dt = dal.getTable(sql);
            return dt;
        }
        

    }
}
