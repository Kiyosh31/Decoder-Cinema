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
    public partial class ModifyMovie : Form
    {
        Class.Connection Connection;
        string idMovie;
        string image;

        public ModifyMovie(Class.Connection Connection, string idMovie)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idMovie = idMovie;
        }

        private void ModifyMovie_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Movie movie = Class.Movie.SearchMovie(Connection.myConnection, idMovie);
            Connection.CloseConnection();

            textBoxName.Text = movie.Name;
            textBoxDuration.Text = movie.Duration;
            comboBoxCategory.Text = movie.Category;
            comboBoxClasification.Text = movie.Clasification;
            textBoxSinopsis.Text = movie.Sinopsis;
            pictureBox1.Image = Image.FromFile(movie.URL);
            image = movie.URL;
            image = image.Replace(@"\", @"\\");
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            try
            {
                if (openfile.ShowDialog() == DialogResult.OK)
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

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            image = image.Replace(@"\", @"\\");
            Class.Movie movie = new Class.Movie(int.Parse(idMovie), textBoxName.Text, textBoxDuration.Text, comboBoxClasification.Text, comboBoxCategory.Text, textBoxSinopsis.Text, image);
            Class.Movie.ModifyMovie(Connection.myConnection, movie);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }
    }
}
