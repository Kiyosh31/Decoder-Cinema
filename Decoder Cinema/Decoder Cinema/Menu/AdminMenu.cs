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
        Class.Employee employee;

        public AdminMenu(Class.Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
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

        private void buttonAddScreening_Click(object sender, EventArgs e)
        {
            AddScreening addscreening = new AddScreening(Connection);
            addscreening.ShowDialog();
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
            this.Hide();
            admincustomer.ShowDialog();
            this.Show();
        }

        private void buttonAdminRoom_Click(object sender, EventArgs e)
        {
            AdminRoom adminroom = new AdminRoom(Connection);
            this.Hide();
            adminroom.ShowDialog();
            this.Show();
        }

        private void buttonAdminMovie_Click(object sender, EventArgs e)
        {
            AdminMovie adminmovie = new AdminMovie(Connection);
            this.Hide();
            adminmovie.ShowDialog();
            this.Show();
        }

        private void buttonAdminScreening_Click(object sender, EventArgs e)
        {
            AdminScreening adminscreening = new AdminScreening(Connection);
            this.Hide();
            adminscreening.ShowDialog();
            this.Show();
        }

        private void buttonSellTicket_Click(object sender, EventArgs e)
        {
            SaleTicket saleticket = new SaleTicket(Connection, employee);
            saleticket.ShowDialog();
        }

        private void buttonReportSale_Click(object sender, EventArgs e)
        {
            ReportSale reportsale = new ReportSale(Connection);
            reportsale.ShowDialog();
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addemployee = new AddEmployee(Connection);
            addemployee.ShowDialog();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminEmployee adminemployee = new AdminEmployee(Connection);
            this.Hide();
            adminemployee.ShowDialog();
            this.Show();
        }

        private void registrarNuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer(Connection);
            addcustomer.ShowDialog();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminCustomer admincustomer = new AdminCustomer(Connection);
            this.Hide();
            admincustomer.ShowDialog();
            this.Show();
        }

        private void nuevaPelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addmovie = new AddMovie(Connection);
            addmovie.ShowDialog();
        }

        private void administrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminMovie adminmovie = new AdminMovie(Connection);
            this.Hide();
            adminmovie.ShowDialog();
            this.Show();
        }

        private void registrarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom addroom = new AddRoom(Connection);
            addroom.ShowDialog();
        }

        private void administrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdminRoom adminroom = new AdminRoom(Connection);
            this.Hide();
            adminroom.ShowDialog();
            this.Show();
        }

        private void nuevaFunciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScreening addscreening = new AddScreening(Connection);
            addscreening.ShowDialog();
        }

        private void administrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AdminScreening adminscreening = new AdminScreening(Connection);
            this.Hide();
            adminscreening.ShowDialog();
            this.Show();
        }
    }
}
