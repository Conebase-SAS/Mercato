using Mercato.Controllers;
using Mercato.Handlers;
using Mercato.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercato.Views.Forms
{
    public partial class frm_vente : Form
    {
        Datalib datalib = new Datalib();
        Calculs calcul = new Calculs();
        clsApprovisionnements cls_approv = new clsApprovisionnements();
        Approvisionnement approv = new Approvisionnement();
        public frm_vente()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_num_approv_OnValueChanged(object sender, EventArgs e)
        {
            approv.num_details = Convert.ToInt32(txt_num_approv.Text);
            cls_approv.sortie_par_article(approv, calcul);
            if(calcul.Qte_sortie>0)
            {
                int dispo;
                dispo = Convert.ToInt32(txt_qte_initiale.Text) - calcul.Qte_sortie;
                txt_qte_disponible.Text = Convert.ToString(dispo);
            }
            else
            {
                txt_qte_disponible.Text = "Stock insuffisant!";
            }
            
        }
    }
}
