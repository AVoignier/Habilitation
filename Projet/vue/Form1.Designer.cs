
namespace Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_developpeurs = new System.Windows.Forms.DataGridView();
            this.habilitationDataSet = new Projet.habilitationDataSet();
            this.habilitationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_changerPwd = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.txb_prenom = new System.Windows.Forms.TextBox();
            this.txb_mail = new System.Windows.Forms.TextBox();
            this.txb_tel = new System.Windows.Forms.TextBox();
            this.lbl_profil = new System.Windows.Forms.Label();
            this.cmb_profil = new System.Windows.Forms.ComboBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txb_pwd = new System.Windows.Forms.TextBox();
            this.txb_encore = new System.Windows.Forms.TextBox();
            this.lbl_encore = new System.Windows.Forms.Label();
            this.btn_pwdEnregistrer = new System.Windows.Forms.Button();
            this.btn_pwdAnnuler = new System.Windows.Forms.Button();
            this.btn_devEnregistrer = new System.Windows.Forms.Button();
            this.btn_devAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_developpeurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_changerPwd);
            this.groupBox1.Controls.Add(this.btn_supprimer);
            this.groupBox1.Controls.Add(this.btn_modifier);
            this.groupBox1.Controls.Add(this.dgv_developpeurs);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "les développeurs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_devAnnuler);
            this.groupBox2.Controls.Add(this.btn_devEnregistrer);
            this.groupBox2.Controls.Add(this.cmb_profil);
            this.groupBox2.Controls.Add(this.lbl_profil);
            this.groupBox2.Controls.Add(this.txb_tel);
            this.groupBox2.Controls.Add(this.txb_mail);
            this.groupBox2.Controls.Add(this.txb_prenom);
            this.groupBox2.Controls.Add(this.txb_nom);
            this.groupBox2.Controls.Add(this.lbl_tel);
            this.groupBox2.Controls.Add(this.lbl_mail);
            this.groupBox2.Controls.Add(this.lbl_prenom);
            this.groupBox2.Controls.Add(this.lbl_nom);
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ajouter un développeur";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_pwdAnnuler);
            this.groupBox3.Controls.Add(this.btn_pwdEnregistrer);
            this.groupBox3.Controls.Add(this.lbl_encore);
            this.groupBox3.Controls.Add(this.txb_encore);
            this.groupBox3.Controls.Add(this.txb_pwd);
            this.groupBox3.Controls.Add(this.lbl_pwd);
            this.groupBox3.Location = new System.Drawing.Point(12, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "changer le mot de passe";
            // 
            // dgv_developpeurs
            // 
            this.dgv_developpeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_developpeurs.Location = new System.Drawing.Point(6, 19);
            this.dgv_developpeurs.Name = "dgv_developpeurs";
            this.dgv_developpeurs.Size = new System.Drawing.Size(651, 271);
            this.dgv_developpeurs.TabIndex = 0;
            // 
            // habilitationDataSet
            // 
            this.habilitationDataSet.DataSetName = "habilitationDataSet";
            this.habilitationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habilitationDataSetBindingSource
            // 
            this.habilitationDataSetBindingSource.DataSource = this.habilitationDataSet;
            this.habilitationDataSetBindingSource.Position = 0;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(6, 296);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(104, 23);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(116, 296);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(104, 23);
            this.btn_supprimer.TabIndex = 2;
            this.btn_supprimer.Text = "supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_changerPwd
            // 
            this.btn_changerPwd.Location = new System.Drawing.Point(226, 296);
            this.btn_changerPwd.Name = "btn_changerPwd";
            this.btn_changerPwd.Size = new System.Drawing.Size(104, 23);
            this.btn_changerPwd.TabIndex = 3;
            this.btn_changerPwd.Text = "changer pwd";
            this.btn_changerPwd.UseVisualStyleBackColor = true;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(6, 22);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(27, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(6, 48);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(42, 13);
            this.lbl_prenom.TabIndex = 1;
            this.lbl_prenom.Text = "prenom";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(238, 22);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(25, 13);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "mail";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(238, 48);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(18, 13);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "tel";
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(54, 19);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(166, 20);
            this.txb_nom.TabIndex = 4;
            // 
            // txb_prenom
            // 
            this.txb_prenom.Location = new System.Drawing.Point(54, 45);
            this.txb_prenom.Name = "txb_prenom";
            this.txb_prenom.Size = new System.Drawing.Size(166, 20);
            this.txb_prenom.TabIndex = 5;
            // 
            // txb_mail
            // 
            this.txb_mail.Location = new System.Drawing.Point(284, 19);
            this.txb_mail.Name = "txb_mail";
            this.txb_mail.Size = new System.Drawing.Size(166, 20);
            this.txb_mail.TabIndex = 6;
            // 
            // txb_tel
            // 
            this.txb_tel.Location = new System.Drawing.Point(284, 45);
            this.txb_tel.Name = "txb_tel";
            this.txb_tel.Size = new System.Drawing.Size(166, 20);
            this.txb_tel.TabIndex = 7;
            // 
            // lbl_profil
            // 
            this.lbl_profil.AutoSize = true;
            this.lbl_profil.Location = new System.Drawing.Point(238, 74);
            this.lbl_profil.Name = "lbl_profil";
            this.lbl_profil.Size = new System.Drawing.Size(29, 13);
            this.lbl_profil.TabIndex = 8;
            this.lbl_profil.Text = "profil";
            // 
            // cmb_profil
            // 
            this.cmb_profil.FormattingEnabled = true;
            this.cmb_profil.Location = new System.Drawing.Point(284, 71);
            this.cmb_profil.Name = "cmb_profil";
            this.cmb_profil.Size = new System.Drawing.Size(166, 21);
            this.cmb_profil.TabIndex = 9;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(6, 22);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(27, 13);
            this.lbl_pwd.TabIndex = 0;
            this.lbl_pwd.Text = "pwd";
            // 
            // txb_pwd
            // 
            this.txb_pwd.Location = new System.Drawing.Point(60, 19);
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.Size = new System.Drawing.Size(166, 20);
            this.txb_pwd.TabIndex = 1;
            // 
            // txb_encore
            // 
            this.txb_encore.Location = new System.Drawing.Point(290, 19);
            this.txb_encore.Name = "txb_encore";
            this.txb_encore.Size = new System.Drawing.Size(166, 20);
            this.txb_encore.TabIndex = 2;
            // 
            // lbl_encore
            // 
            this.lbl_encore.AutoSize = true;
            this.lbl_encore.Location = new System.Drawing.Point(244, 22);
            this.lbl_encore.Name = "lbl_encore";
            this.lbl_encore.Size = new System.Drawing.Size(40, 13);
            this.lbl_encore.TabIndex = 3;
            this.lbl_encore.Text = "encore";
            // 
            // btn_pwdEnregistrer
            // 
            this.btn_pwdEnregistrer.Location = new System.Drawing.Point(9, 43);
            this.btn_pwdEnregistrer.Name = "btn_pwdEnregistrer";
            this.btn_pwdEnregistrer.Size = new System.Drawing.Size(101, 23);
            this.btn_pwdEnregistrer.TabIndex = 4;
            this.btn_pwdEnregistrer.Text = "Enregistrer";
            this.btn_pwdEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btn_pwdAnnuler
            // 
            this.btn_pwdAnnuler.Location = new System.Drawing.Point(116, 45);
            this.btn_pwdAnnuler.Name = "btn_pwdAnnuler";
            this.btn_pwdAnnuler.Size = new System.Drawing.Size(101, 23);
            this.btn_pwdAnnuler.TabIndex = 5;
            this.btn_pwdAnnuler.Text = "annuler";
            this.btn_pwdAnnuler.UseVisualStyleBackColor = true;
            // 
            // btn_devEnregistrer
            // 
            this.btn_devEnregistrer.Location = new System.Drawing.Point(9, 74);
            this.btn_devEnregistrer.Name = "btn_devEnregistrer";
            this.btn_devEnregistrer.Size = new System.Drawing.Size(101, 23);
            this.btn_devEnregistrer.TabIndex = 10;
            this.btn_devEnregistrer.Text = "Enregistrer";
            this.btn_devEnregistrer.UseVisualStyleBackColor = true;
            this.btn_devEnregistrer.Click += new System.EventHandler(this.btn_devEnregistrer_Click);
            // 
            // btn_devAnnuler
            // 
            this.btn_devAnnuler.Location = new System.Drawing.Point(119, 74);
            this.btn_devAnnuler.Name = "btn_devAnnuler";
            this.btn_devAnnuler.Size = new System.Drawing.Size(101, 23);
            this.btn_devAnnuler.TabIndex = 11;
            this.btn_devAnnuler.Text = "annuler";
            this.btn_devAnnuler.UseVisualStyleBackColor = true;
            this.btn_devAnnuler.Click += new System.EventHandler(this.btn_devAnnuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_developpeurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habilitationDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_changerPwd;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.DataGridView dgv_developpeurs;
        private System.Windows.Forms.BindingSource habilitationDataSetBindingSource;
        private habilitationDataSet habilitationDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_profil;
        private System.Windows.Forms.Label lbl_profil;
        private System.Windows.Forms.TextBox txb_tel;
        private System.Windows.Forms.TextBox txb_mail;
        private System.Windows.Forms.TextBox txb_prenom;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Button btn_devAnnuler;
        private System.Windows.Forms.Button btn_devEnregistrer;
        private System.Windows.Forms.Button btn_pwdAnnuler;
        private System.Windows.Forms.Button btn_pwdEnregistrer;
        private System.Windows.Forms.Label lbl_encore;
        private System.Windows.Forms.TextBox txb_encore;
        private System.Windows.Forms.TextBox txb_pwd;
        private System.Windows.Forms.Label lbl_pwd;
    }
}

