using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAO.impl;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private INhanVienDAO nhanVienDAO;

        public NhanVienBUS() => nhanVienDAO = new NhanVienDAOImpl();

        public List<NhanVienDTO> nhanVienDTOs() => nhanVienDAO.nhanVienDTOs();
    }
}
