
namespace GestionInfirmerieGUI
{
    partial class FrmAjoutEleve
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
            this.txtAjoutNom = new System.Windows.Forms.TextBox();
            this.txtAjoutPrenom = new System.Windows.Forms.TextBox();
            this.txtAjoutDateNaissance = new System.Windows.Forms.TextBox();
            this.txtAjoutTelParent = new System.Windows.Forms.TextBox();
            this.txtAjoutTelEleve = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAjoutNom = new System.Windows.Forms.Label();
            this.lblAjoutPrenom = new System.Windows.Forms.Label();
            this.lblAjoutDateNaissance = new System.Windows.Forms.Label();
            this.lblAjoutTelEleve = new System.Windows.Forms.Label();
            this.lblAjoutTelParentEleve = new System.Windows.Forms.Label();
            this.lblAjoutTiersTemps = new System.Windows.Forms.Label();
            this.lblAjoutCommentaireSante = new System.Windows.Forms.Label();
            this.lblAjoutClasse = new System.Windows.Forms.Label();
            this.cmbAjoutTiersTemps = new System.Windows.Forms.ComboBox();
            this.txtAjoutCommentaireSante = new System.Windows.Forms.RichTextBox();
            this.cmbAjoutClasse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAjoutNom
            // 
            this.txtAjoutNom.Location = new System.Drawing.Point(96, 37);
            this.txtAjoutNom.Name = "txtAjoutNom";
            this.txtAjoutNom.Size = new System.Drawing.Size(166, 22);
            this.txtAjoutNom.TabIndex = 0;
            // 
            // txtAjoutPrenom
            // 
            this.txtAjoutPrenom.Location = new System.Drawing.Point(96, 114);
            this.txtAjoutPrenom.Name = "txtAjoutPrenom";
            this.txtAjoutPrenom.Size = new System.Drawing.Size(166, 22);
            this.txtAjoutPrenom.TabIndex = 1;
            // 
            // txtAjoutDateNaissance
            // 
            this.txtAjoutDateNaissance.Location = new System.Drawing.Point(96, 189);
            this.txtAjoutDateNaissance.Name = "txtAjoutDateNaissance";
            this.txtAjoutDateNaissance.Size = new System.Drawing.Size(166, 22);
            this.txtAjoutDateNaissance.TabIndex = 2;
            // 
            // txtAjoutTelParent
            // 
            this.txtAjoutTelParent.Location = new System.Drawing.Point(96, 348);
            this.txtAjoutTelParent.Name = "txtAjoutTelParent";
            this.txtAjoutTelParent.Size = new System.Drawing.Size(166, 22);
            this.txtAjoutTelParent.TabIndex = 3;
            // 
            // txtAjoutTelEleve
            // 
            this.txtAjoutTelEleve.Location = new System.Drawing.Point(96, 273);
            this.txtAjoutTelEleve.Name = "txtAjoutTelEleve";
            this.txtAjoutTelEleve.Size = new System.Drawing.Size(166, 22);
            this.txtAjoutTelEleve.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.Location = new System.Drawing.Point(294, 383);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(206, 55);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(596, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblAjoutNom
            // 
            this.lblAjoutNom.AutoSize = true;
            this.lblAjoutNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutNom.Location = new System.Drawing.Point(93, 9);
            this.lblAjoutNom.Name = "lblAjoutNom";
            this.lblAjoutNom.Size = new System.Drawing.Size(64, 25);
            this.lblAjoutNom.TabIndex = 10;
            this.lblAjoutNom.Text = "Nom :";
            // 
            // lblAjoutPrenom
            // 
            this.lblAjoutPrenom.AutoSize = true;
            this.lblAjoutPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutPrenom.Location = new System.Drawing.Point(91, 82);
            this.lblAjoutPrenom.Name = "lblAjoutPrenom";
            this.lblAjoutPrenom.Size = new System.Drawing.Size(91, 25);
            this.lblAjoutPrenom.TabIndex = 11;
            this.lblAjoutPrenom.Text = "Prénom :";
            // 
            // lblAjoutDateNaissance
            // 
            this.lblAjoutDateNaissance.AutoSize = true;
            this.lblAjoutDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutDateNaissance.Location = new System.Drawing.Point(89, 161);
            this.lblAjoutDateNaissance.Name = "lblAjoutDateNaissance";
            this.lblAjoutDateNaissance.Size = new System.Drawing.Size(185, 25);
            this.lblAjoutDateNaissance.TabIndex = 12;
            this.lblAjoutDateNaissance.Text = "Date de naissance :";
            // 
            // lblAjoutTelEleve
            // 
            this.lblAjoutTelEleve.AutoSize = true;
            this.lblAjoutTelEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutTelEleve.Location = new System.Drawing.Point(91, 232);
            this.lblAjoutTelEleve.Name = "lblAjoutTelEleve";
            this.lblAjoutTelEleve.Size = new System.Drawing.Size(169, 25);
            this.lblAjoutTelEleve.TabIndex = 13;
            this.lblAjoutTelEleve.Text = "Téléphone élève :";
            // 
            // lblAjoutTelParentEleve
            // 
            this.lblAjoutTelParentEleve.AutoSize = true;
            this.lblAjoutTelParentEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutTelParentEleve.Location = new System.Drawing.Point(91, 309);
            this.lblAjoutTelParentEleve.Name = "lblAjoutTelParentEleve";
            this.lblAjoutTelParentEleve.Size = new System.Drawing.Size(220, 25);
            this.lblAjoutTelParentEleve.TabIndex = 14;
            this.lblAjoutTelParentEleve.Text = "Téléphone Parent élève";
            // 
            // lblAjoutTiersTemps
            // 
            this.lblAjoutTiersTemps.AutoSize = true;
            this.lblAjoutTiersTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutTiersTemps.Location = new System.Drawing.Point(510, 82);
            this.lblAjoutTiersTemps.Name = "lblAjoutTiersTemps";
            this.lblAjoutTiersTemps.Size = new System.Drawing.Size(141, 25);
            this.lblAjoutTiersTemps.TabIndex = 15;
            this.lblAjoutTiersTemps.Text = "Tiers temps ? :";
            // 
            // lblAjoutCommentaireSante
            // 
            this.lblAjoutCommentaireSante.AutoSize = true;
            this.lblAjoutCommentaireSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblAjoutCommentaireSante.Location = new System.Drawing.Point(510, 160);
            this.lblAjoutCommentaireSante.Name = "lblAjoutCommentaireSante";
            this.lblAjoutCommentaireSante.Size = new System.Drawing.Size(203, 26);
            this.lblAjoutCommentaireSante.TabIndex = 16;
            this.lblAjoutCommentaireSante.Text = "Commentaire santé";
            // 
            // lblAjoutClasse
            // 
            this.lblAjoutClasse.AutoSize = true;
            this.lblAjoutClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutClasse.Location = new System.Drawing.Point(510, 318);
            this.lblAjoutClasse.Name = "lblAjoutClasse";
            this.lblAjoutClasse.Size = new System.Drawing.Size(73, 25);
            this.lblAjoutClasse.TabIndex = 17;
            this.lblAjoutClasse.Text = "Classe";
            // 
            // cmbAjoutTiersTemps
            // 
            this.cmbAjoutTiersTemps.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAjoutTiersTemps.FormattingEnabled = true;
            this.cmbAjoutTiersTemps.Location = new System.Drawing.Point(506, 112);
            this.cmbAjoutTiersTemps.Name = "cmbAjoutTiersTemps";
            this.cmbAjoutTiersTemps.Size = new System.Drawing.Size(165, 24);
            this.cmbAjoutTiersTemps.TabIndex = 18;
            // 
            // txtAjoutCommentaireSante
            // 
            this.txtAjoutCommentaireSante.Location = new System.Drawing.Point(506, 206);
            this.txtAjoutCommentaireSante.Name = "txtAjoutCommentaireSante";
            this.txtAjoutCommentaireSante.Size = new System.Drawing.Size(246, 78);
            this.txtAjoutCommentaireSante.TabIndex = 19;
            this.txtAjoutCommentaireSante.Text = "";
            // 
            // cmbAjoutClasse
            // 
            this.cmbAjoutClasse.FormattingEnabled = true;
            this.cmbAjoutClasse.Location = new System.Drawing.Point(589, 321);
            this.cmbAjoutClasse.Name = "cmbAjoutClasse";
            this.cmbAjoutClasse.Size = new System.Drawing.Size(162, 24);
            this.cmbAjoutClasse.TabIndex = 20;
            // 
            // FrmAjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAjoutClasse);
            this.Controls.Add(this.txtAjoutCommentaireSante);
            this.Controls.Add(this.cmbAjoutTiersTemps);
            this.Controls.Add(this.lblAjoutClasse);
            this.Controls.Add(this.lblAjoutCommentaireSante);
            this.Controls.Add(this.lblAjoutTiersTemps);
            this.Controls.Add(this.lblAjoutTelParentEleve);
            this.Controls.Add(this.lblAjoutTelEleve);
            this.Controls.Add(this.lblAjoutDateNaissance);
            this.Controls.Add(this.lblAjoutPrenom);
            this.Controls.Add(this.lblAjoutNom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtAjoutTelEleve);
            this.Controls.Add(this.txtAjoutTelParent);
            this.Controls.Add(this.txtAjoutDateNaissance);
            this.Controls.Add(this.txtAjoutPrenom);
            this.Controls.Add(this.txtAjoutNom);
            this.Name = "FrmAjoutEleve";
            this.Text = "FrmAjoutEleve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAjoutNom;
        private System.Windows.Forms.TextBox txtAjoutPrenom;
        private System.Windows.Forms.TextBox txtAjoutDateNaissance;
        private System.Windows.Forms.TextBox txtAjoutTelParent;
        private System.Windows.Forms.TextBox txtAjoutTelEleve;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAjoutNom;
        private System.Windows.Forms.Label lblAjoutPrenom;
        private System.Windows.Forms.Label lblAjoutDateNaissance;
        private System.Windows.Forms.Label lblAjoutTelEleve;
        private System.Windows.Forms.Label lblAjoutTelParentEleve;
        private System.Windows.Forms.Label lblAjoutTiersTemps;
        private System.Windows.Forms.Label lblAjoutCommentaireSante;
        private System.Windows.Forms.Label lblAjoutClasse;
        private System.Windows.Forms.ComboBox cmbAjoutTiersTemps;
        private System.Windows.Forms.RichTextBox txtAjoutCommentaireSante;
        private System.Windows.Forms.ComboBox cmbAjoutClasse;
    }
}