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

namespace GSBCR.Formulaire
{
    public partial class FrmModifierRapport : Form
    {
        public FrmModifierRapport(List<RAPPORT_VISITE> lrv)
        {
            InitializeComponent();

            this.bsRapportEnCours.SuspendBinding();
            this.Dgv1.Columns.Clear();
            this.Dgv1.AutoGenerateColumns = true;
            this.Dgv1.Enabled = false;
            this.Dgv1.Invalidate();
            this.bsRapportEnCours.ResumeBinding();
            this.Dgv1.Enabled = true;
            this.Dgv1.Refresh();

            bsRapportEnCours.DataSource = lrv;
            Dgv1.DataSource = bsRapportEnCours;


            
        }

        private void FrmModifierRapport_Load(object sender, EventArgs e)
        {
            Dgv1.Columns.Remove("RAP_MATRICULE");
            Dgv1.Columns.Remove("leMedicament1");
            Dgv1.Columns.Remove("leMedicament2");
            Dgv1.Columns.Remove("leMotifVisite");
            Dgv1.Columns.Remove("LesEchantillonsOfferts");
            Dgv1.Columns.Remove("lePraticien");
            Dgv1.Columns.Remove("leVisiteur");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {

        }

        private void Dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int bru = dataGridView1.SelectedRows;
            DataGridViewRow row = this.Dgv1.Rows[e.RowIndex];
            Int32 lrv = (Int32)row.Cells[0].Value;
            FrmSaisieModifRapport f = new FrmSaisieModifRapport(lrv);
            f.Show();
        }
    }
}
