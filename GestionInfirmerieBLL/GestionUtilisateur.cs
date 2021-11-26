using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using GestionInfirmerieDAL; // Référence la couche DAL
using GestionInfirmerieBO; // Référence la couche BO

namespace GestionInfirmerieBLL
{
    public class GestionUtilisateur
    {
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        //
        public static bool ConnexionUtilisateur(string login, string mdp)
        {
            return UtilisateurDAO.ConnexionUtilisateur(login, mdp);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateur()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }
        //
        //public static Utilisateur logUtilisateur(string login)
        //{
        //return UtilisateurDAO.GetUtilisateurLog(login);
        //}
    }
}
