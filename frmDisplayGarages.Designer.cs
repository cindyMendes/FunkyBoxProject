namespace FunkyBox
{
    partial class frmDisplayGarages
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
            this.dgvDisplayGarages = new System.Windows.Forms.DataGridView();
            this.btnAddGarage = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayGarages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayGarages
            // 
            this.dgvDisplayGarages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgvDisplayGarages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayGarages.Location = new System.Drawing.Point(2, 114);
            this.dgvDisplayGarages.Name = "dgvDisplayGarages";
            this.dgvDisplayGarages.RowHeadersWidth = 51;
            this.dgvDisplayGarages.Size = new System.Drawing.Size(982, 292);
            this.dgvDisplayGarages.TabIndex = 0;
            // 
            // btnAddGarage
            // 
            this.btnAddGarage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGarage.ForeColor = System.Drawing.Color.Black;
            this.btnAddGarage.Location = new System.Drawing.Point(772, 425);
            this.btnAddGarage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGarage.Name = "btnAddGarage";
            this.btnAddGarage.Size = new System.Drawing.Size(143, 42);
            this.btnAddGarage.TabIndex = 1;
            this.btnAddGarage.Text = "Ajouter un box";
            this.btnAddGarage.UseVisualStyleBackColor = false;
            this.btnAddGarage.Click += new System.EventHandler(this.btnAddGarage_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 55);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Afficher Box";
            // 
            // frmDisplayGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddGarage);
            this.Controls.Add(this.dgvDisplayGarages);
            this.Name = "frmDisplayGarages";
            this.Text = "Affichage Box";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayGarages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayGarages;
        private System.Windows.Forms.Button btnAddGarage;
        private System.Windows.Forms.Label lblTitle;
    }
}