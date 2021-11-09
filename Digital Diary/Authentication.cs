using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Digital_Diary
{
    public class Authentication
    {
        
        private DBController dbConn;
        public Authentication()
        {
            this.dbConn = new DBController();
        }

        public int Validate(Person person)
        {
            this.dbConn = new DBController();
        
            string sql = "SELECT person_id FROM `persons` WHERE `username`='" + person.Username + "' and `password`='" + person.Password + "';";

            MySqlDataReader reader = this.dbConn.GetData(sql);
            reader.Read();

            
            if (reader.HasRows)
            {
                int id = (int)reader["person_id"];
                dbConn.Disconnect();
                return id;
            }
            else
            {
                dbConn.Disconnect();
                return 0;
            }

            //int personId = 

            //if(personId == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return personId;
            //}
        }

    }
}
