using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TAIKHOAN
    {
        private string _TENTK;
        public string TENTK
        {
            get { return _TENTK; }
            set { _TENTK = value; }
        }
        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private string _IDTAIKHOAN;

        public string IDTAIKHOAN
        {
            get { return _IDTAIKHOAN; }
            set { _IDTAIKHOAN = value; }
        }
    }
}
