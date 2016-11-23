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
    public partial class FormLogin : Form
    {
        Class.Connection Connection = new Class.Connection();

        public FormLogin()
        {
            InitializeComponent();

            buttonLogIn.Enabled = false;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                buttonLogIn.Enabled = false;
            }
            else if (textBoxPassword.Text != "")
            {
                buttonLogIn.Enabled = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                buttonLogIn.Enabled = false;
            }
            else if (textBoxUserName.Text != "")
            {
                buttonLogIn.Enabled = true;
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * from employee WHERE idEmployee = '{0}' AND ePassword = '{1}'", textBoxUserName.Text, textBoxPassword.Text), Connection.myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt32(3) == 1)
                {
                    Connection.CloseConnection();
                    Connection.OpenConnection();
                    Class.Employee employee = Class.Employee.SearchEmployee(Connection.myConnection, textBoxUserName.Text);
                    Connection.CloseConnection();
                    AdminMenu adminmenu = new AdminMenu(employee);
                    this.Hide();
                    adminmenu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sesion iniciada como cajero");
                    Connection.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("ID o Contraseña Incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.CloseConnection();
        }
    }
}
