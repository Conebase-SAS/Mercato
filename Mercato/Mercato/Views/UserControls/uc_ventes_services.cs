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
    public partial class uc_ventes_services : UserControl
    {
        Notification_Center notify = new Notification_Center();
        clsDepot cls = new clsDepot();
        Datalib datalib = new Datalib();
        Depot depot = new Depot();
        clsFournisseur cls_fournisseur = new clsFournisseur();
        Fournisseur fournisseur = new Fournisseur();
        clsMenu cls_menu = new clsMenu();
        Menu_Services menu = new Menu_Services();
        clsApprovisionnements cls_approv = new clsApprovisionnements();
        Approvisionnement approvisionnement = new Approvisionnement();
        clsClients cls_clients = new clsClients();
        Clients clients = new Clients();
        clsVentes cls_ventes = new clsVentes();
        Ventes vente = new Ventes();
        public uc_ventes_services()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls_menu.recuperer_menu(listBox1);
            cls_clients.charger_clients(cbx_clients);
            txt_services.Text = "";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_onValueChanged(object sender, EventArgs e)
        {
            menu.Id_menu = txt_search.Text;
            cls_menu.rechercher_menu(listBox1, menu);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_services.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void cbx_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_clients.recuperer_id_client(cbx_clients.Text, lbl_id_client);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frm_menu();
            frm.ShowDialog();
        }

        private void txt_services_onValueChanged(object sender, EventArgs e)
        {
            menu.Id_menu = txt_services.Text;
            cls_menu.Recuperer_prix_menu(txt_prix, menu);
        }

        private void txt_num_commande_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_qte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
