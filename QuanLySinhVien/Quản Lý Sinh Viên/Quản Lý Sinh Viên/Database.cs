using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Sinh_Viên
{
    class Database
    {
        private string connectionString = @"Data Source=DESKTOP-IMD6DBM;Initial Catalog=QLSV;Integrated Security=True";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed " + ex.Message);
            }
        }

        public DataTable SelectData()
        {
            try
            {
                conn.Open();
                sql = "select * from dbo.tblSinhVien";
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load du lieu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
