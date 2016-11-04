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
    public partial class ModifyEmployee : Form
    {
        Class.Connection Connection;

        public ModifyEmployee(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonModifyEmployee_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            int job = 2;
            if(comboBoxJobPosition.Text == "Gerente") { job = 1; }
            Class.Employee employee = new Class.Employee(1, textBoxUserName.Text, textBoxPassword.Text, job, true);
            Class.Employee.AddEmployee(Connection.myConnection, employee);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }
    }
}
