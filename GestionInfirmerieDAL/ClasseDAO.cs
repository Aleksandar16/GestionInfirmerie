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

        public static Classe GetClasse(int id)
        {
            string libelle;

            Classe classe = new Classe();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM classe WHERE id_classe = @id";

            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = id;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = (int)monReader["id_classe"];

                if (monReader["id_classe"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["libelle_classe"].ToString();
                }

                classe = new Classe(id, libelle);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return classe;
        }

        // Cette méthode retourne une List contenant les objets Classe contenus dans la table CLASSE

        public static List<Classe> GetLesClasses()
        {
            int id;
            string libelle;
            Classe uneClasse;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<Classe> lesClasses = new List<Classe>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM CLASSE";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_classe"].ToString());

                if (monReader["Libelle_classe"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_classe"].ToString();
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


