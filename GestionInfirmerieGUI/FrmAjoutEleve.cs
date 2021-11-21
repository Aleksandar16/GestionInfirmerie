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
        public const string OuiTiersTemps = "Oui";
        public const string NonTiersTemps = "Non";
        public FrmAjoutEleve()
        {

            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasse.GetLesClasses();
            // Rattachement de la List à la source de données du comboBox

            cmbAjoutClasse.ValueMember = "id_classe";

            cmbAjoutClasse.DisplayMember = "libelle_classe";

            cmbAjoutClasse.DataSource = liste;

            List<string> tiersTemps = new List<string>();

            tiersTemps.Add(OuiTiersTemps);
            tiersTemps.Add(NonTiersTemps);
            cmbAjoutTiersTemps.DataSource = tiersTemps;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            /*bool tiersTempsBool = true;

            if (Convert.ToBoolean(cmbAjoutTiersTemps.SelectedValue = OuiTiersTemps))
            {
                tiersTempsBool = true;
            }
            else
            {
                tiersTempsBool = false;
            }

            Eleve unEleve = new Eleve(0, txtAjoutNom.Text, txtAjoutPrenom.Text, txtAjoutDateNaissance.Text, txtAjoutTelEleve.Text, txtAjoutTelParent.Text, tiersTempsBool, txtAjoutCommentaireSante.Text, (Classe)cmbAjoutClasse.SelectedItem);*/
        }
    }
}
