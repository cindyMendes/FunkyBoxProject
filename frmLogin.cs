using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkyBox
{
    public partial class frmLogin : Form
    {
        OleDbConnection connexion = new OleDbConnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void valid_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs nécessaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox1.Text == "login")
            {
                if (textBox2.Text == "mdp")
                    this.Hide();
            }
            else
                label3.Visible = true;

           
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Etes-vous sûr de vouloir quitter ?","Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultat == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            
                textBox2.UseSystemPasswordChar = false;
             
            else
                textBox2.UseSystemPasswordChar = true;
        
        }
    }
}
