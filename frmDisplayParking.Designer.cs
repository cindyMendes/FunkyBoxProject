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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParking = new System.Windows.Forms.DataGridView();
            this.btnPkgDspCcl = new System.Windows.Forms.Button();
            this.btnPkgDspCfm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des parkings";
            // 
            // dgvParking
            // 
            this.dgvParking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgvParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParking.Location = new System.Drawing.Point(78, 114);
            this.dgvParking.Name = "dgvParking";
            this.dgvParking.Size = new System.Drawing.Size(837, 292);
            this.dgvParking.TabIndex = 1;
            // 
            // btnPkgDspCcl
            // 
            this.btnPkgDspCcl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPkgDspCcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgDspCcl.ForeColor = System.Drawing.Color.Black;
            this.btnPkgDspCcl.Location = new System.Drawing.Point(300, 447);
            this.btnPkgDspCcl.Name = "btnPkgDspCcl";
            this.btnPkgDspCcl.Size = new System.Drawing.Size(129, 53);
            this.btnPkgDspCcl.TabIndex = 4;
            this.btnPkgDspCcl.Text = "Fermer";
            this.btnPkgDspCcl.UseVisualStyleBackColor = false;
            this.btnPkgDspCcl.Click += new System.EventHandler(this.btnPkgDspCcl_Click);
            // 
            // btnPkgDspCfm
            // 
            this.btnPkgDspCfm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPkgDspCfm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgDspCfm.ForeColor = System.Drawing.Color.Black;
            this.btnPkgDspCfm.Location = new System.Drawing.Point(455, 447);
            this.btnPkgDspCfm.Name = "btnPkgDspCfm";
            this.btnPkgDspCfm.Size = new System.Drawing.Size(129, 53);
            this.btnPkgDspCfm.TabIndex = 5;
            this.btnPkgDspCfm.Text = "Ajouter";
            this.btnPkgDspCfm.UseVisualStyleBackColor = false;
            this.btnPkgDspCfm.Click += new System.EventHandler(this.btnPkgDspCfm_Click);
            // 
            // frmDisplayParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnPkgDspCfm);
            this.Controls.Add(this.btnPkgDspCcl);
            this.Controls.Add(this.dgvParking);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "frmDisplayParking";
            this.Text = "Affichage de la liste de parkings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParking;
        private System.Windows.Forms.Button btnPkgDspCcl;
        private System.Windows.Forms.Button btnPkgDspCfm;
    }
}