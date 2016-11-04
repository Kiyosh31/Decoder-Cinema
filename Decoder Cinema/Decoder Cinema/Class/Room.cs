using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    public class Room
    {
        int idRoom;
        string capacity;
        string availability;
        bool active;

        public Room(int idRoom, string capacity, string availability, bool active)
        {
            this.idRoom = idRoom;
            this.capacity = capacity;
            this.availability = availability;
            this.active = active;
        }

        public int ID
        {
            get { return idRoom; }
            set { idRoom = value; }
        }

        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int AddRoom(MySqlConnection Connection, Room room)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO room(Capacity, Availability, Active) VALUES('{0}', '{1}', true)", room.capacity, room.availability), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static int ModifyRoom(MySqlConnection Connection, Room room)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE room SET Capacity = '{0}' , Availability = '{1}', Active = true WHERE idRoom = {2}", room.capacity, room.availability, room.idRoom), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteRoom(MySqlConnection Connection, string idRoom)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE room SET Active = false WHERE idRoom = {0}", idRoom), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Room> ShowRoom(MySqlConnection Connection)
        {
            List<Room> lRoom = new List<Room>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM room"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room room = new Room(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
                lRoom.Add(room);
            }
            return lRoom;
        }
    }
}
