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

                DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

                NomColumn.DataPropertyName = "Nom";
                NomColumn.HeaderText = "Nom";
                NomColumn.Width = 80;

                DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();

                PrenomColumn.DataPropertyName = "Prenom";
                PrenomColumn.HeaderText = "Prenom";
                PrenomColumn.Width = 80;

                DataGridViewTextBoxColumn NumTelEleveColumn = new DataGridViewTextBoxColumn();

                NumTelEleveColumn.DataPropertyName = "Num_portable";
                NumTelEleveColumn.HeaderText = "Portable Eleve";
                NumTelEleveColumn.Width = 150;

                DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();

                DateColumn.DataPropertyName = "Date_naissance";
                DateColumn.HeaderText = "Date de naissance";
                DateColumn.Width = 160;

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
                CommentaireSanteColumn.Width = 140;

                DataGridViewTextBoxColumn ClasseEleveColumn = new DataGridViewTextBoxColumn();

                ClasseEleveColumn.DataPropertyName = "Classe_Eleve";
                ClasseEleveColumn.HeaderText = "Classe Eleve";
                ClasseEleveColumn.Width = 150;

                dataGridViewEleve.Columns.Add(NomColumn);
                dataGridViewEleve.Columns.Add(PrenomColumn);
                dataGridViewEleve.Columns.Add(NumTelEleveColumn);
                dataGridViewEleve.Columns.Add(DateColumn);
                dataGridViewEleve.Columns.Add(ClasseEleveColumn);
                dataGridViewEleve.Columns.Add(NumTelParentColumn);
                dataGridViewEleve.Columns.Add(TiersTempsColumn);
                dataGridViewEleve.Columns.Add(CommentaireSanteColumn);
                

                dataGridViewEleve.ColumnHeadersVisible = true;
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

                dataGridViewEleve.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                List<Eleve> liste = new List<Eleve>();
                liste = GestionEleve.GetEleve();

                dataGridViewEleve.Rows.Clear();

                if (liste.Count > 0)
                {
                    dataGridViewEleve.Rows.Add(liste.Count);

                    for (int i = 0; i < liste.Count; i++)
                    {
                        dataGridViewEleve[0, i].Value = liste[i].Nom;
                        dataGridViewEleve[1, i].Value = liste[i].Prenom;
                        dataGridViewEleve[2, i].Value = liste[i].Num_portable;
                        dataGridViewEleve[3, i].Value = liste[i].Date_naissance.ToString("dd/MM/yyyy");
                        dataGridViewEleve[4, i].Value = liste[i].Classe_Eleve.Libelle;
                        dataGridViewEleve[5, i].Value = liste[i].Num_portable_parent;
                        if (liste[i].Tiers_temps == true)
                        {
                            dataGridViewEleve[6, i].Value = "Oui";
                        }
                        else
                        {
                            dataGridViewEleve[6, i].Value = "Non";
                        }

                        dataGridViewEleve[7, i].Value = liste[i].Commentaire_sante;
                    }
                }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                List<Eleve> liste = new List<Eleve>();
                liste = GestionEleve.GetElevesName(txtNom.Text);

                if (liste.Count == 0)
                {
                    MessageBox.Show("Il n'existe aucun élève portant ce nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridViewEleve.Rows.Clear();
                    dataGridViewEleve.Rows.Add(liste.Count);

                    for (int i = 0; i < liste.Count; i++)
                    {
                        dataGridViewEleve[0, i].Value = liste[i].Nom;
                        dataGridViewEleve[1, i].Value = liste[i].Prenom;
                        dataGridViewEleve[2, i].Value = liste[i].Date_naissance.ToString("dd/MM/yyyy");
                        dataGridViewEleve[3, i].Value = "0" + liste[i].Num_portable;
                        dataGridViewEleve[4, i].Value = liste[i].Classe_Eleve.Libelle;
                        dataGridViewEleve[5, i].Value = "0" + liste[i].Num_portable_parent;
                        if (liste[i].Tiers_temps == true)
                        {
                            dataGridViewEleve[6, i].Value = "Oui";
                        }
                        else
                        {
                            dataGridViewEleve[6, i].Value = "Non";
                        }

                        dataGridViewEleve[7, i].Value = liste[i].Commentaire_sante;
                    }
                }


            }
            else
            {
                actualiser();
            }
        }

        private void actualiser()
        {
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();

            dataGridViewEleve.Rows.Clear();

            if (liste.Count > 0)
            {
                dataGridViewEleve.Rows.Add(liste.Count);

                for (int i = 0; i < liste.Count; i++)
                {
                    dataGridViewEleve[0, i].Value = liste[i].Nom;
                    dataGridViewEleve[1, i].Value = liste[i].Prenom;
                    dataGridViewEleve[2, i].Value = liste[i].Date_naissance.ToString("dd/MM/yyyy");
                    dataGridViewEleve[3, i].Value = "0" + liste[i].Num_portable;
                    dataGridViewEleve[4, i].Value = liste[i].Classe_Eleve.Libelle;
                    dataGridViewEleve[5, i].Value = "0" + liste[i].Num_portable_parent;
                    if (liste[i].Tiers_temps == true)
                    {
                        dataGridViewEleve[6, i].Value = "Oui";
                    }
                    else
                    {
                        dataGridViewEleve[6, i].Value = "Non";
                    }

                    dataGridViewEleve[7, i].Value = liste[i].Commentaire_sante;
                }
            }
        }
        
    }
}
