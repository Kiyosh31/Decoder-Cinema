using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    public class Screening
    {
        int idScreening;
        float price;
        string startTime;
        string endTime;
        int r_idRoom;
        int m_idMovie;
        bool active;

        public Screening(int idScreening, float price, string startTime, string endTime, int r_idRoom, int m_idMovie, bool active)
        {
            this.idScreening = idScreening;
            this.price = price;
            this.startTime = startTime;
            this.endTime = endTime;
            this.r_idRoom = r_idRoom;
            this.m_idMovie = m_idMovie;
            this.active = active;
        }

        public int ID
        {
            get { return idScreening; }
            set { idScreening = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Start_Time
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public string End_Time
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public int ID_Room
        {
            get { return r_idRoom; }
            set { r_idRoom = value; }
        }

        public int ID_Movie
        {
            get { return m_idMovie; }
            set { m_idMovie = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int AddScreening(MySqlConnection Connection, Screening screening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO screening(sPrice, sStartTime, sEndTime, Room_idRoom, Movie_idMovie, Active) VALUES({0}, '{1}', '{2}', {3}, {4}, true)", screening.price, screening.startTime, screening.endTime, screening.r_idRoom, screening.m_idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static int ModifyScreening(MySqlConnection Connection, Screening screening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE screening SET sPRice = {0}, sStartTime = '{1}', sEndTime = '{2}', Room_idRoom = {3}, Movie_idMovie = {4}, Active = true WHERE idScreening = {5}", screening.price, screening.startTime, screening.endTime, screening.r_idRoom, screening.m_idMovie, screening.idScreening), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteRoom(MySqlConnection Connection, string idScreening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE screening SET Active = false WHERE idScreening = {0}", idScreening), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Screening> ShowRoom(MySqlConnection Connection)
        {
            List<Screening> lScreening = new List<Screening>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM screening"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Screening screening = new Screening(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetBoolean(6));
                lScreening.Add(screening);
            }
            return lScreening;
        }
    }
}
