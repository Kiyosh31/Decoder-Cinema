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

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie addmovie = new AddMovie(Connection);
            addmovie.ShowDialog();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer(Connection);
            addcustomer.ShowDialog();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addroom = new AddRoom(Connection);
            addroom.ShowDialog();
        }

        private void buttonAdminEmployee_Click(object sender, EventArgs e)
        {
            AdminEmployee adminemployee = new AdminEmployee(Connection);
            this.Hide();
            adminemployee.ShowDialog();
            this.Show();
        }

        private void buttonAdminCostumer_Click(object sender, EventArgs e)
        {
            AdminCustomer admincustomer = new AdminCustomer(Connection);
            admincustomer.ShowDialog();
        }

        private void buttonAdminRoom_Click(object sender, EventArgs e)
        {
            AdminRoom adminroom = new AdminRoom(Connection);
            adminroom.ShowDialog();
        }
    }
}
