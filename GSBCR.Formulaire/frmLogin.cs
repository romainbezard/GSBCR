﻿using System;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.Formulaire
{
    public partial class frmLogin : Form
    {
        private string matricule, mdp;
        private VISITEUR visiteur;
        private VAFFECTATION affectation;

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matricule = txtLogin.Text;
            mdp = txtMdp.Text;
            visiteur = Manager.ChargerVisiteur(matricule, mdp);
            if (visiteur == null){lblError.Text = "Login et/ou mot de passe incorrecte";}
            else { typeVisiteur(matricule); }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie le type du visiteur qui se connecte
        /// </summary>
        /// <param name="v">VISITEUR connecté</param>
        public void typeVisiteur(string matricule)
        {
            affectation = Manager.ChargerAffectationVisiteur(matricule);
            if (affectation.TRA_ROLE == "Visiteur")
            {
                FrmSomVisiteur visiteur = new FrmSomVisiteur();
                visiteur.Show();
                Hide();
            }
            else if (affectation.TRA_ROLE == "Délégué")
            {
                FrmSomDelegue delegue = new FrmSomDelegue();
                delegue.Show();
                Hide();
            }
            else if (affectation.TRA_ROLE == "Responsable")
            {
                FrmSomResponsable responsable = new FrmSomResponsable();
                responsable.Show();
                Hide();
            }
            else
                lblError.Text = "Error lors de la recherche du rôle";
        }
    }
}
