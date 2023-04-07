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
            this.SuspendLayout();
            // 
            // txtParkingName
            // 
            this.txtParkingName.Location = new System.Drawing.Point(172, 40);
            this.txtParkingName.Name = "txtParkingName";
            this.txtParkingName.Size = new System.Drawing.Size(100, 20);
            this.txtParkingName.TabIndex = 0;
            // 
            // lblParkingName
            // 
            this.lblParkingName.AutoSize = true;
            this.lblParkingName.Location = new System.Drawing.Point(11, 43);
            this.lblParkingName.Name = "lblParkingName";
            this.lblParkingName.Size = new System.Drawing.Size(82, 13);
            this.lblParkingName.TabIndex = 1;
            this.lblParkingName.Text = "Nom du parking";
            // 
            // lblParkingNumber
            // 
            this.lblParkingNumber.AutoSize = true;
            this.lblParkingNumber.Location = new System.Drawing.Point(11, 75);
            this.lblParkingNumber.Name = "lblParkingNumber";
            this.lblParkingNumber.Size = new System.Drawing.Size(97, 13);
            this.lblParkingNumber.TabIndex = 3;
            this.lblParkingNumber.Text = "Numéro du parking";
            // 
            // txtParkingNumber
            // 
            this.txtParkingNumber.Location = new System.Drawing.Point(172, 75);
            this.txtParkingNumber.Name = "txtParkingNumber";
            this.txtParkingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtParkingNumber.TabIndex = 2;
            // 
            // lblPkgMainAddr
            // 
            this.lblPkgMainAddr.AutoSize = true;
            this.lblPkgMainAddr.Location = new System.Drawing.Point(11, 126);
            this.lblPkgMainAddr.Name = "lblPkgMainAddr";
            this.lblPkgMainAddr.Size = new System.Drawing.Size(146, 13);
            this.lblPkgMainAddr.TabIndex = 5;
            this.lblPkgMainAddr.Text = "Adresse principale du parking";
            // 
            // txtParkingAddr1
            // 
            this.txtParkingAddr1.Location = new System.Drawing.Point(172, 124);
            this.txtParkingAddr1.Name = "txtParkingAddr1";
            this.txtParkingAddr1.Size = new System.Drawing.Size(100, 20);
            this.txtParkingAddr1.TabIndex = 4;
            // 
            // lblPkgAddtnlAddr
            // 
            this.lblPkgAddtnlAddr.AutoSize = true;
            this.lblPkgAddtnlAddr.Location = new System.Drawing.Point(11, 170);
            this.lblPkgAddtnlAddr.Name = "lblPkgAddtnlAddr";
            this.lblPkgAddtnlAddr.Size = new System.Drawing.Size(113, 13);
            this.lblPkgAddtnlAddr.TabIndex = 7;
            this.lblPkgAddtnlAddr.Text = "Complément d\'adresse";
            // 
            // txtParkingAddr2
            // 
            this.txtParkingAddr2.Location = new System.Drawing.Point(172, 170);
            this.txtParkingAddr2.Name = "txtParkingAddr2";
            this.txtParkingAddr2.Size = new System.Drawing.Size(100, 20);
            this.txtParkingAddr2.TabIndex = 6;
            // 
            // lblPkgAddressNmbr
            // 
            this.lblPkgAddressNmbr.AutoSize = true;
            this.lblPkgAddressNmbr.Location = new System.Drawing.Point(12, 211);
            this.lblPkgAddressNmbr.Name = "lblPkgAddressNmbr";
            this.lblPkgAddressNmbr.Size = new System.Drawing.Size(120, 13);
            this.lblPkgAddressNmbr.TabIndex = 9;
            this.lblPkgAddressNmbr.Text = "N° d\'adresse du parking";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(172, 208);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNumber.TabIndex = 8;
            // 
            // frmCreateParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}