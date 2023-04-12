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
        public frmCreateGarage()
        {
            InitializeComponent();
        }
        public void AddGarage()
        {
            Garage newGarage = new Garage(txtGarageNb.Text, txtParkingName.Text, Double.Parse(txtMonthlyRent.Text), Double.Parse(txtMonthlyFees.Text), txtTenantName.Text, DateTime.Parse(txtStartRent.Text));
            frmDisplayGarages.sdGarages.Add(newGarage);
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
