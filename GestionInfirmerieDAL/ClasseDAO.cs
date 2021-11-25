using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;
using System.Data;

namespace GestionInfirmerieDAL
{
    public class ClasseDAO
    {
        // Cette méthode permet de récupérer les données d'une classe
        // retourne une classe
        public static Classe GetClasse(int id)
        {
            string libelle;

            Classe classe = new Classe();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLASSE WHERE id_classe = @id_classe";

            cmd.Parameters.Add(new SqlParameter("@id_classe", SqlDbType.Int));
            cmd.Parameters["@id_classe"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id_classe"];

                libelle = monReader["libelle_classe"].ToString();

                classe = new Classe(id, libelle);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return classe;
        }
        // Cette méthode permet de recupère l'ensemble des classes
        // retourne une liste de classe
        public static List<Classe> GetLesClasses()
        {
            int id;
            string libelle;
            List<Classe> LesClasses = new List<Classe>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLASSE";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id_classe"];

                libelle = monReader["libelle_classe"].ToString();

                Classe classe = new Classe(id, libelle);
                LesClasses.Add(classe);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return LesClasses;
        }
    }
}


