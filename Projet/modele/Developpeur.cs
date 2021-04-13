using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.modele
{
    public class Developpeur
    {
        private int m_IdDeveloppeur;
        private string m_Nom;
        private string m_Prenom;
        private string m_Tel;
        private string m_Mail;
        private int m_IdProfil;
        private string m_Profil;
        private string m_PWD;

        public int IdDev { get => m_IdDeveloppeur; }
        public string Nom { get => m_Nom; set => m_Nom = value; }
        public string Prenom { get => m_Prenom; set => m_Prenom = value; }
        public string Tel { get => m_Tel; set => m_Tel = value; }
        public string Mail { get => m_Mail; set => m_Mail = value; }
        public int idProfil { get => m_IdProfil; set => m_IdProfil = value; }
        public string Profil { get => m_Profil; set => m_Profil = value; } 
        public string PWD { get => m_PWD; set => m_PWD = value; }

        public Developpeur( int idDev, string nom, string prenom, string tel, string mail,int idProfil, string profil, string PWD)
        {
            this.m_IdDeveloppeur = idDev;
            this.m_Nom = nom;
            this.m_Prenom = prenom;
            this.m_Tel = tel;
            this.m_Mail = mail;
            this.m_IdProfil = idProfil;
            this.m_Profil = profil;
            this.m_PWD = PWD;
        }

    }
}
