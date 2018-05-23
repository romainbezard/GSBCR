using GSBCR.BLL;
using GSBCR.modele;
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
    public partial class frmListeMedecinDelegue : Form
    {
        private List<PRATICIEN> lesPraticiens;
        private PRATICIEN lePraticien;
        private TYPE_PRATICIEN type;

        public frmListeMedecinDelegue()
        {
            InitializeComponent();
            lesPraticiens = Manager.ChargerPraticiens();
            foreach (PRATICIEN p in lesPraticiens)
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
            type = Manager.ChargerLeTypeDuPraticien(lePraticien.TYP_CODE);
            txtType.Text = type.TYP_LIBELLE;
            txtTypeLieu.Text = type.TYP_LIEU;
        }

        private void frmListeMedecinDelegue_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
