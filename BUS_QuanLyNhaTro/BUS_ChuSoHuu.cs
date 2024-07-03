using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNhaTro;
using DTO;

namespace BUS_QuanLyNhaTro
{
    public class BUS_ChuSoHuu
    {
        DAL_ChuSoHuu dalChuSoHuu = new DAL_ChuSoHuu();

        public bool ChuSoHuuLogin(DTO_ChuSoHuu csh)
        {
            return dalChuSoHuu.ChuSoHuuLogin(csh);
        }
    }
}
