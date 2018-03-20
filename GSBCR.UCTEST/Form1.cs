using System;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bs_medoc.DataSource = Manager.ChargerMedicaments();
            cbx_medoc.DataSource = bs_medoc;
            cbx_medoc.DisplayMember = "MED_NOMCOMMERCIAL";
            cbx_medoc.ValueMember = "MED_DEPOTLEGAL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedoc.Visible = false;
            cbx_medoc.SelectedIndex = -1;
        }

        private void cbx_medoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_medoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbx_medoc.SelectedItem;
                ucMedoc.LeMedicament = m;
                ucMedoc.Visible = true;
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
