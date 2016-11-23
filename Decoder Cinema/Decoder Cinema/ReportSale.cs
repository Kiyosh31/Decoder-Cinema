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
    public partial class ReportSale : Form
    {
        Class.Connection Connection;

        public ReportSale(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }

        private void ReportSale_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadPanel();
        }

        private void LoadPanel()
        {
            labelNoTicket.Text = "Ticket No. " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelDate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelEmployee.Text = NameEmployee();
            labelCustomer.Text = NameCustomer();
            FillData();
            Total();
        }

        private string NameEmployee()
        {
            string idEmployee = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Connection.OpenConnection();
            Class.Employee employee = Class.Employee.SearchEmployee(Connection.myConnection, idEmployee);
            Connection.CloseConnection();
            return employee.Name;
        }

        private string NameCustomer()
        {
            string idCustomer = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Connection.OpenConnection();
            Class.Customer customer = Class.Customer.SearchCustomer(Connection.myConnection, idCustomer);
            Connection.CloseConnection();
            return customer.Name;
        }

        private void FillData()
        {
            Connection.OpenConnection();
            MySqlDataAdapter adapter = Class.SaleDetail.ShowDetail(Connection.myConnection, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "sale_detail");
            dataGridViewSale.DataSource = dataset;
            dataGridViewSale.DataMember = "sale_detail";
            //dataGridView1.Columns[1].Width = 270;
            Connection.CloseConnection();
        }

        private void Total()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewSale.Rows)
            {
                total += Convert.ToDecimal(row.Cells[6].Value);
            }

            labelTTotal.Text = total.ToString();
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Sale.ShowSale(Connection.myConnection);
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            Connection.CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadPanel();
            FillData();
        }
    }
}
