
namespace GestionInfirmerieGUI
{
    partial class FrmGestionEleve
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnVoirEleve = new System.Windows.Forms.Button();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.lblGestionEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(33, 377);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(150, 48);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnVoirEleve
            // 
            this.btnVoirEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirEleve.Location = new System.Drawing.Point(110, 115);
            this.btnVoirEleve.Name = "btnVoirEleve";
            this.btnVoirEleve.Size = new System.Drawing.Size(212, 69);
            this.btnVoirEleve.TabIndex = 1;
            this.btnVoirEleve.Text = "Voir les élèves";
            this.btnVoirEleve.UseVisualStyleBackColor = true;
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutEleve.Location = new System.Drawing.Point(499, 115);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(212, 69);
            this.btnAjoutEleve.TabIndex = 2;
            this.btnAjoutEleve.Text = "Ajouter un élève";
            this.btnAjoutEleve.UseVisualStyleBackColor = true;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // lblGestionEleve
            // 
            this.lblGestionEleve.AutoSize = true;
            this.lblGestionEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblGestionEleve.Location = new System.Drawing.Point(306, 51);
            this.lblGestionEleve.Name = "lblGestionEleve";
            this.lblGestionEleve.Size = new System.Drawing.Size(196, 25);
            this.lblGestionEleve.TabIndex = 3;
            this.lblGestionEleve.Text = "Gestion des élèves";
            // 
            // FrmGestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGestionEleve);
            this.Controls.Add(this.btnAjoutEleve);
            this.Controls.Add(this.btnVoirEleve);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmGestionEleve";
            this.Text = "FrmGestionEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnVoirEleve;
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.Label lblGestionEleve;
    }
}