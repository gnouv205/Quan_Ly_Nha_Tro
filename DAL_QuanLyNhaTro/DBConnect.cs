using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyNhaTro
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Server=DINHVUONG\MSSQLSERVER01;Database=QuanLyNhaTro;Trusted_Connection=True;");
    }
}
