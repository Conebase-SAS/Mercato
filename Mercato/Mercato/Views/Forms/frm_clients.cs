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
    public partial class frm_clients : Form
    {
        Datalib datalib = new Datalib();
        Clients clients = new Clients();
        clsClients cls_clients = new clsClients();
        public frm_clients()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            txt_id_client.Text = "";
            txt_adresse.Text = "";
            txt_noms_client.Text = "";
            txt_telephone1.Text = "";
            txt_telephone2.Text = "";
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
            if(txt_id_client.Text=="")
            {
                MessageBox.Show("Code client non selectionné");
            }
            var rs =new DialogResult();
            rs = MessageBox.Show("Confirmez vous la suppression de cet enregistrement?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs==DialogResult.Yes)
            {
                clients.Id_clients = txt_id_client.Text;
                cls_clients.supprimer_client(clients);
                refresh();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_client.Text==""||txt_noms_client.Text==""||txt_telephone1.Text=="")
            {
                MessageBox.Show("Veuillez completez les informations à enregistrer");
            }
            else
            {
                clients.Id_clients = txt_id_client.Text;
                clients.Noms = txt_noms_client.Text;
                clients.Adresse = txt_adresse.Text;
                clients.Telephone_mobile = txt_telephone1.Text;
                clients.Telephone_work = txt_telephone2.Text;
                cls_clients.enregistrer_client(clients);
                refresh();
            }
        }
    }
}
