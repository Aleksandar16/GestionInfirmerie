namespace GestionInfirmerieGUI
{
    partial class FrmAjoutVisite
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
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.dtpFinVisite = new System.Windows.Forms.DateTimePicker();
            this.dtpDebutVisite = new System.Windows.Forms.DateTimePicker();
            this.cmbMedic = new System.Windows.Forms.ComboBox();
            this.cbxPriseMedic = new System.Windows.Forms.CheckBox();
            this.lblEleve = new System.Windows.Forms.Label();
            this.lblDateVisite = new System.Windows.Forms.Label();
            this.lblDebutVisite = new System.Windows.Forms.Label();
            this.lblFinVisite = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.RichTextBox();
            this.txtCommentaire = new System.Windows.Forms.RichTextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.cbxMaison = new System.Windows.Forms.CheckBox();
            this.cbxHopital = new System.Windows.Forms.CheckBox();
            this.cbxParent = new System.Windows.Forms.CheckBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.npQuantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.npQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEleve
            // 
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(54, 76);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(221, 24);
            this.cmbEleve.TabIndex = 0;
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Location = new System.Drawing.Point(54, 172);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(221, 22);
            this.dtpDateVisite.TabIndex = 1;
            // 
            // dtpFinVisite
            // 
            this.dtpFinVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinVisite.Location = new System.Drawing.Point(54, 362);
            this.dtpFinVisite.Name = "dtpFinVisite";
            this.dtpFinVisite.Size = new System.Drawing.Size(221, 22);
            this.dtpFinVisite.TabIndex = 3;
            // 
            // dtpDebutVisite
            // 
            this.dtpDebutVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebutVisite.Location = new System.Drawing.Point(54, 265);
            this.dtpDebutVisite.Name = "dtpDebutVisite";
            this.dtpDebutVisite.Size = new System.Drawing.Size(221, 22);
            this.dtpDebutVisite.TabIndex = 2;
            this.dtpDebutVisite.Value = new System.DateTime(2021, 12, 10, 11, 25, 0, 0);
            // 
            // cmbMedic
            // 
            this.cmbMedic.FormattingEnabled = true;
            this.cmbMedic.Location = new System.Drawing.Point(445, 174);
            this.cmbMedic.Name = "cmbMedic";
            this.cmbMedic.Size = new System.Drawing.Size(221, 24);
            this.cmbMedic.TabIndex = 8;
            this.cmbMedic.Visible = false;
            // 
            // cbxPriseMedic
            // 
            this.cbxPriseMedic.AutoSize = true;
            this.cbxPriseMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPriseMedic.Location = new System.Drawing.Point(585, 75);
            this.cbxPriseMedic.Name = "cbxPriseMedic";
            this.cbxPriseMedic.Size = new System.Drawing.Size(216, 24);
            this.cbxPriseMedic.TabIndex = 7;
            this.cbxPriseMedic.Text = "Prise d\'un médicament ?";
            this.cbxPriseMedic.UseVisualStyleBackColor = true;
            this.cbxPriseMedic.CheckedChanged += new System.EventHandler(this.cbxPriseMedic_CheckedChanged);
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleve.Location = new System.Drawing.Point(49, 42);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(61, 25);
            this.lblEleve.TabIndex = 8;
            this.lblEleve.Text = "Elève";
            // 
            // lblDateVisite
            // 
            this.lblDateVisite.AutoSize = true;
            this.lblDateVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateVisite.Location = new System.Drawing.Point(51, 133);
            this.lblDateVisite.Name = "lblDateVisite";
            this.lblDateVisite.Size = new System.Drawing.Size(102, 25);
            this.lblDateVisite.TabIndex = 9;
            this.lblDateVisite.Text = "Date visite";
            // 
            // lblDebutVisite
            // 
            this.lblDebutVisite.AutoSize = true;
            this.lblDebutVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebutVisite.Location = new System.Drawing.Point(53, 231);
            this.lblDebutVisite.Name = "lblDebutVisite";
            this.lblDebutVisite.Size = new System.Drawing.Size(168, 25);
            this.lblDebutVisite.TabIndex = 10;
            this.lblDebutVisite.Text = "Heure début visite";
            // 
            // lblFinVisite
            // 
            this.lblFinVisite.AutoSize = true;
            this.lblFinVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinVisite.Location = new System.Drawing.Point(53, 323);
            this.lblFinVisite.Name = "lblFinVisite";
            this.lblFinVisite.Size = new System.Drawing.Size(139, 25);
            this.lblFinVisite.TabIndex = 11;
            this.lblFinVisite.Text = "Heure fin visite";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(581, 265);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(235, 63);
            this.txtMotif.TabIndex = 10;
            this.txtMotif.Text = "";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(581, 410);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(235, 63);
            this.txtCommentaire.TabIndex = 11;
            this.txtCommentaire.Text = "";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(590, 220);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(103, 25);
            this.lblMotif.TabIndex = 14;
            this.lblMotif.Text = "Motif visite";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.Location = new System.Drawing.Point(590, 359);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(178, 25);
            this.lblCommentaire.TabIndex = 15;
            this.lblCommentaire.Text = "Commentaire visite";
            // 
            // cbxMaison
            // 
            this.cbxMaison.AutoSize = true;
            this.cbxMaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaison.Location = new System.Drawing.Point(230, 435);
            this.cbxMaison.Name = "cbxMaison";
            this.cbxMaison.Size = new System.Drawing.Size(154, 24);
            this.cbxMaison.TabIndex = 5;
            this.cbxMaison.Text = "Retour maison ?";
            this.cbxMaison.UseVisualStyleBackColor = true;
            this.cbxMaison.CheckedChanged += new System.EventHandler(this.cbxMaison_CheckedChanged);
            // 
            // cbxHopital
            // 
            this.cbxHopital.AutoSize = true;
            this.cbxHopital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHopital.Location = new System.Drawing.Point(434, 435);
            this.cbxHopital.Name = "cbxHopital";
            this.cbxHopital.Size = new System.Drawing.Size(98, 24);
            this.cbxHopital.TabIndex = 6;
            this.cbxHopital.Text = "Hopital ?";
            this.cbxHopital.UseVisualStyleBackColor = true;
            this.cbxHopital.CheckedChanged += new System.EventHandler(this.cbxHopital_CheckedChanged);
            // 
            // cbxParent
            // 
            this.cbxParent.AutoSize = true;
            this.cbxParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParent.Location = new System.Drawing.Point(16, 435);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(158, 24);
            this.cbxParent.TabIndex = 4;
            this.cbxParent.Text = "Parent prévenu ?";
            this.cbxParent.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(343, 492);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(189, 55);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 501);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(162, 48);
            this.btnRetour.TabIndex = 13;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(498, 133);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(119, 25);
            this.lblSelection.TabIndex = 21;
            this.lblSelection.Text = "Médicament";
            this.lblSelection.Visible = false;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(730, 133);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(86, 25);
            this.lblQuantite.TabIndex = 23;
            this.lblQuantite.Text = "Quantité";
            this.lblQuantite.Visible = false;
            // 
            // npQuantite
            // 
            this.npQuantite.Cursor = System.Windows.Forms.Cursors.Default;
            this.npQuantite.Location = new System.Drawing.Point(717, 175);
            this.npQuantite.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuantite.Name = "npQuantite";
            this.npQuantite.Size = new System.Drawing.Size(157, 22);
            this.npQuantite.TabIndex = 9;
            this.npQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npQuantite.Visible = false;
            // 
            // FrmAjoutVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.npQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxParent);
            this.Controls.Add(this.cbxHopital);
            this.Controls.Add(this.cbxMaison);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblFinVisite);
            this.Controls.Add(this.lblDebutVisite);
            this.Controls.Add(this.lblDateVisite);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.cbxPriseMedic);
            this.Controls.Add(this.cmbMedic);
            this.Controls.Add(this.dtpDebutVisite);
            this.Controls.Add(this.dtpFinVisite);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.cmbEleve);
            this.Name = "FrmAjoutVisite";
            this.Text = "FrmAjoutVisite";
            ((System.ComponentModel.ISupportInitialize)(this.npQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.DateTimePicker dtpFinVisite;
        private System.Windows.Forms.DateTimePicker dtpDebutVisite;
        private System.Windows.Forms.ComboBox cmbMedic;
        private System.Windows.Forms.CheckBox cbxPriseMedic;
        private System.Windows.Forms.Label lblEleve;
        private System.Windows.Forms.Label lblDateVisite;
        private System.Windows.Forms.Label lblDebutVisite;
        private System.Windows.Forms.Label lblFinVisite;
        private System.Windows.Forms.RichTextBox txtMotif;
        private System.Windows.Forms.RichTextBox txtCommentaire;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.CheckBox cbxMaison;
        private System.Windows.Forms.CheckBox cbxHopital;
        private System.Windows.Forms.CheckBox cbxParent;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown npQuantite;
    }
}