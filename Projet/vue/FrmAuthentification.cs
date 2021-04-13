using Projet.controleur;
using Projet.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.vue
{
    public partial class FrmAuthentification : Form
    {

        private Controle controle;

        public FrmAuthentification(Controle controle)
        {
            this.controle = controle;

            InitializeComponent();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            string nom = txb_nom.Text;
            string prenom = txb_prenom.Text;
            string pwd = txb_pwd.Text;

            Developpeur developpeur = new Developpeur(0, nom, prenom, "", "", 0, "", pwd);
            if (controle.Authentification(developpeur))
            {
                this.Visible = false;
                (new frm_Habilitation(controle)).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Données incorrecte", "Echec de l'authentification", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
