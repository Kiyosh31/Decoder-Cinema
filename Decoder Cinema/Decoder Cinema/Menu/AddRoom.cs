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
    public partial class AddRoom : Form
    {
        Class.Connection Connection;

        public AddRoom(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            if (textBoxCapacity.Text == "" )
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                Class.Room room = new Class.Room(1, textBoxCapacity.Text);
                Class.Room.AddRoom(Connection.myConnection, room);
                Connection.CloseConnection();

                MessageBox.Show("Captura existosa");
                this.Close();
            }
        }
    }
}
