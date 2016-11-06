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
            LoadData();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string idEmployee = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ModifyEmployee modifyemployee = new ModifyEmployee(Connection, idEmployee);
            modifyemployee.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string idemployee = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Employee.DeleteEmployee(Connection.myConnection, idemployee);
                Connection.CloseConnection();
                MessageBox.Show("Eliminado exitosamente");
                LoadData();
            }          
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            MySqlDataAdapter da = Class.Employee.ShowEmployee(Connection.myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "employee";
            Connection.CloseConnection();
        }
    }
}
