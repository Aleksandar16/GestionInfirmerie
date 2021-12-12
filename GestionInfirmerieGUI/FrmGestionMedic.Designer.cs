namespace GestionInfirmerieGUI
{
    partial class FrmGestionMedic
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
            this.btnDetailsMedic = new System.Windows.Forms.Button();
            this.btnAjoutMedic = new System.Windows.Forms.Button();
            this.btnModifierMedic = new System.Windows.Forms.Button();
            this.btnSupprimerMedic = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetailsMedic
            // 
            this.btnDetailsMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsMedic.Location = new System.Drawing.Point(48, 84);
            this.btnDetailsMedic.Name = "btnDetailsMedic";
            this.btnDetailsMedic.Size = new System.Drawing.Size(286, 68);
            this.btnDetailsMedic.TabIndex = 0;
            this.btnDetailsMedic.Text = "Voir les médicaments";
            this.btnDetailsMedic.UseVisualStyleBackColor = true;
            this.btnDetailsMedic.Click += new System.EventHandler(this.btnDetailsMedic_Click);
            // 
            // btnAjoutMedic
            // 
            this.btnAjoutMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutMedic.Location = new System.Drawing.Point(451, 84);
            this.btnAjoutMedic.Name = "btnAjoutMedic";
            this.btnAjoutMedic.Size = new System.Drawing.Size(286, 68);
            this.btnAjoutMedic.TabIndex = 1;
            this.btnAjoutMedic.Text = "Ajouter un médicament";
            this.btnAjoutMedic.UseVisualStyleBackColor = true;
            this.btnAjoutMedic.Click += new System.EventHandler(this.btnAjoutMedic_Click);
            // 
            // btnModifierMedic
            // 
            this.btnModifierMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierMedic.Location = new System.Drawing.Point(48, 278);
            this.btnModifierMedic.Name = "btnModifierMedic";
            this.btnModifierMedic.Size = new System.Drawing.Size(286, 68);
            this.btnModifierMedic.TabIndex = 2;
            this.btnModifierMedic.Text = "Modifier un médicament";
            this.btnModifierMedic.UseVisualStyleBackColor = true;
            this.btnModifierMedic.Click += new System.EventHandler(this.btnModifierMedic_Click);
            // 
            // btnSupprimerMedic
            // 
            this.btnSupprimerMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMedic.Location = new System.Drawing.Point(451, 278);
            this.btnSupprimerMedic.Name = "btnSupprimerMedic";
            this.btnSupprimerMedic.Size = new System.Drawing.Size(286, 68);
            this.btnSupprimerMedic.TabIndex = 3;
            this.btnSupprimerMedic.Text = "Supprimer un médicament";
            this.btnSupprimerMedic.UseVisualStyleBackColor = true;
            this.btnSupprimerMedic.Click += new System.EventHandler(this.btnSupprimerMedic_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 387);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(138, 51);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmGestionMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerMedic);
            this.Controls.Add(this.btnModifierMedic);
            this.Controls.Add(this.btnAjoutMedic);
            this.Controls.Add(this.btnDetailsMedic);
            this.Name = "FrmGestionMedic";
            this.Text = "FrmGestionMedic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetailsMedic;
        private System.Windows.Forms.Button btnAjoutMedic;
        private System.Windows.Forms.Button btnModifierMedic;
        private System.Windows.Forms.Button btnSupprimerMedic;
        private System.Windows.Forms.Button btnRetour;
    }
}