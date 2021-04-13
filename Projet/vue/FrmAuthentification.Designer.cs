
namespace Projet.vue
{
    partial class FrmAuthentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.txb_prenom = new System.Windows.Forms.TextBox();
            this.txb_pwd = new System.Windows.Forms.TextBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(12, 9);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(27, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "nom";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(12, 63);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(27, 13);
            this.lbl_pwd.TabIndex = 1;
            this.lbl_pwd.Text = "pwd";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(12, 36);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(42, 13);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "prenom";
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(57, 6);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(150, 20);
            this.txb_nom.TabIndex = 3;
            // 
            // txb_prenom
            // 
            this.txb_prenom.Location = new System.Drawing.Point(57, 33);
            this.txb_prenom.Name = "txb_prenom";
            this.txb_prenom.Size = new System.Drawing.Size(150, 20);
            this.txb_prenom.TabIndex = 4;
            // 
            // txb_pwd
            // 
            this.txb_pwd.Location = new System.Drawing.Point(57, 60);
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.PasswordChar = '*';
            this.txb_pwd.Size = new System.Drawing.Size(150, 20);
            this.txb_pwd.TabIndex = 5;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(93, 86);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(114, 23);
            this.btn_connexion.TabIndex = 6;
            this.btn_connexion.Text = "Se Connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 125);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.txb_pwd);
            this.Controls.Add(this.txb_prenom);
            this.Controls.Add(this.txb_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_nom);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.TextBox txb_prenom;
        private System.Windows.Forms.TextBox txb_pwd;
        private System.Windows.Forms.Button btn_connexion;
    }
}