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
                //recuperation des sommes deja payés pour cette vente

                paiement.Num_vente = Convert.ToInt32(txt_num_vente.Text);
                cls_paiement.recuperer_deja_payé(paiement);

                // Recuperation informations sur la facture

                detail_vente.Num_vente = Convert.ToInt32(txt_num_vente.Text);
                cls_details_vente.recuperer_facture_details(detail_vente, dataGridView1);
                cls_details_vente.recuperer_total_facture(detail_vente);

                // Calculs

                txt_total_dollars.Text = Convert.ToString(detail_vente.Total_facture_dollars);
                txt_total_fc.Text = Convert.ToString(detail_vente.Total_facture_fc);
                txt_deja_paye.Text = Convert.ToString(paiement.Montant_deja_paye);

                if (txt_deja_paye.Text == txt_total_dollars.Text && txt_total_dollars.Text != "0")
                {
                    button1.Enabled = false;
                    MessageBox.Show("Facture deja payée!");
                }
                else if (txt_deja_paye.Text == txt_total_dollars.Text && txt_total_dollars.Text == "0")
                {
                    button1.Enabled = false;
                    MessageBox.Show("Facture non existante!");
                }
                else
                {
                    button1.Enabled = true;
                }

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
                paiement.Solde_restant = (detail_vente.Total_facture_dollars - paiement.Montant_deja_paye) - paiement.Montant_dollars;
                MessageBox.Show(paiement.Solde_restant.ToString());
                if(paiement.Solde_restant==0)
                {
                    paiement.Status ="Payée";
                }
                else
                {
                    paiement.Status = "Paiement partiel";
                }
                cls_paiement.enregistrer_paiement(paiement);
                txt_num_vente_OnValueChanged(sender, e);
            }
        }

        private void txt_num_vente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_total_dollars_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_total_fc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_montant_paye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
