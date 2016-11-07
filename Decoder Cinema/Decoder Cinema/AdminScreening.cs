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
    public partial class AdminScreening : Form
    {
        Class.Connection Connection;

        public AdminScreening(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            MySqlDataAdapter da = Class.Screening.ShowRoom(Connection.myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "screening");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "screening";
            Connection.CloseConnection();
        }

        private void AdminScreening_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string idScreening = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ModifyScreening modifyscreening = new ModifyScreening(Connection, idScreening);
            modifyscreening.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string idScreening = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Screening.DeleteRoom(Connection.myConnection, idScreening);
                Connection.CloseConnection();
                MessageBox.Show("Eliminado exitosamente");
                LoadData();
            }
        }
    }
}
