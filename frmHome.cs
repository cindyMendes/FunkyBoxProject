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
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }


        /// <summary>
        /// function to instantiate forms
        /// </summary>
        /// <param name="f"></param>
        private void initForm(Form f)
        {
            f.MdiParent = this;
            f.Show();
        } // end initForm

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateCustomer createCustomerForm = new frmCreateCustomer();
            initForm(createCustomerForm);
        } // end ajouterToolStripMenuItem_Click

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayCustomers displayCustomerForm = new frmDisplayCustomers();
            initForm(displayCustomerForm);
        } // end afficherToolStripMenuItem_Click

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreateParking createParkingForm = new frmCreateParking();
            initForm(createParkingForm);
        } // end ajouterToolStripMenuItem1_Click

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        } // end afficherToolStripMenuItem1_Click


    } // end class
} // end namespace
