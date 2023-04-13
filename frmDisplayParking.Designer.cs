namespace FunkyBox
{
    partial class frmDisplayParking
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
            this.dgvParking = new System.Windows.Forms.DataGridView();
            this.lblParkingTile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParking
            // 
            this.dgvParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParking.Location = new System.Drawing.Point(12, 93);
            this.dgvParking.Name = "dgvParking";
            this.dgvParking.Size = new System.Drawing.Size(534, 150);
            this.dgvParking.TabIndex = 0;
            // 
            // lblParkingTile
            // 
            this.lblParkingTile.AutoSize = true;
            this.lblParkingTile.Location = new System.Drawing.Point(31, 37);
            this.lblParkingTile.Name = "lblParkingTile";
            this.lblParkingTile.Size = new System.Drawing.Size(92, 13);
            this.lblParkingTile.TabIndex = 1;
            this.lblParkingTile.Text = "Liste des parkings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblParkingTile);
            this.Controls.Add(this.dgvParking);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParking;
        private System.Windows.Forms.Label lblParkingTile;
    }
}