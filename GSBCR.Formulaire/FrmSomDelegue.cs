using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class FrmSomDelegue : Form
    {
        private string nom, prenom, matricule;
        public FrmSomDelegue(string Nom, string Prenom, string Matricule)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
            matricule = Matricule;
        }

        private void btnConsulterInfosPraticien_Click(object sender, EventArgs e)
        {
            frmListeMedecinDelegue listeMedecin = new frmListeMedecinDelegue();
            listeMedecin.ShowDialog();
        }

        private void FrmSomDelegue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }

        private void btnConsulterInfosMedicament_Click(object sender, EventArgs e)
        {
            frmListeMedecinDelegue listeMedecin = new frmListeMedecinDelegue();
            listeMedecin.ShowDialog();
        }

        private void btnConsulterNvRapRegion_Click(object sender, EventArgs e)
        {

            List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportByRegionDuPraticien(matricule);
            frmConsultRapportRegion consulteRapport = new frmConsultRapportRegion(lesRapports);
            Hide();
            consulteRapport.ShowDialog();
            Show();
        }

        private void bntNouveauRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = null;
            FrmAjoutRapport ajoutr = new FrmAjoutRapport(r, true);
            ajoutr.Show();
        }
    }
}
