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

        public Room(int idRoom, string capacity)
        {
            this.idRoom = idRoom;
            this.capacity = capacity;
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

        public static int AddRoom(MySqlConnection Connection, Room room)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO room(Capacity, Active) VALUES('{0}', true)", room.capacity), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static Room SearchRoom(MySqlConnection Connection, string idRoom)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM room WHERE idRoom = {0} AND active = true", idRoom), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Room room = new Room(reader.GetInt32(0), reader.GetString(1));
                return room;
            }
            Room e = null; return e;
        }

        public static int ModifyRoom(MySqlConnection Connection, Room room)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE room SET Capacity = '{0}' , Active = true WHERE idRoom = {1}", room.capacity, room.idRoom), Connection);
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
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM room WHERE Active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room room = new Room(reader.GetInt32(0), reader.GetString(1));
                lRoom.Add(room);
            }
            return lRoom;
        }
    }
}
