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
    public partial class FrmDetailVisite : Form
    {
        public FrmDetailVisite()
        {
            InitializeComponent();

            GestionVisite.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["GestionInfirmerie"]);

            dgvVisite.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "Date";
            NomColumn.HeaderText = "Date visite";
            NomColumn.Width = 120;

            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();

            PrenomColumn.DataPropertyName = "Heure_debut";
            PrenomColumn.HeaderText = "Heure début";
            PrenomColumn.Width = 120;

            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();

            DateColumn.DataPropertyName = "Heure_fin";
            DateColumn.HeaderText = "Heure fin";
            DateColumn.Width = 110;

            DataGridViewTextBoxColumn NumTelEleveColumn = new DataGridViewTextBoxColumn();

            NumTelEleveColumn.DataPropertyName = "Motif";
            NumTelEleveColumn.HeaderText = "Motif";
            NumTelEleveColumn.Width = 140;

            DataGridViewTextBoxColumn NumTelParentColumn = new DataGridViewTextBoxColumn();

            NumTelParentColumn.DataPropertyName = "Commentaire";
            NumTelParentColumn.HeaderText = "Commentaire";
            NumTelParentColumn.Width = 150;

            DataGridViewTextBoxColumn TiersTempsColumn = new DataGridViewTextBoxColumn();

            TiersTempsColumn.DataPropertyName = "Maison";
            TiersTempsColumn.HeaderText = "Retour maison ?";
            TiersTempsColumn.Width = 150;

            DataGridViewTextBoxColumn CommentaireSanteColumn = new DataGridViewTextBoxColumn();

            CommentaireSanteColumn.DataPropertyName = "Hopital";
            CommentaireSanteColumn.HeaderText = "Hopital ?";
            CommentaireSanteColumn.Width = 100;

            DataGridViewTextBoxColumn ClasseEleveColumn = new DataGridViewTextBoxColumn();

            ClasseEleveColumn.DataPropertyName = "Parent";
            ClasseEleveColumn.HeaderText = "Parents prévenus ?";
            ClasseEleveColumn.Width = 170;

            DataGridViewTextBoxColumn EleveColumn = new DataGridViewTextBoxColumn();

            EleveColumn.DataPropertyName = "Eleve";
            EleveColumn.HeaderText = "Nom Eleve";
            EleveColumn.Width = 150;

            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();

            ClasseColumn.DataPropertyName = "Classe";
            ClasseColumn.HeaderText = "Classe Eleve";
            ClasseColumn.Width = 150;

            DataGridViewTextBoxColumn MedicColumn = new DataGridViewTextBoxColumn();

            MedicColumn.DataPropertyName = "Medicament";
            MedicColumn.HeaderText = "Médicament";
            MedicColumn.Width = 170;

            DataGridViewTextBoxColumn QuantiteMedicColumn = new DataGridViewTextBoxColumn();

            QuantiteMedicColumn.DataPropertyName = "Quantite_Medic";
            QuantiteMedicColumn.HeaderText = "Quantité";
            QuantiteMedicColumn.Width = 170;

            dgvVisite.Columns.Add(NomColumn);
            dgvVisite.Columns.Add(PrenomColumn);
            dgvVisite.Columns.Add(DateColumn);
            dgvVisite.Columns.Add(NumTelEleveColumn);
            dgvVisite.Columns.Add(NumTelParentColumn);
            dgvVisite.Columns.Add(TiersTempsColumn);
            dgvVisite.Columns.Add(CommentaireSanteColumn);
            dgvVisite.Columns.Add(ClasseEleveColumn);
            dgvVisite.Columns.Add(EleveColumn);
            dgvVisite.Columns.Add(ClasseColumn);
            dgvVisite.Columns.Add(MedicColumn);
            dgvVisite.Columns.Add(QuantiteMedicColumn);

            dgvVisite.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dgvVisite.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Visite> liste = new List<Visite>();
            liste = GestionVisite.GetVisite();

            dgvVisite.DataSource = liste;
        }
    }
}
