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
    public partial class AdminMovie : Form
    {
        Class.Connection Connection;

        public AdminMovie(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void AdminMovie_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Movie.ShowMovie(Connection.myConnection);
            Connection.CloseConnection();

            string image = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromFile(image);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string image = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromFile(image);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string idMovie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ModifyMovie modifymovie = new ModifyMovie(Connection, idMovie);
            modifymovie.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string idMovie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Connection.OpenConnection();
                Class.Movie.DeleteMovie(Connection.myConnection, idMovie);
                Connection.CloseConnection();
                MessageBox.Show("Eliminado exitosamente");
                LoadData();
            }
        }
    }
}
