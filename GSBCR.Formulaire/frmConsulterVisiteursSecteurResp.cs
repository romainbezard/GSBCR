using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.Formulaire
{
    public partial class frmConsulterVisiteursSecteurResp : Form
    {
        private string matricule;
        public frmConsulterVisiteursSecteurResp(string Matricule)
        {
            InitializeComponent();
            matricule = Matricule;

            string codeSecteur = Manager.ChargerLeCodeSecteurDuResponsable(matricule);
            List<REGION> lesRegionsDuSecteur = Manager.ChargerRegionParSecteur(codeSecteur);

            cbxRegion.DisplayMember = "REG_NOM";
            cbxRegion.ValueMember = "REG_CODE";
            cbxRegion.SelectedIndex = -1;

            bsRegion.DataSource = lesRegionsDuSecteur;
            cbxRegion.DataSource = bsRegion;
        }

        private void btnConsulterVisiteur_Click(object sender, EventArgs e)
        {
            string codeRegion = txtRegion.Text;
            List<VISITEUR> lesVisiteurs = VisiteurDAO.FindByCodeRegion(codeRegion);

            this.bsVisiteurs.SuspendBinding();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Invalidate();
            this.bsVisiteurs.ResumeBinding();
            this.dataGridView1.Enabled = true;
            this.dataGridView1.Refresh();

            bsVisiteurs.DataSource = lesVisiteurs;
            dataGridView1.DataSource = bsVisiteurs;
            dataGridView1.Columns.Remove("LesRapports");
            dataGridView1.Columns.Remove("LeSecteur");
            dataGridView1.Columns.Remove("LesAffectations");

            if (bsVisiteurs.Count == 0)
            {
                MessageBox.Show("Aucun visiteurs pour cette région", "Aucun visiteurs", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } 
             
        }

        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRegion.SelectedIndex != -1)
            {
                txtRegion.Text = cbxRegion.SelectedValue.ToString();
            }
            else
            {
                txtRegion.Text = String.Empty;
            }
        }

        private void frmConsulterVisiteursSecteurResp_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
