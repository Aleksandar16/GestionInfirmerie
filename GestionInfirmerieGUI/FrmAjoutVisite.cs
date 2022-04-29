using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using System.Configuration;

namespace GestionInfirmerieGUI
{
    public partial class FrmAjoutVisite : Form
    {
        public FrmAjoutVisite()
        {
            InitializeComponent();

            dtpDebutVisite.Format = DateTimePickerFormat.Time;
            dtpDebutVisite.ShowUpDown = true;

            dtpFinVisite.Format = DateTimePickerFormat.Time;
            dtpFinVisite.ShowUpDown = true;

            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();
            // Rattachement de la List à la source de données du comboBox

            cmbEleve.ValueMember = "Id";

            cmbEleve.DisplayMember = "Full_name";

            cmbEleve.DataSource = liste;

            List<Medicament> listes = new List<Medicament>();
            listes = GestionMedicament.GetMedicament();
            // Rattachement de la List à la source de données du comboBox

            cmbMedic.ValueMember = "Id";

            cmbMedic.DisplayMember = "Nom";

            cmbMedic.DataSource = listes;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPriseMedic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriseMedic.Checked)
            {
                lblSelection.Visible = true;
                cmbMedic.Visible = true;
                npQuantite.Visible = true;
                lblQuantite.Visible = true;
            }
            else
            {
                lblSelection.Visible = false;
                cmbMedic.Visible = false;
                npQuantite.Visible = false;
                lblQuantite.Visible = false;
            }
        }

        private void cbxMaison_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMaison.Checked)
            {
                cbxHopital.Visible = false;
                cbxMaison.Checked = true;
            }
            else
            {
                cbxHopital.Visible = true;
            }
        }

        private void cbxHopital_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHopital.Checked)
            {
                cbxMaison.Visible = false;
                cbxHopital.Checked = true;
            }
            else
            {
                cbxMaison.Visible = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (dtpDateVisite.Value > DateTime.Now)
            {
                MessageBox.Show("La date de la visite ne peut pas être supérieur à la date d'auourd'hui !");
            }
            else
            {
                if (dtpDebutVisite.Value < dtpFinVisite.Value)
                {
                    if (txtMotif.Text != string.Empty || txtCommentaire.Text != string.Empty)
                    {
                        if (cbxPriseMedic.Checked)
                        {
                            Visite uneVisite = new Visite(0, dtpDateVisite.Value, dtpDebutVisite.Value.TimeOfDay, dtpFinVisite.Value.TimeOfDay, txtMotif.Text, txtCommentaire.Text, cbxMaison.Checked,
                            cbxHopital.Checked, cbxParent.Checked, (Medicament)cmbMedic.SelectedItem, (int)npQuantite.Value, (Eleve)cmbEleve.SelectedItem);

                            GestionVisite.CreerVisiteMedic(uneVisite);

                            MessageBox.Show("Votre saisie a bien été enregistrée.");

                            this.Close();
                        }
                        else
                        {
                            Visite uneVisite = new Visite(0, dtpDateVisite.Value, dtpDebutVisite.Value.TimeOfDay, dtpFinVisite.Value.TimeOfDay, txtMotif.Text, txtCommentaire.Text, cbxMaison.Checked,
                            cbxHopital.Checked, cbxParent.Checked, (Eleve)cmbEleve.SelectedItem);

                            GestionVisite.CreerVisite(uneVisite);

                            MessageBox.Show("Votre saisie a bien été enregistrée.");

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez remplir les champs motif et commentaire !");
                    }
                }
                else
                {
                    MessageBox.Show("L'heure de début de visite doit être inférieur à l'heure de fin de visite !");
                }
            }
        }
    }
}
