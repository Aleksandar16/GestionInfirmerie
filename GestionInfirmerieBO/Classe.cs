using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Classe
    {
        private int id_classe;
        private string libelle_classe;
        public Classe() { }
        public Classe(string libelle_classe)
        {
            this.libelle_classe = Libelle;
        }
        public Classe(int id, string libelle)
        {
            id_classe = Id;
            libelle_classe = Libelle;
        }

        public int Id { get => id_classe; set => id_classe = value; }
        public string Libelle { get => libelle_classe; set => libelle_classe = value; }
    }
}
