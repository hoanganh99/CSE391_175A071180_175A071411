using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TAIKHOAN
    {
        DAL_CONN ketnoi = new DAL_CONN();
        public System.Data.DataTable load_taikhoan()
        {
            string sql = "Load_TaiKhoan";
            return ketnoi.Load_Data(sql);
        }
        public int insert_taikhoan(DTO_TAIKHOAN taikhoan_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@IDTAIKHOAN";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            values[2] = taikhoan_public.IDTAIKHOAN;
            string sql = "Insert_TaiKhoan";
            return ketnoi.Execute(sql, name, values, parameter);
        }
       
        public int check_dangnhap(DTO_TAIKHOAN taikhoan_public)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnInteger(sql);
        }
        public string get_IDTAIKHOAN(DTO_TAIKHOAN taikhoan_public)
        {
            string sql = "SELECT IDTAIKHOAN FROM TaiKhoan WHERE TENTK='" + taikhoan_public.TENTK + "' AND MATKHAU='" + taikhoan_public.MATKHAU + "'";
            return ketnoi.ReturnString(sql);
        }
    }
}
