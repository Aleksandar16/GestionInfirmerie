namespace GestionInfirmerieGUI
{
    partial class FrmAjoutMedic
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
            this.lblNomMedic = new System.Windows.Forms.Label();
            this.txtNomMedic = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomMedic
            // 
            this.lblNomMedic.AutoSize = true;
            this.lblNomMedic.Location = new System.Drawing.Point(305, 81);
            this.lblNomMedic.Name = "lblNomMedic";
            this.lblNomMedic.Size = new System.Drawing.Size(137, 17);
            this.lblNomMedic.TabIndex = 0;
            this.lblNomMedic.Text = "Nom du médicament";
            // 
            // txtNomMedic
            // 
            this.txtNomMedic.Location = new System.Drawing.Point(234, 140);
            this.txtNomMedic.Name = "txtNomMedic";
            this.txtNomMedic.Size = new System.Drawing.Size(282, 22);
            this.txtNomMedic.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(329, 241);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(79, 43);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(100, 342);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(102, 51);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmAjoutMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNomMedic);
            this.Controls.Add(this.lblNomMedic);
            this.Name = "FrmAjoutMedic";
            this.Text = "FrmAjoutMedic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMedic;
        private System.Windows.Forms.TextBox txtNomMedic;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRetour;
    }
}