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
    public partial class FrmGestionEleve : Form
    {
        public FrmGestionEleve()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            FrmAjoutEleve FrmAjoutEleve;
            FrmAjoutEleve = new FrmAjoutEleve();
            FrmAjoutEleve.ShowDialog();
            FrmAjoutEleve.Close();
        }

        private void btnVoirEleve_Click(object sender, EventArgs e)
        {
            FrmDetailEleve FrmDetailEleve;
            FrmDetailEleve = new FrmDetailEleve();
            FrmDetailEleve.ShowDialog();
            FrmDetailEleve.Close();
        }
    }
}
