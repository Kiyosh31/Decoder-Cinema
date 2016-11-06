using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder_Cinema
{
    public partial class ModifyRoom : Form
    {
        Class.Connection Connection;
        string idRoom;

        public ModifyRoom(Class.Connection Connection, string idRoom)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idRoom = idRoom;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Room room = new Class.Room(1, textBoxCapacity.Text);
            Class.Room.ModifyRoom(Connection.myConnection, room);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }

        private void ModifyRoom_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Room room = Class.Room.SearchRoom(Connection.myConnection, idRoom);
            Connection.CloseConnection();
        }
    }
}
