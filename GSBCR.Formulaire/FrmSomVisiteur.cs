using System;
using System.Windows.Forms;
using GSBCR.modele;
using System.Collections.Generic;
using GSBCR.DAL;
using GSBCR.BLL;

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

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsulterInfosPraticien_Click(object sender, EventArgs e)
        {
            frmListeMedecin listeMedecin = new frmListeMedecin();
            listeMedecin.ShowDialog();
        }

        private void btnModifierRapport_Click(object sender, EventArgs e)
        {
            List<int> etat = new List<int>();
            etat.Add(1);
            List<RAPPORT_VISITE> liste = Manager.ChargerRapportParVisiteurEtat(matricule,etat);
            FrmModifierRapport f = new FrmModifierRapport(liste);
            f.ShowDialog();
        }

        private void bntNouveauRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            FrmAjoutRapport ajoutr = new FrmAjoutRapport(r, true);
            ajoutr.Show();
        }

        private void btnConsulterRapport_Click(object sender, EventArgs e)
        {
            List<int> etat = new List<int>();
            etat.Add(3);
            etat.Add(2);
            List<RAPPORT_VISITE> liste = Manager.ChargerRapportParVisiteurEtat(matricule, etat);
            frmListeRapValide voir = new frmListeRapValide(liste);
            voir.Show();
        }

        private void btnConsulterInfosMedicament_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament m = new FrmConsulterMedicament();
            m.Show();
        }

        private void FrmSomVisiteur_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }
    }
}
