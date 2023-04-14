using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FunkyBox
{
    public partial class frmCreateCustomer : Form
    {

        frmDisplayCustomers displayCustomerForm = new frmDisplayCustomers();

        public frmCreateCustomer()
        {
            InitializeComponent();
        } // end frmCreateCustomer

        public void AddCustomer()
        {
            Customer newCustomer = new Customer(txtFirstname.Text, txtLastname.Text, txtStreetNumber.Text, txtStreetType.Text, txtStreetName.Text, txtPostalCode.Text, txtCity.Text, txtAddVehicle.Text);
            frmDisplayCustomers.sdCustomers.Add(newCustomer);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCustomer();
            this.Close();
            frmDisplayCustomers frmDC = new frmDisplayCustomers();
            frmDC.Show();

        } // end btnSave_Click


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end btnCancel_Click


    } // end Class
} // end namespace
