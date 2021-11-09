using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int PersonId  { get; set; }
        public string Importance { get; set; }
        public string Date { get; set; }
        public string UpdateTime { get; set; }

        private DBController dbConn;
        public Event()
        {
            this.dbConn = new DBController();
        }

        public int AddEvent()
        {
            dbConn = new DBController();
            string sql = "INSERT INTO `events` (`event_id`, `description`, `person_id`, `importance`, `event_date`, `updated_date`) VALUES (NULL, '" + Description+"', '"+PersonId+"', '"+Importance+"', '"+Date+ "', '"+DateTime.Now.ToString()+"');";
            int result = this.dbConn.ExecuteQuery(sql);
            dbConn.Disconnect();
            return result;

        }

        public int UpdateEvent()
        {
            dbConn = new DBController();
            string sql = "UPDATE `events` SET `description` = '" + Description+"', `importance` = '"+Importance+ "',`event_date` = '" + Date + "', `updated_date` = '" + DateTime.Now.ToString() + "' WHERE `events`.`event_id` = "+Id+";";
            int result= this.dbConn.ExecuteQuery(sql);
            dbConn.Disconnect();
            return result;
        }

        public int DeleteEvent(int id)
        {
            dbConn = new DBController();
            string sql = "DELETE FROM `events` WHERE `events`.`event_id` = "+id+";";
            int result = this.dbConn.ExecuteQuery(sql);
            dbConn.Disconnect();
            return result;
        }

        public List<Event> GetAllById(int id)
        {
            dbConn = new DBController();
            string sql = "SELECT * FROM events where person_id=" + id;
            
            List<Event> eventList = new List<Event>();

            try
            {
                MySqlDataReader reader = dbConn.GetData(sql);
                while (reader.Read())
                {
                    Event e = new Event();
                    e.Id = Convert.ToInt32(reader["event_id"]);
                    e.Description = reader["description"].ToString();
                    e.Importance = reader["importance"].ToString();
                    e.Date = reader["event_date"].ToString();
                    e.UpdateTime = reader["updated_date"].ToString();
                    //product.Price = Convert.ToSingle(reader["Price"]);
                    eventList.Add(e);
                }

                dbConn.Disconnect();
                return eventList;

            }
            catch (Exception)
            {

                return eventList;
            }



            
            
        }


    }
}
