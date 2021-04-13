using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projet.controleur;
using Projet.modele;

namespace Projet
{
    public partial class Form1 : Form
    {

        private Controle controle;


        public Form1()
        {
            InitializeComponent();

            dgv_developpeurs.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controle = new Controle(this);
            RemplirLesDeveloppeurs();
            RemplirLesProfils();
        }

        public void RemplirLesDeveloppeurs() 
        {
            List<Developpeur> lesDeveloppeurs =  controle.GetLesDeveloppeurs();
            dgv_developpeurs.DataSource = lesDeveloppeurs;
            dgv_developpeurs.Columns["IdDev"].Visible = false;
            dgv_developpeurs.Columns["PWD"].Visible = false;
            dgv_developpeurs.Columns["idProfil"].Visible = false;
        }

        public void RemplirLesProfils() 
        {
            List<Profil> lesProfils = controle.GetLesProfils();

            cmb_profil.DataSource = lesProfils;
            cmb_profil.ValueMember = "idProfil";
            cmb_profil.DisplayMember = "nom";
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if( dgv_developpeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)dgv_developpeurs.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Voulez vous vraiment supprimer " + developpeur.Prenom + " " + developpeur.Nom + "?", "Confirmation de la suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    controle.DelDeveloppeur(developpeur);
                        
            }


        }

        private void btn_devEnregistrer_Click(object sender, EventArgs e)
        {
            if( txb_nom.Text != "" && txb_prenom.Text != "" && txb_mail.Text!="" && txb_tel.Text!="")
            {
                if (MessageBox.Show("Voulez vous vraiment ajouter " + txb_prenom.Text + " " + txb_nom.Text + "?", "Confirmation de la suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int idDeveloppeur = controle.trouverIdDeveloppeurDisponible();
                    string nom = txb_nom.Text;
                    string prenom = txb_prenom.Text;
                    string tel = txb_tel.Text;
                    string mail = txb_mail.Text;
                    int idProfil = ((Profil)cmb_profil.SelectedItem).idProfil;
                    string profil = ((Profil)cmb_profil.SelectedItem).nom;
                    string Pwd = "";

                    Developpeur developpeur = new Developpeur(idDeveloppeur, nom, prenom, tel, mail, idProfil, profil, Pwd);
                    controle.AddDeveloppeur(developpeur);
                    viderChamps();
                }
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if( dgv_developpeurs.SelectedRows.Count > 0)
            {
                bool changement = false;
                Developpeur devModele = (Developpeur)dgv_developpeurs.SelectedRows[0].DataBoundItem;
                Developpeur developpeur = new Developpeur(devModele.IdDev, devModele.Nom, devModele.Prenom, devModele.Tel, devModele.Mail, devModele.idProfil, devModele.Profil, devModele.PWD);
                
                if( txb_nom.Text != "" && txb_nom.Text != developpeur.Nom)
                {
                    developpeur.Nom = txb_nom.Text;
                    changement = true;
                }

                if( txb_prenom.Text != "" && txb_prenom.Text != developpeur.Prenom)
                {
                    developpeur.Prenom = txb_prenom.Text;
                    changement = true;
                }

                if( txb_mail.Text != "" && txb_mail.Text != developpeur.Mail)
                {
                    developpeur.Mail = txb_mail.Text;
                    changement = true;
                }

                if(txb_tel.Text != "" && txb_tel.Text != developpeur.Tel)
                {
                    developpeur.Tel = txb_tel.Text;
                    changement = true;
                }

                if( ((Profil)cmb_profil.SelectedItem).idProfil != developpeur.idProfil)
                {
                    developpeur.idProfil = ((Profil)cmb_profil.SelectedItem).idProfil;
                    changement = true;
                }

                if(MessageBox.Show( "Voulez vous appliquer ces modifications ?", "Confirmation de la modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.UpdateDeveloppeur(developpeur);
                    viderChamps();
                }

            }
        }

        private void viderChamps()
        {
            txb_nom.Text = "";
            txb_prenom.Text = "";
            txb_tel.Text = "";
            txb_mail.Text = "";
        }

        private void btn_devAnnuler_Click(object sender, EventArgs e)
        {
            viderChamps();
        }
    }
}
