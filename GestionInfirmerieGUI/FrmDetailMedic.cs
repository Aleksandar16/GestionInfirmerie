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
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
namespace GestionInfirmerieGUI
{
    public partial class FrmDetailMedic : Form
    {
        public FrmDetailMedic()
        {
            InitializeComponent();


            GestionMedicament.SetchaineConnexion(ConfigurationManager.ConnectionStrings
            ["GestionInfirmerie"]);

            dataGridViewMedicament.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();

            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom";
            NomColumn.Width = 80;



            dataGridViewMedicament.Columns.Add(NomColumn);


            dataGridViewMedicament.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridViewMedicament.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicament();

            dataGridViewMedicament.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomMedic.Text))
            {
                if (GestionMedicament.ChercherMedicament(txtNomMedic.Text) == true)
                {
                    List<Medicament> listes = new List<Medicament>();
                    listes = GestionMedicament.GetUnMedicament(txtNomMedic.Text);
                    dataGridViewMedicament.DataSource = listes;
                }

                if (GestionMedicament.ChercherMedicament(txtNomMedic.Text) == false)
                {
                    MessageBox.Show("Le médicament n'existe pas !", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicament.GetMedicament();

            dataGridViewMedicament.DataSource = liste;
        }
    }
}
