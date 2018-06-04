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
    public partial class FrmSaisieModifRapport : Form
    {
        private int numrapport;
        public FrmSaisieModifRapport(int num)
        {
            InitializeComponent();
            numrapport = num;
            List<RAPPORT_VISITE> lrv = Manager.ChargerRapprotByNum(num);
            RAPPORT_VISITE rv = lrv[0];

            List<MEDICAMENT> lm = Manager.ChargerMedicaments();

            CbMed1.DisplayMember = "MED_NOMCOMMERCIAL";
            CbMed1.ValueMember = "MED_DEPOTLEGAL";

            CbMed2.DisplayMember = "MED_NOMCOMMERCIAL";
            CbMed2.ValueMember = "MED_DEPOTLEGAL";

            BsMed1.DataSource = lm;
            CbMed1.DataSource = BsMed1;

            BsMed2.DataSource = lm;
            CbMed2.DataSource = BsMed2;



            LbRapNum.Text = rv.RAP_NUM.ToString();
            TbPra.Text = rv.RAP_PRANUM.ToString();
            TbBilan.Text = rv.RAP_BILAN;
            TbConf.Text = rv.RAP_CONFIANCE;
            TbMotif.Text = rv.RAP_MOTIF;

            LbEtat.Text = rv.RAP_ETAT;

            LbDate.Text = rv.RAP_DATVISIT.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSaisieModifRapport_Load(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lrv = Manager.ChargerRapprotByNum(numrapport);
            RAPPORT_VISITE rv = lrv[0];
            MessageBox.Show("Valeur de MED1 :" + rv.RAP_MED1.ToString(), "Erreur", MessageBoxButtons.OK);

            if (rv.RAP_MED1 != null)
            {
                CbMed1.SelectedIndex = BsMed1.Find("MED_DEPOTLEGAL", rv.RAP_MED1);
            }
            else
            {
                CbMed1.SelectedIndex = -1;
            }
            if (rv.RAP_MED2 != null)
            {
                CbMed2.SelectedIndex = BsMed2.Find("MED_DEPOTLEGAL", rv.RAP_MED2);
            }
            else
            {
                CbMed2.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CbMed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
