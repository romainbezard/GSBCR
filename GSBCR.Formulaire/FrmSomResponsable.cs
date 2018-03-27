using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.Formulaire
{
    public partial class FrmSomResponsable : Form
    {
        private string nom, prenom;

        public FrmSomResponsable(string Nom, string Prenom)
        {
            InitializeComponent();
            nom = Nom;
            prenom = Prenom;
        }

        private void FrmSomResponsable_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblNomVisiteur.Text += " " + nom + " " + prenom;
        }

        private void btnConsulterRapportRegionSecteur_Click(object sender, EventArgs e)
        {
            
        }
    }
}
