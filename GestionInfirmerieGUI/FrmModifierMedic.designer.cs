namespace GestionInfirmerieGUI
{
    partial class FrmModifierMedic
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
            this.cmbModifierMedic = new System.Windows.Forms.ComboBox();
            this.btnModifierMedic = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbModifierMedic
            // 
            this.cmbModifierMedic.FormattingEnabled = true;
            this.cmbModifierMedic.Location = new System.Drawing.Point(282, 155);
            this.cmbModifierMedic.Name = "cmbModifierMedic";
            this.cmbModifierMedic.Size = new System.Drawing.Size(185, 24);
            this.cmbModifierMedic.TabIndex = 0;
            // 
            // btnModifierMedic
            // 
            this.btnModifierMedic.Location = new System.Drawing.Point(324, 232);
            this.btnModifierMedic.Name = "btnModifierMedic";
            this.btnModifierMedic.Size = new System.Drawing.Size(103, 46);
            this.btnModifierMedic.TabIndex = 1;
            this.btnModifierMedic.Text = "Modifier";
            this.btnModifierMedic.UseVisualStyleBackColor = true;
            this.btnModifierMedic.Click += new System.EventHandler(this.btnModifierMedic_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 391);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(152, 47);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmModifierMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierMedic);
            this.Controls.Add(this.cmbModifierMedic);
            this.Name = "FrmModifierMedic";
            this.Text = "FrmModifierMedic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModifierMedic;
        private System.Windows.Forms.Button btnModifierMedic;
        private System.Windows.Forms.Button btnRetour;
    }
}