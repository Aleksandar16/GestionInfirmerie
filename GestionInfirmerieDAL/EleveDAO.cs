using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO;
        // Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }

        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table ELEVE
        public static List<Eleve> GetEleve()
        {
            int id;
            string nom;
            string prenom;
            DateTime date_naissance_eleve;
            string num_portable_eleve;
            string num_tel_parent_eleve;
            bool tiers_temps_eleve;
            string commentaire_sante_eleve;
            string libelle_classe;

            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_eleve"];
                nom = monReader["nom_eleve"].ToString();
                prenom = monReader["prenom_eleve"].ToString();
                date_naissance_eleve = (DateTime)monReader["date_naissance_eleve"];
                num_portable_eleve = monReader["num_portable_eleve"].ToString();
                num_tel_parent_eleve = monReader["num_tel_parent_eleve"].ToString();
                tiers_temps_eleve = (bool)monReader["tiers_temps_eleve"];
                commentaire_sante_eleve = monReader["commentaire_sante_eleve"].ToString();
                libelle_classe = monReader["libelle_classe"].ToString();

                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve, 
                    commentaire_sante_eleve, libelle_classe);
                lesEleves.Add(unEleve);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }
        public static List<Eleve> GetUnEleve(string Nom)
        {
            int id;
            string nom;
            string prenom;
            DateTime date_naissance_eleve;
            string num_portable_eleve;
            string num_tel_parent_eleve;
            bool tiers_temps_eleve;
            string commentaire_sante_eleve;
            string libelle_classe;

            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = Nom;
            cmd.CommandText = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe AND nom_eleve = @Param1";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_eleve"];
                nom = monReader["nom_eleve"].ToString();
                prenom = monReader["prenom_eleve"].ToString();
                date_naissance_eleve = (DateTime)monReader["date_naissance_eleve"];
                num_portable_eleve = monReader["num_portable_eleve"].ToString();
                num_tel_parent_eleve = monReader["num_tel_parent_eleve"].ToString();
                tiers_temps_eleve = (bool)monReader["tiers_temps_eleve"];
                commentaire_sante_eleve = monReader["commentaire_sante_eleve"].ToString();
                libelle_classe = monReader["libelle_classe"].ToString();

                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve,
                    commentaire_sante_eleve, libelle_classe);
                lesEleves.Add(unEleve);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        public static Eleve GetEleveModif(Eleve EleveId)
        {
            int id;
            string nom;
            string prenom;
            DateTime date_naissance_eleve;
            string num_portable_eleve;
            string num_tel_parent_eleve;
            bool tiers_temps_eleve;
            string commentaire_sante_eleve;
            string libelle_classe;

            Eleve unEleve = new Eleve();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = EleveId;
            cmd.CommandText = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe AND id_eleve = @Param1";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_eleve"];
                nom = monReader["nom_eleve"].ToString();
                prenom = monReader["prenom_eleve"].ToString();
                date_naissance_eleve = (DateTime)monReader["date_naissance_eleve"];
                num_portable_eleve = monReader["num_portable_eleve"].ToString();
                num_tel_parent_eleve = monReader["num_tel_parent_eleve"].ToString();
                tiers_temps_eleve = (bool)monReader["tiers_temps_eleve"];
                commentaire_sante_eleve = monReader["commentaire_sante_eleve"].ToString();
                libelle_classe = monReader["libelle_classe"].ToString();

                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve,
                    commentaire_sante_eleve, libelle_classe);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return unEleve;
        }

        public static bool TrouverEleve(string Nom)
        {
            foreach (Eleve unEleve in GetUnEleve(Nom))
            {
                if (Nom == unEleve.Nom)
                {
                    return true;
                }
            }

            return false;
        }

        // Cette méthode insert un nouvel élève passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ELEVE values('" + unEleve.Nom + "', '" + unEleve.Prenom + "', '" + unEleve.Date_naissance + "', '" + unEleve.Num_portable + "', '" +
                unEleve.Num_portable_parent + "', '" + unEleve.Tiers_temps + "', '" + unEleve.Commentaire_sante + "', '" + unEleve.Id_Classe_E + "', '" + unEleve.Id_Classe + "')";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un élève passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVE SET nom_eleve = '" + unEleve.Nom + "', prenom_eleve = '" + unEleve.Prenom + "', date_naissance_eleve = '" + unEleve.Date_naissance + "'" +
                ", num_portable_eleve = '" + unEleve.Num_portable + "', num_tel_parent_eleve = '" + unEleve.Num_portable_parent + "', tiers_temps_eleve = '" + unEleve.Tiers_temps + "'" +
                ", commentaire_sante_eleve = '" + unEleve.Commentaire_sante + "'" + ", id_classe_e = '" + unEleve.Id_Classe + "', id_classe = '" + unEleve.Id_Classe + "' WHERE id_eleve = " + unEleve.Id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un élève passé en paramètre
        public static int DeleteEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVE WHERE id_eleve = " + unEleve.Id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}


