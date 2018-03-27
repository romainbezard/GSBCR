using System;
using System.Windows.Forms;
using GSBCR.modele;
using System.Collections.Generic;
using GSBCR.DAL;

namespace GSBCR.Formulaire
{
    public partial class FrmSomVisiteur : Form
    {
        private string nom, prenom, matricule;

        public FrmSomVisiteur(string Nom, string Prenom, string Matricule)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
            matricule = Matricule;
        }

        private void btnConsulterInfosPraticien_Click(object sender, EventArgs e)
        {
            frmListeMedecin listeMedecin = new frmListeMedecin();
            listeMedecin.ShowDialog();
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
