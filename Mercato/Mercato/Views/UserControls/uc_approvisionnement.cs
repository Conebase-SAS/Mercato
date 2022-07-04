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
    public partial class uc_approvisionnement : UserControl
    {
        public uc_approvisionnement()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_approvisionnement();
            fr.ShowDialog();
        }

        private void rdbtn_noms_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.HintText = "Rechercher par fournisseur";
        }

        private void rdbtn_produit_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.HintText = "Rechercher par nom de produit";
        }

        private void rdbtn_approv_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.HintText = "Rechercher par approvisionnement de produit";
        }

        private void rdbtn_status_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.HintText = "Rechercher par status du produit";
        }
    }
}
