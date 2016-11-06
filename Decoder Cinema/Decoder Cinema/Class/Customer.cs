using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    class Customer
    {
        int idCustomer;
        string name;
        string lastName;
        string adress;
        string email;
        string tel;

        public Customer(int idCustomer, string name, string lastName, string adress, string email, string tel)
        {
            this.idCustomer = idCustomer;
            this.name = name;
            this.lastName = lastName;
            this.adress = adress;
            this.email = email;
            this.tel = tel;
        }

        public int ID
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Last_Name
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public static int AddCustomer(MySqlConnection Connection, Customer customer)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO customer(cName, cLastName, cAdress, cEmail, cTel, active) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', true)", customer.name, customer.lastName, customer.adress, customer.email, customer.tel), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static Customer SearchCustomer(MySqlConnection Connection, string idCustomer)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM customer WHERE idCustomer = {0} AND active = true", idCustomer), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Customer customer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                return customer;
            }
            Customer e = null; return e;
        }

        public static int ModifyCustomer(MySqlConnection Connection, Customer customer)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE customer SET cName = '{0}', cLastName = '{1}', cAdress = '{2}', cEmail = '{3}', cTel = '{4}', active = true WHERE idCustomer = {5}", customer.name, customer.lastName, customer.adress, customer.email, customer.tel, customer.idCustomer), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteCustomer(MySqlConnection Connection, string idCustomer)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE customer SET active = false WHERE idCustomer = {0}", idCustomer), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Customer> ShowEmployee(MySqlConnection Connection)
        {
            List<Customer> lCustomer = new List<Customer>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM customer WHERE active = true"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                lCustomer.Add(customer);
            }
            return lCustomer;
        }
    }
}
