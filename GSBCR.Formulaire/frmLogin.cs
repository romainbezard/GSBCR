using System;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.Formulaire
{
    public partial class frmLogin : Form
    {
        private string matricule, mdp;
        private VISITEUR visiteur;
        private VAFFECTATION affectation;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialisation des variables de connexion
            matricule = txtLogin.Text;
            mdp = txtMdp.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visiteur = Manager.ChargerVisiteur(matricule, mdp);
            if (visiteur == null){lblError.Text = "Login et/ou mot de passe incorrecte";}
            else { typeVisiteur(matricule); }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie le type du visiteur qui se connecte
        /// </summary>
        /// <param name="v">VISITEUR connecté</param>
        public void typeVisiteur(string matricule)
        {
            affectation = Manager.ChargerAffectationVisiteur(matricule);
            if (affectation.VIS_MATRICULE == "Visiteur")
                lblError.Text = "Bienvenue, visiteur";
            if (affectation.VIS_MATRICULE == "Délégué")
                lblError.Text = "Bienvenue, délégué";
            if (affectation.VIS_MATRICULE == "Responsable")
                lblError.Text = "Bienvenue, Responsable";
        }
    }
}
