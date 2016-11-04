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
    public partial class AdminEmployee : Form
    {
        Class.Connection Connection;

        public AdminEmployee(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Employee.ShowEmployee(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            ModifyEmployee modifyemployee = new ModifyEmployee(Connection);
            modifyemployee.ShowDialog();
        }
    }
}
