using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Diplome
    {
        private int id_diplome;
        private string libelle_diplome;

        public Diplome()
        {
        }

        public Diplome(int id)
        {
            this.id_diplome = id;
        }
        public Diplome(string libelle)
        {
            this.libelle_diplome = libelle;
        }
        public Diplome(int id, string libelle)
        {
            this.id_diplome = id;
            this.libelle_diplome = libelle;
        }

        public int Id_diplome { get => id_diplome; set => id_diplome = value; }
        public string Libelle_diplome { get => libelle_diplome; set => libelle_diplome = value; }
        public override string ToString()
        {
            return this.Libelle_diplome;
        }
    }
}
