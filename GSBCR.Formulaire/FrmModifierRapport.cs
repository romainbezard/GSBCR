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
        public FrmModifierRapport(List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            bsrapport.DataSource = lr;
            dataGridView1.DataSource = bsrapport;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAjoutRapport_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsrapport_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            RAPPORT_VISITE lr = (RAPPORT_VISITE)bsrapport.Current;
            txtnumrap.Text = lr.RAP_NUM.ToString();//8

            
        }

        private void btndeco_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            txtnumrap.Text = lr.RAP_NUM.ToString();
            txtmotif.Text = lr.RAP_MOTIF;
            txtautremotif.Text = lr.RAP_MOTIFAUTRE;
            txtbilan.Text = lr.RAP_BILAN;
            txtcoefconf.Text = lr.RAP_CONFIANCE;
            txtmed1.Text = lr.RAP_MED1;
            txtmed2.Text = lr.RAP_MED2;
            txtpract.Text = lr.RAP_PRANUM.ToString();
            txtpractremp.Text = lr.RAP_PNOMREMPL;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
