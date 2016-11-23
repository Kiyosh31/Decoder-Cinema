using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Decoder_Cinema.Class
{
    class SaleDetail
    {
        int idSale;
        int idScreening;
        float price;
        int quantity;

        public SaleDetail(int idSale, int idScreening, float price, int quantity)
        {
            this.idSale = idSale;
            this.idScreening = idScreening;
            this.price = price;
            this.quantity = quantity;
        }

        public int ID_Sale
        {
            get { return idSale; }
            set { idSale = value; }
        }

        public int ID_Screening
        {
            get { return idScreening; }
            set { idScreening = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public static int AddSaleDetail(MySqlConnection Connection, SaleDetail saledetail)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO sale_detail(Sale_idSale, Screening_idScreening, sdPrice, Quantity) VALUES({0}, {1}, {2}, {3})", saledetail.idSale, saledetail.idScreening, saledetail.price, saledetail.quantity), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }

        public static MySqlDataAdapter ShowDetail(MySqlConnection Connection, string idSale)
        {
            string Query = ("SELECT movie.mName as Pelicula, screening.Room_idRoom as Sala, screening.Date as Fecha, screening.sStartTime as Hora, sale_detail.sdPrice as Precio, sale_detail.Quantity as Cantidad, Round(sale_detail.sdPrice * sale_detail.Quantity, 1) as Importe FROM sale_detail INNER JOIN screening ON sale_detail.Screening_idScreening = screening.idScreening INNER JOIN movie ON screening.Movie_idMovie = movie.idMovie WHERE sale_Detail.Sale_idSale = {0}");
            MySqlDataAdapter da = new MySqlDataAdapter(String.Format(Query, idSale), Connection);
            return da;
        }
    }
}
