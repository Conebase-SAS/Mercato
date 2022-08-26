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
    public partial class frm_articles : Form
    {
        Datalib datalib = new Datalib();
        clsPaquetage cls = new clsPaquetage();        
        Paquetage paquetage = new Paquetage();
        clsTypes_Articles cls_types = new clsTypes_Articles();
        Types_Articles types_articles = new Types_Articles();
        clsCategorie cls_cat = new clsCategorie();
        clsArticles cls_art = new clsArticles();
        Articles articles = new Articles();
        public frm_articles()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            txt_id_article.Text = "";
            txt_designation.Text = "";
            txt_description.Text = "";            
            cbx_categorie.Text = "";
            cbx_paquetage.Text = "";
            cbx_type.Text = "";
            cls.charger_paquetage(cbx_paquetage);
            cls_types.charger_types_articles(cbx_type);
            cls_cat.charger_categories_articles(cbx_categorie);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            var fr = new frm_paquetage();
            fr.ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            var fr = new frm_types_articles();
            fr.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            var fr = new frm_categories();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_article.Text==""||txt_designation.Text==""||txt_description.Text==""||cbx_type.Text==""||cbx_paquetage.Text==""||cbx_categorie.Text=="")
            {
                MessageBox.Show("Completez les cases manquantes!");
            }
            else
            {
                articles.Id_article = txt_id_article.Text;
                articles.Designation_article = txt_designation.Text;
                articles.Id_categories_articles = cbx_categorie.Text;
                articles.Id_types_articles = cbx_type.Text;
                articles.Id_paquetage = cbx_paquetage.Text;
                articles.Description_articles = txt_description.Text;
                cls_art.enregistrer_articles(articles);
                //MessageBox.Show(articles.ToString());
                refresh();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(txt_id_article.Text!="")
            {
                DialogResult rs = MessageBox.Show(this, "Voulez vous supprimer cet article?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                if (rs==DialogResult.Yes)
                {
                    articles.Id_article = txt_id_article.Text;
                    cls_art.supprimer_articles(articles);
                    refresh();
                }
            }
        }
    }
}
