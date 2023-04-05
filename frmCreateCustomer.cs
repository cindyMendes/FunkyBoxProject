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

        Point myPointTextBox = new Point(683, 115);
        Point myPointPictureBox = new Point(876, 115);
        Point myPointPictureBox2 = new Point (836, 115);
        List<TextBox> txtBoxList = new List<TextBox>();
        List<PictureBox> picBoxList = new List<PictureBox>();
        int counterAdd = 0;
        int counterDel = 0;

       
        /// <summary>
        /// Fonction ajout de textBox et bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAdd_Click(object sender, EventArgs e)
        {
            if (counterAdd < 6)
            {
                myPointTextBox.Y += 40;
                myPointPictureBox.Y += 40;
                myPointPictureBox2.Y += 40;
                TextBox txtAddVehicle = new TextBox();
                txtAddVehicle.Location = myPointTextBox;
                txtAddVehicle.Size = new Size(131, 26);
                txtAddVehicle.Font = new Font("Microsoft Sans Serif", 12);
                this.Controls.Add(txtAddVehicle);
                txtBoxList.Add(txtAddVehicle);
                picAdd.Location = myPointPictureBox; 
                PictureBox picDel = new PictureBox();
                picDel.Location = myPointPictureBox2;
                picDel.Size = new Size(26, 26);
                picDel.Image = global::FunkyBox.Properties.Resources.minus1;
                picDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picDel.Click += new System.EventHandler(this.picDel_Click);
                this.Controls.Add(picDel);
                picBoxList.Add(picDel);
                counterAdd++;

            }
            else
            {
                MessageBox.Show("La limite de véhicules par locataire est atteinte.");
            }
        }//endPicAddClick

        private void picDel_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(txtBoxList[counterAdd].Text);
        }

        


    }//endClass
}//endNamespace
