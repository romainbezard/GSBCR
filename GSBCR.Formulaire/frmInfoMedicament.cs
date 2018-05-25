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
    public partial class frmInfoMedicament : Form
    {
        public frmInfoMedicament(string codeMedoc)
        {
            InitializeComponent();
            MEDICAMENT m = Manager.ChargerLeMedicament(codeMedoc);
            txtNomCommercial.Text = m.MED_NOMCOMMERCIAL;
            txtMed1.Text = m.MED_DEPOTLEGAL;
            txtEffet.Text = m.MED_EFFETS;
            txtCompo.Text = m.MED_COMPOSITION;
            txtContrIndic.Text = m.MED_CONTREINDIC;
            txtCodeFam.Text = m.FAM_CODE;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
