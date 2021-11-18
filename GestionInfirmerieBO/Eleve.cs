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
        private int Num_portable_eleve;
        private int Num_portable_parent_eleve;
        private bool Tiers_temps_eleve;
        private string Commentaire_sante_eleve;
        private int Id_classe_eleve;

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, int num_portable_eleve,
            int num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, int id_classe_eleve)
        {
            Id_eleve = id_eleve;
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_naissance_eleve = date_naissance_eleve;
            Num_portable_eleve = num_portable_eleve;
            Num_portable_parent_eleve = num_portable_parent_eleve;
            Tiers_temps_eleve = tiers_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Id_classe_eleve = id_classe_eleve;
        }

        public int Id { get => Id_eleve; set => Id_eleve = value; }
        public string Nom { get => Nom_eleve; set => Nom_eleve = value; }
        public string Prenom { get => Prenom_eleve; set => Prenom_eleve = value; }
        public DateTime Date_naissance { get => Date_naissance_eleve; set => Date_naissance_eleve = value; }
        public int Num_portable { get => Num_portable_eleve; set => Num_portable_eleve = value; }
        public int Num_portable_parent { get => Num_portable_parent_eleve; set => Num_portable_parent_eleve = value; }
        public bool Tiers_temps { get => Tiers_temps_eleve; set => Tiers_temps_eleve = value; }
        public string Commentaire_sante { get => Commentaire_sante_eleve; set => Commentaire_sante_eleve = value; }
        public int Id_classe { get => Id_classe_eleve; set => Id_classe_eleve = value; }
    }
}
