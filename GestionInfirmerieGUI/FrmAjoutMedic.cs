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

namespace GestionInfirmerieGUI
{
    public partial class FrmAjoutMedic : Form
    {
        public FrmAjoutMedic()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if (txtNomMedic.Text == string.Empty)
            {
                MessageBox.Show("Vous devez remplir le champ");
            }
            else
            {
                Medicament unMedicament = new Medicament(txtNomMedic.Text);

                GestionMedicament.CreerMedicament(unMedicament);

                MessageBox.Show("Votre saisie a bien été enregistré.");

                this.Close();
            }
        }
    }
}
