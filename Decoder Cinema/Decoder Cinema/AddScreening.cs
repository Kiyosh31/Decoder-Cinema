using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema
{
    public partial class AddScreening : Form
    {
        Class.Connection Connection;
        bool i = false;

        public AddScreening(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
            LoadC();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxPrice.Text == "" || comboBoxRoom.Text == "" || textBoxMovie.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                dateTimeDate.Format = DateTimePickerFormat.Custom;
                dateTimeDate.CustomFormat = "yyy-MM-dd";
                string Date = dateTimeDate.Text;
                string hora = dateTimeStart.Text;
                Connection.OpenConnection();
                Class.Screening screening = new Class.Screening(1, float.Parse(textBoxPrice.Text), dateTimeStart.Text, dateTimeEnd.Text, int.Parse(textBoxCapacity.Text), Date, int.Parse(comboBoxRoom.Text), int.Parse(textBoxMovie.Text));
                Class.Screening.AddScreening(Connection.myConnection, screening);
                Connection.CloseConnection();
                MessageBox.Show("Captura existosa");
                this.Close();
            }
        }

        private void LoadC()
        {
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM room WHERE Active = true"), Connection.myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Connection.CloseConnection();
            comboBoxRoom.DataSource = dataTable;
            comboBoxRoom.ValueMember = "idRoom";
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(i == true)
            {
                Connection.OpenConnection();
                textBoxCapacity.Text = Class.Room.SearchRoom(Connection.myConnection, comboBoxRoom.Text).Capacity.ToString();
                Connection.CloseConnection();
            }
            i = true;
        }

        private void buttonChooseM_Click(object sender, EventArgs e)
        {
            AddScreeningMovie addmovie = new AddScreeningMovie(Connection);
            addmovie.ShowDialog();
            textBoxMovie.Text = addmovie.ID;
        }

        private void comboBoxRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxRoom_Click(object sender, EventArgs e)
        {
        }

        private void AddScreening_Load(object sender, EventArgs e)
        {

        }
    }
}
