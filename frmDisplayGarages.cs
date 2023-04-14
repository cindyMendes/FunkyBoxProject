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
    internal partial class frmDisplayGarages : Form
    {
        public static List<Garage> sdGarages = new List<Garage>();
        public static DataTable displayGarages = new DataTable();

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

            displayGarages.Clear();
            foreach (Garage newGarage in sdGarages)
            {
                DataRow dr = displayGarages.NewRow();
                dr[0] = newGarage.GarageId;
                dr[1] = newGarage.ParkingName;
                dr[2] = newGarage.MonthlyRent;
                dr[3] = newGarage.MonthlyFees;
                dr[4] = newGarage.TenantName;
                dr[5] = newGarage.StartRent;
                displayGarages.Rows.Add(dr);
            }
            
            dgvDisplayGarages.DataSource = displayGarages;
            
        }
        private void btnAddGarage_Click(object sender, EventArgs e)
        {
            this.Close(); 
            displayGarages.Clear();
            frmCreateGarage frmCG = new frmCreateGarage();
            frmCG.ShowDialog();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
