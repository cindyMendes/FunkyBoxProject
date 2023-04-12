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

        Point myPointTextBox = new Point(683, 115);
        Point myPointPictureBox = new Point(876, 115);
        Point myPointPictureBox2 = new Point (836, 115);
        List<TextBox> txtBoxList = new List<TextBox>();
        List<PictureBox> picBoxList = new List<PictureBox>();
        int counter = 0;
       
        /// <summary>
        /// Fonction ajout de textBox et bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAdd_Click(object sender, EventArgs e)
        {
            if (counter < 6)
            {
                myPointTextBox.Y += 40;
                myPointPictureBox.Y += 40;
                myPointPictureBox2.Y += 40;
                TextBox txtAddVehicle = new TextBox();
                txtAddVehicle.Location = myPointTextBox;
                txtAddVehicle.Size = new Size(131, 26);
                txtAddVehicle.Font = new Font("Microsoft Sans Serif", 12);
                this.Controls.Add(txtAddVehicle);
                txtBoxList.Add(txtAddVehicle);
                picAdd.Location = myPointPictureBox; 
                PictureBox picDel = new PictureBox();
                picDel.Location = myPointPictureBox2;
                picDel.Size = new Size(26, 26);
                picDel.Image = global::FunkyBox.Properties.Resources.minus1;
                picDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picDel.Click += new System.EventHandler(this.picDel_Click);
                this.Controls.Add(picDel);
                picBoxList.Add(picDel);
                counter++;
            }
            else
            {
                MessageBox.Show("La limite de véhicules par locataire est atteinte.");
            }
        }//endPicAddClick

        private void picDel_Click(object sender, System.EventArgs e)
        {
            // need to fix this code
            //MessageBox.Show(e.ToString());


        } // end picDel_Click

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end btnCancel_Click

     

    } // end Class
} // end namespace
