using System;
using System.Windows.Forms;
using GSBCR.modele;

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

        private void bntNouveauRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            FrmAjoutRapport ajoutr = new FrmAjoutRapport(r, true);
            ajoutr.Show();
        }

        private void btnConsulterInfosMedicament_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament m = new FrmConsulterMedicament(matricule);
            m.Show();
        }

        private void FrmSomVisiteur_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }
    }
}
