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
        DataTable displayGarages;
        public frmCreateGarage()
        {
            InitializeComponent();
        }
        public void AddGarage()
        {
            DataRow dr;
            dr = displayGarages.NewRow();
            dr[0] = textGarageNb.Text;
            dr[1] = txtParkingName.Text;
            dr[2] = txtMonthlyRent.Text;
            dr[3] = txtMonthlyFees.Text;
            dr[4] = txtTenantName.Text;
            dr[5] = txtStartRent.Text;
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
            this.Hide();
            AddGarage();
            frmDisplayGarages frmDG = new frmDisplayGarages();
            frmDG.ShowDialog();
            this.Close();
        }
    }
}
