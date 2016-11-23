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
    public partial class SaleTicket : Form
    {
        private Class.Connection Connection;
        private Class.Employee employee;
        private string Date;
        private int NoTicket;

        public SaleTicket(Class.Connection Connection, Class.Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            this.Connection = Connection;
        }

        private void SaleTicket_Load(object sender, EventArgs e)
        {
            LoadDataMovie();
            SetDate();
            textBoxTotal.Text = "0";
            NoTicket = MaxID();
            labelNoTicket.Text = "Ticket No. " + NoTicket.ToString();
            textBoxEmployee.Text = employee.Name;
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            if (dataGridViewScreening.CurrentRow.Cells[4].Value.ToString() == "0")
            {
                MessageBox.Show("Boletos agotados\npara esta función");
            }
            else
            {
                bool flag = false;
                string idScreening = dataGridViewScreening.CurrentRow.Cells[0].Value.ToString();

                if(Duplicate(idScreening)) { flag = true; }
                string ID = dataGridViewScreening.CurrentRow.Cells[0].Value.ToString();
                string MovieName = dataGridViewScreening.CurrentRow.Cells[7].Value.ToString();
                string Room = dataGridViewScreening.CurrentRow.Cells[6].Value.ToString();
                string DateMovie = dataGridViewScreening.CurrentRow.Cells[5].Value.ToString();
                string TimeStart = dataGridViewScreening.CurrentRow.Cells[2].Value.ToString();
                string Price = dataGridViewScreening.CurrentRow.Cells[1].Value.ToString();

                if(flag)
                {
                    AddQuantity(idScreening);
                }
                else
                {
                    dataGridViewSale.Rows.Add(ID, MovieName, Room, DateMovie, TimeStart, 1, Price, Price);
                }

                dataGridViewScreening.CurrentRow.Cells[4].Value = Convert.ToInt32(dataGridViewScreening.CurrentRow.Cells[4].Value) - 1;
                Total();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSale.Rows.Remove(dataGridViewSale.CurrentRow);
                dataGridViewScreening.CurrentRow.Cells[4].Value = Convert.ToInt32(dataGridViewScreening.CurrentRow.Cells[4].Value) + 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un elemento de la lista");
            }

            Total();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.OpenConnection();
                Class.Customer customer = Class.Customer.SearchCustomer(Connection.myConnection, textBoxIDcustomer.Text);
                Connection.CloseConnection();
                textBoxName.Text = customer.Name;
                textBoxEmail.Text = customer.Email;
            }
            catch (Exception)
            {
                MessageBox.Show("No existe Cliente");
            }
            Connection.CloseConnection();

        }

        private void SetDate()
        {
            DateTime today = DateTime.Now;
            Date = today.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private int MaxID()
        {
            int max = 1;
            Connection.OpenConnection();
            MySqlDataReader reader = Class.Sale.MaxID(Connection.myConnection);
            if (reader.Read())
            {
                if (!reader.IsDBNull(0)) { max = reader.GetInt32(0); max++; }
            }
            Connection.CloseConnection();
            return max;
        }

        private bool Duplicate(string ID)
        {
            bool flag = false;
            int i = 0;

            foreach (DataGridViewRow Row in dataGridViewSale.Rows)
            {
                if (ID == Convert.ToString(Row.Cells[0].Value))
                {
                    i++;
                }
                if (i >= 1) { flag = true; }
            }

            return flag;
        }

        private int AddQuantity(string idScreening)
        {
            int currentQuantity = 0;
            decimal price = 0;
            int QuantityProduct = CheckStock(idScreening);
            foreach (DataGridViewRow Row in dataGridViewSale.Rows)
            {
                if (idScreening == Convert.ToString(Row.Cells[0].Value))
                {
                    currentQuantity = Convert.ToInt32(Row.Cells["Cantidad"].Value);
                    price = Convert.ToDecimal(Row.Cells["Precio"].Value);

                    if (QuantityProduct > currentQuantity)
                    {
                        currentQuantity++;
                        Row.Cells["Cantidad"].Value = currentQuantity;
                        Row.Cells["Importe"].Value = price * currentQuantity;
                    }
                    else
                    {
                        MessageBox.Show("No hay mas stock");
                    }
                }
            }
            currentQuantity++;
            return currentQuantity;
        }

        private int CheckStock(string idScreening)
        {
            Connection.OpenConnection();
            Class.Screening screening = Class.Screening.SearchScreening(Connection.myConnection, idScreening);
            Connection.CloseConnection();
            return screening.Stock;
        }

        private void LoadDataMovie()
        {
            Connection.OpenConnection();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT mName, mUrl, idMovie as Pelicula from movie", Connection.myConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "movie");
            dataGridViewMovie.DataSource = dataSet;
            dataGridViewMovie.DataMember = "movie";
            dataGridViewMovie.Columns[1].Visible = false;
            dataGridViewMovie.Columns[0].Width = 200;

            pictureBox1.Image = Image.FromFile(dataGridViewMovie.CurrentRow.Cells[1].Value.ToString());

            Connection.CloseConnection();
            LoadDataScreening(dataGridViewMovie.CurrentRow.Cells[2].Value.ToString());
        }

        private void LoadDataScreening(string idMovie)
        {
            Connection.OpenConnection();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(String.Format("SELECT idScreening as ID, sPrice as Precio, sStartTime as Hora_Inicio,"
             + "sEndTime as Hora_Fin, Stock as Disponibles, Date as Fecha, Room_idRoom as Sala,"
             + "mName as Pelicula FROM screening INNER JOIN movie ON Movie_idMovie = idMovie WHERE screening.Active = true AND idMovie = {0}", idMovie), Connection.myConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "screening");
            dataGridViewScreening.DataSource = dataSet;
            dataGridViewScreening.DataMember = "screening";
            dataGridViewScreening.Columns[0].Visible = false;

            Connection.CloseConnection();
        }

        private void dataGridViewMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(dataGridViewMovie.CurrentRow.Cells[1].Value.ToString());
            LoadDataScreening(dataGridViewMovie.CurrentRow.Cells[2].Value.ToString());
        }

        private void Total()
        {
            decimal total = 0;

            foreach(DataGridViewRow row in dataGridViewSale.Rows)
            {
                total += Convert.ToDecimal(row.Cells[7].Value);
            }

            textBoxTotal.Text = total.ToString();
        }

        private void AddSale()
        {
            Connection.OpenConnection();
            Class.Sale sale = new Class.Sale(1, Date, employee.ID, Int32.Parse(textBoxIDcustomer.Text));
            Class.Sale.AddSale(Connection.myConnection, sale);
            Connection.CloseConnection();
        }

        private void AddDetail(int idSale, string idScreening, string Price, int quantity)
        {
            Connection.OpenConnection();
            Class.SaleDetail detail = new Class.SaleDetail(idSale, int.Parse(idScreening), float.Parse(Price), quantity);
            Class.SaleDetail.AddSaleDetail(Connection.myConnection, detail);
            Connection.CloseConnection();
        }

        private void AddAllDetail()
        {
            foreach (DataGridViewRow row in dataGridViewSale.Rows)
            {
                AddDetail(NoTicket, row.Cells[0].Value.ToString(), row.Cells["Precio"].Value.ToString(), Convert.ToInt32(row.Cells["Cantidad"].Value));
            }
        }

        private void DecreaseStock()
        {
            foreach (DataGridViewRow row in dataGridViewSale.Rows)
            {
                string idScreening = Convert.ToString(row.Cells[0].Value);
                int StockDecrease = Convert.ToInt32(row.Cells["Cantidad"].Value);

                Connection.OpenConnection();
                Class.Screening screening = Class.Screening.SearchScreening(Connection.myConnection, idScreening);
                Connection.CloseConnection();

                screening.Stock = screening.Stock - StockDecrease;
                screening.Date = Convert.ToDateTime(screening.Date).ToString("yyyy-MM-dd");

                Connection.OpenConnection();
                Class.Screening.ModifyScreening(Connection.myConnection, screening);
                Connection.CloseConnection();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxTotal.Text == "0" || textBoxName.Text == "")
            {
                MessageBox.Show("Debe Llenar Todos Los Campos");
            }
            else
            {
                DecreaseStock();
                AddSale();
                AddAllDetail();
                MessageBox.Show("Compra Exitosa");
                this.Close();
            }
        }
    }
}