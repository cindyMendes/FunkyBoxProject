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
        public Garage oneGarage = new Garage("jkgyf", "Nice Centre", 150, 15, "Dupont", new DateTime(2017, 8, 24));
        public DataTable displayGarages = new DataTable();

        public frmDisplayGarages()
        {
            InitializeComponent();
            displayGarages.Columns.Add(new DataColumn("Identifiant du box", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Loyer mensuel", typeof(System.Double)));
            displayGarages.Columns.Add(new DataColumn("Charges mensuelles", typeof(System.Double)));
            displayGarages.Columns.Add(new DataColumn("Nom du locataire", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Début de location", typeof(System.DateTime)));
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
    }
}
