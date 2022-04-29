using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GestionInfirmerieBO;
using GestionInfirmerieDAL;

namespace GestionInfirmerieBLL
{
    public class GestionDiplome
    {
        private static GestionDiplome uneGestionDiplome; // objet BLL

        // Accesseur en lecture
        public static GestionDiplome GetGestionDiplome()
        {
            if (uneGestionDiplome == null)
            {
                uneGestionDiplome = new GestionDiplome();
            }
            return uneGestionDiplome;
        }
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets élève en faisant appel à la méthode GetEleve() de la DAL
        public static List<Diplome> GetDiplome()
        {
            return DiplomeDAO.GetDiplome();
        }
    }
}
