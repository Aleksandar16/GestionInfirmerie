using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Utilisateur
    {
        private int id;
        private string login;
        private string mdp;

        // variables de stockage de l'utilisateur connecté
        private static Utilisateur utilisateurLog;

        public Utilisateur()
        {

        }
        public Utilisateur(int id)
        {
            this.id = id;
        }
        public Utilisateur(int id, string login)
        {
            this.id = id;
            this.login = login;
        }
        public Utilisateur(string login, string mdp)
        {
            this.login = login;
            this.mdp = mdp;
        }
        public Utilisateur(int id, string login, string mdp)
        {
            this.id = id;
            this.login = login;
            this.mdp = mdp;
        }

        public int Id { get => this.id; set => this.id = value; }

        public string Login { get => login; set => login = value; }

        public string Mdp { get => mdp; set => mdp = value; }

        public static Utilisateur UtilisateurLog { get => utilisateurLog; set => utilisateurLog = value; }
    }
}
