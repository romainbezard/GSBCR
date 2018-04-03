using System;
using System.Windows.Forms;
using GSBCR.modele;
using System.Collections.Generic;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class frmListeMedecin : Form
    {
        private List<PRATICIEN> lesPraticiens;
        private PRATICIEN lePraticien;
        //d
        public frmListeMedecin()
        {
            InitializeComponent();
            lesPraticiens = Manager.ChargerPraticiens();
            foreach(PRATICIEN p in lesPraticiens)
            {
                cbxPraticien.Items.Add(p.PRA_NUM);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lePraticien = Manager.ChargerLePraticien(Convert.ToInt32(cbxPraticien.SelectedItem));
            frmRapVisitePraticien rapportVisite = new frmRapVisitePraticien(lePraticien.PRA_NUM);
            rapportVisite.ShowDialog();
        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lePraticien = Manager.ChargerLePraticien(Convert.ToInt32(cbxPraticien.SelectedItem));
            txtNom.Text = lePraticien.PRA_NOM;
            txtPrenom.Text = lePraticien.PRA_PRENOM;
            txtAdresse.Text = lePraticien.PRA_ADRESSE;
            txtVille.Text = lePraticien.PRA_CP + " " + lePraticien.PRA_VILLE;
        }
    }
}
