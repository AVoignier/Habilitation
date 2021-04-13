using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.modele
{
    public class Profil
    {

        private int m_idProfil;
        private string m_nom;

        public int idProfil { get => m_idProfil; set => m_idProfil = value; }
        public string nom { get => m_nom; set => m_nom = value; }

        public Profil(int idProfil, string nom) 
        {
            m_idProfil = idProfil;
            m_nom = nom;
        }

        public string ToString() 
        {
            return m_nom;
        }

    }
}
