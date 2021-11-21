using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL; // Référence la couche DAL

namespace GestionInfirmerieBLL
{
    public class GestionClasse
    {
        private static GestionClasse uneGestionClasse; // objet BLL

        // Accesseur en lecture
        public static GestionClasse GetGestionClasse()
        {
            if (uneGestionClasse == null)
            {
                uneGestionClasse = new GestionClasse();
            }
            return uneGestionClasse;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Classe en faisant appel à la méthode GetClasse() de la DAL
        public static List<Classe> GetClasse()
        {
            return ClasseDAO.GetClasse();
        }
    }
}
