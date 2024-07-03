using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL_QuanLyNhaTro
{
    public class DAL_ChuSoHuu : DBConnect
    {
        public bool ChuSoHuuLogin(DTO_ChuSoHuu csh)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM CHUSOHUU WHERE EMAIL='" + csh.Email + "' AND MATKHAU='" + csh.MatKhau + "'");
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
