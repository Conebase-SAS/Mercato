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
    public partial class frm_paquetage : Form
    {
        clsPaquetage cls = new clsPaquetage();
        Datalib datalib = new Datalib();
        Paquetage paquetage = new Paquetage();
        public frm_paquetage()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_designation.Text = "";
            txt_id_paquetage.Text = "";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_paquetage.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Completez les cases manquantes!");
            }
            else
            {
                paquetage.Id_paquetage = txt_id_paquetage.Text;
                paquetage.designation_paquetage = txt_designation.Text;
                cls.enregistrer_paquetage(paquetage);
                refresh();
            }
        }
    }
}
