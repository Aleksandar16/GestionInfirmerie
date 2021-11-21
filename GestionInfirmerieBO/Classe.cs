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
        public Classe() { }
        public Classe(int id)
        {
            this.Id_classe = id;
        }
        public Classe(int id, string libelle)
        {
            this.Id_classe = id;
            this.Libelle_classe = libelle;
        }

        public int Id { get => this.Id_classe; set => Id_classe = value; }
        public string Libelle { get => this.Libelle_classe; set => Libelle_classe = value; }
    }
}
