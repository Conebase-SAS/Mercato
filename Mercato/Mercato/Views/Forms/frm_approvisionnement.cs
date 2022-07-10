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
            txt_article.Text = "";
            txt_num_approv.Text = "";
            txt_points.Text = "";
            txt_prix_achat_dollars.Text = "";
            txt_prix_achat_francs.Text = "";
            txt_prix_solde_dollars.Text = "";
            txt_prix_solde_fc.Text = "";
            txt_prix_vente_dollars.Text = "";
            txt_prix_vente_fc.Text = "";
            txt_qte_entree.Text = "";
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
            txt_article.Text = listBox1.SelectedItem.ToString();
        }
    }
}
