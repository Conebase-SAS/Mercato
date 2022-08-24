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
    public partial class uc_utilisateurs : UserControl
    {
        Datalib datalib = new Datalib();        
        Boutique boutique = new Boutique();
        clsBoutique cls_boutique = new clsBoutique();
        public uc_utilisateurs()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            boutique.Id_compagnie = Properties.Settings.Default.Id_company;
            boutique.Id_boutique = Properties.Settings.Default.Id_boutique;
            cls_boutique.afficher_login(boutique, dataGridView1);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var fr = new frm_shop ();
            fr.ShowDialog();
        }

        private void txt_search_OnValueChanged(object sender, EventArgs e)
        {
            //boutique.Id_boutique = txt_search.Text;
            //cls_boutique(clients, dataGridView1);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frm_shop fr = new frm_shop();
            fr.txt_id_boutique.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            fr.txt_designation.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            fr.txt_password.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            fr.txt_compagnie.Text = Properties.Settings.Default.Id_company;
            fr.ShowDialog();
        }
    }
}
