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
    public partial class AdminRoom : Form
    {
        Class.Connection Connection;

        public AdminRoom(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void AdminRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Room.ShowRoom(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string idRoom = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ModifyRoom modifyroom = new ModifyRoom(Connection, idRoom);
            modifyroom.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string idRoom = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Room.DeleteRoom(Connection.myConnection, idRoom);
                Connection.CloseConnection();
                MessageBox.Show("Eliminado exitosamente");
                LoadData();
            }
        }
    }
}
