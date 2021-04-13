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
    public partial class frm_Habilitation : Form
    {

        private Controle controle;
        private bool changementPwdEnCours;


        public frm_Habilitation(Controle controle)
        {
            InitializeComponent();

            this.controle = controle;
            changementPwdEnCours = false;
            grb_changerPwd.Enabled = false;
            dgv_developpeurs.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemplirLesDeveloppeurs();
            RemplirLesProfils();
        }

        public void RemplirLesDeveloppeurs() 
        {
            List<Developpeur> lesDeveloppeurs =  controle.GetLesDeveloppeurs();
            dgv_developpeurs.DataSource = lesDeveloppeurs;
            dgv_developpeurs.Columns["IdDev"].Visible = false;
            //dgv_developpeurs.Columns["PWD"].Visible = false;
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
                {
                    controle.DelDeveloppeur(developpeur);
                    RemplirLesDeveloppeurs();
                }
                        
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
                    RemplirLesDeveloppeurs();
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
                    RemplirLesDeveloppeurs();
                    ViderChampsAjouter();
                }

            }
        }

        private void ViderChampsAjouter()
        {
            txb_nom.Text = "";
            txb_prenom.Text = "";
            txb_tel.Text = "";
            txb_mail.Text = "";
            cmb_profil.SelectedIndex = 0;
        }

        private void ViderChampsPwd()
        {
            txb_pwd.Text = "";
            txb_encore.Text = "";
        }

        private void btn_devAnnuler_Click(object sender, EventArgs e)
        {
            ViderChampsAjouter();
        }

        private void btn_changerPwd_Click(object sender, EventArgs e)
        {
            if( dgv_developpeurs.SelectedRows.Count > 0)
            {
                ChangementPwdEnCours(true);
            }
        }

        private void btn_pwdAnnuler_Click(object sender, EventArgs e)
        {
            if( changementPwdEnCours)
            {
                ChangementPwdEnCours(false);
            }
        }

        private void btn_pwdEnregistrer_Click(object sender, EventArgs e)
        {
            if( changementPwdEnCours)
            {
                //Si les champs de texte sont identiques
                if( txb_pwd.Text == txb_encore.Text && txb_pwd.Text != "")
                {
                    Developpeur developpeur = (Developpeur)dgv_developpeurs.SelectedRows[0].DataBoundItem;
                    if( MessageBox.Show( "Voulez vous vraiment changer de mot de passe de " + developpeur.Prenom + " " + developpeur.Nom + " ?", "Confirmation du changement", MessageBoxButtons.YesNo ) == DialogResult.Yes)
                    {
                        developpeur.PWD = txb_pwd.Text;
                        controle.UpdatePwd(developpeur);

                        ChangementPwdEnCours(false);
                    }
                }
                else if(txb_pwd.Text == "" && txb_encore.Text == "")
                {
                    MessageBox.Show("Veuillez remplir les champs " + lbl_pwd.Text + " et " + lbl_encore.Text, "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Les mot de passe ne correspondent pas", "", MessageBoxButtons.OK);
                }
            }
        }

        private void ChangementPwdEnCours(bool etat) 
        {
            if (etat)
            {
                changementPwdEnCours = true;

                grb_Dev.Enabled = false;
                grb_ajoutDev.Enabled = false;
                grb_changerPwd.Enabled = true;
                ViderChampsAjouter();
            }
            else
            {
                changementPwdEnCours = false;

                grb_Dev.Enabled = true;
                grb_ajoutDev.Enabled = true;
                grb_changerPwd.Enabled = false;
                ViderChampsPwd();
            }
        }
    }
}
