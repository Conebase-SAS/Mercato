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
        clsDetails_Ventes cls_details_vente = new clsDetails_Ventes();
        Details_Ventes detail_vente = new Details_Ventes();
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
            if (int.TryParse(txt_qte_voulue.Text, out _))
            {
                if (Convert.ToInt32(txt_qte_voulue.Text) <= Convert.ToInt32(txt_qte_disponible.Text))
                {
                    if(txt_num_approv.Text!=""||txt_qte_voulue.Text!="")
                    {
                        if (txt_num_vente.Text == "")
                        {
                            detail_vente.Num_details_vente = 0;
                        }
                        else
                        {
                            if (int.TryParse(txt_num_vente.Text, out _))
                            {
                                detail_vente.Num_details_vente = Convert.ToInt32(txt_num_vente.Text);
                            }
                        }
                        detail_vente.Num_details = Convert.ToInt32(txt_num_approv.Text);
                        detail_vente.Date_details_vente = DateTime.Now;
                        detail_vente.Num_vente = Convert.ToInt32(txt_num_vente.Text);
                        detail_vente.Qte_sortie = Convert.ToInt32(txt_qte_voulue.Text);
                        cls_details_vente.enregistrer_details_vente(detail_vente);

                        // appel de la mise a jour du stock

                        cls_approv.sortie_par_article(approv, calcul);
                        cls_approv.recuperer_qte_initiale(approv, calcul);
                        int dispo;
                        dispo = calcul.Qte_initiale - calcul.Qte_sortie;
                        if(dispo==0)
                        {
                            approv.stats_vente = "Ecoulé";
                            cls_approv.update_stock_state(approv);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informations manquantes! "+e.ToString());
                    }
                    
                }
                else
                {
                    MessageBox.Show("La quantité demandée est supérieure à ce que vous avez de disponible");
                }
            }
        }

        private void txt_num_approv_OnValueChanged(object sender, EventArgs e)
        {
            approv.num_details = Convert.ToInt32(txt_num_approv.Text);
            cls_approv.sortie_par_article(approv, calcul);
            cls_approv.recuperer_qte_initiale(approv, calcul);
            txt_qte_initiale.Text = Convert.ToString(calcul.Qte_initiale);
            if(calcul.Qte_sortie>=0)
            {
                int dispo;
                dispo = Convert.ToInt32(txt_qte_initiale.Text) - calcul.Qte_sortie;
                txt_qte_disponible.Text = Convert.ToString(dispo);
            }
            else
            {
                txt_qte_disponible.Text = "Stock insuffisant!";
            }
            txt_qte_disponible.Text = Convert.ToString(calcul.Qte_initiale - calcul.Qte_sortie);
            
        }
    }
}
