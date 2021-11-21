
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
            // FrmDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewEleve);
            this.Name = "FrmDetailEleve";
            this.Text = "FrmDetailEleve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEleve;
    }
}