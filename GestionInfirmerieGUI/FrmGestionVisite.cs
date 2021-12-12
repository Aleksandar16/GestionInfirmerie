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
    public partial class FrmGestionVisite : Form
    {
        public FrmGestionVisite()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetailVisite_Click(object sender, EventArgs e)
        {
            FrmDetailVisite FrmDetailVisite;
            FrmDetailVisite = new FrmDetailVisite();
            FrmDetailVisite.ShowDialog();
            FrmDetailVisite.Close();
        }

        private void btnAjoutVisite_Click(object sender, EventArgs e)
        {
            FrmAjoutVisite FrmAjoutVisite;
            FrmAjoutVisite = new FrmAjoutVisite();
            FrmAjoutVisite.ShowDialog();
            FrmAjoutVisite.Close();
        }

        private void btnModifierVisite_Click(object sender, EventArgs e)
        {
            FrmModifierVisite FrmModifierVisite;
            FrmModifierVisite = new FrmModifierVisite();
            FrmModifierVisite.ShowDialog();
            FrmModifierVisite.Close();
        }
    }
}
