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
            string ntm = "";
            string leMedicament =  txtMed1.Text;
            List<RAPPORT_VISITE> lr = RapportVisiteDAO.FindByMedicament(leMedicament);
            foreach (RAPPORT_VISITE leRapport in lr)
            {
                ntm += leRapport.RAP_NUM + ", " ;
            }

            this.bsRapports.SuspendBinding();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Invalidate();
            this.bsRapports.ResumeBinding();
            this.dataGridView1.Enabled = true;
            this.dataGridView1.Refresh();

            bsRapports.DataSource = lr;
            dataGridView1.DataSource = bsRapports;
            dataGridView1.Columns.Remove("leMedicament1");
            dataGridView1.Columns.Remove("leMedicament2");
            dataGridView1.Columns.Remove("leMotifVisite");
            dataGridView1.Columns.Remove("LesEchantillonsOfferts");
            dataGridView1.Columns.Remove("lePraticien");
            dataGridView1.Columns.Remove("leVisiteur");

            if(bsRapports.Count == 0)
            {
                MessageBox.Show("Aucun rapport de visite pour ce médicament", "Aucun rapport", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bsRapports_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            Int32 numRapport = (Int32)row.Cells[1].Value;

            List<RAPPORT_VISITE> rv = Manager.ChargerRapprotByNum(numRapport);
            foreach(RAPPORT_VISITE v in rv)
            {
                string text = " Numéro du rapport : " + v.RAP_NUM + "\n Numéro du praticien : " + v.RAP_PRANUM + "\n Etat : "
                + v.RAP_ETAT + "\n Motif " + v.RAP_MOTIF + "\n Autre motif : " + v.RAP_MOTIFAUTRE + "\n Matricule du visiteur associé : " + v.RAP_MATRICULE
                + "\n Date : " + v.RAP_DATE + "\n Date Visite : " + v.RAP_DATVISIT + "\n Confiance : " + v.RAP_CONFIANCE + "\n Bilan : " + v.RAP_BILAN
                + "\n Médicament 1 : " + v.RAP_MED1 + "\n Médicament 2 : " + v.RAP_MED2 ;
                MessageBox.Show(text, "Détail du rapport" ,MessageBoxButtons.OK);
            }

            
        }
    }
}
