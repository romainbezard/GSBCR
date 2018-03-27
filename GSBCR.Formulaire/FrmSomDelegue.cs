using System;
using System.Windows.Forms;

namespace GSBCR.Formulaire
{
    public partial class FrmSomDelegue : Form
    {
        private string nom, prenom;
        public FrmSomDelegue(string Nom, string Prenom)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
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
    }
}
