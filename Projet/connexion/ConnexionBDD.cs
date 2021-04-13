using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.connexion
{

    

    public class ConnexionBDD
    {
        private string chaineConnexion = "server=192.168.0.19;user id=habilitation;database=habilitation;persistsecurityinfo=True;password='motdepasseuser'";
        private MySqlConnection connexion;
        private MySqlCommand command;
        private MySqlDataReader curseur;
        private static ConnexionBDD instance = null;

        private ConnexionBDD() 
        {
            connexion = new MySqlConnection(chaineConnexion);
            connexion.Open();
        }

        public static ConnexionBDD getInstance() 
        {
            if(instance == null)
            {
                instance = new ConnexionBDD();
            }

            return instance;
        }

        public void ReqSelect(string requete, Dictionary<string, object> parametres = null)
        {
            command = new MySqlCommand(requete, connexion);

            //Si il y a des paramètres
            if(parametres != null)
            {
                foreach( KeyValuePair<string,object> parametre in parametres)
                {
                    command.Parameters.Add( new MySqlParameter(parametre.Key, parametre.Value));
                }
                command.Prepare();
            }

            curseur = command.ExecuteReader();
        }

        public void ReqUpdate(string requete, Dictionary<string, object> parametres)
        {
            command = new MySqlCommand(requete, connexion);

            foreach (KeyValuePair<string, object> parametre in parametres)
            {
                command.Parameters.Add(new MySqlParameter(parametre.Key, parametre.Value));
            }
            command.Prepare();

            command.ExecuteNonQuery();
        }

        public bool Read()
        {
            if(curseur == null)
            {
                return false;
            }

            return curseur.Read();
        }

        public object Field(string champ)
        {
            if(curseur == null)
            {
                return false;
            }

            return curseur[champ];
        }

        public void Close() 
        {
            
            if(curseur != null)
            {
                curseur.Close();
            }

        }

    }

    /*
            //Creation de la connection
            string chaineConnection = "server=192.168.0.19;user id=habilitation;database=habilitation;persistsecurityinfo=True;password='motdepasseuser'";
            MySqlConnection connection = new MySqlConnection(chaineConnection);
            connection.Open();

            //Création de la requete, application de la requete, création ddu curseur (reader) de la commande
            string req = "SELECT IdDeveloppeur, nom, prenom FROM developpeur;";
            MySqlCommand command = new MySqlCommand(req, connection);
            MySqlDataReader reader = command.ExecuteReader();

            //Lecture de la réponse
            bool finCurseur = reader.Read();
            while (!finCurseur)
            {
                Console.WriteLine(reader["idDeveloppeur"] + " ; " + reader["nom"] + " ; " + reader["prenom"]);
                finCurseur = reader.Read();
            }

            //Quand la lecture est fini, fermeture du curseur et de la connection
            reader.Close();
            connection.Close();
            */
}
