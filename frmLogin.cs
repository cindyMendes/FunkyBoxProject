using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkyBox
{
    public partial class frmLogin : Form
    {
        Label lbl5 = new Label();
        Label lbl6 = new Label();
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
                {
                    this.Hide();
                    frmHome frmHome = new frmHome();
                    frmHome.Show();
                }
                else
                label3.Visible = true;
            }

        }
            private void valid_MouseEnter(object sender, EventArgs e)
            {
                valid.ForeColor = Color.Black;
            }
            private void valid_MouseLeave(object sender, EventArgs e)
            {
                valid.ForeColor = Color.White;
            }



        private void Quit_Click (object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Quit_MouseEnter(object sender, EventArgs e)
        {
            valid.ForeColor = Color.Black;
        }
        private void Quit_MouseLeave(object sender, EventArgs e)
        {
            valid.ForeColor = Color.White;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            lbl5.Text = "Saisir mot de passe";
            lbl5.Location = new Point(160, 160);
            this.Controls.Add(lbl5);
            
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(lbl5);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            lbl6.Text = "Saisir le login";
            lbl6.Location = new Point(160, 100);
            this.Controls.Add(lbl6);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(lbl6);
        }
    }
}
