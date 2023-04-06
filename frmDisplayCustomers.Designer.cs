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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStreetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStreetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colStreetNumber,
            this.colStreetType,
            this.colStreetName,
            this.colPostalCode,
            this.colCity});
            this.dataGridView1.Location = new System.Drawing.Point(78, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 55);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Afficher Clients";
            // 
            // colFirstName
            // 
            this.colFirstName.FillWeight = 45.41081F;
            this.colFirstName.HeaderText = "Prénom";
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.FillWeight = 45.41081F;
            this.colLastName.HeaderText = "Nom";
            this.colLastName.Name = "colLastName";
            // 
            // colStreetNumber
            // 
            this.colStreetNumber.FillWeight = 14.57031F;
            this.colStreetNumber.HeaderText = "N°";
            this.colStreetNumber.Name = "colStreetNumber";
            // 
            // colStreetType
            // 
            this.colStreetType.FillWeight = 45.41081F;
            this.colStreetType.HeaderText = "Type de voie";
            this.colStreetType.Name = "colStreetType";
            // 
            // colStreetName
            // 
            this.colStreetName.FillWeight = 45.41081F;
            this.colStreetName.HeaderText = "Nom de rue";
            this.colStreetName.Name = "colStreetName";
            // 
            // colPostalCode
            // 
            this.colPostalCode.FillWeight = 45.41081F;
            this.colPostalCode.HeaderText = "Code Postal";
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colCity
            // 
            this.colCity.FillWeight = 45.41081F;
            this.colCity.HeaderText = "Ville";
            this.colCity.Name = "colCity";
            // 
            // frmDisplayCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDisplayCustomers";
            this.Text = "frmDisplayCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
    }
}