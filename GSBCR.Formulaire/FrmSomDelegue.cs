using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
