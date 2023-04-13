using System.Windows.Forms;

namespace FunkyBox
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.valid = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.log.Location = new System.Drawing.Point(55, 28);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(44, 18);
            this.log.TabIndex = 0;
            this.log.Text = "Login";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mdp.Location = new System.Drawing.Point(17, 64);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(98, 18);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(133, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // valid
            // 
            this.valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid.ForeColor = System.Drawing.Color.Black;
            this.valid.Location = new System.Drawing.Point(83, 224);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(122, 34);
            this.valid.TabIndex = 4;
            this.valid.Text = "Valider";
            this.valid.UseVisualStyleBackColor = false;
            this.valid.Click += new System.EventHandler(this.valid_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Quit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.Quit.ForeColor = System.Drawing.Color.Black;
            this.Quit.Location = new System.Drawing.Point(83, 286);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(122, 34);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quitter";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox.Location = new System.Drawing.Point(133, 99);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(139, 19);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Afficher les caratères";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(55, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mot de passe incorrect. Désolé.";
            this.label3.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(290, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.log);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button valid;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label3;
    }
}