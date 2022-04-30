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
    public partial class FrmModificationVisite : Form
    {
        public FrmModificationVisite()
        {
            InitializeComponent();
            GestionVisite.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Visite> liste = new List<Visite>();
            liste = GestionVisite.GetVisite();
            // Rattachement de la List à la source de données du comboBox

            comboBox1.ValueMember = "Id";

            comboBox1.DisplayMember = "Info";

            comboBox1.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifierVisite_Click(object sender, EventArgs e)
        {
            Visite uneVisite = (Visite)comboBox1.SelectedItem;

            this.Hide();
            var modifierVisite = new FrmModifierVisite(uneVisite);
            modifierVisite.FormClosed += (s, args) => this.Close();
            modifierVisite.Show();
        }
    }
}
