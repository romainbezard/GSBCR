﻿using System;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.Formulaire
{
    public partial class frmLogin : Form
    {
        private string matricule, mdp, nom, prenom;
        private VISITEUR visiteur;
        private VAFFECTATION affectation;

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtMdp.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matricule = txtLogin.Text;
            mdp = txtMdp.Text;
            visiteur = Manager.ChargerVisiteur(matricule, mdp);
            if (visiteur == null){lblErr.Text = "Login et/ou mot de passe incorrecte";}
            else {
                nom = visiteur.VIS_NOM;
                prenom = visiteur.Vis_PRENOM;
                txtMdp.Text = "";
                typeVisiteur(matricule);
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie le type du visiteur qui se connecte et le renvoie à son formulaire
        /// </summary>
        /// <param name="v">VISITEUR connecté</param>
        public void typeVisiteur(string matricule)
        {
            affectation = Manager.ChargerAffectationVisiteur(matricule);
            if (affectation.TRA_ROLE == "Visiteur")
            {
                FrmSomVisiteur visiteur = new FrmSomVisiteur(nom, prenom, matricule);
                Hide();
                visiteur.ShowDialog();
                Visible = true;
            }
            else if (affectation.TRA_ROLE == "Délégué")
            {
                FrmSomDelegue delegue = new FrmSomDelegue(nom, prenom, matricule);
                Hide();
                delegue.ShowDialog();
                Show();
            }
            else if (affectation.TRA_ROLE == "Responsable")
            {
                FrmSomResponsable responsable = new FrmSomResponsable(nom, prenom, matricule);
                responsable.Show();
                Hide();
            }
            else
                lblErr.Text = "Error lors de la recherche du rôle";
        }
        
    }
}
