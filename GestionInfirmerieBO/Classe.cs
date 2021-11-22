using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Classe
    {
        private int Id_classe;
        private string Libelle_classe;
        public Classe(string libelle_classe)
        {
            Libelle_classe = Libelle;
        }
        public Classe(int Id, string Libelle)
        {
            Id_classe = Id;
            Libelle_classe = Libelle;
        }

        public int Id { get => Id_classe; set => Id_classe = value; }
        public string Libelle { get => Libelle_classe; set => Libelle_classe = value; }
    }
}
