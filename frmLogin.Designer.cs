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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.valid = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(160, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // valid
            // 
            this.valid.BackColor = System.Drawing.Color.Transparent;
            this.valid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.valid.FlatAppearance.BorderSize = 2;
            this.valid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.valid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valid.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid.ForeColor = System.Drawing.Color.Transparent;
            this.valid.Location = new System.Drawing.Point(96, 284);
            this.valid.Name = "valid";
            this.valid.Size = new System.Drawing.Size(205, 34);
            this.valid.TabIndex = 4;
            this.valid.Text = "Valider";
            this.valid.UseVisualStyleBackColor = false;
            this.valid.Click += new System.EventHandler(this.valid_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Quit.FlatAppearance.BorderSize = 2;
            this.Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.ForeColor = System.Drawing.Color.Transparent;
            this.Quit.Location = new System.Drawing.Point(96, 346);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(203, 34);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quitter";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click_1);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox.Location = new System.Drawing.Point(160, 189);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(139, 19);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Afficher les caratères";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(104, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mot de passe incorrect. Désolé.";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FunkyBox.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(96, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FunkyBox.Properties.Resources.istockphoto_1148287609_170667a1;
            this.pictureBox2.Location = new System.Drawing.Point(96, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(412, 405);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button valid;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}