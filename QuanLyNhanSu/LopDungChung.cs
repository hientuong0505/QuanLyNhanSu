using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\QuanLyNhanSu\QuanLyNhanSu\QuanLyNhanSu.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }

        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            return ketqua;
        }

        public int Dem(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
