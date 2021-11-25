
namespace GestionInfirmerieGUI
{
    partial class FrmDetailEleve
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
            this.dataGridViewEleve = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.RowHeadersWidth = 51;
            this.dataGridViewEleve.RowTemplate.Height = 24;
            this.dataGridViewEleve.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewEleve.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 391);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(167, 47);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click_1);
            // 
            // FrmDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridViewEleve);
            this.Name = "FrmDetailEleve";
            this.Text = "FrmDetailEleve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEleve;
        private System.Windows.Forms.Button btnRetour;
    }
}