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

namespace GestionInfirmerieGUI
{
    public partial class FrmModifierVisite : Form
    {
        public int id;
        Visite uneVisite;
        public FrmModifierVisite(Visite uneVisite)
        {
            InitializeComponent();

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;

            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;

            id = uneVisite.Id;

            GestionVisite.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleve.GetEleve();
            List<Medicament> liste2 = new List<Medicament>();
            liste2 = GestionMedicament.GetMedicament();
            // Rattachement de la List à la source de données du comboBox

            comboBox1.ValueMember = "Id";

            comboBox1.DisplayMember = "Full_name";

            if (uneVisite.Medicament != null)
            {
                checkBox4.Checked = true;
                comboBox2.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                checkBox4.Checked = false;
                comboBox2.Visible = false;
                numericUpDown1.Visible = false;
            }

            comboBox1.DataSource = liste;
            comboBox1.Text = uneVisite.Eleve.Full_name;
            dateTimePicker1.Value = uneVisite.Date;
            dateTimePicker2.Value = DateTime.Now.Add(uneVisite.Heure_debut);
            dateTimePicker3.Value = DateTime.Now.Add(uneVisite.Heure_fin);
            checkBox1.Checked = uneVisite.Parent;
            checkBox2.Checked = uneVisite.Maison;
            checkBox3.Checked = uneVisite.Hopital;
            comboBox2.DataSource = liste2;
            comboBox2.Text = uneVisite.Medicament.Nom;
            numericUpDown1.Value = uneVisite.Medicament.Quantite;
            richTextBox1.Text = uneVisite.Motif;
            richTextBox2.Text = uneVisite.Commentaire;
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(dateTimePicker1.Value, DateTime.Now) < 0)
                {
                    if (dateTimePicker2.Value <= dateTimePicker3.Value)
                    {
                        if (checkBox4.Checked == true)
                        {
                            Visite uneVisite = new Visite(id, dateTimePicker1.Value, dateTimePicker2.Value.TimeOfDay, dateTimePicker3.Value.TimeOfDay, richTextBox1.Text, richTextBox2.Text,
                        checkBox2.Checked, checkBox3.Checked, checkBox1.Checked, (Medicament)comboBox2.SelectedItem, (int)numericUpDown1.Value, (Eleve)comboBox1.SelectedItem);

                            GestionVisite.ModifierVisite(uneVisite);

                            MessageBox.Show("Votre saisie a bien été modifiée.");

                            this.Hide();
                            var visiteFrm = new FrmModificationVisite();
                            visiteFrm.FormClosed += (s, args) => this.Close();
                            visiteFrm.Show();
                        }
                        else
                        {
                            Visite uneVisite = new Visite(id, dateTimePicker1.Value, dateTimePicker2.Value.TimeOfDay, dateTimePicker3.Value.TimeOfDay, richTextBox1.Text, richTextBox2.Text,
                        checkBox2.Checked, checkBox3.Checked, checkBox1.Checked, (Medicament)comboBox2.SelectedItem, (int)numericUpDown1.Value, (Eleve)comboBox1.SelectedItem);

                            GestionVisite.ModifierVisiteSansMedic(uneVisite);

                            MessageBox.Show("Votre saisie a bien été modifiée.");

                            this.Hide();
                            var visiteFrm = new FrmModificationVisite();
                            visiteFrm.FormClosed += (s, args) => this.Close();
                            visiteFrm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer une date valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("L'heure de début ne peut pas être supérieure à l'heure de fin", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Impossible de modifier la visite");
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                comboBox2.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                numericUpDown1.Visible = false;
            }
        }
    }
}
