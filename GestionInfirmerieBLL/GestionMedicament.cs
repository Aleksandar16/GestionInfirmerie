using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieDAL; // Référence la couche DAL
using GestionInfirmerieBO; // Référence la couche BO
using System.Configuration;

namespace GestionInfirmerieBLL
{
    public class GestionMedicament
    {
        private static GestionMedicament uneGestionMedicament; // objet BLL

        // Accesseur en lecture
        public static GestionMedicament GetGestionMedicament()
        {
            if (uneGestionMedicament == null)
            {
                uneGestionMedicament = new GestionMedicament();
            }
            return uneGestionMedicament;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets élève en faisant appel à la méthode GetEleve() de la DAL
        public static List<Medicament> GetMedicament()
        {
            return MedicamentDAO.GetMedicament();
        }
        // Méthode qui renvoit une List d'objets élève en faisant appel à la méthode GetUnEleve() de la DAL
        public static List<Medicament> GetUnMedicament(string Nom)
        {
            return MedicamentDAO.GetUnMedicament(Nom);
        }

        // Méthode qui cherche un élève avec la méthode TrouverEleve(Nom) de la DAL
        public static bool ChercherMedicament(string Nom)
        {
            return MedicamentDAO.TrouverMedicament(Nom);
        }
        // Méthode qui renvoi l’objet élève en l'ajoutant à la
        // BD avec la méthode AjoutEleve(unEleve) de la DAL
        public static int CreerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.AjoutMedicament(unMedicament);
        }
        // Méthode qui modifie un nouvel élève avec la méthode UpdateEleve de la DAL
        public static int ModifierMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.UpdateMedicament(unMedicament);
        }
        // Méthode qui modifie un nouvel élève avec la méthode UpdateEleve de la DAL
        public static Medicament InfoModifierMedicament(Medicament MedicamentId)
        {
            return MedicamentDAO.GetMedicamentModif(MedicamentId);
        }
        // Méthode qui supprime un élève avec la méthode DeleteEleve de la DAL
        public static int SupprimerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.DeleteMedicament(unMedicament);
        }
    }
}
