using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    class Sale
    {
        int idSale;
        string datetime;
        int e_idEmployee;
        int c_idCustomer;
        bool active;

        public Sale(int idSale, string datetime, int e_idEmployee, int c_idCustomer)
        {
            this.idSale = idSale;
            this.datetime = datetime;
            this.e_idEmployee = e_idEmployee;
            this.c_idCustomer = c_idCustomer;
        }

        public int ID
        {
            get { return idSale; }
            set { idSale = value; }
        }

        public string Date
        {
            get { return datetime; }
            set { datetime = value; }
        }

        public int ID_Employee
        {
            get { return e_idEmployee; }
            set { e_idEmployee = value; }
        }

        public int ID_Customer
        {
            get { return c_idCustomer; }
            set { c_idCustomer = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int AddSale(MySqlConnection Connection, Sale sale)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO sale(DateTime, Employee_idEmployee, Customer_idCustomer, Active) VALUES('{0}', '{1}', '{2}', true)", sale.datetime, sale.e_idEmployee, sale.c_idCustomer), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static int ModifySale(MySqlConnection Connection, Sale sale)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE sale SET DateTime = '{0}', Employee_idEmployee = {1}, Customer_idCustomer = {2}, Active = true WHERE idSale = {3}", sale.datetime, sale.e_idEmployee, sale.c_idCustomer, sale.idSale), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteSale(MySqlConnection Connection, string idSale)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE sale SET Active = false WHERE idSale = {0}", idSale), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Sale> ShowSale(MySqlConnection Connection)
        {
            List<Sale> lSale = new List<Sale>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM sale"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sale sale = new Sale(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                lSale.Add(sale);
            }
            return lSale;
        }
    }
}
