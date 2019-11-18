using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace SSPanel
{
    class DBHelper
    {
        //Login play = new Login();
        private MySqlConnection conn = null;
        private string connString = string.Empty;
       
        public DBHelper()
        {
            
            connString = $"server={Helper.add};database=sspanel;uid={Helper.use};pwd={Helper.pwd}";
            
        }

        public MySqlConnection GetSqlConnection()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connString);
            }
            else
            {
                return conn;
            }
            return conn;
        }
        public void OpenSqlConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseSqlConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public int ExeCuteNoQuery(string sql)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, GetSqlConnection());
                OpenSqlConnection();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误" + e.Message);
                return 0;
            }
            finally {
                CloseSqlConnection();
            }

        }
        public object ExeScalar(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, GetSqlConnection());
                OpenSqlConnection();

                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误" + e.Message);
                return 0;
            }
            finally {
                CloseSqlConnection();
            }
        }
        public MySqlDataReader EXeReader(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, GetSqlConnection());
                OpenSqlConnection();
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("错误" + e.Message);
                return null;

            }
            finally {
                CloseSqlConnection();
            }
        }
    }
}
