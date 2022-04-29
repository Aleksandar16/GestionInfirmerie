namespace GestionInfirmerieGUI
{
    partial class FrmModificationVisite
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
            this.lblNomEleveVisite = new System.Windows.Forms.Label();
            this.btnModifierVisite = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomEleveVisite
            // 
            this.lblNomEleveVisite.AutoSize = true;
            this.lblNomEleveVisite.Location = new System.Drawing.Point(304, 97);
            this.lblNomEleveVisite.Name = "lblNomEleveVisite";
            this.lblNomEleveVisite.Size = new System.Drawing.Size(130, 16);
            this.lblNomEleveVisite.TabIndex = 0;
            this.lblNomEleveVisite.Text = "Sélectionner la visite";
            // 
            // btnModifierVisite
            // 
            this.btnModifierVisite.Location = new System.Drawing.Point(322, 212);
            this.btnModifierVisite.Name = "btnModifierVisite";
            this.btnModifierVisite.Size = new System.Drawing.Size(98, 39);
            this.btnModifierVisite.TabIndex = 2;
            this.btnModifierVisite.Text = "Modifier";
            this.btnModifierVisite.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(51, 319);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(92, 48);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // FrmModificationVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierVisite);
            this.Controls.Add(this.lblNomEleveVisite);
            this.Name = "FrmModificationVisite";
            this.Text = "FrmModificationVisite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomEleveVisite;
        private System.Windows.Forms.Button btnModifierVisite;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}