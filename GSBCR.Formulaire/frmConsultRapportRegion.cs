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



            frmInfoRapportRegion information = new frmInfoRapportRegion(p, v, Convert.ToInt32(row.Cells[1].Value), row.Cells[3].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[4].Value.ToString());
            information.Show();
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
