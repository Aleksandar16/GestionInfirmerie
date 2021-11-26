
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnTout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.RowHeadersWidth = 51;
            this.dataGridViewEleve.RowTemplate.Height = 24;
            this.dataGridViewEleve.Size = new System.Drawing.Size(776, 352);
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
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(22, 36);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(270, 22);
            this.txtNom.TabIndex = 2;
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChercher.Location = new System.Drawing.Point(333, 23);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(199, 42);
            this.btnChercher.TabIndex = 3;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = false;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnTout
            // 
            this.btnTout.BackColor = System.Drawing.Color.Gray;
            this.btnTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTout.Location = new System.Drawing.Point(574, 23);
            this.btnTout.Name = "btnTout";
            this.btnTout.Size = new System.Drawing.Size(191, 41);
            this.btnTout.TabIndex = 4;
            this.btnTout.Text = "Actualiser";
            this.btnTout.UseVisualStyleBackColor = false;
            this.btnTout.Click += new System.EventHandler(this.btnTout_Click);
            // 
            // FrmDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTout);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataGridViewEleve);
            this.Name = "FrmDetailEleve";
            this.Text = "FrmDetailEleve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEleve;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Button btnTout;
    }
}