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
    public partial class AddEmployee : Form
    {
        Class.Connection Connection;

        public AddEmployee(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxUserName.Text == "" || comboBoxJobPosition.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                int job = 2;
                if(comboBoxJobPosition.Text == "Gerente") { job = 1; }
                else if(comboBoxJobPosition.Text == "Vendedor") { job = 2; }
                Class.Employee employee = new Class.Employee(1, textBoxUserName.Text, textBoxPassword.Text, job);
                Class.Employee.AddEmployee(Connection.myConnection, employee);
                Connection.CloseConnection();

                MessageBox.Show("Empleado registrado\nExitosamente");
                this.Close();
            }
        }
    }
}
