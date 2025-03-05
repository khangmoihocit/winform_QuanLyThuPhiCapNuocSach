using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   
    //hehe
    public class TaiKhoanDTO
    {
        private string _tenTaiKhoan;
        private string _matKhau;
        private string _email;

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string tenTaiKhoan, string matKhau, string email)
        {
            _tenTaiKhoan = tenTaiKhoan;
            _matKhau = matKhau;
            _email = email;
        }

        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
