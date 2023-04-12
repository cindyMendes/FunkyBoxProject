using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FunkyBox
{
    public partial class frmDisplayCustomers : Form
    {

        //private Parking Parking;
        DataTable newCustomer = new DataTable();

        public frmDisplayCustomers()
        {
            InitializeComponent();
            newCustomer.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Numéro de rue", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Type de voie", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Code postal", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            newCustomer.Columns.Add(new DataColumn("Plaque d'immatriculation", typeof(System.String)));
            grdCustomers.DataSource = newCustomer;
        }
        public void AddCustomer()
        {
            DataRow nc;
            nc = newCustomer.NewRow();
            nc[0] = textBox1.Text;
            nc[1] = textBox2.Text;
            nc[2] = textBox3.Text;
            nc[3] = textBox4.Text;
            nc[4] = textBox5.Text;
            nc[5] = textBox6.Text;
            nc[6] = textBox7.Text;
            nc[7] = textBox8.Text;
            newCustomer.Rows.Add(nc);
        }
        public void btnValid_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*// hard coded customers
        Customer oneCustomer = new Customer("Laurent", "Campan", 44, "Rue", "Hérold", "06000", "Nice", "QW-234-VF");
        Customer twoCustomer = new Customer("Nicolas", "Raoux", 170, "Rue", "Henri Martin", "06330", "Roquefort-Les-Pins", "XC-653-LK");
        Customer threeCustomer = new Customer("Cindy", "Mendes", 1, "Chemin", "des Lavandins", "06800", "Cagnes-Sur-Mer", "DY-104-MG");
        Customer fourCustomer = new Customer("Qaïs", "Hamadou", 29, "Avenue", "Jean Médecin", "06000", "Nice", "PO-921-NA");


        //this.Parking = new Parking("TEST", "Test Class POS");
        this.Parking = new Parking();

        this.Parking.Ajouter(oneCustomer);
        this.Parking.Ajouter(twoCustomer);
        this.Parking.Ajouter(threeCustomer);
        this.Parking.Ajouter(fourCustomer);

        this.afficheCustomers();


    } // end frmDisplayCustomers

    public void afficheCustomers()
    {
        this.grdCustomers.DataSource = Parking.ListCustomer();
        this.grdCustomers.Refresh();
    } // end afficheCustomers   */
    } // end class
} // end namespace
