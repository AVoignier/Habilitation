using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projet.modele;
using Projet.dal;

namespace Projet.controleur
{

    public class Controle
    {

        private Form1 form;
        private List<Developpeur> lesDeveloppeurs;
        private List<Profil> lesProfils;


        public Controle(Form1 form) 
        {
            this.form = form;

            chargerLesDeveloppeurs();
            chargerLesProfils();

        }

        public List<Developpeur> GetLesDeveloppeurs() 
        {
            return lesDeveloppeurs;
        }

        public List<Profil> GetLesProfils()
        {
            return lesProfils;
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            if(lesDeveloppeurs.Contains(developpeur))
            {
                AccesDonnees.DelDeveloppeur(developpeur);
                chargerLesDeveloppeurs();
                form.RemplirLesDeveloppeurs();

            }

        }

        public void AddDeveloppeur(Developpeur developpeur) 
        {
            AccesDonnees.AddDeveloppeur(developpeur);
            chargerLesDeveloppeurs();
            form.RemplirLesDeveloppeurs();
        }

        public void UpdateDeveloppeur(Developpeur developpeur) 
        {
            AccesDonnees.UpdateDeveloppeur(developpeur);
            chargerLesDeveloppeurs();
            form.RemplirLesDeveloppeurs();
        }

        public void UpdatePwd(Developpeur developpeur) 
        {
            
        }

        private void chargerLesDeveloppeurs()
        {
            if(lesDeveloppeurs != null)
                lesDeveloppeurs.Clear();

            lesDeveloppeurs = AccesDonnees.getLesDeveloppeurs();
        }

        private void chargerLesProfils()
        {
            if(lesProfils != null)
                lesProfils.Clear();

            lesProfils = AccesDonnees.GetlesProfils();
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
