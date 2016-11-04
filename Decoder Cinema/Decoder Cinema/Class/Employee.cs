using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    class Employee
    {
        int idEmployee;
        string name;
        string password;
        int idJobPosition;
        bool active;

        public Employee(int idEmployee, string name, string password, int idJobPosition, bool active)
        {
            this.name = name;
            this.password = password;
            this.idJobPosition = idJobPosition;
            this.active = active;
        }

        public int ID
        {   get { return idEmployee; }
            set { idEmployee = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Job_Position
        {
            get { return idJobPosition; }
            set { idJobPosition = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public static int AddEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO employee(eName, ePassword, JobPosition_idJobPosition, active) VALUES('{0}', '{1}', {2}, true)", employee.name, employee.password, employee.idJobPosition), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        /*public static int SearchEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE idEmployee = {0}", idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }*/

        public static int ModifyEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET eName = '{0}', ePassword = '{1}', eJobPosition = {2}, active = true WHERE idEmployee = {3}", employee.name, employee.password, employee.idJobPosition, employee.idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET active = false WHERE idEmployee = {0}", idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static IList<Employee> ShowEmployee(MySqlConnection Connection)
        {
            List<Employee> lEmployee = new List<Employee>();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee"), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) { Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetBoolean(4));
                lEmployee.Add(employee); }
            return lEmployee;
        }
    }
}