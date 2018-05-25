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
    public partial class frmInfoPraticien : Form
    {
        public frmInfoPraticien(PRATICIEN p)
        {
            InitializeComponent();
            txtPraNum.Text = p.PRA_NUM.ToString();
            txtPraNom.Text = p.PRA_NOM;
            txtPraPrenom.Text = p.PRA_PRENOM;
            txtPraAddr.Text = p.PRA_ADRESSE;
            txtPraVille.Text = p.PRA_VILLE;
            txtPraCP.Text = p.PRA_CP;
            txtPraCoefNot.Text = p.PRA_COEFNOTORIETE.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
