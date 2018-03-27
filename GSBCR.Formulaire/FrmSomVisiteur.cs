using System;
using System.Windows.Forms;
using GSBCR.modele;
using System.Collections.Generic;
using GSBCR.DAL;

namespace GSBCR.Formulaire
{
    public partial class FrmSomVisiteur : Form
    {
        private frmLogin donneeVisiteur = new frmLogin();
        private string nom, prenom;

        public FrmSomVisiteur(string Nom, string Prenom)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
        }

        private void btnModifierRapport_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> liste = RapportVisiteDAO.FindByEtatEtVisiteur(matricule,1);
            Form f = new FrmModifierRapport(liste);
        }

        private void FrmSomVisiteur_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }
    }
}
