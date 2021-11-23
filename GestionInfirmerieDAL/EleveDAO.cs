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
            cmd.CommandText = " SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_eleve"].ToString());
                if (monReader["id_eleve"] == DBNull.Value)
                {
                    id = default(int);
                    nom = default(string);
                    prenom = default(string);
                    date_naissance_eleve = default(DateTime);
                    num_portable_eleve = default(string);
                    num_tel_parent_eleve = default(string);
                    tiers_temps_eleve = default(bool);
                    commentaire_sante_eleve = default(string);
                    libelle_classe = default(string);
                }
                else
                {
                    nom = monReader["nom_eleve"].ToString();
                    prenom = monReader["prenom_eleve"].ToString();
                    date_naissance_eleve = (DateTime)monReader["date_naissance_eleve"];
                    num_portable_eleve = monReader["num_portable_eleve"].ToString();
                    num_tel_parent_eleve = monReader["num_tel_parent_eleve"].ToString();
                    tiers_temps_eleve = (bool)monReader["tiers_temps_eleve"];
                    commentaire_sante_eleve = monReader["commentaire_sante_eleve"].ToString();
                    libelle_classe = monReader["libelle_classe"].ToString();
                }
                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve, 
                    commentaire_sante_eleve, libelle_classe);
                lesEleves.Add(unEleve);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        // Cette méthode insert un nouvel eleve passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ELEVE values('" + unEleve.Nom + unEleve.Prenom + unEleve.Date_naissance + unEleve.Num_portable +
                unEleve.Num_portable_parent + unEleve.Tiers_temps + unEleve.Commentaire_sante + "')";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode modifie un eleve passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVE SET nom_eleve = '" + unEleve.Nom + "' prenom_eleve = '" + unEleve.Prenom + "' date_naissance_eleve = '" + unEleve.Date_naissance + "'" +
                " num_portable_eleve = '" + unEleve.Num_portable + "' num_tel_parent_eleve = '" + unEleve.Num_portable_parent + "' tiers_temps_eleve = '" + unEleve.Tiers_temps + "'" +
                " commenataire_sante_eleve = '" + unEleve.Commentaire_sante + "' WHERE id_eleve = " + unEleve.Id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un eleve dont l'id est passé en paramètre
        public static int DeleteEleve(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVE WHERE id_eleve = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}


