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
    public partial class AdminMenu : Form
    {
        Class.Connection Connection = new Class.Connection();

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addemployee = new AddEmployee(Connection);
            addemployee.ShowDialog();
        }
    }
}
