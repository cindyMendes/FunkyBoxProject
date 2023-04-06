using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FunkyBox
{
    public partial class frmDisplayCustomers : Form
    {

        private ClassPOS classPOS;



        public frmDisplayCustomers()
        {
            InitializeComponent();

            // hard coded customers
            Customer oneCustomer = new Customer("Laurent", "Campan", 44, "Rue", "Hérold", "06000", "Nice", "QW-234-VF");
            Customer twoCustomer = new Customer("Nicolas", "Raoux", 170, "Rue", "Henri Martin", "06330", "Roquefort-Les-Pins", "XC-653-LK");
            Customer threeCustomer = new Customer("Cindy", "Mendes", 1, "Chemin", "des Lavandins", "06800", "Cagnes-Sur-Mer", "DY-104-MG");
            Customer fourCustomer = new Customer("Qaïs", "Hamadou", 29, "Avenue", "Jean Médecin", "06000", "Nice", "PO-921-NA");

            this.classPOS = new ClassPOS("TEST", "Test Class POS");

            this.classPOS.Ajouter(oneCustomer);
            this.classPOS.Ajouter(twoCustomer);
            this.classPOS.Ajouter(threeCustomer);
            this.classPOS.Ajouter(fourCustomer);

            this.afficheCustomers();


        } // end frmDisplayCustomers

        private void afficheCustomers()
        {
            this.grdCustomers.DataSource = classPOS.ListerStagiaires();
            this.grdCustomers.Refresh();
        } // end afficheCustomers



    } // end class
} // end namespace
