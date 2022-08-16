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
    public partial class frm_shop : Form
    {
        Datalib datalib = new Datalib();
        clsBoutique clsboutique = new clsBoutique();
        Boutique boutique = new Boutique();
        public frm_shop()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {            
            txt_compagnie.Text = Properties.Settings.Default.Id_company;
            txt_designation.Text = "";
            txt_id_boutique.Text = Properties.Settings.Default.Id_boutique;
            txt_password.Text = "";
            cbx_level.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbx_level.Text==""||txt_password.Text==""||txt_id_boutique.Text==""||txt_compagnie.Text=="")
            {
                MessageBox.Show("Veuillez completer les champs obligatoires!");
            }
            else
            {
                boutique.Admin_level = cbx_level.Text;
                boutique.Designation = txt_designation.Text;
                boutique.Id_boutique = txt_id_boutique.Text;
                boutique.Id_compagnie = txt_compagnie.Text;
                boutique.Password = txt_password.Text;
                clsboutique.enregistrer_boutique(boutique);                
            }
            
        }
    }
}
