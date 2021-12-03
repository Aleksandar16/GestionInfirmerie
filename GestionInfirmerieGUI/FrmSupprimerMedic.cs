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
    public partial class FrmSupprimerMedic : Form
    {
        public FrmSupprimerMedic()
        {
            InitializeComponent();
            GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicament();
            // Rattachement de la List à la source de données du comboBox

            comboBoxSupprimerMedic.ValueMember = "Id";

            comboBoxSupprimerMedic.DisplayMember = "Nom";

            comboBoxSupprimerMedic.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerMedic_Click(object sender, EventArgs e)
        {
            Medicament unMedicament = new Medicament((int)comboBoxSupprimerMedic.SelectedValue);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer le médicament de la base de données ?", "Enregistrement", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GestionMedicament.SupprimerMedicament(unMedicament);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Vous allez retourner au menu de gestion des élèves");
            }

            this.Close();
        }
    }
}
