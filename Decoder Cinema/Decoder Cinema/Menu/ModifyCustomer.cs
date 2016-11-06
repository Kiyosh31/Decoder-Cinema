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
    public partial class ModifyCustomer : Form
    {
        Class.Connection Connection;
        string idCustomer;

        public ModifyCustomer(Class.Connection Connection, string idCustomer)
        {
            InitializeComponent();
            this.Connection = Connection;
            this.idCustomer = idCustomer;
        }

        private void ModifyCustomer_Load(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Customer customer = Class.Customer.SearchCustomer(Connection.myConnection, idCustomer);
            textBoxName.Text = customer.Name;
            textBoxLastName.Text = customer.Last_Name;
            textBoxAdress.Text = customer.Adress;
            textBoxEmail.Text = customer.Email;
            textBoxTel.Text = customer.Tel;
            Connection.CloseConnection();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();
            Class.Customer customer = new Class.Customer(int.Parse(idCustomer), textBoxName.Text, textBoxLastName.Text, textBoxAdress.Text, textBoxEmail.Text, textBoxTel.Text);
            Class.Customer.ModifyCustomer(Connection.myConnection, customer);
            Connection.CloseConnection();

            MessageBox.Show("Modificado exitosamente");
            this.Close();
        }
    }
}
