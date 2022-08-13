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
    public partial class frm_couleur : Form
    {
        clsCouleurs cls = new clsCouleurs();
        Datalib datalib = new Datalib();
        Couleurs couleur = new Couleurs();
        public frm_couleur()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_designation.Text = "";
            txt_id_couleur.Text = "";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_couleur.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Completez les cases manquantes!");
            }
            else
            {
                couleur.ID_couleur = txt_id_couleur.Text;
                couleur.Designation = txt_designation.Text;
                cls.enregistrer_couleur(couleur);
                refresh();
            }
        }
    }
}
