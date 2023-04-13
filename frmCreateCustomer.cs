using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FunkyBox
{
    public partial class frmCreateCustomer : Form
    {

        frmDisplayCustomers displayCustomerForm = new frmDisplayCustomers();
        //DataGridView dt = frmDisplayCustomers.dt;


        public frmCreateCustomer()
        {
            InitializeComponent();
        } // end frmCreateCustomer

        private void btnSave_Click(object sender, EventArgs e)
        {
            //List<string> oneLP = new List<string>();
            //oneLP.Add("SD-564-FD");
            //oneLP.Add("IU-598-TY");
            //List<string> twoLP = new List<string>();
            //List<string> threeLP = new List<string>();
            //List<string> fourLP = new List<string>();
            //Customer c = new Customer("Laurent", "Campan", 44, "Rue", "Hérold", "06000", "Nice", oneLP);
            //Customer twoCustomer = new Customer("Nicolas", "Raoux", 170, "Rue", "Henri Martin", "06330", "Roquefort-Les-Pins", twoLP);
            //Customer threeCustomer = new Customer("Cindy", "Mendes", 1, "Chemin", "des Lavandins", "06800", "Cagnes-Sur-Mer", threeLP);
            //Customer fourCustomer = new Customer("Qaïs", "Hamadou", 29, "Avenue", "Jean Médecin", "06000", "Nice", fourLP);

            //MessageBox.Show(c.ToString());
            //MessageBox.Show(twoCustomer.ToString());
            //MessageBox.Show(threeCustomer.ToString());
            //MessageBox.Show(fourCustomer.ToString());

            //Customer c = new Customer(txtFirstname.Text, txtLastname.Text, txtStreetNumber.Text, txtStreetType.Text, txtStreetName.Text, txtPostalCode.Text, txtCity.Text, txtAddVehicle.Text) ;

            //c.Ajouter(c);
            //MessageBox.Show(c.AllCustomersDict.Values.Count.ToString()) ;
            
            //dt.Location = new Point(100, 150);
            //dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dt.Size = new Size(500, 200);
            ////dt.DataSource = c.ListCustomer(); 

            //displayCustomerForm.Controls.Add(dt);
            //displayCustomerForm.Show();
            

        } // end btnSave_Click


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end btnCancel_Click


    } // end Class
} // end namespace
