using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projet.modele;
using Projet.dal;
using Projet.vue;

namespace Projet.controleur
{

    public class Controle
    {

        private bool authentificationOK = false;

        public Controle() 
        {
            (new FrmAuthentification(this)).ShowDialog();

        }

        public List<Developpeur> GetLesDeveloppeurs() 
        {
            return AccesDonnees.getLesDeveloppeurs();
        }

        public List<Profil> GetLesProfils()
        {
            return AccesDonnees.GetlesProfils();
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            List<Developpeur> lesDeveloppeurs = AccesDonnees.getLesDeveloppeurs();

            if(lesDeveloppeurs.Contains(developpeur))
            {
                AccesDonnees.DelDeveloppeur(developpeur);
            }

        }

        public void AddDeveloppeur(Developpeur developpeur) 
        {
            AccesDonnees.AddDeveloppeur(developpeur);
        }

        public void UpdateDeveloppeur(Developpeur developpeur) 
        {
            AccesDonnees.UpdateDeveloppeur(developpeur);
        }

        public void UpdatePwd(Developpeur developpeur) 
        {
            AccesDonnees.UpdatePwd(developpeur);
        }

        public bool Authentification(Developpeur developpeur)
        {
            //if ( AccesDonnees.Authentification(developpeur) )
            //    (new frm_Habilitation(this)).ShowDialog();

            return AccesDonnees.Authentification(developpeur);
        }

        public int trouverIdDeveloppeurDisponible()
        {
            int id = 0;
            bool idDispo = true;
            while (!idDeveloppeurDisponible(id))
                id++;

            return id;

        }

        private bool idDeveloppeurDisponible(int id)
        {
            List<Developpeur> lesDeveloppeurs = AccesDonnees.getLesDeveloppeurs();

            bool dispo = true;
            for(int i=0; i<lesDeveloppeurs.Count && dispo; i++)
            {
                if (id == lesDeveloppeurs[i].IdDev)
                    dispo = false;
            }

            return dispo;
        }

    }
}
