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
    public partial class FrmModifierMedic : Form
    {
        public FrmModifierMedic()
        {
            InitializeComponent();
            GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicament();
            // Rattachement de la List à la source de données du comboBox

            cmbModifierMedic.ValueMember = "Id";

            cmbModifierMedic.DisplayMember = "Nom";

            cmbModifierMedic.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierMedic_Click(object sender, EventArgs e)
        {
            Medicament unMedicament = (Medicament)cmbModifierMedic.SelectedItem;

            FrmModificationMedic FrmModificationMedic = new FrmModificationMedic(unMedicament);
            FrmModificationMedic.Show(); // ouverture du formulaire
        }
    }
}
