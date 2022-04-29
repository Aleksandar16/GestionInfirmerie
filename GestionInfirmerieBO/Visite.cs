using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Visite
    {
        private int Id_visite;
        private DateTime Date_visite;
        private TimeSpan Heure_debut_visite;
        private TimeSpan Heure_fin_visite;
        private string Motif_visite;
        private string Commentaire_visite;
        private bool Maison_visite;
        private bool Hopital_visite;
        private bool Parent_visite;
        private Medicament Medicament_visite;
        private int Quantite_Medic_visite;
        private Eleve Eleve_visite;
        private Classe Classe_visite;
        public Visite()
        {

        }
        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite, string motif_visite, string commentaire_visite,
            bool maison_visite, bool hopital_visite, bool parent_visite, Medicament medicament_visite, int quantite_medic_visite, Eleve eleve_visite)
        {
            this.Id_visite = id_visite;
            this.Date_visite = date_visite;
            this.Heure_debut_visite = heure_debut_visite;
            this.Heure_fin_visite = heure_fin_visite;
            this.Motif_visite = motif_visite;
            this.Commentaire_visite = commentaire_visite;
            this.Maison_visite = maison_visite;
            this.Hopital_visite = hopital_visite;
            this.Parent_visite = parent_visite;
            this.Medicament_visite = medicament_visite;
            this.Quantite_Medic_visite = quantite_medic_visite;
            this.Eleve_visite = eleve_visite;
        }
        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite, string motif_visite, string commentaire_visite,
            bool maison_visite, bool hopital_visite, bool parent_visite, Eleve eleve_visite)
        {
            this.Id_visite = id_visite;
            this.Date_visite = date_visite;
            this.Heure_debut_visite = heure_debut_visite;
            this.Heure_fin_visite = heure_fin_visite;
            this.Motif_visite = motif_visite;
            this.Commentaire_visite = commentaire_visite;
            this.Maison_visite = maison_visite;
            this.Hopital_visite = hopital_visite;
            this.Parent_visite = parent_visite;
            this.Eleve_visite = eleve_visite;
        }
        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite, string motif_visite, string commentaire_visite,
            bool maison_visite, bool hopital_visite, bool parent_visite, Medicament medicament_visite, int quantite_medic_visite, Eleve eleve_visite, Classe classe_visite)
        {
            this.Id_visite = id_visite;
            this.Date_visite = date_visite;
            this.Heure_debut_visite = heure_debut_visite;
            this.Heure_fin_visite = heure_fin_visite;
            this.Motif_visite = motif_visite;
            this.Commentaire_visite = commentaire_visite;
            this.Maison_visite = maison_visite;
            this.Hopital_visite = hopital_visite;
            this.Parent_visite = parent_visite;
            this.Medicament_visite = medicament_visite;
            this.Quantite_Medic_visite = quantite_medic_visite;
            this.Eleve_visite = eleve_visite;
            this.Classe_visite = classe_visite;
        }

        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite, string motif_visite, string commentaire_visite,
            bool maison_visite, bool hopital_visite, bool parent_visite, Eleve eleve_visite, Classe classe_visite)
        {
            this.Id_visite = id_visite;
            this.Date_visite = date_visite;
            this.Heure_debut_visite = heure_debut_visite;
            this.Heure_fin_visite = heure_fin_visite;
            this.Motif_visite = motif_visite;
            this.Commentaire_visite = commentaire_visite;
            this.Maison_visite = maison_visite;
            this.Hopital_visite = hopital_visite;
            this.Parent_visite = parent_visite;
            this.Eleve_visite = eleve_visite;
            this.Classe_visite = classe_visite;
        }

        public int Id { get => Id_visite; set => Id_visite = value; }
        public DateTime Date { get => Date_visite; set => Date_visite = value; }
        public TimeSpan Heure_debut { get => Heure_debut_visite; set => Heure_debut_visite = value; }
        public TimeSpan Heure_fin { get => Heure_fin_visite; set => Heure_fin_visite = value; }
        public string Motif { get => Motif_visite; set => Motif_visite = value; }
        public string Commentaire { get => Commentaire_visite; set => Commentaire_visite = value; }
        public bool Maison { get => Maison_visite; set => Maison_visite = value; }
        public bool Hopital { get => Hopital_visite; set => Hopital_visite = value; }
        public bool Parent { get => Parent_visite; set => Parent_visite = value; }
        public Medicament Medicament { get => Medicament_visite; set => Medicament_visite = value; }
        public int Quantite_Medic { get => Quantite_Medic_visite; set => Quantite_Medic_visite = value; }
        public Eleve Eleve { get => Eleve_visite; set => Eleve_visite = value; }
        public Classe Classe { get => Classe_visite; set => Classe_visite = value; }

        public override int GetHashCode()
        {
            return this.Quantite_Medic;
        }
    }
}
