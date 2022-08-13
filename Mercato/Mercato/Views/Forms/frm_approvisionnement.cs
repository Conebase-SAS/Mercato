using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Controllers;
using Mercato.Handlers;
using Mercato.Models;
using Mercato.Views.Forms;

namespace Mercato.Views.Forms
{
    public partial class frm_approvisionnement : Form
    {
        Notification_Center notify = new Notification_Center();
        clsDepot cls = new clsDepot();
        Datalib datalib = new Datalib();
        Depot depot = new Depot();
        clsFournisseur cls_fournisseur = new clsFournisseur();
        Fournisseur fournisseur = new Fournisseur();
        clsArticles cls_art = new clsArticles();
        Articles articles = new Articles();
        clsApprovisionnements cls_approv = new clsApprovisionnements();
        Approvisionnement approvisionnement = new Approvisionnement();
        clsCouleurs cls_couleurs = new clsCouleurs();
        Couleurs couleurs = new Couleurs();
        
        public frm_approvisionnement()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls.charger_depot(cbx_depot);
            cls_art.charger_listbox_article(listBox1);
            cls_fournisseur.charger_fournisseurs(cbx_fournisseur);
            cls_couleurs.recuperer_couleur(cbx_couleur);
            txt_article.Text = "";
            txt_num_approv.Text = "";
            txt_points.Text = "";
            txt_prix_achat_dollars.Text = "";
            txt_prix_achat_francs.Text = "";
            txt_prix_vente_dollars.Text = "";
            txt_prix_vente_fc.Text = "";
            txt_caracteristiques.Text = "";
            txt_search.Text = "";
            cbx_depot.Text = "";
            cbx_fournisseur.Text = "";
            cbx_status.Text = "";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_fournisseur_Click(object sender, EventArgs e)
        {
            var fr = new frm_fournisseurs();
            fr.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            var fr = new frm_depot();
            fr.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            var fr = new frm_articles();
            fr.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_article.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
            
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            articles.Id_article = txt_search.Text;
            cls_art.rechercher_article(listBox1, articles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_article.Text==""||txt_prix_vente_dollars.Text==""||txt_prix_vente_fc.Text==""||txt_caracteristiques.Text=="")
            {
                MessageBox.Show("Veuillez completer les informations de base");
            }
            else
            {
                if(txt_num_approv.Text=="")
                {
                    approvisionnement.num_details = 0;
                }
                else
                {
                    approvisionnement.num_details = Convert.ToInt32(txt_num_approv.Text);
                }
                approvisionnement.Id_article = txt_article.Text;
                approvisionnement.Numero_serie = txt_numero_serie.Text;
                approvisionnement.Id_couleur = cbx_couleur.Text;
                approvisionnement.Caracteristiques = txt_caracteristiques.Text;
                approvisionnement.prix_achat_usd = Convert.ToDecimal(txt_prix_achat_dollars.Text);
                approvisionnement.prix_achat_fc = Convert.ToDecimal(txt_prix_achat_francs.Text);
                approvisionnement.qte_entree = Convert.ToDecimal(txt_qte.Text);
                approvisionnement.ID_fournisseurs = cbx_fournisseur.Text;
                approvisionnement.Date_expriation = dtpick_expiration.Value;
                approvisionnement.prix_vente_usd = Convert.ToDecimal(txt_prix_vente_dollars.Text);
                approvisionnement.prix_vente_fc = Convert.ToDecimal(txt_prix_vente_fc.Text);
                approvisionnement.points =Convert.ToInt32(txt_points.Text);
                approvisionnement.ID_Depot=cbx_depot.Text;
                approvisionnement.stats_vente=cbx_status.Text;
                cls_approv.enregistrer_approvisionement(approvisionnement);
            }
        }

        private void cbx_couleurs_Click(object sender, EventArgs e)
        {
            var fr = new frm_couleur();
            fr.ShowDialog();
        }
    }
}
