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
    public partial class FrmSomDelegue : Form
    {
        public FrmSomDelegue()
        {
            InitializeComponent();
        }

        private void FrmSomDelegue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void bntNouveauRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = null;
            FrmAjoutRapport ajoutr = new FrmAjoutRapport(r, true);
            ajoutr.Show();
        }
    }
}
