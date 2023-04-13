namespace FunkyBox
{
    partial class frmDisplayCustomers
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
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.btnValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnValid.Location = new System.Drawing.Point(618, 447);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(129, 53);
            this.btnValid.TabIndex = 1;
            this.btnValid.Text = "Valider";
            this.btnValid.UseVisualStyleBackColor = false;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(78, 114);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(837, 292);
            this.grdCustomers.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(786, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 55);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Afficher Clients";
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnHome.Location = new System.Drawing.Point(618, 447);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(129, 53);
            this.btnReturnHome.TabIndex = 49;
            this.btnReturnHome.Text = "Fermer";
            this.btnReturnHome.UseVisualStyleBackColor = false;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(786, 447);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 53);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmDisplayCustomersBis
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCity.Location = new System.Drawing.Point(389, 166);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 18);
            this.lblCity.TabIndex = 43;
            this.lblCity.Text = "Ville";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLicence.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLicence.Location = new System.Drawing.Point(389, 207);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(108, 18);
            this.lblLicence.TabIndex = 44;
            this.lblLicence.Text = "Immatricualtion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 48;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 20);
            this.textBox4.TabIndex = 49;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(522, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 20);
            this.textBox5.TabIndex = 50;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(522, 128);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(175, 20);
            this.textBox6.TabIndex = 51;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(522, 166);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(175, 20);
            this.textBox7.TabIndex = 52;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(522, 205);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(175, 20);
            this.textBox8.TabIndex = 53;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFirstName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFirstName.Location = new System.Drawing.Point(49, 89);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 18);
            this.lblFirstName.TabIndex = 54;
            this.lblFirstName.Text = "Prénom";
            // 
            // grdCustomers
            // 
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(47, 264);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(837, 177);
            this.grdCustomers.TabIndex = 45;
            // 
            // frmDisplayCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdCustomers);
            this.Name = "frmDisplayCustomersBis";
            this.Text = "Afficher clients";
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReturnHome;
        private System.Windows.Forms.Button btnAdd;
    }
}