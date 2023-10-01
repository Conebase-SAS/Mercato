using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Handlers;
using Mercato.Models;
using Mercato.Controllers;

namespace Mercato.Views.Forms
{
    public partial class frm_fournisseurs : Form
    {
        clsFournisseur cls = new clsFournisseur();
        Datalib datalib = new Datalib();
        Fournisseur fournisseur = new Fournisseur();
        public frm_fournisseurs()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            txt_designation.Text = "";
            txt_id_fournisseur.Text = "";
            txt_telephone.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_telephone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_fournisseur.Text==""||txt_telephone.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Veuillez compléter les cases manquantes!");
            }
            else
            {
                fournisseur.Id_fournisseur = txt_id_fournisseur.Text;
                fournisseur.designation_fournisseur = txt_designation.Text;
                fournisseur.telephone = txt_telephone.Text;
                cls.enregistrer_fournisseurs(fournisseur);
                refresh();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
