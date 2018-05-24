using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class FrmSomResponsable : Form
    {
        string nom, prenom, matricule;

        public FrmSomResponsable(string Nom, string Prenom, string Matricule)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
            matricule = Matricule;
        }

        private void FrmSomResponsable_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }

        private void btnMettreVisiteurDelegue_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulterMedicament_Click(object sender, EventArgs e)
        {
            FrmConsulterMedicament m = new FrmConsulterMedicament();
            m.Show();
        }

        private void btnConsulterListeVisiteurRegion_Click(object sender, EventArgs e)
        {
            frmConsulterVisiteursSecteurResp consulte = new frmConsulterVisiteursSecteurResp(matricule);
            consulte.Show();
        }

        private void btnConsulterPraticien_Click(object sender, EventArgs e)
        {
            frmListeMedecinDelegue listeMedecin = new frmListeMedecinDelegue();
            listeMedecin.ShowDialog();
        }

        private void btnConsulterRapportRegionSecteur_Click(object sender, EventArgs e)
        {
            frmConsulterRapportSecteurResp consulte = new frmConsulterRapportSecteurResp(matricule);
            consulte.Show();
        }
    }
}
