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

        private DataTable dtCustomers;

        private SortedDictionary<String, Customer> allCustomers;

        public void Ajouter(Customer unCustomer)
        {
            this.allCustomers.Add(unCustomer.LicencePlate, unCustomer);
        }

        public DataTable ListCustomer()
        {
            this.dtCustomers.Clear();
            foreach (Customer c in this.allCustomers.Values)
            {
                DataRow dr;   
                dr = this.dtCustomers.NewRow();
                dr[0] = c.FirstName;
                dr[1] = c.LastName;
                dr[2] = c.StreetNumber;
                dr[3] = c.StreetType;
                dr[4] = c.StreetName;
                dr[5] = c.PostalCode;
                dr[6] = c.City;
                dr[7] = c.LicencePlate;

                this.dtCustomers.Rows.Add(dr);
            }

            return this.dtCustomers;
        }


        public Parking()
        {
            //this.code = code;
            //this.name = name;
 
            allCustomers = new SortedDictionary<string, Customer>();
            dtCustomers = new DataTable();

            this.dtCustomers.Columns.Add(new DataColumn("Prenom", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("Numero", typeof(System.Int32)));
            this.dtCustomers.Columns.Add(new DataColumn("Type", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("Rue", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("CP", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            this.dtCustomers.Columns.Add(new DataColumn("Immatriculation", typeof(System.String)));
        }



    } // end class
} // end namespace
