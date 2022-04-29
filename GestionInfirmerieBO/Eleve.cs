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
        /*private string Libelle_classe;
        private int Id_Classe_Eleve;*/
        private Classe Classe;
        private List<Diplome> diplomes;

        //Sauvegarde de l'id de l'élève pour appliquer les modifications et la suppression
        private static Eleve eleveId;
        
        public Eleve()
        { }
        public Eleve(int id_eleve)
        {
            this.Id_eleve = id_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, string num_portable_eleve,
            string num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, Classe classe /*int id_classe_eleve*/)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance_eleve = date_naissance_eleve;
            this.Num_portable_eleve = num_portable_eleve;
            this.Num_portable_parent_eleve = num_portable_parent_eleve;
            this.Tiers_temps_eleve = tiers_temps_eleve;
            this.Commentaire_sante_eleve = commentaire_sante_eleve;
            /*this.Id_Classe_Eleve = id_classe_eleve;*/
            this.Classe = classe;
        }
        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, string num_portable_eleve,
            string num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, Classe classe /*int id_classe_eleve*/, List<Diplome> diplomes)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance_eleve = date_naissance_eleve;
            this.Num_portable_eleve = num_portable_eleve;
            this.Num_portable_parent_eleve = num_portable_parent_eleve;
            this.Tiers_temps_eleve = tiers_temps_eleve;
            this.Commentaire_sante_eleve = commentaire_sante_eleve;
            /*this.Id_Classe_Eleve = id_classe_eleve;*/
            this.Classe = classe;
            this.diplomes = diplomes;
        }

        public Eleve(string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, string num_portable_eleve,
            string num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, Classe classe /*int id_classe_eleve*/, List<Diplome> diplomes)
        {
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance_eleve = date_naissance_eleve;
            this.Num_portable_eleve = num_portable_eleve;
            this.Num_portable_parent_eleve = num_portable_parent_eleve;
            this.Tiers_temps_eleve = tiers_temps_eleve;
            this.Commentaire_sante_eleve = commentaire_sante_eleve;
            /*this.Id_Classe_Eleve = id_classe_eleve;*/
            this.Classe = classe;
            this.diplomes = diplomes;
        }

        /*public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_naissance_eleve, string num_portable_eleve,
            string num_portable_parent_eleve, bool tiers_temps_eleve, string commentaire_sante_eleve, string libelle_classe)
        {
            this.Id_eleve = id_eleve;
            this.Nom_eleve = nom_eleve;
            this.Prenom_eleve = prenom_eleve;
            this.Date_naissance_eleve = date_naissance_eleve;
            this.Num_portable_eleve = num_portable_eleve;
            this.Num_portable_parent_eleve = num_portable_parent_eleve;
            this.Tiers_temps_eleve = tiers_temps_eleve;
            this.Commentaire_sante_eleve = commentaire_sante_eleve;
            this.Libelle_classe = libelle_classe;
        }*/

        public int Id { get => this.Id_eleve; set => this.Id_eleve = value; }
        public string Nom { get => this.Nom_eleve; set => this.Nom_eleve = value; }
        public string Prenom { get => this.Prenom_eleve; set => this.Prenom_eleve = value; }
        public DateTime Date_naissance { get => this.Date_naissance_eleve; set => this.Date_naissance_eleve = value; }
        public string Num_portable { get => this.Num_portable_eleve; set => this.Num_portable_eleve = value; }
        public string Num_portable_parent { get => this.Num_portable_parent_eleve; set => this.Num_portable_parent_eleve = value; }
        public bool Tiers_temps { get => this.Tiers_temps_eleve; set => this.Tiers_temps_eleve = value; }
        public string Commentaire_sante { get => this.Commentaire_sante_eleve; set => this.Commentaire_sante_eleve = value; }
        public static Eleve EleveId { get => eleveId; set => eleveId = value; }
        /*public string Libelle { get => this.Libelle_classe; set => this.Libelle_classe = value; }
        public int Id_Classe { get => this.Id_Classe_Eleve; set => this.Id_Classe_Eleve = value; }*/
        public Classe Classe_Eleve { get => Classe; set => Classe = value; }
        public string Full_name {
            get
            {
                return Nom + " " + Prenom;
            }
        }

        public List<Diplome> Diplomes { get => diplomes; set => diplomes = value; }

        public override string ToString()
        {
            return this.Full_name;
        }
    }
}
