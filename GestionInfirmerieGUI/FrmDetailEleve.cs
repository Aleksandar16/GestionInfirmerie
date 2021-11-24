using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;

namespace GestionInfirmerieGUI
{
    public partial class FrmDetailEleve : Form
    {
        public FrmDetailEleve()
        {
            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["GestionInfirmerie"]);

            dataGridViewEleve.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();

            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "ID";
            IdColumn.Width = 50;

            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom";
            NomColumn.Width = 80;

            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();

            PrenomColumn.DataPropertyName = "Prenom";
            PrenomColumn.HeaderText = "Prenom";
            PrenomColumn.Width = 80;

            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();

            DateColumn.DataPropertyName = "Date_naissance";
            DateColumn.HeaderText = "Date";
            DateColumn.Width = 80;

            DataGridViewTextBoxColumn NumTelEleveColumn = new DataGridViewTextBoxColumn();

            NumTelEleveColumn.DataPropertyName = "Num_portable";
            NumTelEleveColumn.HeaderText = "Portable Eleve";
            NumTelEleveColumn.Width = 150;

            DataGridViewTextBoxColumn NumTelParentColumn = new DataGridViewTextBoxColumn();

            NumTelParentColumn.DataPropertyName = "Num_portable_parent";
            NumTelParentColumn.HeaderText = "Portable Parent";
            NumTelParentColumn.Width = 150;

            DataGridViewTextBoxColumn TiersTempsColumn = new DataGridViewTextBoxColumn();

            TiersTempsColumn.DataPropertyName = "Tiers_temps";
            TiersTempsColumn.HeaderText = "Tiers temps";
            TiersTempsColumn.Width = 120;

            DataGridViewTextBoxColumn CommentaireSanteColumn = new DataGridViewTextBoxColumn();

            CommentaireSanteColumn.DataPropertyName = "Commentaire_sante";
            CommentaireSanteColumn.HeaderText = "Commentaire santé";
            CommentaireSanteColumn.Width = 120;

            DataGridViewTextBoxColumn ClasseEleveColumn = new DataGridViewTextBoxColumn();

            ClasseEleveColumn.DataPropertyName = "Classe";
            ClasseEleveColumn.HeaderText = "Classe Eleve";
            ClasseEleveColumn.Width = 150;

            dataGridViewEleve.Columns.Add(IdColumn);
            dataGridViewEleve.Columns.Add(NomColumn);
            dataGridViewEleve.Columns.Add(PrenomColumn);
            dataGridViewEleve.Columns.Add(DateColumn);
            dataGridViewEleve.Columns.Add(NumTelEleveColumn);
            dataGridViewEleve.Columns.Add(NumTelParentColumn);
            dataGridViewEleve.Columns.Add(TiersTempsColumn);
            dataGridViewEleve.Columns.Add(CommentaireSanteColumn);
            dataGridViewEleve.Columns.Add(ClasseEleveColumn);

            dataGridViewEleve.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridViewEleve.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();

            dataGridViewEleve.DataSource = liste;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
