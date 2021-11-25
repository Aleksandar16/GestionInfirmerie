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
        public FrmModificationEleve()
        {
            InitializeComponent();

            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasse.GetLesClasses();
            // Rattachement de la List à la source de données du comboBox

            cmbClasse.ValueMember = "Id";

            cmbClasse.DisplayMember = "Libelle";

            cmbClasse.DataSource = liste;

            List<bool> tiersTemps = new List<bool>();
            cmbTiersTemps.DataSource = tiersTemps;

            Eleve eleve = Eleve.EleveId;
            txtNom.Text = eleve.Nom.Trim();
            txtPrenom.Text = eleve.Prenom.Trim();
            dtpDateNaissance.Value = eleve.Date_naissance;
            txtNumTelEleve.Text = eleve.Num_portable.Trim();
            txtNumTelParent.Text = eleve.Num_portable_parent.Trim();
            if (eleve.Tiers_temps == true)
            {
                cmbTiersTemps.SelectedValue = true;
            }
            else
            {
                cmbTiersTemps.SelectedValue = false;
            }
        }
    }
}
