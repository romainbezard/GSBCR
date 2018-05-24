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
    public partial class frmConsultRapportRegion : Form
    {
        public frmConsultRapportRegion(List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            bs.DataSource = lr;
            Dg.DataSource = bs;
            
        }

        private void Dg_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.Dg.Rows[e.RowIndex];
            PRATICIEN p = Manager.ChargerLePraticien(Convert.ToInt32(row.Cells[2].Value));
            VISITEUR v = Manager.ChargerVisiteurMatricule(row.Cells[0].Value.ToString());
            string med1 = "rien";

            if (row.Cells[8].Value.ToString() == null)
            {
                med1 = row.Cells[8].Value.ToString();
            }

            //frmInfoRapportRegion information = new frmInfoRapportRegion(p, v, row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[8].Value.ToString());
            //information.Show();

            DialogResult d = MessageBox.Show("Numéros du praticien : " + row.Cells[2].Value.ToString() + "\n son nom : " + p.PRA_NOM + "\n Nom du visiteur : " + v.VIS_NOM
                + "\n Num rapport : " + row.Cells[1].Value.ToString() + "\n Date de la visite : " + row.Cells[3].Value.ToString() + "\n Motif : " + row.Cells[6].Value.ToString()
                + "\n Coef de confiance : " + row.Cells[4].Value.ToString() + "\n Code med1 : " + med1, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(d == DialogResult.OK)
            {
                // Procedure stockée UpRapport pas valide --> Donc erreur de lancement
            }
        }

        private void frmConsultRapportRegion_Load(object sender, EventArgs e)
        {
            Dg.Columns.Remove("leMedicament1");
            Dg.Columns.Remove("leMedicament2");
            Dg.Columns.Remove("leMotifVisite");
            Dg.Columns.Remove("LesEchantillonsOfferts");
            Dg.Columns.Remove("lePraticien");
            Dg.Columns.Remove("leVisiteur");
            Dg.Columns.Remove("RAP_DATE");
            Dg.Columns.Remove("RAP_ETAT");
            Dg.Columns.Remove("RAP_NOMREMPL");
            Dg.Columns.Remove("RAP_PNOMREMPL");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
