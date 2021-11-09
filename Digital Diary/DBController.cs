using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Digital_Diary
{
    public class DBController
    {
        MySqlConnection conn;
        MySqlCommand command;

        public DBController()
        {
            //string connString = "datasource=69.13.47.36;port=3306;username=tnrsoftc_diaryadmin;password=Bpiz0kTAFmPb;database=tnrsoftc_cdiary";
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=labfinal";
            
            //try
            //{
                this.conn = new MySqlConnection(connString);
                this.conn.Open();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Internet Disconnected");
            //}
           
        }

        public MySqlDataReader GetData(string sql)
        {
            this.command = new MySqlCommand(sql, this.conn);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new MySqlCommand(sql, this.conn);
            return this.command.ExecuteNonQuery();
        }

        public void Disconnect()
        {
            this.conn.Close();
        }

        ~DBController()
        {
            //this.conn.Close();
        }
    }
}
