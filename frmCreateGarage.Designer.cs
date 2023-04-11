namespace FunkyBox
{
    partial class frmCreateGarage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGarageId = new System.Windows.Forms.Label();
            this.lblStartRent = new System.Windows.Forms.Label();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.lblMonthlyFees = new System.Windows.Forms.Label();
            this.lblMonthlyRent = new System.Windows.Forms.Label();
            this.lblParkingName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtParkingName = new System.Windows.Forms.TextBox();
            this.txtMonthlyFees = new System.Windows.Forms.TextBox();
            this.textGarageNb = new System.Windows.Forms.TextBox();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.txtStartRent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 55);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Nouveau box";
            // 
            // lblGarageId
            // 
            this.lblGarageId.AutoSize = true;
            this.lblGarageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarageId.Location = new System.Drawing.Point(74, 115);
            this.lblGarageId.Name = "lblGarageId";
            this.lblGarageId.Size = new System.Drawing.Size(152, 24);
            this.lblGarageId.TabIndex = 18;
            this.lblGarageId.Text = "Identifiant du box";
            // 
            // lblStartRent
            // 
            this.lblStartRent.AutoSize = true;
            this.lblStartRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartRent.Location = new System.Drawing.Point(74, 315);
            this.lblStartRent.Name = "lblStartRent";
            this.lblStartRent.Size = new System.Drawing.Size(157, 24);
            this.lblStartRent.TabIndex = 20;
            this.lblStartRent.Text = "Début de location";
            // 
            // lblTenantName
            // 
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenantName.Location = new System.Drawing.Point(74, 275);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(153, 24);
            this.lblTenantName.TabIndex = 21;
            this.lblTenantName.Text = "Nom du locataire";
            // 
            // lblMonthlyFees
            // 
            this.lblMonthlyFees.AutoSize = true;
            this.lblMonthlyFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyFees.Location = new System.Drawing.Point(74, 235);
            this.lblMonthlyFees.Name = "lblMonthlyFees";
            this.lblMonthlyFees.Size = new System.Drawing.Size(183, 24);
            this.lblMonthlyFees.TabIndex = 22;
            this.lblMonthlyFees.Text = "Charges mensuelles";
            // 
            // lblMonthlyRent
            // 
            this.lblMonthlyRent.AutoSize = true;
            this.lblMonthlyRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyRent.Location = new System.Drawing.Point(74, 195);
            this.lblMonthlyRent.Name = "lblMonthlyRent";
            this.lblMonthlyRent.Size = new System.Drawing.Size(135, 24);
            this.lblMonthlyRent.TabIndex = 23;
            this.lblMonthlyRent.Text = "Loyer mensuel";
            // 
            // lblParkingName
            // 
            this.lblParkingName.AutoSize = true;
            this.lblParkingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingName.Location = new System.Drawing.Point(74, 155);
            this.lblParkingName.Name = "lblParkingName";
            this.lblParkingName.Size = new System.Drawing.Size(145, 24);
            this.lblParkingName.TabIndex = 24;
            this.lblParkingName.Text = "Nom du parking";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(254, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(418, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Valider";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtParkingName
            // 
            this.txtParkingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingName.Location = new System.Drawing.Point(254, 155);
            this.txtParkingName.Name = "txtParkingName";
            this.txtParkingName.Size = new System.Drawing.Size(284, 26);
            this.txtParkingName.TabIndex = 27;
            // 
            // txtMonthlyFees
            // 
            this.txtMonthlyFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyFees.Location = new System.Drawing.Point(254, 235);
            this.txtMonthlyFees.Name = "txtMonthlyFees";
            this.txtMonthlyFees.Size = new System.Drawing.Size(84, 26);
            this.txtMonthlyFees.TabIndex = 28;
            // 
            // textGarageNb
            // 
            this.textGarageNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGarageNb.Location = new System.Drawing.Point(254, 115);
            this.textGarageNb.Name = "textGarageNb";
            this.textGarageNb.Size = new System.Drawing.Size(84, 26);
            this.textGarageNb.TabIndex = 29;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyRent.Location = new System.Drawing.Point(254, 195);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.Size = new System.Drawing.Size(84, 26);
            this.txtMonthlyRent.TabIndex = 30;
            // 
            // txtTenantName
            // 
            this.txtTenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenantName.Location = new System.Drawing.Point(254, 275);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(284, 26);
            this.txtTenantName.TabIndex = 31;
            // 
            // txtStartRent
            // 
            this.txtStartRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartRent.Location = new System.Drawing.Point(254, 315);
            this.txtStartRent.Name = "txtStartRent";
            this.txtStartRent.Size = new System.Drawing.Size(84, 26);
            this.txtStartRent.TabIndex = 32;
            // 
            // frmCreateGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txtStartRent);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.txtMonthlyRent);
            this.Controls.Add(this.textGarageNb);
            this.Controls.Add(this.txtMonthlyFees);
            this.Controls.Add(this.txtParkingName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblParkingName);
            this.Controls.Add(this.lblMonthlyRent);
            this.Controls.Add(this.lblMonthlyFees);
            this.Controls.Add(this.lblTenantName);
            this.Controls.Add(this.lblStartRent);
            this.Controls.Add(this.lblGarageId);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreateGarage";
            this.Text = "frmCreateGarage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGarageId;
        private System.Windows.Forms.Label lblStartRent;
        private System.Windows.Forms.Label lblTenantName;
        private System.Windows.Forms.Label lblMonthlyFees;
        private System.Windows.Forms.Label lblMonthlyRent;
        private System.Windows.Forms.Label lblParkingName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtParkingName;
        private System.Windows.Forms.TextBox txtMonthlyFees;
        private System.Windows.Forms.TextBox textGarageNb;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.TextBox txtStartRent;
    }
}