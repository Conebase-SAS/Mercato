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
using Mercato.Handlers;
using Mercato.Controllers;
using Mercato.Models;

namespace Mercato.Views.UserControls
{
    public partial class uc_approvisionnement : UserControl
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
        public uc_approvisionnement()
        {
            InitializeComponent();
            refresh();
        }
        
        private void refresh()
        {
            cls_approv.afficher_approvisionnement(dataGridView1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_approvisionnement();
            fr.ShowDialog();
        }
        private void rdbtn_produit_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_search.HintText = "Rechercher par nom de produit";
            rdbtn_status.Checked = false;
            rdbtn_fournisseur.Checked = false;
            rdbtn_approv.Checked = false;
        }

        private void rdbtn_approv_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_search.HintText = "Rechercher par approvisionnement de produit";
            rdbtn_status.Checked = false;
            rdbtn_fournisseur.Checked = false;
            rdbtn_produit.Checked = false;
        }

        private void rdbtn_status_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_search.HintText = "Rechercher par status du produit";
            rdbtn_produit.Checked = false;
            rdbtn_fournisseur.Checked = false;
            rdbtn_approv.Checked = false;
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            if(rdbtn_approv.Checked==true)
            {
                int myInt;
                if (int.TryParse(txt_search.Text, out myInt)) //if user input is a number then
                {
                    approvisionnement.num_details = Convert.ToInt32(txt_search.Text);
                    cls_approv.rechercher_approvisionnement_details(dataGridView1, approvisionnement);
                }
                else
                {

                }
                
            }
            if (rdbtn_fournisseur.Checked == true)
            {
                approvisionnement.ID_fournisseurs = txt_search.Text;
                cls_approv.rechercher_approvisionnement_fournisseur(dataGridView1, approvisionnement);
            }
            if (rdbtn_produit.Checked == true)
            {
                approvisionnement.Id_article = txt_search.Text;
                cls_approv.rechercher_approvisionnement_produit(dataGridView1, approvisionnement);
            }
            if (rdbtn_status.Checked == true)
            {
                approvisionnement.stats_vente = txt_search.Text;
                cls_approv.rechercher_approvisionnement_vente(dataGridView1, approvisionnement);
            }
            //dataGridView1.AutoResizeColumn();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void rdbtn_fournisseur_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_search.HintText = "Rechercher par fournisseur";
            rdbtn_status.Checked = false;
            rdbtn_fournisseur.Checked = false;
            rdbtn_approv.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_approvisionnement fr = new frm_approvisionnement();
            fr.txt_num_approv.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fr.txt_article.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.txt_prix_achat_dollars.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.txt_prix_achat_francs.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fr.txt_qte_entree.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            fr.cbx_fournisseur.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());

            fr.dtpick_expiration.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            fr.dtpick_debut_solde.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            fr.dt_pick_fin_solde.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            fr.txt_prix_vente_dollars.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            fr.txt_prix_vente_fc.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[10].Value.ToString());
            fr.txt_prix_solde_dollars.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[11].Value.ToString());
            fr.txt_prix_solde_fc.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
            fr.cbx_depot.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
            fr.txt_points.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[14].Value.ToString());
            fr.cbx_status.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[15].Value.ToString());
            fr.ShowDialog();
        }
    }
}
