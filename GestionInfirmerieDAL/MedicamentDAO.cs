using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class MedicamentDAO
    {
        private static MedicamentDAO unMedicamentDAO;
        // Accesseur en lecture, renvoi une instance
        public static MedicamentDAO GetunMedicamentDAO()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }
            return unMedicamentDAO;
        }

        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table ELEVE
        public static List<Medicament> GetMedicament()
        {
            int id;
            string nom;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Medicament> lesMedicaments = new List<Medicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM MEDICAMENT";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_medicament"];
                nom = monReader["nom_medicament"].ToString();

                unMedicament = new Medicament(id, nom);
                lesMedicaments.Add(unMedicament);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }

        public static List<Medicament> GetUnMedicament(string Nom)
        {
            int id;
            string nom;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Medicament> lesMedicaments = new List<Medicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = Nom;
            cmd.CommandText = "SELECT * FROM MEDICAMENT WHERE nom_medicament = @Param1";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_medicament"];
                nom = monReader["nom_medicament"].ToString();

                unMedicament = new Medicament(id, nom);
                lesMedicaments.Add(unMedicament);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }


        public static Medicament GetMedicamentModif(Medicament MedicamentId)
        {
            int id;
            string nom;
            
            Medicament unMedicament = new Medicament();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = MedicamentId;
            cmd.CommandText = "SELECT * FROM MEDICAMENT WHERE id_medicament = @Param1";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_medicament"];
                nom = monReader["nom_medicament"].ToString();
                
                unMedicament = new Medicament(id, nom);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return unMedicament;
        }

        public static bool TrouverMedicament(string Nom)
        {
            foreach (Medicament unMedicament in GetUnMedicament(Nom))
            {
                if (Nom == unMedicament.Nom)
                {
                    return true;
                }
            }

            return false;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutMedicament(Medicament unMedicament)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
           ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = unMedicament.Nom;
            cmd.CommandText = "INSERT INTO MEDICAMENT values(@Nom)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un élève passé en paramètre dans la BD
        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters["@Id"].Value = unMedicament.Id;
            cmd.Parameters["@Nom"].Value = unMedicament.Nom;
            cmd.CommandText = "UPDATE MEDICAMENT SET nom_medicament = @Nom WHERE id_medicament = @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un élève passé en paramètre
        public static int DeleteMedicament(Medicament unMedicament)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unMedicament.Id;
            cmd.CommandText = "DELETE FROM MEDICAMENT WHERE id_medicament = @Id";
            try
            {
                nbEnr = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
