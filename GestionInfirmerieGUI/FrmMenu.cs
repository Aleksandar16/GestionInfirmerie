using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInfirmerieGUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGestionEleve_Click(object sender, EventArgs e)
        {
            FrmGestionEleve FrmGestionEleve;
            FrmGestionEleve = new FrmGestionEleve();
            FrmGestionEleve.ShowDialog();
            FrmGestionEleve.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr de vouloir quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGestionMedicament_Click(object sender, EventArgs e)
        {
            FrmGestionMedic FrmGestionMedic;
            FrmGestionMedic = new FrmGestionMedic();
            FrmGestionMedic.ShowDialog();
            FrmGestionMedic.Close();
        }
    }
}
