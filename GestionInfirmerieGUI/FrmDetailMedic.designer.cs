namespace GestionInfirmerieGUI
{
    partial class FrmDetailMedic
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
            this.dataGridViewMedicament = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.txtNomMedic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedicament
            // 
            this.dataGridViewMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicament.Location = new System.Drawing.Point(52, 90);
            this.dataGridViewMedicament.Name = "dataGridViewMedicament";
            this.dataGridViewMedicament.RowHeadersWidth = 51;
            this.dataGridViewMedicament.RowTemplate.Height = 24;
            this.dataGridViewMedicament.Size = new System.Drawing.Size(736, 308);
            this.dataGridViewMedicament.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 397);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(149, 41);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(568, 31);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(89, 43);
            this.btnChercher.TabIndex = 2;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(687, 31);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(82, 43);
            this.btnActualiser.TabIndex = 3;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // txtNomMedic
            // 
            this.txtNomMedic.Location = new System.Drawing.Point(52, 36);
            this.txtNomMedic.Name = "txtNomMedic";
            this.txtNomMedic.Size = new System.Drawing.Size(355, 22);
            this.txtNomMedic.TabIndex = 4;
            // 
            // FrmDetailMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomMedic);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridViewMedicament);
            this.Name = "FrmDetailMedic";
            this.Text = "FrmDetailMedic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedicament;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.TextBox txtNomMedic;
    }
}