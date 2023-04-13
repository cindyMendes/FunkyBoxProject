   using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBox
{
    internal class Parking
    {

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }   
        }

        private string name;

        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        private DataTable dtCustomersParking;

        private SortedDictionary<String, Customer> dictCustomersParking;

        public void Ajouter(Customer unCustomer)
        {
            this.dictCustomersParking.Add(unCustomer.LicencePlate, unCustomer);
        }

        public DataTable ListCustomerParking()
        {
            this.dtCustomersParking.Clear();
            foreach (Customer c in this.dictCustomersParking.Values)
            {
                DataRow dr;   
                dr = this.dtCustomersParking.NewRow();
                dr[0] = c.FirstName;
                dr[1] = c.LastName;
                dr[2] = c.StreetNumber;
                dr[3] = c.StreetType;
                dr[4] = c.StreetName;
                dr[5] = c.PostalCode;
                dr[6] = c.City;
                dr[7] = c.LicencePlate;

                this.dtCustomersParking.Rows.Add(dr);  
            }

            return this.dtCustomersParking;
        }


        public Parking()
        {
            //this.code = code;
            //this.name = name;
 
            dictCustomersParking = new SortedDictionary<string, Customer>();
            dtCustomersParking = new DataTable();

            this.dtCustomersParking.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Numero", typeof(System.Int32)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Type", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Rue", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("CP", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            this.dtCustomersParking.Columns.Add(new DataColumn("Immatriculation", typeof(System.String)));
        }



    } // end class
} // end namespace
