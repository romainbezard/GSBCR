using System;
using System.Windows.Forms;
using GSBCR.modele;
using System.Collections.Generic;
using GSBCR.BLL;

namespace GSBCR.Formulaire
{
    public partial class frmListeMedecin : Form
    {
        private List<PRATICIEN> lesPraticiens;

        public frmListeMedecin()
        {
            InitializeComponent();
        }

        private void frmListeMedecin_Load(object sender, EventArgs e)
        {
            lesPraticiens = Manager.ChargerPraticiens();
            foreach(PRATICIEN p in lesPraticiens)
            {
                //DgPraticiens.Rows.Add(p.PRA_NUM, p.PRA_NOM, p.PRA_PRENOM, p.PRA_ADRESSE, p.PRA_CP, p.PRA_VILLE, p.PRA_COEFNOTORIETE, p.TYP_CODE, p.POSSEDERs, p.LeType, p.LesRapports);
                //Console.WriteLine(p.PRA_NUM + " " + p.PRA_NOM + " " + p.PRA_PRENOM + " " + p.PRA_ADRESSE + " " + p.PRA_CP + " " + p.PRA_VILLE + " " + p.PRA_COEFNOTORIETE + " " + p.TYP_CODE + " " + p.POSSEDERs + " " + p.LeType + " " + p.LesRapports);
                Console.WriteLine(p.PRA_NUM);
            }
        }
    }
}
