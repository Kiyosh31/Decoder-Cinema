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
    public partial class AddCustomer : Form
    {
        Class.Connection Connection;

        public AddCustomer(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLastName.Text == "" || textBoxAdress.Text == "" || textBoxEmail.Text == "" ||
                textBoxTel.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                Class.Customer customer = new Class.Customer(1, textBoxName.Text, textBoxLastName.Text, textBoxAdress.Text, textBoxEmail.Text, textBoxTel.Text);
                Class.Customer.AddCustomer(Connection.myConnection, customer);
                Connection.CloseConnection();

                MessageBox.Show("Cliente registrado\nExitosamente");
                this.Close();
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
