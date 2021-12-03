using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInfirmerieGUI
{
    public partial class FrmModificationMedic : Form
    {
        public int id;
        public FrmModificationMedic(Medicament unMedicament)
        {
            InitializeComponent();

            id = unMedicament.Id;

            GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if (txtNomMedic.Text == string.Empty)
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
            }
            else
            {
                Medicament unMedicament = new Medicament(id, txtNomMedic.Text);

                GestionMedicament.ModifierMedicament(unMedicament);

                MessageBox.Show("Votre saisie a bien été modifié.");

                this.Close();
            }
        }
    }
}
