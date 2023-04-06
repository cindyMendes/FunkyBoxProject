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
            this.txtBoxparkingName = new System.Windows.Forms.TextBox();
            this.lblParkingName = new System.Windows.Forms.Label();
            this.lblParkingNumber = new System.Windows.Forms.Label();
            this.txtBoxparkingNumber = new System.Windows.Forms.TextBox();
            this.lblPkgMainAddr = new System.Windows.Forms.Label();
            this.txtBoxPkgMainAddr = new System.Windows.Forms.TextBox();
            this.lblPkgAddtnlAddr = new System.Windows.Forms.Label();
            this.txtBoxPkgAddtnlAddr = new System.Windows.Forms.TextBox();
            this.lblPkgAddressNmbr = new System.Windows.Forms.Label();
            this.txtBoxPkgAddressNmbr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxparkingName
            // 
            this.txtBoxparkingName.Location = new System.Drawing.Point(172, 40);
            this.txtBoxparkingName.Name = "txtBoxparkingName";
            this.txtBoxparkingName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxparkingName.TabIndex = 0;
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
            // txtBoxparkingNumber
            // 
            this.txtBoxparkingNumber.Location = new System.Drawing.Point(172, 75);
            this.txtBoxparkingNumber.Name = "txtBoxparkingNumber";
            this.txtBoxparkingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxparkingNumber.TabIndex = 2;
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
            // txtBoxPkgMainAddr
            // 
            this.txtBoxPkgMainAddr.Location = new System.Drawing.Point(172, 124);
            this.txtBoxPkgMainAddr.Name = "txtBoxPkgMainAddr";
            this.txtBoxPkgMainAddr.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPkgMainAddr.TabIndex = 4;
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
            // txtBoxPkgAddtnlAddr
            // 
            this.txtBoxPkgAddtnlAddr.Location = new System.Drawing.Point(172, 170);
            this.txtBoxPkgAddtnlAddr.Name = "txtBoxPkgAddtnlAddr";
            this.txtBoxPkgAddtnlAddr.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPkgAddtnlAddr.TabIndex = 6;
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
            // txtBoxPkgAddressNmbr
            // 
            this.txtBoxPkgAddressNmbr.Location = new System.Drawing.Point(172, 208);
            this.txtBoxPkgAddressNmbr.Name = "txtBoxPkgAddressNmbr";
            this.txtBoxPkgAddressNmbr.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPkgAddressNmbr.TabIndex = 8;
            // 
            // frmCreateParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPkgAddressNmbr);
            this.Controls.Add(this.txtBoxPkgAddressNmbr);
            this.Controls.Add(this.lblPkgAddtnlAddr);
            this.Controls.Add(this.txtBoxPkgAddtnlAddr);
            this.Controls.Add(this.lblPkgMainAddr);
            this.Controls.Add(this.txtBoxPkgMainAddr);
            this.Controls.Add(this.lblParkingNumber);
            this.Controls.Add(this.txtBoxparkingNumber);
            this.Controls.Add(this.lblParkingName);
            this.Controls.Add(this.txtBoxparkingName);
            this.Name = "frmCreateParking";
            this.Text = "frmCreateParking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxparkingName;
        private System.Windows.Forms.Label lblParkingName;
        private System.Windows.Forms.Label lblParkingNumber;
        private System.Windows.Forms.TextBox txtBoxparkingNumber;
        private System.Windows.Forms.Label lblPkgMainAddr;
        private System.Windows.Forms.TextBox txtBoxPkgMainAddr;
        private System.Windows.Forms.Label lblPkgAddtnlAddr;
        private System.Windows.Forms.TextBox txtBoxPkgAddtnlAddr;
        private System.Windows.Forms.Label lblPkgAddressNmbr;
        private System.Windows.Forms.TextBox txtBoxPkgAddressNmbr;
    }
}