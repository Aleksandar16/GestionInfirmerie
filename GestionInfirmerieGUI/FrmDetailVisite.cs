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

            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom";
            NomColumn.Width = 120;

            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();

            PrenomColumn.DataPropertyName = "Prenom";
            PrenomColumn.HeaderText = "Prenom";
            PrenomColumn.Width = 120;

            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();

            ClasseColumn.DataPropertyName = "Libelle";
            ClasseColumn.HeaderText = "Classe Eleve";
            ClasseColumn.Width = 150;

            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();

            DateColumn.DataPropertyName = "Date";
            DateColumn.HeaderText = "Date";
            DateColumn.Width = 110;

            DataGridViewTextBoxColumn HeureDebutColumn = new DataGridViewTextBoxColumn();

            HeureDebutColumn.DataPropertyName = "Heure_debut";
            HeureDebutColumn.HeaderText = "Heure Début";
            HeureDebutColumn.Width = 110;

            DataGridViewTextBoxColumn HeureFinColumn = new DataGridViewTextBoxColumn();

            HeureFinColumn.DataPropertyName = "Heure_fin";
            HeureFinColumn.HeaderText = "Heure fin";
            HeureFinColumn.Width = 110;

            DataGridViewTextBoxColumn MotifColumn = new DataGridViewTextBoxColumn();

            MotifColumn.DataPropertyName = "Motif";
            MotifColumn.HeaderText = "Motif";
            MotifColumn.Width = 140;

            DataGridViewTextBoxColumn CommentaireColumn = new DataGridViewTextBoxColumn();

            CommentaireColumn.DataPropertyName = "Commentaire";
            CommentaireColumn.HeaderText = "Commentaire";
            CommentaireColumn.Width = 150;

            DataGridViewTextBoxColumn MaisonColumn = new DataGridViewTextBoxColumn();

            MaisonColumn.DataPropertyName = "Maison";
            MaisonColumn.HeaderText = "Retour maison ?";
            MaisonColumn.Width = 150;

            DataGridViewTextBoxColumn HopitalColumn = new DataGridViewTextBoxColumn();

            HopitalColumn.DataPropertyName = "Hopital";
            HopitalColumn.HeaderText = "Hopital ?";
            HopitalColumn.Width = 100;

            DataGridViewTextBoxColumn ParentColumn = new DataGridViewTextBoxColumn();

            ParentColumn.DataPropertyName = "Parent";
            ParentColumn.HeaderText = "Parents prévenus ?";
            ParentColumn.Width = 170;

            DataGridViewTextBoxColumn MedicColumn = new DataGridViewTextBoxColumn();

            MedicColumn.DataPropertyName = "Medicament";
            MedicColumn.HeaderText = "Médicament";
            MedicColumn.Width = 260;

            dgvVisite.Columns.Add(NomColumn);
            dgvVisite.Columns.Add(PrenomColumn);
            dgvVisite.Columns.Add(ClasseColumn);
            dgvVisite.Columns.Add(DateColumn);
            dgvVisite.Columns.Add(HeureDebutColumn);
            dgvVisite.Columns.Add(HeureFinColumn);
            dgvVisite.Columns.Add(MotifColumn);
            dgvVisite.Columns.Add(CommentaireColumn);
            dgvVisite.Columns.Add(MaisonColumn);
            dgvVisite.Columns.Add(HopitalColumn);
            dgvVisite.Columns.Add(ParentColumn);
            dgvVisite.Columns.Add(MedicColumn);

            dgvVisite.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dgvVisite.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Visite> liste = new List<Visite>();
            liste = GestionVisite.GetVisite();

            dgvVisite.Rows.Clear();

            if (liste.Count > 0)
            {
                dgvVisite.Rows.Add(liste.Count);

                for (int i = 0; i < liste.Count; i++)
                {
                    dgvVisite[0, i].Value = liste[i].Eleve.Prenom;
                    dgvVisite[1, i].Value = liste[i].Eleve.Nom;
                    dgvVisite[2, i].Value = liste[i].Classe.Libelle;
                    dgvVisite[3, i].Value = liste[i].Date.ToString("dd/MM/yyyy");
                    dgvVisite[4, i].Value = liste[i].Heure_debut;
                    dgvVisite[5, i].Value = liste[i].Heure_fin;
                    dgvVisite[6, i].Value = liste[i].Motif;
                    dgvVisite[7, i].Value = liste[i].Commentaire;
                    if (liste[i].Maison == true)
                    {
                        dgvVisite[8, i].Value = "Oui";
                    }
                    else
                    {
                        dgvVisite[8, i].Value = "Non";
                    }
                    if (liste[i].Hopital == true)
                    {
                        dgvVisite[9, i].Value = "Oui";
                    }
                    else
                    {
                        dgvVisite[9, i].Value = "Non";
                    }
                    if (liste[i].Parent == true)
                    {
                        dgvVisite[10, i].Value = "Oui";
                    }
                    else
                    {
                        dgvVisite[10, i].Value = "Non";
                    }

                    string medicStr;

                    if (liste.Count != 0)
                    {
                        if (liste[i].Medicament.Nom != null)
                        {
                            medicStr = liste[i].Medicament.Nom + ": " + liste[i].Medicament.Quantite.ToString() + " ";
                        }
                        else
                        {
                            medicStr = "Aucun Medicament Donnée";
                        }
                    }
                    else
                    {
                        medicStr = "Aucun Medicament Donnée";
                    }

                    dgvVisite[11, i].Value = medicStr;
                }
            }
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            List<Visite> listes = new List<Visite>();
            listes = GestionVisite.GetVisites(dtpSearch.Value);
            dgvVisite.DataSource = listes;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (GestionVisite.ChercherVisite(dtpSearch.Value) == true)
            {
                List<Visite> listes = new List<Visite>();
                listes = GestionVisite.GetVisites(dtpSearch.Value);
                dgvVisite.DataSource = listes;
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            List<Visite> liste = new List<Visite>();
            liste = GestionVisite.GetVisite();

            dgvVisite.DataSource = liste;
        }
    }
}
