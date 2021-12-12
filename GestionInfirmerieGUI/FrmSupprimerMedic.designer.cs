namespace GestionInfirmerieGUI
{
    partial class FrmSupprimerMedic
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
            this.comboBoxSupprimerMedic = new System.Windows.Forms.ComboBox();
            this.btnSupprimerMedic = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSupprimerMedic
            // 
            this.comboBoxSupprimerMedic.FormattingEnabled = true;
            this.comboBoxSupprimerMedic.Location = new System.Drawing.Point(267, 166);
            this.comboBoxSupprimerMedic.Name = "comboBoxSupprimerMedic";
            this.comboBoxSupprimerMedic.Size = new System.Drawing.Size(235, 24);
            this.comboBoxSupprimerMedic.TabIndex = 0;
            // 
            // btnSupprimerMedic
            // 
            this.btnSupprimerMedic.Location = new System.Drawing.Point(333, 257);
            this.btnSupprimerMedic.Name = "btnSupprimerMedic";
            this.btnSupprimerMedic.Size = new System.Drawing.Size(98, 35);
            this.btnSupprimerMedic.TabIndex = 1;
            this.btnSupprimerMedic.Text = "Supprimer";
            this.btnSupprimerMedic.UseVisualStyleBackColor = true;
            this.btnSupprimerMedic.Click += new System.EventHandler(this.btnSupprimerMedic_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 392);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(140, 46);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmSupprimerMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerMedic);
            this.Controls.Add(this.comboBoxSupprimerMedic);
            this.Name = "FrmSupprimerMedic";
            this.Text = "FrmSupprimerMedic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSupprimerMedic;
        private System.Windows.Forms.Button btnSupprimerMedic;
        private System.Windows.Forms.Button btnRetour;
    }
}