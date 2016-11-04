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

        public SaleDetail(int idSale, int idScreening, float price)
        {
            this.idSale = idSale;
            this.idScreening = idScreening;
            this.price = price;
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

        public static int AddSaleDetail(MySqlConnection Connection, SaleDetail saledetail)
        {
            MySqlCommand command = new MySqlCommand(String.Format("INSERT INTO sale_detail(Sale_idSale, Screening_idScreening, sdPrice) VALUES({0}, {1}, {2})", saledetail.idSale, saledetail.idScreening, saledetail.price), Connection);
            int OK = command.ExecuteNonQuery();
            /// if OK = 1 it's ok, if OK = 0 error
            return OK;
        }
    }
}
