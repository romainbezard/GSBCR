using System;
using System.Windows.Forms;

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

        private void FrmSomVisiteur_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }
    }
}
