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
    public partial class frm_pay_articles : Form
    {
        Datalib datalib = new Datalib();
        clsDetails_Ventes cls_details_vente = new clsDetails_Ventes();
        Details_Ventes detail_vente = new Details_Ventes();
        clsPaiements cls_paiement = new clsPaiements();
        Paiement paiement = new Paiement();
        public frm_pay_articles()
        {
            InitializeComponent();
            recuperer_taux();
        }
        private void refresh()
        {

        }
        private void recuperer_taux()
        {
            cls_paiement.recuperer_taux(paiement);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_num_vente_OnValueChanged(object sender, EventArgs e)
        {
            if(txt_num_vente.Text!="")
            {
                detail_vente.Num_vente =Convert.ToInt32(txt_num_vente.Text);
                cls_details_vente.recuperer_facture_details(detail_vente, dataGridView1);
                cls_details_vente.recuperer_total_facture(detail_vente);
                txt_total_dollars.Text = Convert.ToString(detail_vente.Total_facture_dollars);
                txt_total_fc.Text = Convert.ToString(detail_vente.Total_facture_fc);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detail_vente.Num_details_vente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(txt_num_vente.Text!="")
            {
                var rs = new DialogResult();
                rs = MessageBox.Show(this, "Voulez vous enlever cet article", "Retrait d'article", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs==DialogResult.Yes)
                {
                    cls_details_vente.supprimer_details_vente(detail_vente);
                    txt_num_vente_OnValueChanged(sender, e);
                }                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_montant_paye.Text==""||txt_num_vente.Text=="")
            {
                MessageBox.Show("Completez les informations obligatoires!");
            }
            else
            {
                paiement.Num_vente = Convert.ToInt32(txt_num_vente.Text);
                paiement.Montant_dollars = Convert.ToDecimal(txt_montant_paye.Text);
                paiement.Montant_fc = paiement.Montant_dollars * paiement.Taux;
                paiement.Solde_restant = Convert.ToDecimal(txt_total_dollars.Text) - Convert.ToDecimal(txt_montant_paye.Text);
                MessageBox.Show(paiement.Num_vente.ToString());
                MessageBox.Show(paiement.Montant_dollars.ToString());
                MessageBox.Show(paiement.Montant_fc.ToString());
                MessageBox.Show(paiement.Solde_restant.ToString());
                // cls_paiement.enregistrer_paiement(paiement);
            }
        }
    }
}
