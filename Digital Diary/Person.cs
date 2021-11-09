using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    public class Person
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public string Name { get; set; }

        private DBController dbConn;

        public Person()
        {
            this.dbConn = new DBController();
        }

        public int AddPerson()
        {
            //string sql = "INSERT INTO `persons` (`person_id`, `username`, `password`, `name`) VALUES (NULL, '"+Username+"', '"+Password+"', '"+Name+"');";
            string sql = "INSERT INTO `persons` (`person_id`, `username`, `password`) VALUES (NULL, '" + Username + "', '" + Password + "');";
            return this.dbConn.ExecuteQuery(sql);
        }

        public void DeletePerson()
        {
            string sql = "DELETE FROM `persons` WHERE `persons`.`person_id` = "+Id+";";
            this.dbConn.ExecuteQuery(sql);
        }

        public void UpdatePerson()
        {
            //string sql = "UPDATE `persons` SET `username` = '"+Username+"', `password` = '"+Password+"', `name` = '"+Name+"' WHERE `persons`.`person_id` = "+Id+";";
            string sql = "UPDATE `persons` SET `username` = '" + Username + "', `password` = '" + Password + "' WHERE `persons`.`person_id` = " + Id + ";";
            this.dbConn.ExecuteQuery(sql);
        }
    }
}
