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
    //SECTION CLASS
    public partial class frmCreateParking : Form
    {
        ParkingPur data;
        public DataTable displayParking = new DataTable();
        //Le constructeur frmCreateParking
        public frmCreateParking()
        {
            InitializeComponent();
            displayParking.Columns.Add(new DataColumn("PNmCol", typeof(String)));
            displayParking.Columns.Add(new DataColumn("PNbCol", typeof(String)));
            displayParking.Columns.Add(new DataColumn("PA1Col", typeof(String)));
            displayParking.Columns.Add(new DataColumn("PA2Col", typeof(String)));
            displayParking.Columns.Add(new DataColumn("SNCol", typeof(String)));
        }

        // déclaration de la liste pour stocker les données
        //List<ParkingPur> ParkingList = new List<ParkingPur>();


        // classe pour stocker les données du formulaire
        public class ParkingPur
        {
            public string ParkingName { get; set; }
            public string ParkingNumber { get; set; }
            public string ParkingAddr1 { get; set; }
            public string ParkingAddr2 { get; set; }
            public string StreetNumber { get; set; }

            public ParkingPur(String ParkingName, String ParkingNumber, String ParkingAddr1, String ParkingAddr2, string StreetNumber)
            {
                this.ParkingName = ParkingName;
                this.ParkingNumber = ParkingNumber;
                this.ParkingAddr1 = ParkingAddr1;
                this.ParkingAddr2 = ParkingAddr2;
                this.StreetNumber = StreetNumber;


               
            }    
            


        }

        //FIN SECTION CLASS

        //SECTION GESTION DE L'ÉVÈNEMENT CLIC SUR BOUTON CONFIRMER
        

        private void btnParkingConfirm_Click(object sender, EventArgs e)
        {
            // création d'un nouvel objet ParkingPur à partir des champs du formulaire
           data = new ParkingPur(txtParkingName.Text, txtParkingNumber.Text, txtParkingAddr1.Text, txtParkingAddr2.Text, txtStreetNumber.Text); 

            ParkingList(data);



            if (displayParking is null)
            {
                MessageBox.Show("vide");
            }

            //ParkingPur data2 = new ParkingPur(txtParkingName.Text, txtParkingNumber.Text, txtParkingAddr1.Text, txtParkingAddr2.Text, txtStreetNumber.Text); //

            txtParkingName.Clear();
           
        }
        // FIN SECTION  GESTION DE L'ÉVÈNEMENT CLIC SUR BOUTON CONFIRMER

        //SECTION AFFICHAGE DE LA PAGE SUIVANTE CONTENANT LE DGV

       

        

        //public ParkingPur Parking1 = new ParkingPur("", "", "", "", "");

        //création des lignes du tableau lié à DataTable
        public DataTable  ParkingList(ParkingPur PKName)
        {

           // this.displayParking.Clear();
            DataRow drow = displayParking.NewRow();
            drow = displayParking.NewRow();
            drow[0] = PKName.ParkingName;
            drow[1] = PKName.ParkingNumber;
            drow[2] = PKName.ParkingAddr1;
            drow[3] = PKName.ParkingAddr2;
            drow[4] = PKName.StreetNumber;
            //MessageBox.Show(drow[0].ToString());
            return displayParking;
        }

        

        private void btnParkingDisplay_Click(object sender, EventArgs e)
        {
            frmDisplayParking displayPark= new frmDisplayParking();

            // détachement de la source de données pour éviter les conflits
            frmDisplayParking.displayView.DataSource = null;
            // affectation de la liste des données comme source de données pour le DataGridView
            frmDisplayParking.displayView.DataSource = ParkingList(data);
            
            displayPark.Show();


        }


        //FIN SECTION AFFICHAGE dDE LA PAGE SUIVANTE CONTENANT LE DGV

        //
        //        frmDisplayGarages


        //namespace FunkyBox
        //    {
        //        internal partial class frmDisplayGarages : Form
        //        {
        //            public static List<Garage> sdGarages = new List<Garage>();
        //            public static DataTable displayGarages = new DataTable();

        //            public frmDisplayGarages()
        //            {
        //                InitializeComponent();

        //                if (displayGarages.Columns.Count == 0)
        //                {
        //                    displayGarages.Columns.Add(new DataColumn("Identifiant du box", typeof(System.String)));
        //                    displayGarages.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
        //                    displayGarages.Columns.Add(new DataColumn("Loyer mensuel", typeof(System.Double)));
        //                    displayGarages.Columns.Add(new DataColumn("Charges mensuelles", typeof(System.Double)));
        //                    displayGarages.Columns.Add(new DataColumn("Nom du locataire", typeof(System.String)));
        //                    displayGarages.Columns.Add(new DataColumn("Début de location", typeof(System.DateTime)));
        //                }

        //                foreach (Garage newGarage in sdGarages)
        //                {
        //                    DataRow dr = displayGarages.NewRow();
        //                    dr[0] = newGarage.GarageId;
        //                    dr[1] = newGarage.ParkingName;
        //                    dr[2] = newGarage.MonthlyRent;
        //                    dr[3] = newGarage.MonthlyFees;
        //                    dr[4] = newGarage.TenantName;
        //                    dr[5] = newGarage.StartRent;
        //                    displayGarages.Rows.Add(dr);
        //                }
        //                dgvDisplayGarages.DataSource = displayGarages;

        //            }
        //            private void btnAddGarage_Click(object sender, EventArgs e)
        //            {
        //                displayGarages.Clear();
        //                this.Hide();
        //                frmCreateGarage frmCG = new frmCreateGarage();
        //                frmCG.ShowDialog();

        //            }
        //        }
        //    }


        //    frmCreateGarage


        //namespace FunkyBox
        //    {
        //        public partial class frmCreateGarage : Form
        //        {
        //            public frmCreateGarage()
        //            {
        //                InitializeComponent();
        //            }
        //            public void AddGarage()
        //            {
        //                Garage newGarage = new Garage(txtGarageNb.Text, txtParkingName.Text, Double.Parse(txtMonthlyRent.Text), Double.Parse(txtMonthlyFees.Text), txtTenantName.Text, DateTime.Parse(txtStartRent.Text));
        //                frmDisplayGarages.sdGarages.Add(newGarage);
        //            }

        //            private void btnCancel_Click(object sender, EventArgs e)
        //            {
        //                this.Hide();
        //                frmDisplayGarages frmDG = new frmDisplayGarages();
        //                frmDG.ShowDialog();
        //                this.Close();
        //            }

        //            private void btnSave_Click(object sender, EventArgs e)
        //            {
        //                AddGarage();
        //                this.Hide();
        //                frmDisplayGarages frmDG = new frmDisplayGarages();
        //                frmDG.ShowDialog();
        //                this.Close();
        //            }
        //        }
        //    }
        //    //

    }


}
