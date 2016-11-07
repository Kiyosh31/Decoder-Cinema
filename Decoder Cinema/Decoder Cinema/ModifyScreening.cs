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
    public partial class ModifyScreening : Form
    {
        Class.Connection Connection;
        string idScreening;
        DataTable dataTable = new DataTable();

        public ModifyScreening(Class.Connection Connection, string idScreening)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idScreening = idScreening;
        }

        private void ModifyScreening_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Screening screening = Class.Screening.SearchScreening(Connection.myConnection, idScreening);
            Connection.CloseConnection();
            textBoxPrice.Text = screening.Price.ToString();
            dateTimeStart.Text = screening.Start_Time;
            dateTimeEnd.Text = screening.End_Time;
            dateTimeDate.Text = screening.Date;
            comboBoxRoom.Text = screening.ID_Room.ToString();
            textBoxMovie.Text = screening.ID_Movie.ToString();
            textBoxAvailable.Text = screening.Stock.ToString();

            
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM room WHERE Active = true"), Connection.myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(dataTable);
            Connection.CloseConnection();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            dateTimeDate.Format = DateTimePickerFormat.Custom;
            dateTimeDate.CustomFormat = "yyy-MM-dd";
            string Date = dateTimeDate.Text;
            Class.Screening screening = new Class.Screening(int.Parse(idScreening), float.Parse(textBoxPrice.Text), dateTimeStart.Text, dateTimeEnd.Text, int.Parse(textBoxAvailable.Text), Date, int.Parse(comboBoxRoom.Text), int.Parse(textBoxMovie.Text));
            Class.Screening.ModifyScreening(Connection.myConnection, screening);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }

        private void buttonChooseM_Click(object sender, EventArgs e)
        {
            AddScreeningMovie addmovie = new AddScreeningMovie(Connection);
            addmovie.ShowDialog();
            textBoxMovie.Text = addmovie.ID;
        }

        private void comboBoxRoom_Click(object sender, EventArgs e)
        {
            comboBoxRoom.DataSource = dataTable;
            comboBoxRoom.ValueMember = "idRoom";
        }
    }
}
