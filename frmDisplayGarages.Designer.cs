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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayGarages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayGarages
            // 
            this.dgvDisplayGarages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayGarages.Location = new System.Drawing.Point(1, 0);
            this.dgvDisplayGarages.Name = "dgvDisplayGarages";
            this.dgvDisplayGarages.Size = new System.Drawing.Size(797, 292);
            this.dgvDisplayGarages.TabIndex = 0;
            // 
            // frmDisplayGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDisplayGarages);
            this.Name = "frmDisplayGarages";
            this.Text = "frmDisplayGarage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayGarages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayGarages;
    }
}