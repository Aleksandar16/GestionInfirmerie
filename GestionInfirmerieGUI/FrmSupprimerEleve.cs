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

            cmbSupprimer.DisplayMember = "Full_name";

            cmbSupprimer.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Eleve unEleve = new Eleve((int)cmbSupprimer.SelectedValue);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer l'élève de la base de données ?", "Enregistrement", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    GestionEleve.SupprimerEleve(unEleve);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible de supprimer l'élève");
                }
            }
        }
    }
}
