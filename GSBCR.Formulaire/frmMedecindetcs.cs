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
    public partial class frmMedecindetcs : Form
    {
        public frmMedecindetcs(List<PRATICIEN> lrv)
        {
            InitializeComponent();

            this.bsmed.SuspendBinding();
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Invalidate();
            this.bsmed.ResumeBinding();
            this.dataGridView1.Enabled = true;
            this.dataGridView1.Refresh();

            bsmed.DataSource = lrv;
            dataGridView1.DataSource = bsmed;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMedecindetcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
