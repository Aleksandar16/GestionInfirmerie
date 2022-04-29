using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class DiplomeDAO
    {
        private static DiplomeDAO unDiplomeDAO;
        // Accesseur en lecture, renvoi une instance
        public static DiplomeDAO GetunDiplomeDAO()
        {
            if (unDiplomeDAO == null)
            {
                unDiplomeDAO = new DiplomeDAO();
            }
            return unDiplomeDAO;
        }

        public static List<Diplome> GetDiplome()
        {
            int id;
            string libelle;

            Diplome unDiplome;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Diplome> lesDiplomes = new List<Diplome>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM DIPLOME";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = (int)monReader["id_diplome"];
                libelle = monReader["libelle_diplome"].ToString();

                unDiplome = new Diplome(id, libelle);
                lesDiplomes.Add(unDiplome);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesDiplomes;
        }
    }
}
