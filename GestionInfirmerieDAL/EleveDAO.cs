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
            Classe classe;
            List<Diplome> diplomes = new List<Diplome>();
            Diplome diplome;

            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT ELEVE.*, CLASSE.* FROM ELEVE INNER JOIN CLASSE ON CLASSE.id_classe = ELEVE.id_classe;";
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
                /*libelle_classe = monReader["libelle_classe"].ToString();*/
                classe = new Classe((int)monReader["id_classe"],monReader["libelle_classe"].ToString());

                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve, 
                    commentaire_sante_eleve, classe);
                lesEleves.Add(unEleve);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            for (int i = 0; i < lesEleves.Count(); i++)
            {
                int idEleve = lesEleves[i].Id;

                maConnexion.Open();

                string Id = "@id" + i;

                cmd.CommandText = "SELECT DIPLOME.*, POSSEDER.* FROM DIPLOME, POSSEDER WHERE DIPLOME.id_diplome = POSSEDER.id_diplome AND POSSEDER.id_eleve = " + Id;

                cmd.Parameters.AddWithValue(Id, idEleve);

                monReader = cmd.ExecuteReader();

                while (monReader.Read())
                {
                    diplome = new Diplome((int)monReader["id_diplome"], monReader["libelle_diplome"].ToString());
                    if (diplome == null)
                    {
                        diplome = new Diplome(0, "Aucun");
                    }
                    diplomes.Add(diplome);
                }
                lesEleves[i].Diplomes = diplomes;
                maConnexion.Close();

            }

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
            /*string libelle_classe;*/
            Classe libelle_classe;

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
                /*libelle_classe = monReader["libelle_classe"].ToString();*/
                libelle_classe = new Classe((int)monReader["id_classe"]);

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
            /*string libelle_classe;*/
            Classe libelle_classe;

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
                /*libelle_classe = monReader["libelle_classe"].ToString();*/
                libelle_classe = new Classe((int)monReader["id_classe"]);

                unEleve = new Eleve(id, nom, prenom, date_naissance_eleve, num_portable_eleve, num_tel_parent_eleve, tiers_temps_eleve,
                    commentaire_sante_eleve, libelle_classe);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return unEleve;
        }

        public static List<Eleve> GetElevesName(string name)
        {
            int id;
            string nom;
            string prenom;
            DateTime dateNaissance;
            string portableEleve;
            int idClasse;
            string libelleClasse;
            string telParent;
            bool tiersTemps;
            string commentaireSante;
            Eleve unEleve;


            List<Eleve> lesEleves = new List<Eleve>();

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT ELEVE.*, CLASSE.* FROM ELEVE, CLASSE WHERE CLASSE.id_classe = ELEVE.id_classe AND ELEVE.nom_eleve LIKE '' + @name + '%'";
            cmd.Parameters.AddWithValue("@name", name);

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["id_eleve"].ToString());
                nom = monReader["nom_eleve"].ToString();
                prenom = monReader["prenom_eleve"].ToString();
                dateNaissance = DateTime.Parse(monReader["date_naissance_eleve"].ToString());
                portableEleve = monReader["num_portable_eleve"].ToString();
                idClasse = Int32.Parse(monReader["id_classe"].ToString());
                libelleClasse = monReader["libelle_classe"].ToString();
                telParent = monReader["num_tel_parent_eleve"].ToString();
                if (monReader["tiers_temps_eleve"].ToString() == "True")
                {
                    tiersTemps = true;
                }
                else
                {
                    tiersTemps = false;
                }
                commentaireSante = monReader["commentaire_sante_eleve"].ToString();

                Classe uneClasse = new Classe(idClasse, libelleClasse);

                unEleve = new Eleve(id, nom, prenom, dateNaissance, portableEleve, telParent, tiersTemps, commentaireSante, uneClasse);
                lesEleves.Add(unEleve);
            }
            maConnexion.Close();

            return lesEleves;
        }

        // Cette méthode insert un nouvel élève passé en paramètre dans la BD
        public static int AjoutEleve(Eleve unEleve)
        {
            /*cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = EleveId;
            cmd.CommandText = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe AND id_eleve = @Param1";*/
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Prenom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@DateNaissance", System.Data.SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@NumTelEleve", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@NumTelParent", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@TiersTemps", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@CommentaireSante", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@IdClasse", System.Data.SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = unEleve.Nom;
            cmd.Parameters["@Prenom"].Value = unEleve.Prenom;
            cmd.Parameters["@DateNaissance"].Value = unEleve.Date_naissance;
            cmd.Parameters["@NumTelEleve"].Value = unEleve.Num_portable;
            cmd.Parameters["@NumTelParent"].Value = unEleve.Num_portable_parent;
            cmd.Parameters["@TiersTemps"].Value = unEleve.Tiers_temps;
            cmd.Parameters["@CommentaireSante"].Value = unEleve.Commentaire_sante;
            /*cmd.Parameters["@IdClasse"].Value = unEleve.Id_Classe;*/
            cmd.Parameters["@IdClasse"].Value = unEleve.Classe_Eleve.Id;
            cmd.CommandText = "INSERT INTO ELEVE values(@Nom, @Prenom, @DateNaissance, @NumTelEleve, @NumTelParent, @TiersTemps, @CommentaireSante, @IdClasse)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

       /* public static int AjoutEleveDiplome(Eleve unEleve)
        {
            *//*cmd.Parameters.Add(new SqlParameter("@Param1", System.Data.SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = EleveId;
            cmd.CommandText = "SELECT * FROM ELEVE, CLASSE WHERE ELEVE.id_classe = CLASSE.id_classe AND id_eleve = @Param1";*//*
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Prenom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@DateNaissance", System.Data.SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@NumTelEleve", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@NumTelParent", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@TiersTemps", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@CommentaireSante", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@IdClasse", System.Data.SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = unEleve.Nom;
            cmd.Parameters["@Prenom"].Value = unEleve.Prenom;
            cmd.Parameters["@DateNaissance"].Value = unEleve.Date_naissance;
            cmd.Parameters["@NumTelEleve"].Value = unEleve.Num_portable;
            cmd.Parameters["@NumTelParent"].Value = unEleve.Num_portable_parent;
            cmd.Parameters["@TiersTemps"].Value = unEleve.Tiers_temps;
            cmd.Parameters["@CommentaireSante"].Value = unEleve.Commentaire_sante;
            *//*cmd.Parameters["@IdClasse"].Value = unEleve.Id_Classe;*//*
            cmd.Parameters["@IdClasse"].Value = unEleve.Classe_Eleve.Id;
            cmd.CommandText = "INSERT INTO ELEVE values(@Nom, @Prenom, @DateNaissance, @NumTelEleve, @NumTelParent, @TiersTemps, @CommentaireSante, @IdClasse)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();

            maConnexion.Open();
            cmd.CommandText = "SELECT MAX(id_eleve) AS 'id_eleve' FROM ELEVE ";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            int id = (int)sqlDataReader["id_eleve"];
            maConnexion.Close();

            for (int i = 0; i < unEleve.Diplomes.Count; i++)
            {
                maConnexion.Open();
                string id_eleve = "@Id_Eleve" + i;
                string id_diplome = "@Id_Diplome" + i;
                cmd.CommandText = "INSERT INTO POSSEDER (id_eleve,id_diplome) VALUES (" + id_eleve + "," + id_diplome + ")";
                cmd.Parameters.AddWithValue(id_eleve, id);
                cmd.Parameters.AddWithValue(id_diplome, unEleve.Diplomes[i].Id_diplome);

                cmd.ExecuteNonQuery();
                maConnexion.Close();
            }

            return nbEnr;
        }*/
        // Cette méthode modifie un élève passé en paramètre dans la BD
        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Prenom", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@DateNaissance", System.Data.SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@NumTelEleve", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@NumTelParent", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@TiersTemps", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@CommentaireSante", System.Data.SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@IdClasse", System.Data.SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unEleve.Id;
            cmd.Parameters["@Nom"].Value = unEleve.Nom;
            cmd.Parameters["@Prenom"].Value = unEleve.Prenom;
            cmd.Parameters["@DateNaissance"].Value = unEleve.Date_naissance;
            cmd.Parameters["@NumTelEleve"].Value = unEleve.Num_portable;
            cmd.Parameters["@NumTelParent"].Value = unEleve.Num_portable_parent;
            cmd.Parameters["@TiersTemps"].Value = unEleve.Tiers_temps;
            cmd.Parameters["@CommentaireSante"].Value = unEleve.Commentaire_sante;
            /*cmd.Parameters["@IdClasse"].Value = unEleve.Id_Classe;*/
            cmd.Parameters["@IdClasse"].Value = unEleve.Classe_Eleve.Id;
            cmd.CommandText = "UPDATE ELEVE SET nom_eleve = @Nom, prenom_eleve = @Prenom, date_naissance_eleve = @DateNaissance, num_portable_eleve = @NumTelEleve, num_tel_parent_eleve = @NumTelParent, tiers_temps_eleve = @TiersTemps, commentaire_sante_eleve = @CommentaireSante, id_classe = @IdClasse WHERE id_eleve =  + @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un élève passé en paramètre
        public static int DeleteEleve(int id)
        {
            int nbEnr;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVE WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@id", id);
            nbEnr = cmd.ExecuteNonQuery();
            maConnexion.Close();

            return nbEnr;
        }
    }
}


