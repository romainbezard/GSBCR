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
    public partial class frmConsultRapportRegion : Form
    {
        public frmConsultRapportRegion(List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            bs.DataSource = lr;
            Dg.DataSource = lr;
        }
    }
}
