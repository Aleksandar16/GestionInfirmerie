namespace GestionInfirmerieGUI
{
    partial class FrmModificationEleve
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumTelParent = new System.Windows.Forms.TextBox();
            this.txtNumTelEleve = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cmbTiersTemps = new System.Windows.Forms.ComboBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblNumTelEleve = new System.Windows.Forms.Label();
            this.lblNumTelParent = new System.Windows.Forms.Label();
            this.lblTiersTemps = new System.Windows.Forms.Label();
            this.lblCommentaireSante = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.txtCommentaireSante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(88, 62);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 22);
            this.txtNom.TabIndex = 0;
            // 
            // txtNumTelParent
            // 
            this.txtNumTelParent.Location = new System.Drawing.Point(88, 346);
            this.txtNumTelParent.Name = "txtNumTelParent";
            this.txtNumTelParent.Size = new System.Drawing.Size(167, 22);
            this.txtNumTelParent.TabIndex = 3;
            // 
            // txtNumTelEleve
            // 
            this.txtNumTelEleve.Location = new System.Drawing.Point(88, 268);
            this.txtNumTelEleve.Name = "txtNumTelEleve";
            this.txtNumTelEleve.Size = new System.Drawing.Size(167, 22);
            this.txtNumTelEleve.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(88, 126);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(167, 22);
            this.txtPrenom.TabIndex = 5;
            // 
            // cmbTiersTemps
            // 
            this.cmbTiersTemps.FormattingEnabled = true;
            this.cmbTiersTemps.Location = new System.Drawing.Point(509, 62);
            this.cmbTiersTemps.Name = "cmbTiersTemps";
            this.cmbTiersTemps.Size = new System.Drawing.Size(247, 24);
            this.cmbTiersTemps.TabIndex = 7;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(509, 346);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(247, 24);
            this.cmbClasse.TabIndex = 8;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(65, 199);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(241, 22);
            this.dtpDateNaissance.TabIndex = 9;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 392);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(173, 46);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifier.Location = new System.Drawing.Point(303, 392);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(173, 46);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(141, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(36, 16);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(141, 97);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(54, 16);
            this.lblPrenom.TabIndex = 13;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(111, 166);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(120, 16);
            this.lblDateNaissance.TabIndex = 14;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // lblNumTelEleve
            // 
            this.lblNumTelEleve.AutoSize = true;
            this.lblNumTelEleve.Location = new System.Drawing.Point(111, 234);
            this.lblNumTelEleve.Name = "lblNumTelEleve";
            this.lblNumTelEleve.Size = new System.Drawing.Size(110, 16);
            this.lblNumTelEleve.TabIndex = 15;
            this.lblNumTelEleve.Text = "Téléphone élève";
            // 
            // lblNumTelParent
            // 
            this.lblNumTelParent.AutoSize = true;
            this.lblNumTelParent.Location = new System.Drawing.Point(111, 307);
            this.lblNumTelParent.Name = "lblNumTelParent";
            this.lblNumTelParent.Size = new System.Drawing.Size(114, 16);
            this.lblNumTelParent.TabIndex = 16;
            this.lblNumTelParent.Text = "Téléphone parent";
            // 
            // lblTiersTemps
            // 
            this.lblTiersTemps.AutoSize = true;
            this.lblTiersTemps.Location = new System.Drawing.Point(575, 26);
            this.lblTiersTemps.Name = "lblTiersTemps";
            this.lblTiersTemps.Size = new System.Drawing.Size(78, 16);
            this.lblTiersTemps.TabIndex = 17;
            this.lblTiersTemps.Text = "Tiers temps";
            // 
            // lblCommentaireSante
            // 
            this.lblCommentaireSante.AutoSize = true;
            this.lblCommentaireSante.Location = new System.Drawing.Point(557, 112);
            this.lblCommentaireSante.Name = "lblCommentaireSante";
            this.lblCommentaireSante.Size = new System.Drawing.Size(123, 16);
            this.lblCommentaireSante.TabIndex = 18;
            this.lblCommentaireSante.Text = "Commentaire santé";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(592, 307);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(49, 16);
            this.lblClasse.TabIndex = 19;
            this.lblClasse.Text = "Classe";
            // 
            // txtCommentaireSante
            // 
            this.txtCommentaireSante.Location = new System.Drawing.Point(532, 187);
            this.txtCommentaireSante.Name = "txtCommentaireSante";
            this.txtCommentaireSante.Size = new System.Drawing.Size(164, 22);
            this.txtCommentaireSante.TabIndex = 20;
            // 
            // FrmModificationEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCommentaireSante);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblCommentaireSante);
            this.Controls.Add(this.lblTiersTemps);
            this.Controls.Add(this.lblNumTelParent);
            this.Controls.Add(this.lblNumTelEleve);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.cmbTiersTemps);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNumTelEleve);
            this.Controls.Add(this.txtNumTelParent);
            this.Controls.Add(this.txtNom);
            this.Name = "FrmModificationEleve";
            this.Text = "FrmModificationEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumTelParent;
        private System.Windows.Forms.TextBox txtNumTelEleve;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cmbTiersTemps;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblNumTelEleve;
        private System.Windows.Forms.Label lblNumTelParent;
        private System.Windows.Forms.Label lblTiersTemps;
        private System.Windows.Forms.Label lblCommentaireSante;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox txtCommentaireSante;
    }
}