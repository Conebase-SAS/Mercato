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
using Mercato.Views.Forms;

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
        Boutique boutique = new Boutique();

        public uc_ventes_articles()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            //cls_art.charger_listbox_article(listBox1);
            cls_clients.charger_clients(cbx_clients);
            cls_approv.afficher_articles_disponible(dataGridView1);
            txt_article.Text = "";
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //articles.Id_article = txt_search.Text;
            //cls_art.rechercher_article(listBox1, articles);
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            //articles.Id_article = txt_search.Text;
            //cls_art.rechercher_article(listBox1, articles);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //txt_article.Text = listBox1.SelectedItem.ToString();
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

        private void txt_article_OnValueChanged(object sender, EventArgs e)
        {
            approvisionnement.Id_article = txt_article.Text;
            cls_approv.rechercher_articles_disponible_nom(dataGridView1, approvisionnement);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (cbx_clients.Text == "")
            {
                MessageBox.Show("Selectionner un client!");
            }
            else
            {
                if (txt_num_vente.Text == "")
                {
                    vente.Num_vente = 0;
                }
                else
                {
                    vente.Num_vente = Convert.ToInt32(txt_num_vente.Text);
                }
                vente.Id_clients = cbx_clients.Text;
                vente.Id_boutique = Properties.Settings.Default.Id_boutique;
                vente.Description_ventes = "Vente articles";
                vente.Date_vente = DateTime.Now;
                vente.Vente_id = Guid.NewGuid().ToString();
                MessageBox.Show(boutique.Id_boutique);
                cls_ventes.enregistrer_vente(vente);
                txt_num_vente.Text =Convert.ToString(vente.Num_vente);
            }
        }

        private void txt_numero_serie_OnValueChanged(object sender, EventArgs e)
        {
            approvisionnement.Numero_serie = txt_numero_serie.Text;
            cls_approv.rechercher_articles_disponible_serie(dataGridView1, approvisionnement);
        }

        private void txt_caracterisitques_OnValueChanged(object sender, EventArgs e)
        {
            approvisionnement.Caracteristiques = txt_caracterisitques.Text;
            cls_approv.rechercher_articles_disponible_specs(dataGridView1, approvisionnement);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_vente fr = new frm_vente();
            fr.txt_num_vente.Text = txt_num_vente.Text;
            fr.txt_num_approv.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fr.txt_article.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.txt_numero_serie.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.txt_couleur.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fr.txt_caracteristiques.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            fr.txt_prix_vente_dollars.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            fr.txt_prix_vente_fc.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            fr.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {
            frm_pay_articles fr = new frm_pay_articles();
            fr.txt_num_vente.Text = txt_num_vente.Text;
            fr.ShowDialog();
        }
    }
}
