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
    public partial class frmInfoRapportRegion : Form
    {
        public frmInfoRapportRegion(PRATICIEN p, VISITEUR v, string numRapport, string dateVisite, string motifVisite, string coefConfiance, string CodeMed1)
        {
            InitializeComponent();
            txtNomVisiteur.Text = v.VIS_NOM;
            txtNumPraticien.Text = p.PRA_NUM.ToString();
            txtNomPraticien.Text = p.PRA_NOM;
            txtNumRapport.Text = numRapport;
            txtDateVisite.Text = dateVisite;
            txtMotifVisite.Text = motifVisite;
            txtCoefConf.Text = coefConfiance;
            txtCodeMed1.Text = CodeMed1;
            //txtCodeMed2.Text = CodeMed2;
        }


    }
}
