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
            MessageBox.Show("Le box a bien été ajouté.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddGarage();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
               
        }
    }
}
