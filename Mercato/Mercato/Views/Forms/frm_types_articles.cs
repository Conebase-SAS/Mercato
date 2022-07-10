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
    public partial class frm_types_articles : Form
    {
        clsTypes_Articles cls = new clsTypes_Articles();
        Datalib datalib = new Datalib();
        Types_Articles types_articles = new Types_Articles();
        public frm_types_articles()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            txt_id_type.Text = "";
            txt_designation.Text = "";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_type.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Veuillez completer les cases manquantes!");
            }
            else
            {
                types_articles.Id_types_articles = txt_id_type.Text;
                types_articles.Designation_types_articles = txt_designation.Text;
                cls.enregistrer_types_articles(types_articles);
                refresh();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(txt_id_type.Text=="")
            {
                MessageBox.Show("Completez le numéro de l'enregistrement à supprimer");
            }
            else
            {
                types_articles.Id_types_articles = txt_id_type.Text;
                cls.supprimer_types_articles(types_articles);
            }
        }
    }
}
