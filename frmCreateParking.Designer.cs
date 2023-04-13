namespace FunkyBox
{
    partial class frmCreateParking
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
            this.txtParkingName = new System.Windows.Forms.TextBox();
            this.lblParkingName = new System.Windows.Forms.Label();
            this.lblParkingNumber = new System.Windows.Forms.Label();
            this.txtParkingNumber = new System.Windows.Forms.TextBox();
            this.lblPkgMainAddr = new System.Windows.Forms.Label();
            this.txtParkingAddr1 = new System.Windows.Forms.TextBox();
            this.lblPkgAddtnlAddr = new System.Windows.Forms.Label();
            this.txtParkingAddr2 = new System.Windows.Forms.TextBox();
            this.lblPkgAddressNmbr = new System.Windows.Forms.Label();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParkingConfirm = new System.Windows.Forms.Button();
            this.btnParkingCancel = new System.Windows.Forms.Button();
            this.btnParkingDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParkingName
            // 
            this.txtParkingName.Location = new System.Drawing.Point(389, 115);
            this.txtParkingName.Name = "txtParkingName";
            this.txtParkingName.Size = new System.Drawing.Size(100, 20);
            this.txtParkingName.TabIndex = 0;
            // 
            // lblParkingName
            // 
            this.lblParkingName.AutoSize = true;
            this.lblParkingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblParkingName.Location = new System.Drawing.Point(74, 115);
            this.lblParkingName.Name = "lblParkingName";
            this.lblParkingName.Size = new System.Drawing.Size(145, 24);
            this.lblParkingName.TabIndex = 1;
            this.lblParkingName.Text = "Nom du parking";
            // 
            // lblParkingNumber
            // 
            this.lblParkingNumber.AutoSize = true;
            this.lblParkingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblParkingNumber.Location = new System.Drawing.Point(79, 155);
            this.lblParkingNumber.Name = "lblParkingNumber";
            this.lblParkingNumber.Size = new System.Drawing.Size(173, 24);
            this.lblParkingNumber.TabIndex = 3;
            this.lblParkingNumber.Text = "Numéro du parking";
            // 
            // txtParkingNumber
            // 
            this.txtParkingNumber.Location = new System.Drawing.Point(389, 155);
            this.txtParkingNumber.Name = "txtParkingNumber";
            this.txtParkingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtParkingNumber.TabIndex = 2;
            // 
            // lblPkgMainAddr
            // 
            this.lblPkgMainAddr.AutoSize = true;
            this.lblPkgMainAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgMainAddr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPkgMainAddr.Location = new System.Drawing.Point(79, 195);
            this.lblPkgMainAddr.Name = "lblPkgMainAddr";
            this.lblPkgMainAddr.Size = new System.Drawing.Size(261, 24);
            this.lblPkgMainAddr.TabIndex = 5;
            this.lblPkgMainAddr.Text = "Adresse principale du parking";
            // 
            // txtParkingAddr1
            // 
            this.txtParkingAddr1.Location = new System.Drawing.Point(389, 195);
            this.txtParkingAddr1.Name = "txtParkingAddr1";
            this.txtParkingAddr1.Size = new System.Drawing.Size(100, 20);
            this.txtParkingAddr1.TabIndex = 4;
            // 
            // lblPkgAddtnlAddr
            // 
            this.lblPkgAddtnlAddr.AutoSize = true;
            this.lblPkgAddtnlAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgAddtnlAddr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPkgAddtnlAddr.Location = new System.Drawing.Point(79, 235);
            this.lblPkgAddtnlAddr.Name = "lblPkgAddtnlAddr";
            this.lblPkgAddtnlAddr.Size = new System.Drawing.Size(205, 24);
            this.lblPkgAddtnlAddr.TabIndex = 7;
            this.lblPkgAddtnlAddr.Text = "Complément d\'adresse";
            // 
            // txtParkingAddr2
            // 
            this.txtParkingAddr2.Location = new System.Drawing.Point(389, 235);
            this.txtParkingAddr2.Name = "txtParkingAddr2";
            this.txtParkingAddr2.Size = new System.Drawing.Size(100, 20);
            this.txtParkingAddr2.TabIndex = 6;
            // 
            // lblPkgAddressNmbr
            // 
            this.lblPkgAddressNmbr.AutoSize = true;
            this.lblPkgAddressNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgAddressNmbr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPkgAddressNmbr.Location = new System.Drawing.Point(79, 275);
            this.lblPkgAddressNmbr.Name = "lblPkgAddressNmbr";
            this.lblPkgAddressNmbr.Size = new System.Drawing.Size(211, 24);
            this.lblPkgAddressNmbr.TabIndex = 9;
            this.lblPkgAddressNmbr.Text = "N° d\'adresse du parking";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(389, 275);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nouveau parking";
            // 
            // btnParkingConfirm
            // 
            this.btnParkingConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnParkingConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingConfirm.Location = new System.Drawing.Point(413, 353);
            this.btnParkingConfirm.Name = "btnParkingConfirm";
            this.btnParkingConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnParkingConfirm.TabIndex = 11;
            this.btnParkingConfirm.Text = "Confirmer";
            this.btnParkingConfirm.UseVisualStyleBackColor = false;
            this.btnParkingConfirm.Click += new System.EventHandler(this.btnParkingConfirm_Click);
            // 
            // btnParkingCancel
            // 
            this.btnParkingCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnParkingCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingCancel.Location = new System.Drawing.Point(298, 353);
            this.btnParkingCancel.Name = "btnParkingCancel";
            this.btnParkingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnParkingCancel.TabIndex = 12;
            this.btnParkingCancel.Text = "Annuler";
            this.btnParkingCancel.UseVisualStyleBackColor = false;
            // 
            // btnParkingDisplay
            // 
            this.btnParkingDisplay.Location = new System.Drawing.Point(414, 402);
            this.btnParkingDisplay.Name = "btnParkingDisplay";
            this.btnParkingDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnParkingDisplay.TabIndex = 13;
            this.btnParkingDisplay.Text = "Affichage liste";
            this.btnParkingDisplay.UseVisualStyleBackColor = true;
            this.btnParkingDisplay.Click += new System.EventHandler(this.btnParkingDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Création d\'un nouveau parking";
            // 
            // btnPkgCreateCnfrm
            // 
            this.btnPkgCreateCnfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPkgCreateCnfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPkgCreateCnfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgCreateCnfrm.ForeColor = System.Drawing.Color.Black;
            this.btnPkgCreateCnfrm.Location = new System.Drawing.Point(528, 320);
            this.btnPkgCreateCnfrm.Name = "btnPkgCreateCnfrm";
            this.btnPkgCreateCnfrm.Size = new System.Drawing.Size(122, 34);
            this.btnPkgCreateCnfrm.TabIndex = 11;
            this.btnPkgCreateCnfrm.Text = "Créer";
            this.btnPkgCreateCnfrm.UseVisualStyleBackColor = false;
            // 
            // btnPkgCreateCncl
            // 
            this.btnPkgCreateCncl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPkgCreateCncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPkgCreateCncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgCreateCncl.ForeColor = System.Drawing.Color.Black;
            this.btnPkgCreateCncl.Location = new System.Drawing.Point(366, 320);
            this.btnPkgCreateCncl.Name = "btnPkgCreateCncl";
            this.btnPkgCreateCncl.Size = new System.Drawing.Size(122, 34);
            this.btnPkgCreateCncl.TabIndex = 12;
            this.btnPkgCreateCncl.Text = "Annuler";
            this.btnPkgCreateCncl.UseVisualStyleBackColor = false;
            // 
            // frmCreateParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.btnParkingDisplay);
            this.Controls.Add(this.btnParkingCancel);
            this.Controls.Add(this.btnParkingConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPkgAddressNmbr);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.lblPkgAddtnlAddr);
            this.Controls.Add(this.txtParkingAddr2);
            this.Controls.Add(this.lblPkgMainAddr);
            this.Controls.Add(this.txtParkingAddr1);
            this.Controls.Add(this.lblParkingNumber);
            this.Controls.Add(this.txtParkingNumber);
            this.Controls.Add(this.lblParkingName);
            this.Controls.Add(this.txtParkingName);
            this.Name = "frmCreateParking";
            this.Text = "frmCreateParking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParkingName;
        private System.Windows.Forms.Label lblParkingName;
        private System.Windows.Forms.Label lblParkingNumber;
        private System.Windows.Forms.TextBox txtParkingNumber;
        private System.Windows.Forms.Label lblPkgMainAddr;
        private System.Windows.Forms.TextBox txtParkingAddr1;
        private System.Windows.Forms.Label lblPkgAddtnlAddr;
        private System.Windows.Forms.TextBox txtParkingAddr2;
        private System.Windows.Forms.Label lblPkgAddressNmbr;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParkingConfirm;
        private System.Windows.Forms.Button btnParkingCancel;
        private System.Windows.Forms.Button btnParkingDisplay;
        private System.Windows.Forms.Button btnPkgCreateCnfrm;
        private System.Windows.Forms.Button btnPkgCreateCncl;
    }
}