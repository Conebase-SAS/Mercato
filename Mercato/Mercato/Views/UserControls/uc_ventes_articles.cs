using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Handlers;
using Mercato.Controllers;
using Mercato.Models;

namespace Mercato.Views.UserControls
{
    public partial class uc_ventes_articles : UserControl
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
        clsClients cls_clients = new clsClients();
        Clients clients = new Clients();
        clsVentes cls_ventes = new clsVentes();
        Ventes vente = new Ventes();

        public uc_ventes_articles()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls_art.charger_listbox_article(listBox1);
            cls_clients.charger_clients(cbx_clients);
            txt_article.Text = "";
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            articles.Id_article = txt_search.Text;
            cls_art.rechercher_article(listBox1, articles);
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            articles.Id_article = txt_search.Text;
            cls_art.rechercher_article(listBox1, articles);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(cbx_clients.Text=="")
            {
                MessageBox.Show("Selectionner un client!");
            }
            else
            {
                if (txt_num_commande.Text == "")
                {
                    vente.Num_vente = 0;
                }
                else
                {
                    vente.Num_vente = Convert.ToInt32(txt_num_commande.Text);
                }
                vente.Id_clients = cbx_clients.Text;
                vente.Id_boutique = "ONE HORIZON 1";
                vente.Description_ventes = "Test";
                vente.Date_vente = DateTime.Now;
                vente.Vente_id = Environment.UserName;
                cls_ventes.enregistrer_vente(vente);
            }
            
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

        private void cbx_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cls_clients.recuperer_id_client();
            //MessageBox.Show(clients.Id_clients);
        }
    }
}
