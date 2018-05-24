using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class frmRapVisitePraticien : Form
    {
        private Int32 pranum;
        private List<RAPPORT_VISITE> lesRapports = null;
        private RAPPORT_VISITE leRapport = null;

        public frmRapVisitePraticien(Int32 PRA_NUM)
        {
            InitializeComponent();
            pranum = PRA_NUM;
            lesRapports = Manager.ChargerRapportByPatricien(pranum);
            foreach(RAPPORT_VISITE rv in lesRapports)
            {
                cbxRapport.Items.Add(rv.RAP_NUM);
            }
        }

        private void cbxRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            leRapport = Manager.ChargerRapportByPraticienAndNum(pranum, Convert.ToInt32(cbxRapport.SelectedItem));
            txtDate.Text = leRapport.RAP_DATE.ToString();
            txtDateVisite.Text = leRapport.RAP_DATVISIT.ToString();
            if (leRapport.RAP_MOTIFAUTRE == "")
                txtAutre.Text = "Rien d'autre";
            else
                txtAutre.Text = leRapport.RAP_MOTIFAUTRE;
            txtBilan.Text = leRapport.RAP_BILAN;
            TxtMed1.Text = leRapport.RAP_MED1;
            txtMed2.Text = leRapport.RAP_MED2;
            txtMotif.Text = leRapport.RAP_MOTIF;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRapVisitePraticien_Load(object sender, EventArgs e)
        {
            if(cbxRapport.Items.Count == 0)
            {
                MessageBox.Show("Aucun rapport de visite", "Aucun rapport", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
        }
    }
}
