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
using MySql.Data;

namespace Decoder_Cinema
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            logInButton.Enabled = false;
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            if(userTextBox.Text == "")
            {
                logInButton.Enabled = false;
            }
            else if(passTextBox.Text != "")
            {
                logInButton.Enabled = true;
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                logInButton.Enabled = false;
            }
            else if (userTextBox.Text != "")
            {
                logInButton.Enabled = true;
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost; port = 3306; username = root; password = terminusman";
                MySqlConnection conectDB = new MySqlConnection(myConnection);

                MySqlCommand selectedCommand = new MySqlCommand("Select * from decodercinema.employee where idEmployee = '" + this.userTextBox.Text + "'and passwordEmployee = '" + this.passTextBox.Text + "' ;", conectDB);

                MySqlDataReader myReader;
                conectDB.Open();
                myReader = selectedCommand.ExecuteReader();

                int count = 0;

                while(myReader.Read())
                {
                    count++;
                }

                if(count == 1)
                {
                    //Si el usuario y contraseña son correctos se instancia la nueva ventana.
                    Menu windowMenu = new Menu();
                    windowMenu.ShowDialog();
                }
                else if(count > 1)
                {
                    MessageBox.Show("Id o Contraseña Duplicadas.");
                }
                else
                {
                    MessageBox.Show("Id o Contraseña Incorrectos.");
                }
                conectDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
