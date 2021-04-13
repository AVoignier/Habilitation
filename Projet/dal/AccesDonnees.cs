using Projet.connexion;
using Projet.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.dal
{
    public class AccesDonnees
    {
        private static ConnexionBDD connexionDb = ConnexionBDD.getInstance();

        public AccesDonnees()
        {
                connexionDb = ConnexionBDD.getInstance();
        }

        public static List<Developpeur> getLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            string req = "SELECT developpeur.iddeveloppeur AS devId, developpeur.nom AS devNom, developpeur.prenom AS devPrenom, developpeur.tel AS devTel, developpeur.mail AS devMail, developpeur.idProfil AS devIdProfil, developpeur.pwd AS devPwd, profil.nom AS profilNom" +
                        " FROM developpeur" +
                        " LEFT JOIN profil ON developpeur.idProfil = profil.idProfil" +
                        " ORDER BY developpeur.nom;";
            connexionDb.ReqSelect(req);

            int idDev;
            string nom;
            string prenom;
            string tel;
            string mail;
            int idProfil;
            string PWD;
            string profil;

            while (connexionDb.Read())
            {
                idDev = (int)connexionDb.Field("devId");
                nom = connexionDb.Field("devNom").ToString();
                prenom = connexionDb.Field("devPrenom").ToString();
                tel = connexionDb.Field("devTel").ToString();
                mail = connexionDb.Field("devMail").ToString();
                idProfil = (int)connexionDb.Field("devIdProfil");
                PWD = connexionDb.Field("devPwd").ToString();
                profil = connexionDb.Field("profilNom").ToString();

                lesDeveloppeurs.Add(new Developpeur(idDev, nom, prenom, tel, mail, idProfil, profil, PWD));
            }

            connexionDb.Close();

            return lesDeveloppeurs;
        }

        public static List<Profil> GetlesProfils() 
        {
            List<Profil> lesProfils = new List<Profil>();
            string req = "SELECT *" +
                        " FROM profil;";
            connexionDb.ReqSelect(req);

            int idProfil;
            string nom;

            while (connexionDb.Read())
            {
                idProfil = (int)connexionDb.Field("idProfil");
                nom = connexionDb.Field("nom").ToString();

                lesProfils.Add(new Profil(idProfil, nom));
            }

            connexionDb.Close();

            return lesProfils;
        }

        public static void DelDeveloppeur(Developpeur developpeur)
        {
            string req = "DELETE FROM developpeur" +
                        " WHERE idDeveloppeur = @idDev;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idDev", developpeur.IdDev);

            connexionDb.ReqUpdate(req, parametres);
        }

        public static void AddDeveloppeur(Developpeur developpeur)
        {
            string req = "INSERT INTO developpeur(idDeveloppeur, idProfil, nom, prenom, tel, mail, pwd)" +
                        " VALUES (@idDeveloppeur, @idProfil, @nom, @prenom, @tel, @mail, @pwd);";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idDeveloppeur", developpeur.IdDev);
            parametres.Add("@idProfil", developpeur.idProfil);
            parametres.Add("@nom", developpeur.Nom);
            parametres.Add("@prenom", developpeur.Prenom);
            parametres.Add("@tel", developpeur.Tel);
            parametres.Add("@mail", developpeur.Mail);
            parametres.Add("@pwd", developpeur.PWD);

            connexionDb.ReqUpdate(req, parametres);
        }

        public static void UpdateDeveloppeur(Developpeur developpeur)
        {
            string req = "UPDATE developpeur" +
                        " SET idProfil = @idProfil, nom = @nom , prenom = @prenom, tel = @tel, mail = @mail" +
                        " WHERE idDeveloppeur = @idDev;";

            Dictionary<string, object> parametres = new Dictionary<string, object>();
            parametres.Add("@idProfil", developpeur.idProfil);
            parametres.Add("@nom", developpeur.Nom);
            parametres.Add("@prenom", developpeur.Prenom);
            parametres.Add("@tel", developpeur.Tel);
            parametres.Add("@mail", developpeur.Mail);
            parametres.Add("@idDev", developpeur.IdDev);

            connexionDb.ReqUpdate(req, parametres);

        }

        public static void UpdatePwd(Developpeur developpeur)
        {

        }

        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }


    }
}
