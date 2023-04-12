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
    public partial class frmCreateGarage : Form
    {
        public static DataTable displayGarages = new DataTable();
        public frmCreateGarage()
        {
            InitializeComponent();
        }
        public void AddGarage()
        {
            Garage twoGarage = new Garage(txtGarageNb.Text, txtParkingName.Text, Double.Parse(txtMonthlyRent.Text), Double.Parse(txtMonthlyFees.Text), txtTenantName.Text, DateTime.Parse(txtStartRent.Text));
            DataRow dr;
            dr = displayGarages.NewRow();
            dr[0] = twoGarage.GarageId;
            dr[1] = twoGarage.ParkingName;
            dr[2] = twoGarage.MonthlyRent;
            dr[3] = twoGarage.MonthlyFees;
            dr[4] = twoGarage.TenantName;
            dr[5] = twoGarage.StartRent;
            displayGarages.Rows.Add(dr);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDisplayGarages frmDG = new frmDisplayGarages();
            frmDG.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddGarage();
            this.Hide();
            frmDisplayGarages frmDG = new frmDisplayGarages();
            frmDG.ShowDialog();
            this.Close();
        }
    }
}
