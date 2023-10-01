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
    public partial class uc_clients : UserControl
    {
        Datalib datalib = new Datalib();        
        Clients clients = new Clients();
        clsClients cls_clients = new clsClients();
        public uc_clients()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls_clients.afficher_clients(dataGridView1);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_clients ();
            fr.ShowDialog();
        }

        private void txt_search_onValueChanged(object sender, EventArgs e)
        {
            clients.Noms = txt_search.Text;
            cls_clients.rechercher_clients_by_noms(clients, dataGridView1);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_clients fr = new frm_clients();
            fr.txt_id_client.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fr.txt_noms_client.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.txt_adresse.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.txt_telephone1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fr.txt_telephone2.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            fr.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frm_clients fr = new frm_clients();
            fr.txt_id_client.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fr.txt_noms_client.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.txt_adresse.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.txt_telephone1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fr.txt_telephone2.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            fr.ShowDialog();
        }
    }
}
