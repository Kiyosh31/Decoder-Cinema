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
        string idEmployee;

        public ModifyEmployee(Class.Connection Connection, string idEmployee)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idEmployee = idEmployee;
        }

        private void buttonModifyEmployee_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            int job = 2;
            if(comboBoxJobPosition.Text == "Gerente") { job = 1; }
            Class.Employee employee = new Class.Employee(int.Parse(idEmployee), textBoxUserName.Text, textBoxPassword.Text, job);
            Class.Employee.ModifyEmployee(Connection.myConnection, employee);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }

        private void ModifyEmployee_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Employee employee = Class.Employee.SearchEmployee(Connection.myConnection, idEmployee);
            Connection.CloseConnection();
            textBoxID.Text = employee.ID.ToString();
            textBoxUserName.Text = employee.Name;
            textBoxPassword.Text = employee.Password;
            if (employee.Job_Position == 1) { comboBoxJobPosition.Text = "Gerente"; }
            else { comboBoxJobPosition.Text = "Vendedor"; }
        }
    }
}
