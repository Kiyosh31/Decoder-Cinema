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
    public partial class AddMovie : Form
    {
        string image;
        Class.Connection Connection;

        public AddMovie(Class.Connection Connection)
        {
            InitializeComponent();
            this.Connection = Connection;
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            try
            {
                if(openfile.ShowDialog() == DialogResult.OK)
                {
                    image = openfile.FileName;
                    pictureBox1.Image = Image.FromFile(image);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            if(textBoxDuration.Text == "" || textBoxName.Text == "" || textBoxSinopsis.Text == "" || image == "" || comboBoxCategory.Text == "" || comboBoxClasification.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                Connection.OpenConnection();
                image = image.Replace(@"\", @"\\");
                Class.Movie movie = new Class.Movie(1, textBoxName.Text, textBoxDuration.Text, comboBoxClasification.Text, comboBoxCategory.Text, textBoxSinopsis.Text, image);
                Class.Movie.AddMovie(Connection.myConnection, movie);
                Connection.CloseConnection();

                MessageBox.Show("Película registrada\nExitosamente");
                this.Close();
            }
        }
    }
}
