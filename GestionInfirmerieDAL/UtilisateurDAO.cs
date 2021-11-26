using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;
using System.Data;

namespace GestionInfirmerieDAL
{
    public class UtilisateurDAO
    {
        public static List<Utilisateur> GetUtilisateurs()
        {
            int id;
            string login;
            string mdp;
            Utilisateur unUtilisateur;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM UTILISATEUR";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id"].ToString());

                if (monReader["id"] == DBNull.Value)
                {
                    login = default(string);
                    mdp = default(string);
                }
                else
                {
                    login = monReader["login"].ToString();
                    mdp = monReader["mdp"].ToString();
                }
                unUtilisateur = new Utilisateur(id, login, mdp);
                lesUtilisateurs.Add(unUtilisateur);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesUtilisateurs;
        }

        // Cette méthode permet de récupérer les données d'un utilisateur
        // retourne un utilisateur
        public static Utilisateur GetUtilisateur(int id)
        {
            string login;

            Utilisateur utilisateur = new Utilisateur();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM UTILISATEUR WHERE id = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id_utilisateur"];

                if (monReader["id_utilisateur"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["login_utilisateur"].ToString();
                }

                utilisateur = new Utilisateur(id, login);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return utilisateur;
        }

        // Cette méthode permet la connexion d'un utilisateur
        public static bool ConnexionUtilisateur(string login, string mdp)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT login_utilisateur, mot_de_passe_utilisateur FROM UTILISATEUR";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["login_utilisateur"].ToString() == login && monReader["mot_de_passe_utilisateur"].ToString() == mdp)
                {
                    monReader.Close();
                    maConnexion.Close();
                    return true;
                }
            }
            monReader.Close();
            maConnexion.Close();
            return false;
        }
    }

}
