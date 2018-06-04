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

using GSBCR.DAL;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class frmListeRapValide : Form
    {
        public frmListeRapValide(List<RAPPORT_VISITE> lrv)
        {
            InitializeComponent();
            bs.DataSource = lrv;
            dataGridView1.DataSource = lrv;
            if (bs.Count == 0)
            {
                MessageBox.Show("Aucun rapport n'est de type validé", "Aucun rapport", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmListeRapValide_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int bru = dataGridView1.SelectedRows;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            Int32 lrv = (Int32)row.Cells[1].Value;
            frmDetailRap f = new frmDetailRap(lrv);
            f.Show();
            
        }
    }
}
