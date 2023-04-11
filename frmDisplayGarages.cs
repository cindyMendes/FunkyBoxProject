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
    public partial class frmDisplayGarages : Form
    {
        DataTable displayGarages;

        public frmDisplayGarages()
        {
            InitializeComponent();
            displayGarages.Columns.Add(new DataColumn("Identifiant du box", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Loyer mensuel", typeof(System.Double)));
            displayGarages.Columns.Add(new DataColumn("Charges mensuelles", typeof(System.Double)));
            displayGarages.Columns.Add(new DataColumn("Nom du locataire", typeof(System.String)));
            displayGarages.Columns.Add(new DataColumn("Début de location", typeof(System.DateTime)));
            dgvDisplayGarages.DataSource = displayGarages;
        }
    }
}
