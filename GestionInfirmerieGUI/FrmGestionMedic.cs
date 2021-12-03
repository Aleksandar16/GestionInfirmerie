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
    public partial class FrmGestionMedic : Form
    {
        public FrmGestionMedic()
        {
            InitializeComponent();
        }

        private void btnDetailsMedic_Click(object sender, EventArgs e)
        {
            FrmDetailMedic FrmDetailMedic;
            FrmDetailMedic = new FrmDetailMedic();
            FrmDetailMedic.ShowDialog();
            FrmDetailMedic.Close();
        }

        private void btnAjoutMedic_Click(object sender, EventArgs e)
        {
            FrmAjoutMedic FrmAjoutMedic;
            FrmAjoutMedic = new FrmAjoutMedic();
            FrmAjoutMedic.ShowDialog();
            FrmAjoutMedic.Close();
        }

        private void btnModifierMedic_Click(object sender, EventArgs e)
        {
            FrmModifierMedic FrmModifierMedic;
            FrmModifierMedic = new FrmModifierMedic();
            FrmModifierMedic.ShowDialog();
            FrmModifierMedic.Close();
        }

        private void btnSupprimerMedic_Click(object sender, EventArgs e)
        {
            FrmSupprimerMedic FrmSupprimerMedic;
            FrmSupprimerMedic = new FrmSupprimerMedic();
            FrmSupprimerMedic.ShowDialog();
            FrmSupprimerMedic.Close();
        }
    }
}
