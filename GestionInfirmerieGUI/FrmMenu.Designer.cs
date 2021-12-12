
namespace GestionInfirmerieGUI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnGestionEleve = new System.Windows.Forms.Button();
            this.btnGestionVisite = new System.Windows.Forms.Button();
            this.btnGestionMedicament = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.lblMenu.Location = new System.Drawing.Point(238, 74);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(316, 32);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Gestion Infirmerie";
            // 
            // btnGestionEleve
            // 
            this.btnGestionEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGestionEleve.Location = new System.Drawing.Point(44, 180);
            this.btnGestionEleve.Name = "btnGestionEleve";
            this.btnGestionEleve.Size = new System.Drawing.Size(206, 64);
            this.btnGestionEleve.TabIndex = 1;
            this.btnGestionEleve.Text = "Gestion des élèves";
            this.btnGestionEleve.UseVisualStyleBackColor = true;
            this.btnGestionEleve.Click += new System.EventHandler(this.btnGestionEleve_Click);
            // 
            // btnGestionVisite
            // 
            this.btnGestionVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGestionVisite.Location = new System.Drawing.Point(286, 180);
            this.btnGestionVisite.Name = "btnGestionVisite";
            this.btnGestionVisite.Size = new System.Drawing.Size(189, 64);
            this.btnGestionVisite.TabIndex = 2;
            this.btnGestionVisite.Text = "Gestion des visites";
            this.btnGestionVisite.UseVisualStyleBackColor = true;
            this.btnGestionVisite.Click += new System.EventHandler(this.btnGestionVisite_Click);
            // 
            // btnGestionMedicament
            // 
            this.btnGestionMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnGestionMedicament.Location = new System.Drawing.Point(508, 180);
            this.btnGestionMedicament.Name = "btnGestionMedicament";
            this.btnGestionMedicament.Size = new System.Drawing.Size(261, 64);
            this.btnGestionMedicament.TabIndex = 3;
            this.btnGestionMedicament.Text = "Gestion des médicaments";
            this.btnGestionMedicament.UseVisualStyleBackColor = true;
            this.btnGestionMedicament.Click += new System.EventHandler(this.btnGestionMedicament_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitter.Location = new System.Drawing.Point(619, 394);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 44);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnGestionMedicament);
            this.Controls.Add(this.btnGestionVisite);
            this.Controls.Add(this.btnGestionEleve);
            this.Controls.Add(this.lblMenu);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnGestionEleve;
        private System.Windows.Forms.Button btnGestionVisite;
        private System.Windows.Forms.Button btnGestionMedicament;
        private System.Windows.Forms.Button btnQuitter;
    }
}

