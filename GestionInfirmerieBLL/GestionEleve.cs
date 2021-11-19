using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionInfirmerie
    {
        private static GestionInfirmerie uneGestionInfirmerie; // objet BLL

        // Accesseur en lecture
        public static GestionInfirmerie GetGestionInfirmerie()
        {
            if (uneGestionInfirmerie == null)
            {
                uneGestionInfirmerie = new GestionInfirmerie();
            }
            return uneGestionInfirmerie;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Eleve> GetEleve()
        {
            return GestionInfirmerieDAO.GetEleve();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerEleve(Eleve ut)
        {
            return GestionInfirmerieDAO.AjoutEleve(ut);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Eleve ut)
        {
            return GestionInfirmerieDAO.UpdateEleve(ut);
        }
        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return GestionInfirmerieDAO.DeleteEleve(id);
        }
    }
}
