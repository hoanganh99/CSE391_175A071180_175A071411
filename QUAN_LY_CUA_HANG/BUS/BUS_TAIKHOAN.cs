using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_TAIKHOAN
    {
        DAL_TAIKHOAN taikhoan_dal = new DAL_TAIKHOAN();
        public DataTable load_taikhoan()
        {
            return taikhoan_dal.load_taikhoan();
        }
        public int insert_taikhoan(DTO_TAIKHOAN taikhoan_public)
        {
            return taikhoan_dal.insert_taikhoan(taikhoan_public);
        }
        public int check_dangnhap(DTO_TAIKHOAN taikhoan_public)
        {
            return taikhoan_dal.check_dangnhap(taikhoan_public);
        }
        public string get_IDTAIKHOAN(DTO_TAIKHOAN taikhoan_public)
        {
            return taikhoan_dal.get_IDTAIKHOAN(taikhoan_public);
        }
    }
}
