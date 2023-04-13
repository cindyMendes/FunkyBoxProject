using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkyBox
{
    public partial class frmDisplayCustomers : Form
    {

        public static List<Customer> sdCustomers = new List<Customer>();
        public static DataTable displayCustomers = new DataTable();


        public frmDisplayCustomers()
        {
            InitializeComponent();

            if (displayCustomers.Columns.Count == 0)
            {
                displayCustomers.Columns.Add(new DataColumn("Nom", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Numéro de rue", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Type de voie", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Code postal", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Ville", typeof(System.String)));
                displayCustomers.Columns.Add(new DataColumn("Plaque d'immatriculation", typeof(System.String)));
            }

            foreach (Customer newCustomer in sdCustomers)
            {
                DataRow dr = displayCustomers.NewRow();
                dr[0] = newCustomer.FirstName;
                dr[1] = newCustomer.LastName;
                dr[2] = newCustomer.StreetNumber;
                dr[3] = newCustomer.StreetType;
                dr[4] = newCustomer.StreetName;
                dr[5] = newCustomer.PostalCode;
                dr[6] = newCustomer.City;
                dr[7] = newCustomer.LicencePlate;
                displayCustomers.Rows.Add(dr);
            }
            grdCustomers.DataSource = displayCustomers;


        } // end frmDisplayCustomersBis

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            displayCustomers.Clear();
            frmCreateCustomer frmCC = new frmCreateCustomer();
            frmCC.ShowDialog();
        } // end btnAdd_Click

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end btnReturnHome_Click


    } // end class
} // end namespace
