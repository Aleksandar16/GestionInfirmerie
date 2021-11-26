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
    public partial class FrmModificationEleve : Form
    {
        public const bool OuiTiersTemps = true;
        public const bool NonTiersTemps = false;
        public int id;
        public FrmModificationEleve(Eleve unEleve)
        {
            InitializeComponent();

            id = unEleve.Id;

            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasse.GetLesClasses();
            // Rattachement de la List à la source de données du comboBox

            cmbClasse.ValueMember = "Id";

            cmbClasse.DisplayMember = "Libelle";

            cmbClasse.DataSource = liste;

            List<bool> tiersTemps = new List<bool>();

            tiersTemps.Add(OuiTiersTemps);
            tiersTemps.Add(NonTiersTemps);
            cmbTiersTemps.DataSource = tiersTemps;

            txtNom.Text = unEleve.Nom;
            txtPrenom.Text = unEleve.Prenom;
            dtpDateNaissance.Value = unEleve.Date_naissance;
            txtNumTelEleve.Text = unEleve.Num_portable;
            txtNumTelParent.Text = unEleve.Num_portable_parent;
            cmbTiersTemps.SelectedItem = unEleve.Tiers_temps;
            txtCommentaireSante.Text = unEleve.Commentaire_sante;
            cmbClasse.Text = unEleve.Libelle;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if (txtNom.Text == string.Empty || txtPrenom.Text == string.Empty || dtpDateNaissance.Text == string.Empty || txtNumTelEleve.Text == string.Empty ||
                txtNumTelParent.Text == string.Empty || cmbTiersTemps.Text == string.Empty || txtCommentaireSante.Text == string.Empty || cmbClasse.Text == string.Empty)
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
            }
            else
            {
                Eleve unEleve = new Eleve(id, txtNom.Text, txtPrenom.Text, dtpDateNaissance.Value, txtNumTelEleve.Text, txtNumTelParent.Text,
                (bool)cmbTiersTemps.SelectedValue, txtCommentaireSante.Text, (int)cmbClasse.SelectedValue, (int)cmbClasse.SelectedValue);

                GestionEleve.ModifierEleve(unEleve);

                MessageBox.Show("Votre saisie a bien été modifié.");

                this.Close();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
