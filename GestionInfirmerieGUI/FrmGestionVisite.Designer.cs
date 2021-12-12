namespace GestionInfirmerieGUI
{
    partial class FrmGestionVisite
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
            this.btnDetailVisite = new System.Windows.Forms.Button();
            this.btnAjoutVisite = new System.Windows.Forms.Button();
            this.btnModifierVisite = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDetailVisite
            // 
            this.btnDetailVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailVisite.Location = new System.Drawing.Point(120, 90);
            this.btnDetailVisite.Name = "btnDetailVisite";
            this.btnDetailVisite.Size = new System.Drawing.Size(225, 63);
            this.btnDetailVisite.TabIndex = 0;
            this.btnDetailVisite.Text = "Voir les visites";
            this.btnDetailVisite.UseVisualStyleBackColor = true;
            this.btnDetailVisite.Click += new System.EventHandler(this.btnDetailVisite_Click);
            // 
            // btnAjoutVisite
            // 
            this.btnAjoutVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutVisite.Location = new System.Drawing.Point(448, 90);
            this.btnAjoutVisite.Name = "btnAjoutVisite";
            this.btnAjoutVisite.Size = new System.Drawing.Size(225, 63);
            this.btnAjoutVisite.TabIndex = 1;
            this.btnAjoutVisite.Text = "Ajouter une visite";
            this.btnAjoutVisite.UseVisualStyleBackColor = true;
            this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
            // 
            // btnModifierVisite
            // 
            this.btnModifierVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierVisite.Location = new System.Drawing.Point(289, 227);
            this.btnModifierVisite.Name = "btnModifierVisite";
            this.btnModifierVisite.Size = new System.Drawing.Size(225, 63);
            this.btnModifierVisite.TabIndex = 2;
            this.btnModifierVisite.Text = "Modifier une visite";
            this.btnModifierVisite.UseVisualStyleBackColor = true;
            this.btnModifierVisite.Click += new System.EventHandler(this.btnModifierVisite_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 388);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(157, 50);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmGestionVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierVisite);
            this.Controls.Add(this.btnAjoutVisite);
            this.Controls.Add(this.btnDetailVisite);
            this.Name = "FrmGestionVisite";
            this.Text = "FrmGestionVisite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetailVisite;
        private System.Windows.Forms.Button btnAjoutVisite;
        private System.Windows.Forms.Button btnModifierVisite;
        private System.Windows.Forms.Button btnRetour;
    }
}