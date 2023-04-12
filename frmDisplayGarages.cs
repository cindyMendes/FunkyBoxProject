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
    internal partial class frmDisplayGarages : Form
    {
<<<<<<< Updated upstream
        //DataTable displayGarages;

        //public frmCreateGarage()
        //{
        //    InitializeComponent();
        //    displayGarages.Columns.Add(new DataColumn("Identifiant du box", typeof(System.String)));
        //    displayGarages.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
        //    displayGarages.Columns.Add(new DataColumn("Loyer mensuel", typeof(System.Double)));
        //    displayGarages.Columns.Add(new DataColumn("Charges mensuelles", typeof(System.Double)));
        //    displayGarages.Columns.Add(new DataColumn("Nom du locataire", typeof(System.String)));
        //    displayGarages.Columns.Add(new DataColumn("Début de location", typeof(System.DateTime)));
        //    dgvDisplayGarages.DataSource = displayGarages;
        //}
        //public void AddGarage()
        //{
        //    DataRow dr;
        //    dr = displayGarages.NewRow();
        //    dr[0] = textGarageNb.Text;
        //    dr[1] = txtParkingName.Text;
        //    dr[2] = txtMonthlyRent.Text;
        //    dr[3] = txtMonthlyFees.Text;
        //    dr[4] = txtTenantName.Text;
        //    dr[5] = txtStartRent.Text;
        //    displayGarages.Rows.Add(dr);
        //}
=======
        public Garage oneGarage = new Garage("jkgyf", "Nice Centre", 150, 15, "Dupont", new DateTime(2017, 8, 24));
        public DataTable displayGarages = frmCreateGarage.displayGarages;
        

        public frmDisplayGarages()
        {
            InitializeComponent();

            if (displayGarages.Columns.Count == 0)
            {
                displayGarages.Columns.Add(new DataColumn("Identifiant du box", typeof(System.String)));
                displayGarages.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
                displayGarages.Columns.Add(new DataColumn("Loyer mensuel", typeof(System.Double)));
                displayGarages.Columns.Add(new DataColumn("Charges mensuelles", typeof(System.Double)));
                displayGarages.Columns.Add(new DataColumn("Nom du locataire", typeof(System.String)));
                displayGarages.Columns.Add(new DataColumn("Début de location", typeof(System.DateTime)));
            }
            
            DataRow dr;
            dr = displayGarages.NewRow();
            dr[0] = oneGarage.GarageId;
            dr[1] = oneGarage.ParkingName;
            dr[2] = oneGarage.MonthlyRent;
            dr[3] = oneGarage.MonthlyFees;
            dr[4] = oneGarage.TenantName;
            dr[5] = oneGarage.StartRent;
            displayGarages.Rows.Add(dr);
            dgvDisplayGarages.DataSource = displayGarages;
            
        }
>>>>>>> Stashed changes

        private void btnAddGarage_Click(object sender, EventArgs e)
        {
            displayGarages.Clear();
            this.Hide(); 
            frmCreateGarage frmCG = new frmCreateGarage();
            frmCG.ShowDialog();
            
        }
    }
}
