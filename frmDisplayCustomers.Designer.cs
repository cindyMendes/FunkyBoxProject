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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colStreetNumber,
            this.colStreetType,
            this.colStreetName,
            this.colPostalCode,
            this.colCity});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 64);
            this.dataGridView1.TabIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "Prénom";
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Nom";
            this.colLastName.Name = "colLastName";
            // 
            // colStreetNumber
            // 
            this.colStreetNumber.HeaderText = "N°";
            this.colStreetNumber.Name = "colStreetNumber";
            // 
            // colStreetType
            // 
            this.colStreetType.HeaderText = "Type de voie";
            this.colStreetType.Name = "colStreetType";
            // 
            // colStreetName
            // 
            this.colStreetName.HeaderText = "Nom de rue";
            this.colStreetName.Name = "colStreetName";
            // 
            // colPostalCode
            // 
            this.colPostalCode.HeaderText = "Code Postal";
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colCity
            // 
            this.colCity.HeaderText = "Ville";
            this.colCity.Name = "colCity";
            // 
            // frmDisplayCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDisplayCustomers";
            this.Text = "frmDisplayCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
    }
}