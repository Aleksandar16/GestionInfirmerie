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
    public partial class FrmAjoutEleve : Form
    {
        public const bool OuiTiersTemps = true;
        public const bool NonTiersTemps = false;
        public FrmAjoutEleve()
        {

            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasse.GetLesClasses();
            // Rattachement de la List à la source de données du comboBox

            cmbAjoutClasse.ValueMember = "Id";

            cmbAjoutClasse.DisplayMember = "Libelle";

            cmbAjoutClasse.DataSource = liste;

            List<bool> tiersTemps = new List<bool>();

            tiersTemps.Add(OuiTiersTemps);
            tiersTemps.Add(NonTiersTemps);
            cmbAjoutTiersTemps.DataSource = tiersTemps;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Eleve unEleve = new Eleve(0, txtAjoutNom.Text, txtAjoutPrenom.Text, dtpAjoutDateNaissance.Value, txtAjoutTelEleve.Text, txtAjoutTelParent.Text,
                (bool)cmbAjoutTiersTemps.SelectedValue, txtAjoutCommentaireSante.Text, (int)cmbAjoutClasse.SelectedValue, (int)cmbAjoutClasse.SelectedValue);

            GestionEleve.CreerEleve(unEleve);

            MessageBox.Show("Votre saisie a bien été enregistré.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
