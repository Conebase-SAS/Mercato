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
    public partial class frm_menu : Form
    {
        Notification_Center notify = new Notification_Center();
        clsMenu cls = new clsMenu();
        Datalib datalib = new Datalib();
        Menu_Services menu = new Menu_Services();
        public frm_menu()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_designation.Text = "";
            txt_id_service.Text = "";
            txt_prix.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if(txt_id_service.Text==""||txt_prix.Text=="")
            {
                MessageBox.Show("Entrez les informations sur le prix et le menu");
            }
            else
            {
                menu.Id_menu = txt_id_service.Text;
                menu.Designation = txt_designation.Text;
                menu.Prix = Convert.ToDecimal(txt_prix.Text);
                cls.enregistrer_menu(menu);
            }
        }
    }
}
