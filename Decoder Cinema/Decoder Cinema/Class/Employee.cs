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

        public Employee(int idEmployee, string name, string password, int idJobPosition)
        {
            this.idEmployee = idEmployee;
            this.name = name;
            this.password = password;
            this.idJobPosition = idJobPosition;
        }

        public Employee(int idEmployee, string name, string password, string idJobPosition)
        {
            this.idEmployee = idEmployee;

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

        public static Employee SearchEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM employee WHERE idEmployee = {0} AND active = true", idEmployee), Connection);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                return employee;
            }
            Employee e = null; return e;
        }

        public static int ModifyEmployee(MySqlConnection Connection, Employee employee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET eName = '{0}', ePassword = '{1}', JobPosition_idJobPosition = {2}, active = true WHERE idEmployee = {3}", employee.name, employee.password, employee.idJobPosition, employee.idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }

        public static int DeleteEmployee(MySqlConnection Connection, string idEmployee)
        {
            MySqlCommand command = new MySqlCommand(String.Format("UPDATE employee SET active = false WHERE idEmployee = {0}", idEmployee), Connection);
            int OK = command.ExecuteNonQuery();
            return OK;
        }
       
        public static MySqlDataAdapter ShowEmployee(MySqlConnection Connection)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT idEmployee as ID, eName as Nombre, ePassword as Password, Name as Puesto FROM employee e INNER JOIN jobposition j ON e.JobPosition_idJobPosition = j.idJobPosition WHERE active = true", Connection);
            return da;
        }
    }
}