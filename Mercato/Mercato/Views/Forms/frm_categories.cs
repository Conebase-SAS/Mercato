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
    public partial class frm_categories : Form
    {
        clsCategorie cls = new clsCategorie();
        Datalib datalib = new Datalib();
        Categorie categorie = new Categorie();
        public frm_categories()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_id_categorie.Text = "";
            txt_designation.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_categorie.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Veuillez completer les cases manquantes !");
            }
            else
            {
                categorie.Id_categories_articles = txt_id_categorie.Text;
                categorie.Designation_categories_articles = txt_designation.Text;
                cls.enregistrer_categories_articles(categorie);
                refresh();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
