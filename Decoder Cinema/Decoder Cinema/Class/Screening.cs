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
        int stock;
        string startTime;
        string endTime;
        string date;
        int r_idRoom;
        int m_idMovie;

        public Screening(int idScreening, float price, string startTime, string endTime, int stock, string date, int r_idRoom, int m_idMovie)
        {
            this.idScreening = idScreening;
            this.price = price;
            this.startTime = startTime;
            this.endTime = endTime;
            this.stock = stock;
            this.date = date;
            this.r_idRoom = r_idRoom;
            this.m_idMovie = m_idMovie;
        }

        public Screening()
        {

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

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
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

        public string Date
        {
            get { return date; }
            set { date = value; }
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

        public static int AddScreening(MySqlConnection Connection, Screening screening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO screening(sPrice, sStartTime, sEndTime, Stock, Date, Room_idRoom, Movie_idMovie, Active) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', true)", screening.price, screening.startTime, screening.endTime, screening.stock, screening.date, screening.r_idRoom, screening.m_idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static Screening SearchScreening(MySqlConnection Connection, string idScreening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM screening WHERE idScreening = {0} AND Active = true", idScreening), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Screening screening = new Screening(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
                return screening;
            }
            Screening e = null; return e;
        }

        public static int ModifyScreening(MySqlConnection Connection, Screening screening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE screening SET sPrice = '{0}', sStartTime = '{1}', sEndTime = '{2}', Stock = '{3}', Date = '{4}', Room_idRoom = '{5}', Movie_idMovie = '{6}' WHERE idScreening = {7}", screening.price, screening.startTime, screening.endTime, screening.stock, screening.date, screening.r_idRoom, screening.m_idMovie, screening.idScreening), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteRoom(MySqlConnection Connection, string idScreening)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE screening SET Active = false WHERE idScreening = {0}", idScreening), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static MySqlDataAdapter ShowRoom(MySqlConnection Connection)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT idScreening as ID, sPrice as Precio, sStartTime as Hora_Inicio, sEndTime as Hora_Fin, Stock, Date as Fecha, Room_idRoom as Sala, mName as Pelicula FROM screening INNER JOIN movie ON Movie_idMovie = idMovie WHERE screening.Active = true", Connection);
            return da;
        }
    }
}
