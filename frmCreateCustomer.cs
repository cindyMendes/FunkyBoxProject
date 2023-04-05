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
    public partial class frmCreateCustomer : Form
    {
        public frmCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer oneCustomer = new Customer("Laurent", "Campan", 44, "Rue", "Hérold", "06000", "Nice");
            Customer twoCustomer = new Customer("Nicolas", "Raoux", 170, "Rue", "Henri Martin", "06330", "Roquefort-Les-Pins");
            Customer threeCustomer = new Customer("Cindy", "Mendes", 1, "Chemin", "des Lavandins", "06800", "Cagnes-Sur-Mer");
            Customer fourCustomer = new Customer("Qaïs", "Hamadou", 29, "Avenue", "Jean Médecin", "06000", "Nice");

            MessageBox.Show(oneCustomer.ToString() + Environment.NewLine + twoCustomer.ToString());
            //MessageBox.Show(twoCustomer.ToString());
            //MessageBox.Show(threeCustomer.ToString());
            //MessageBox.Show(fourCustomer.ToString());

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            TextBox txtAddVehicle = new TextBox();
            txtAddVehicle.Location = new Point(200, 230);
            this.Controls.Add(txtAddVehicle);
            //NICO le boss 
        }
    }
}
