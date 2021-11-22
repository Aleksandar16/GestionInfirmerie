using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Eleve
    {
        private int Id_eleve;
        private string Nom_eleve;
        private string Prenom_eleve;
        private DateTime Date_naissance_eleve;
        private string Num_portable_eleve;
        private string Num_portable_parent_eleve;
        private bool Tiers_temps_eleve;
        private string Commentaire_sante_eleve;
        private Classe Id_classe_eleve;

        //Sauvegarde de l'id de l'élève pour appliquer les modifications et la suppression
        private static Eleve eleveId;

        public Eleve() { }
        public Eleve(int id)
        {
            this.Id = id;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, string num_portable_eleve,
            string num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, Classe id_classe_eleve)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance_eleve = date_naissance_eleve;
            this.Num_portable_eleve = num_portable_eleve;
            this.Num_portable_parent_eleve = num_portable_parent_eleve;
            this.Tiers_temps_eleve = tiers_temps_eleve;
            this.Commentaire_sante_eleve = commentaire_sante_eleve;
            this.Id_classe_eleve = id_classe_eleve;
        }

        public int Id { get => this.Id_eleve; set => this.Id_eleve = value; }
        public string Nom { get => this.Nom_eleve; set => this.Nom_eleve = value; }
        public string Prenom { get => this.Prenom_eleve; set => this.Prenom_eleve = value; }
        public DateTime Date_naissance { get => this.Date_naissance_eleve; set => this.Date_naissance_eleve = value; }
        public string Num_portable { get => this.Num_portable_eleve; set => this.Num_portable_eleve = value; }
        public string Num_portable_parent { get => this.Num_portable_parent_eleve; set => this.Num_portable_parent_eleve = value; }
        public bool Tiers_temps { get => this.Tiers_temps_eleve; set => this.Tiers_temps_eleve = value; }
        public string Commentaire_sante { get => this.Commentaire_sante_eleve; set => this.Commentaire_sante_eleve = value; }
        public static Eleve EleveId { get => eleveId; set => eleveId = value; }
        public Classe Id_classe { get => this.Id_classe_eleve; set => this.Id_classe_eleve = value; }
    }
}
