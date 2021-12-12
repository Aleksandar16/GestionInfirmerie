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
    public partial class FrmModifierEleve : Form
    {
        public FrmModifierEleve()
        {   // Afficher dans le comboBox les noms et prénoms de chaque élève de la base de données
            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();
            // Rattachement de la List à la source de données du comboBox

            cmbModifier.ValueMember = "Id";

            cmbModifier.DisplayMember = "Full_name";

            cmbModifier.DataSource = liste;

        }
        // Bouton pour retourner à la page de gestion des élèves
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Eleve unEleve = (Eleve)cmbModifier.SelectedItem;

            FrmModificationEleve FrmModificationEleve = new FrmModificationEleve(unEleve);
            FrmModificationEleve.Show(); // ouverture du formulaire
        }
    }
}
