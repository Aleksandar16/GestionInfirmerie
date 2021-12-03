using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Medicament
    {
        private int Id_medicament;
        private string Nom_medicament;
        

        //Sauvegarde de l'id de l'élève pour appliquer les modifications et la suppression
        private static Medicament medicamentId;

        public Medicament()
        { }
        public Medicament(int id_medicament)
        {
            this.Id_medicament = id_medicament;
        }
        public Medicament(string nom_medicament)
        {
            this.Nom_medicament = nom_medicament;
            
        }
        public Medicament(int id_medicament, string nom_medicament)
        {
            this.Id_medicament = id_medicament;
            this.Nom_medicament = nom_medicament;
        }

        public int Id { get => this.Id_medicament; set => this.Id_medicament = value; }
        public string Nom { get => this.Nom_medicament; set => this.Nom_medicament = value; }
        
    }
}
