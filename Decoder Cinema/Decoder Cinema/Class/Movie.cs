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
        string duration;
        string clasification;
        string category;
        string sinopsis;
        string url;

        public Movie(int idMovie, string name, string duration, string clasification, string category, string sinopsis, string url)
        {
            this.idMovie = idMovie;
            this.name = name;
            this.duration = duration;
            this.clasification = clasification;
            this.category = category;
            this.sinopsis = sinopsis;
            this.url = url;
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

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
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

        public string Sinopsis
        {
            get { return sinopsis; }
            set { sinopsis = value; }
        }

        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        public static int AddMovie(MySqlConnection Connection, Movie movie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO movie(mName, mDuration, mClasification, mCategory, mSinopsis, mUrl, active) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', true)", movie.name, movie.duration, movie.clasification, movie.category, movie.sinopsis, movie.url), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static Movie SearchMovie(MySqlConnection Connection, string idMovie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM movie WHERE idMovie = {0} AND active = true", idMovie), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Movie movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                return movie;
            }
            Movie e = null; return e;
        }

        public static int ModifyMovie(MySqlConnection Connection, Movie movie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE movie SET mName = '{0}', mDuration = '{1}', mClasification = '{2}', mCategory = '{3}', mSinopsis = '{4}', mUrl = '{5}' WHERE idMovie = {6}", movie.name, movie.duration, movie.clasification, movie.category, movie.sinopsis, movie.url, movie.idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteMovie(MySqlConnection Connection, string idMovie)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE movie SET active = false WHERE idMovie = {0}", idMovie), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Movie> ShowMovie(MySqlConnection Connection)
        {
            List<Movie> lMovie = new List<Movie>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM movie WHERE active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Movie movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                lMovie.Add(movie);
            }
            return lMovie;
        }
    }
}
