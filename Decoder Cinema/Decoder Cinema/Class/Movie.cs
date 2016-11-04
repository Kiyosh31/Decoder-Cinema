using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    class Movie
    {
        int idMovie;
        string name;
        string clasification;
        string category;
        bool active;

        public Movie(int idMovie, string name, string clasification, string category, bool active)
        {
            this.idMovie = idMovie;
            this.name = name;
            this.clasification = clasification;
            this.category = category;
            this.active = active;
        }

        public int ID
        {
            get { return idMovie; }
            set { idMovie = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Clasification
        {
            get { return clasification; }
            set { clasification = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int AddMovie(MySqlConnection Connection, Movie movie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO movie(mNAme, mClasification, mCategory, active) VALUES('{0}', '{1}', '{2}', true)", movie.name, movie.clasification, movie.category), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static int ModifyMovie(MySqlConnection Connection, Movie movie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE movie SET mName = '{0}', mClasification = '{1}', mCategory = '{2}', active = true WHERE idMovie = {3}", movie.name, movie.clasification, movie.category, movie.idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteMovie(MySqlConnection Connection, string idMovie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE movie SET active = false WHERE idMovie = {0}", idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Movie> ShowEmployee(MySqlConnection Connection)
        {
            List<Movie> lMovie = new List<Movie>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM movie"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Movie movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4));
                lMovie.Add(movie);
            }
            return lMovie;
        }
    }
}
