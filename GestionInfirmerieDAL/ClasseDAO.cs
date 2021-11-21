using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class ClasseDAO
    {
        private static ClasseDAO uneClasseDAO;
        // Accesseur en lecture, renvoi une instance
        public static ClasseDAO GetuneClasseDAO()
        {
            if (uneClasseDAO == null)
            {
                uneClasseDAO = new ClasseDAO();
            }
            return uneClasseDAO;
        }

        // Cette méthode retourne une List contenant les objets Classe contenus dans la table CLASSE
        public static List<Classe> GetClasse()
        {
            int id;
            string libelle;
            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Classe
            List<Classe> lesClasses = new List<Classe>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM CLASSE";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_classe"].ToString());
                if (monReader["libelle_classe"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle_classe"].ToString();
                }
                uneClasse = new Classe(id, libelle);
                lesClasses.Add(uneClasse);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesClasses;
        }
    }
}


