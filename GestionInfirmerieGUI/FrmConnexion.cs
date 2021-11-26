using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionInfirmerieBLL;
using GestionInfirmerieBO; 
using System.Data.SqlClient;
using System.Threading;
using GestionInfirmerieGUI;

namespace GestionInfirmerie
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            GestionUtilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // vérification des informations de connexion

            //si le nom et mdp est le meme que celui dans la bdd SI oui, on va sur la page Menu
            if (GestionUtilisateur.ConnexionUtilisateur(txtNomUtilisateur.Text, txtMdp.Text))
            {
                FrmMenu choixAdmin = new FrmMenu();
                choixAdmin.Show();
                this.Hide();
            }
            else
            {
                //message d'erreur si le nom ou le mdp est pas bon
                MessageBox.Show("Nom ou mot de passe incorrects.");
            }
        }
    }
}
