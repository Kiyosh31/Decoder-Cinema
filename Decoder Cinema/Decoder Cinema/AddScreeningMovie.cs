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
    public partial class AddScreeningMovie : Form
    {
        Class.Connection Connection;
        string image;
        string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public AddScreeningMovie(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void AdminScreeningMovie_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            dataGridView1.DataSource = Class.Movie.ShowMovie(Connection.myConnection);
            Connection.CloseConnection();

            image = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromFile(image);
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            image = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromFile(image);
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
