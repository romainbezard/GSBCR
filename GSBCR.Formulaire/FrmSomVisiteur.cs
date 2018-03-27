using System;
using System.Windows.Forms;

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

        private void FrmSomVisiteur_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }
    }
}
