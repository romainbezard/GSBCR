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
    public partial class frmInfoRapportRegion : Form
    {
        private PRATICIEN P;

        public frmInfoRapportRegion(PRATICIEN p, VISITEUR v, int numRapport, string dateVisite, string motifVisite, string coefConfiance)
        {
            InitializeComponent();
            List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapprotByNum(numRapport);
            P = p;
            foreach(RAPPORT_VISITE rv in lesRapports)
            {
                txtCodeMed1.Text = rv.RAP_MED1;
                txtCodeMed2.Text = rv.RAP_MED2;
            }

            txtNomVisiteur.Text = v.VIS_NOM;
            txtNumPraticien.Text = p.PRA_NUM.ToString();
            txtNomPraticien.Text = p.PRA_NOM;
            txtNumRapport.Text = numRapport.ToString();
            txtDateVisite.Text = dateVisite;
            txtMotifVisite.Text = motifVisite;
            txtCoefConf.Text = coefConfiance;
        }

        private void btnInfoPraticien_Click(object sender, EventArgs e)
        {
            frmInfoPraticien IP = new frmInfoPraticien(P);
            IP.Show();
        }

        private void btnInfoMed1_Click(object sender, EventArgs e)
        {
            if(txtCodeMed1.Text == "")
            {
                MessageBox.Show("Aucun médicament", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                frmInfoMedicament IM = new frmInfoMedicament(txtCodeMed1.Text);
                IM.Show();
            }
        }

        private void btnInfoMed2_Click(object sender, EventArgs e)
        {
            if (txtCodeMed2.Text == "")
            {
                MessageBox.Show("Aucun médicament", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmInfoMedicament IM = new frmInfoMedicament(txtCodeMed2.Text);
                IM.Show();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapprotByNum(Convert.ToInt32(txtNumRapport.Text));

            foreach(RAPPORT_VISITE rv in lesRapports)
            {
                Manager.MajRapport(rv.RAP_NUM, rv.RAP_MATRICULE);
            }
            Close();
        }
    }
}
