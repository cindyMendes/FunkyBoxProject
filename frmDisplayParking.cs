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
    public partial class frmDisplayParking : Form
    {
        public static List<PureParking> parkingList = new List<PureParking>();
        public static DataTable displayParkings = new DataTable();

        public frmDisplayParking()
        {
            InitializeComponent();

            if (displayParkings.Columns.Count == 0)
            {
                displayParkings.Columns.Add(new DataColumn("Nom parking", typeof(System.String)));
                displayParkings.Columns.Add(new DataColumn("Numéro parking", typeof(System.String)));
                displayParkings.Columns.Add(new DataColumn("Numéro de voie", typeof(System.String)));
                displayParkings.Columns.Add(new DataColumn("Adresse principale", typeof(System.String)));
                displayParkings.Columns.Add(new DataColumn("Adresse complémentaire", typeof(System.String)));

            }

            displayParkings.Clear();
            foreach (PureParking newParking in parkingList)
            {
                DataRow dr = displayParkings.NewRow();
                dr[0] = newParking.ParkingName;
                dr[1] = newParking.ParkingNumber;
                dr[2] = newParking.ParkingStNb;
                dr[3] = newParking.ParkingAdd1;
                dr[4] = newParking.ParkingAdd2;

                displayParkings.Rows.Add(dr);
            }
            dgvParking.DataSource = displayParkings;
        }


        private void btnPkgDspCcl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPkgDspCfm_Click(object sender, EventArgs e)
        {
            this.Close();
            displayParkings.Clear();
            frmCreateParking frmCP = new frmCreateParking();
            frmCP.ShowDialog();
        }

    }
}
