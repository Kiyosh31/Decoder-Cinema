using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder_Cinema
{
    public partial class AdminCustomer : Form
    {
        Class.Connection Connection;

        public AdminCustomer(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void AdminCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Customer.ShowEmployee(Connection.myConnection);
            Connection.CloseConnection();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string idCustomer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ModifyCustomer modifycustomer = new ModifyCustomer(Connection, idCustomer);
            modifycustomer.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string idCustomer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Customer.DeleteCustomer(Connection.myConnection, idCustomer);
                Connection.CloseConnection();
                MessageBox.Show("Eliminado exitosamente");
                LoadData();
            }
        }
    }
}
