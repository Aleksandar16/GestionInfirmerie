namespace GestionInfirmerieGUI
{
    partial class FrmDetailVisite
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
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisite
            // 
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Location = new System.Drawing.Point(12, 65);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.RowHeadersWidth = 51;
            this.dgvVisite.RowTemplate.Height = 24;
            this.dgvVisite.Size = new System.Drawing.Size(1658, 431);
            this.dgvVisite.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Blue;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetour.Location = new System.Drawing.Point(12, 446);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(161, 50);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Location = new System.Drawing.Point(199, 12);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(268, 22);
            this.dtpSearch.TabIndex = 2;
            this.dtpSearch.ValueChanged += new System.EventHandler(this.dtpSearch_ValueChanged);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(787, 12);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(221, 47);
            this.btnActualiser.TabIndex = 3;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(239, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmDetailVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 508);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgvVisite);
            this.Name = "FrmDetailVisite";
            this.Text = "FrmDetailVisite";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnSearch;
    }
}