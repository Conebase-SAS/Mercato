using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Views.Forms;

namespace Mercato.Views.UserControls
{
    public partial class uc_clients : UserControl
    {
        public uc_clients()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_clients ();
            fr.ShowDialog();
        }
    }
}
