using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuSoHuu
    {
        private int _ID;
        private string _maChuSH;
        private string _tenChuSH;
        private string _email;
        private string _dienThoai;
        private string _diaChi;
        private string _matKhau;

        public int ID
        {
            get => _ID;
            set => _ID = value;
        }
        public string MaChuSoHuu
        {
            get => _maChuSH;
            set => _maChuSH = value;
        }
        public string TenChuSH
        {
            get => _tenChuSH;
            set => _tenChuSH = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string DienThoai
        {
            get => _dienThoai;
            set => _dienThoai = value;
        }
        public string DiaChi
        {
            get => _diaChi;
            set => _diaChi = value;
        }
        public string MatKhau
        {
            get => _matKhau;
            set => _matKhau = value;
        }

        public DTO_ChuSoHuu () {}
        public DTO_ChuSoHuu(int ID, string maChuSH, string tenChuSH, string email, string dienThoai, string diaChi, string matKhau)
        {
            this._ID = ID;
            this._maChuSH = maChuSH;
            this._tenChuSH = tenChuSH;
            this._email = email;
            this._dienThoai = dienThoai;
            this._diaChi = diaChi;
            this._matKhau = matKhau;
        }
    }
}
