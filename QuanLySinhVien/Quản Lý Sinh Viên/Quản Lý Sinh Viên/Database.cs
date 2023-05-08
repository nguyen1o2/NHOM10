using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYSINHVIEN;

namespace Quản_Lý_Sinh_Viên
{
    class Database
    {
        //private static string connectionString = @"Data Source=DESKTOP-IMD6DBM;Initial Catalog=QLSV;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IMD6DBM;Initial Catalog=QLSV;Integrated Security=True");
        //private string sql;
        private DataTable dt;
        private SqlCommand cmd;
        SqlDataAdapter adapter;
        //public Database()
        //{
        //    try
        //    {
        //        conn = new SqlConnection(connectionString);
        //        conn.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("connected failed " + ex.Message);
        //    }
        //}

        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                //dt = new DataSet();
                ////sql = "exec  SelectAllSinhVien";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    connection.Open();
                //    adapter = new SqlDataAdapter(sql, conn);
                //    adapter.Fill(dt);
                //    //connection.Close();
                //    return dt;
                //}

                //}
                conn.Open();
                cmd = new SqlCommand(sql, conn);//nội dung sql được truyền vào
                cmd.CommandType = CommandType.StoredProcedure;//set cmmand type cho cmd
                foreach(var para in lstPara)//gắn các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                //sql = "exec  SelectAllSinhVien";
                //cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //adapter = new SqlDataAdapter(sql, conn);
                //adapter.Fill(dt);
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

        public DataRow Select(String sql)
        {
            try
            {
                //conn.Open();
                //cmd = new SqlCommand(sql, conn);
                //DataTable dt = new DataTable();
                //dt.Load(cmd.ExecuteReader());
                //return dt.Rows[0];
                dt = new DataTable();
                //sql = "exec  SelectAllSinhVien";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                    conn.Open();
                    adapter = new SqlDataAdapter(sql, conn);
                    adapter.Fill(dt);
                    //connection.Close();
                    return dt.Rows[0];
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int Execute(String sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
