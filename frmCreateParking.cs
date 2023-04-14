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
    public partial class frmCreateParking : Form
    {
        public frmCreateParking()
        {
            InitializeComponent();
        }

        private void btnParkingCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParkingCnfrm_Click(object sender, EventArgs e)
        {
            PureParking NewParking = new PureParking(txtParkingName.Text, txtParkingNumber.Text, txtParkingAddr1.Text, txtParkingAddr2.Text, txtStreetNumber.Text);
            frmDisplayParking.parkingList.Add(NewParking);
            MessageBox.Show("Le client a bien été ajouté.");

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
