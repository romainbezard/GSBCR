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
    public partial class frmConsulterRapportSecteurResp : Form
    {
        private string matricule;
        public frmConsulterRapportSecteurResp(string Matricule)
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

             /*foreach (REGION laReg in lesRegionsDuSecteur)
            {
                cbxRegion.Items.Add(laReg.REG_NOM);
            }*/
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

        private void frmConsulterRapportSecteurResp_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnConsulterRapport_Click(object sender, EventArgs e)
        {
            string codeRegion = txtRegion.Text;
            List<RAPPORT_VISITE> lesRapports = RapportVisiteDAO.FindByCodeRegion(codeRegion);

            this.bsRapports.SuspendBinding();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Invalidate();
            this.bsRapports.ResumeBinding();
            this.dataGridView1.Enabled = true;
            this.dataGridView1.Refresh();

            bsRapports.DataSource = lesRapports;
            dataGridView1.DataSource = bsRapports;
            dataGridView1.Columns.Remove("leMedicament1");
            dataGridView1.Columns.Remove("leMedicament2");
            dataGridView1.Columns.Remove("leMotifVisite");
            dataGridView1.Columns.Remove("LesEchantillonsOfferts");
            dataGridView1.Columns.Remove("lePraticien");
            dataGridView1.Columns.Remove("leVisiteur");

            if (bsRapports.Count == 0)
            {
                MessageBox.Show("Aucun rapport de visite pour cette région", "Aucun rapport", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
