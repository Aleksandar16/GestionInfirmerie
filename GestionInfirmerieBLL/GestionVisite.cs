using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GestionInfirmerieBO;
using GestionInfirmerieDAL;

namespace GestionInfirmerieBLL
{
    public class GestionVisite
    {
        private static GestionVisite uneGestionVisite; // objet BLL

        // Accesseur en lecture
        public static GestionVisite GetGestionVisite()
        {
            if (uneGestionVisite == null)
            {
                uneGestionVisite = new GestionVisite();
            }
            return uneGestionVisite;
        }
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static int CreerVisiteMedic(Visite uneVisite)
        {
            return VisiteDAO.AjoutVisiteMedic(uneVisite);
        }
        public static int CreerVisite(Visite uneVisite)
        {
            return VisiteDAO.AjoutVisite(uneVisite);
        }
        public static List<Visite> GetVisite()
        {
            return VisiteDAO.GetVisite();
        }
    }
}
