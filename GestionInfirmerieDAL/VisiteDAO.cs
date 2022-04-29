using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;

namespace GestionInfirmerieDAL
{
    public class VisiteDAO
    {
        private static VisiteDAO uneVisiteDAO;
        // Accesseur en lecture, renvoi une instance
        public static VisiteDAO GetuneVisiteDAO()
        {
            if (uneVisiteDAO == null)
            {
                uneVisiteDAO = new VisiteDAO();
            }
            return uneVisiteDAO;
        }
        // Ajout d'une visite qui contient un médicament
        public static int AjoutVisiteMedic(Visite uneVisite)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.AddWithValue("@Date", uneVisite.Date);
            cmd.Parameters.AddWithValue("@Heure_debut", uneVisite.Heure_debut);
            cmd.Parameters.AddWithValue("@Heure_fin", uneVisite.Heure_fin);
            cmd.Parameters.AddWithValue("@Motif", uneVisite.Motif);
            cmd.Parameters.AddWithValue("@Commentaire", uneVisite.Commentaire);
            cmd.Parameters.AddWithValue("@Maison", uneVisite.Maison);
            cmd.Parameters.AddWithValue("@Hopital", uneVisite.Hopital);
            cmd.Parameters.AddWithValue("@Parent", uneVisite.Parent);
            cmd.Parameters.AddWithValue("@Id_eleve", uneVisite.Eleve.Id);
            cmd.CommandText = "INSERT INTO VISITE values(@Date, @Heure_debut, @Heure_fin, @Motif, @Commentaire, @Maison, @Hopital, @Parent, @Id_eleve)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();

            maConnexion.Open();
            cmd.CommandText = "SELECT MAX(id_visite) AS 'id' FROM VISITE ";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            int id_visite = (int)sqlDataReader["id"];
            maConnexion.Close();

            maConnexion.Open();
            string Id_visite = "@Id_visite";
            string Id_medic = "@Id_medic";
            string Quantite = "@Quantite_medic";
            cmd.CommandText = "INSERT INTO DONNER values(@Id_visite, @Id_medic, @Quantite_medic)";
            cmd.Parameters.AddWithValue(Id_visite, id_visite);
            cmd.Parameters.AddWithValue(Id_medic, uneVisite.Medicament.Id);
            cmd.Parameters.AddWithValue(Quantite, uneVisite.Quantite_Medic);

            cmd.ExecuteNonQuery();
            maConnexion.Close();
            return nbEnr;
        }

        // Ajout d'une visite qui ne contient pas de médicament
        public static int AjoutVisite(Visite uneVisite)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.AddWithValue("@Date", uneVisite.Date);
            cmd.Parameters.AddWithValue("@Heure_debut", uneVisite.Heure_debut);
            cmd.Parameters.AddWithValue("@Heure_fin", uneVisite.Heure_fin);
            cmd.Parameters.AddWithValue("@Motif", uneVisite.Motif);
            cmd.Parameters.AddWithValue("@Commentaire", uneVisite.Commentaire);
            cmd.Parameters.AddWithValue("@Maison", uneVisite.Maison);
            cmd.Parameters.AddWithValue("@Hopital", uneVisite.Hopital);
            cmd.Parameters.AddWithValue("@Parent", uneVisite.Parent);
            cmd.Parameters.AddWithValue("@Id_eleve", uneVisite.Eleve.Id);
            cmd.CommandText = "INSERT INTO VISITE values(@Date, @Heure_debut, @Heure_fin, @Motif, @Commentaire, @Maison, @Hopital, @Parent, @Id_eleve)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static bool TrouverVisite(DateTime Date)
        {
            foreach (Visite lesVisites in GetVisites(Date))
            {
                if (Date == lesVisites.Date)
                {
                    return true;
                }
            }

            return false;
        }
        public static List<Visite> GetVisite()
        {
            int id_visite;
            DateTime date_visite;
            TimeSpan heure_debut_visite;
            TimeSpan heure_fin_visite;
            string motif_visite;
            string commentaire_visite;
            bool maison_visite;
            bool hopital_visite;
            bool parent_visite;
            Medicament medicament;
            Eleve eleve;
            Classe classe;

            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visite
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT VISITE.*, ELEVE.*, CLASSE.* FROM VISITE, ELEVE INNER JOIN CLASSE ON CLASSE.id_classe = ELEVE.id_classe WHERE " +
                "VISITE.id_eleve = ELEVE.id_eleve ORDER BY VISITE.id_visite; ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_visite = (int)monReader["id_visite"];
                date_visite = (DateTime)monReader["date_visite"];
                heure_debut_visite = DateTime.Parse(monReader["heure_debut_visite"].ToString()).TimeOfDay;
                heure_fin_visite = DateTime.Parse(monReader["heure_fin_visite"].ToString()).TimeOfDay;
                motif_visite = monReader["motif_visite"].ToString();
                commentaire_visite = monReader["commentaire_visite"].ToString();
                maison_visite = (bool)monReader["rentre_maison_visite"];
                hopital_visite = (bool)monReader["hopital_visite"];
                parent_visite = (bool)monReader["parent_prevenu_visite"];
                eleve = new Eleve((int)monReader["id_eleve"], monReader["nom_eleve"].ToString());
                classe = new Classe((int)monReader["id_classe"], monReader["libelle_classe"].ToString());

                uneVisite = new Visite(id_visite, date_visite, heure_debut_visite, heure_fin_visite, motif_visite, commentaire_visite, maison_visite,
                    hopital_visite, parent_visite, eleve, classe);
                lesVisites.Add(uneVisite);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            for (int i = 0; i < lesVisites.Count(); i++)
            {
                int id = lesVisites[i].Id;

                maConnexion.Open();

                string Id = "@id" + i;

                cmd.CommandText = "SELECT * FROM MEDICAMENT,DONNER WHERE DONNER.id_medicament = MEDICAMENT.id_medicament AND DONNER.id_visite = " + Id;

                cmd.Parameters.AddWithValue(Id, id);

                monReader = cmd.ExecuteReader();

                medicament = new Medicament();

                while (monReader.Read())
                {
                    medicament = new Medicament((int)monReader["id_medicament"], monReader["nom_medicament"].ToString(), (int)monReader["quantite_medicament"]);
                    if (medicament == null)
                    {
                        medicament = new Medicament(0, "Aucun", 0);
                    }
                }
                lesVisites[i].Medicament = medicament;
                maConnexion.Close();
            }

            return lesVisites;
        }

        public static List<Visite> GetVisites(DateTime Date)
        {
            int id_visite;
            DateTime date_visite;
            TimeSpan heure_debut_visite;
            TimeSpan heure_fin_visite;
            string motif_visite;
            string commentaire_visite;
            bool maison_visite;
            bool hopital_visite;
            bool parent_visite;
            Medicament medicament;
            Eleve eleve;
            Classe classe;

            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visite
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT VISITE.*, ELEVE.*, CLASSE.* FROM VISITE, ELEVE INNER JOIN CLASSE ON CLASSE.id_classe = ELEVE.id_classe WHERE" +
                " VISITE.id_eleve = ELEVE.id_eleve ORDER BY VISITE.id_visite; ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_visite = (int)monReader["id_visite"];
                date_visite = (DateTime)monReader["date_visite"];
                heure_debut_visite = DateTime.Parse(monReader["heure_debut_visite"].ToString()).TimeOfDay;
                heure_fin_visite = DateTime.Parse(monReader["heure_fin_visite"].ToString()).TimeOfDay;
                motif_visite = monReader["motif_visite"].ToString();
                commentaire_visite = monReader["commentaire_visite"].ToString();
                maison_visite = (bool)monReader["rentre_maison_visite"];
                hopital_visite = (bool)monReader["hopital_visite"];
                parent_visite = (bool)monReader["parent_prevenu_visite"];
                eleve = new Eleve((int)monReader["id_eleve"], monReader["nom_eleve"].ToString());
                classe = new Classe((int)monReader["id_classe"], monReader["libelle_classe"].ToString());

                uneVisite = new Visite(id_visite, date_visite, heure_debut_visite, heure_fin_visite, motif_visite, commentaire_visite, maison_visite,
                    hopital_visite, parent_visite, eleve, classe);
                lesVisites.Add(uneVisite);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            for (int i = 0; i < lesVisites.Count(); i++)
            {
                int id = lesVisites[i].Id;

                maConnexion.Open();

                string Id = "@id" + i;

                cmd.CommandText = "SELECT * FROM MEDICAMENT,DONNER WHERE DONNER.id_medicament = MEDICAMENT.id_medicament AND DONNER.id_visite = " + Id;

                cmd.Parameters.AddWithValue(Id, id);

                monReader = cmd.ExecuteReader();

                medicament = new Medicament();

                while (monReader.Read())
                {
                    medicament = new Medicament((int)monReader["id_medicament"], monReader["nom_medicament"].ToString(), (int)monReader["quantite_medicament"]);
                }
                lesVisites[i].Medicament = medicament;
                maConnexion.Close();
            }

            return lesVisites;
        }
    }
}
