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
    public partial class uc_articles : UserControl
    {
        Datalib datalib = new Datalib();
        clsArticles cls_art = new clsArticles();
        Articles articles = new Articles();
        public uc_articles()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls_art.afficher_articles(dataGridView1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_articles();
            fr.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_articles fr = new frm_articles();
            fr.txt_id_article.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            fr.txt_designation.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.cbx_categorie.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.cbx_type.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            fr.cbx_paquetage.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            fr.txt_description.Text= Convert.ToString(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            fr.ShowDialog();
        }

        private void txt_search_onValueChanged(object sender, EventArgs e)
        {
            articles.Id_article = txt_search.Text;
            cls_art.rechercher_articles(articles, dataGridView1);
        }
    }
}
