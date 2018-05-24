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
    public partial class frmDetailRap : Form
    {
        public frmDetailRap(Int32 num)
        {
            InitializeComponent();

            List<RAPPORT_VISITE> rv = Manager.ChargerRapprotByNum(num);
            foreach(RAPPORT_VISITE v in rv)
            {
                txtnumrap.Text = v.RAP_NUM.ToString();
                txtnumpra.Text = v.RAP_PRANUM.ToString();
                txtetat.Text = v.RAP_ETAT.ToString();
                txtdate.Text = v.RAP_DATE.ToString();

                if(v.RAP_MED1 != null)
                {
                    txtmed1.Text = v.RAP_MED1;
                }
                if (v.RAP_MED2 != null)
                {
                    txtmed2.Text = v.RAP_MED2;
                }
            }


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetailRap_Load(object sender, EventArgs e)
        {

        }

        private void txtnumrap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
