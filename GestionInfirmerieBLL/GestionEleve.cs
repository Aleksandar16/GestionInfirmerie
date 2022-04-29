using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GestionInfirmerieBO;
using GestionInfirmerieDAL;

namespace GestionInfirmerieBLL
{
    public class GestionEleve
    {
        private static GestionEleve uneGestionEleve; // objet BLL

        // Accesseur en lecture
        public static GestionEleve GetGestionEleve()
        {
            if (uneGestionEleve == null)
            {
                uneGestionEleve = new GestionEleve();
            }
            return uneGestionEleve;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets élève en faisant appel à la méthode GetEleve() de la DAL
        public static List<Eleve> GetEleve()
        {
            return EleveDAO.GetEleve();
        }
        // Méthode qui renvoit une List d'objets élève en faisant appel à la méthode GetUnEleve() de la DAL
        public static List<Eleve> GetUnEleve(string Nom)
        {
            return EleveDAO.GetUnEleve(Nom);
        }

        // Méthode qui cherche un élève avec la méthode TrouverEleve(Nom) de la DAL
        public static bool ChercherEleve(string Nom)
        {
            return EleveDAO.TrouverEleve(Nom);
        }
        // Méthode qui renvoi l’objet élève en l'ajoutant à la
        // BD avec la méthode AjoutEleve(unEleve) de la DAL
        public static int CreerEleve(Eleve unEleve)
        {
            return EleveDAO.AjoutEleve(unEleve);
        }

        public static int CreerEleveDiplome(Eleve unEleve)
        {
            return EleveDAO.AjoutEleveDiplome(unEleve);
        }
        // Méthode qui modifie un nouvel élève avec la méthode UpdateEleve de la DAL
        public static int ModifierEleve(Eleve unEleve)
        {
            return EleveDAO.UpdateEleve(unEleve);
        }
        // Méthode qui modifie un nouvel élève avec la méthode UpdateEleve de la DAL
        public static Eleve InfoModifierEleve(Eleve EleveId)
        {
            return EleveDAO.GetEleveModif(EleveId);
        }
        // Méthode qui supprime un élève avec la méthode DeleteEleve de la DAL
        public static int SupprimerEleve(Eleve unEleve)
        {
            return EleveDAO.DeleteEleve(unEleve);
        }
    }
}
