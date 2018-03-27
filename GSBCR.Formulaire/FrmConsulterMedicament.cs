using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.BLL;
using GSBCR.modele;
using System.Windows.Forms;
using GSBCR.DAL;

namespace GSBCR.Formulaire
{
    public partial class FrmConsulterMedicament : Form
    {
        public FrmConsulterMedicament()
        {
            InitializeComponent();
            //initialisation des listes déroulantes médicaments et échantillons
            List<MEDICAMENT> lmed = Manager.ChargerMedicaments();

            cbxMed1.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMed1.ValueMember = "MED_DEPOTLEGAL";
            cbxMed1.SelectedIndex = -1;

            bsMed1.DataSource = lmed;
            cbxMed1.DataSource = bsMed1;
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void cbxMed1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMed1.SelectedIndex != -1)
                {          
                    txtMed1.Text = cbxMed1.SelectedValue.ToString();
                }
                else
                {
                    txtMed1.Text = String.Empty;
                }
        }

        private void btnVoirMedoc_Click(object sender, EventArgs e)
        {
            MEDICAMENT m = Manager.ChargerLeMedicament(txtMed1.Text);
            txtCompo.Text = m.MED_COMPOSITION;
            txtCodeFam.Text = m.FAM_CODE;
            txtContrIndic.Text =  m.MED_CONTREINDIC;
            txtEffet.Text = m.MED_EFFETS;
        }

        private void btnVoirRapportMed_Click(object sender, EventArgs e)
        {
            /*List<string> matricule = matricule;
            List<RAPPORT_VISITE> lr = RapportVisiteDAO.FindBymedicamentEtVisiteur();
            bsRapports*/
        }
    }
}
