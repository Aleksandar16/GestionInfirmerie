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
    public partial class FrmSupprimerEleve : Form
    {
        public FrmSupprimerEleve()
        {
            InitializeComponent();
            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();
            // Rattachement de la List à la source de données du comboBox

            cmbSupprimer.ValueMember = "Id";

            cmbSupprimer.DisplayMember = "Nom";

            cmbSupprimer.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Eleve unEleve = new Eleve((int)cmbSupprimer.SelectedValue);

            GestionEleve.SupprimerEleve(unEleve);

            if (MessageBox.Show(this, "Vous allez retourner sur le menu de gestion des élèves", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("L'élève a bien été supprimer de la base de données.");
            }
            this.Close();
        }
    }
}
