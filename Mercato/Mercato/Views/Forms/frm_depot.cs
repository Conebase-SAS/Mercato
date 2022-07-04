using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Models;
using Mercato.Handlers;
using Mercato.Controllers;

namespace Mercato.Views.Forms
{
    public partial class frm_depot : Form
    {
        Notification_Center notify = new Notification_Center();
        clsDepot cls = new clsDepot();
        Datalib datalib = new Datalib();
        Depot depot = new Depot();
        public frm_depot()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            txt_designation.Text = "";
            txt_id_depot.Text = "";
            txt_telephone.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_id_depot.Text==""||txt_designation.Text=="")
            {
                MessageBox.Show("Rassurez vous d'avoir complété les cases obligatoires!");
            }
            else
            {
                depot.Id_depot = txt_id_depot.Text;
                depot.designation_depot = txt_designation.Text;
                depot.telephone = txt_telephone.Text;
                cls.enregistrer_depot(depot);
                refresh();
            }
        }
    }
}
