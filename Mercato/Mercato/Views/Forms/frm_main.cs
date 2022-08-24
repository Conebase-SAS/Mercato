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
using Mercato.Views.UserControls;

namespace Mercato.Views.Forms
{
    public partial class frm_main : Form
    {
        Boutique boutique = new Boutique();
        public frm_main()
        {
            InitializeComponent();
            //activate_admin(true);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
        public void activate_admin(bool answer)
        {
            btn_stock.Visible = answer;
            //MessageBox.Show("btn_stock visible set to " + answer.ToString());
            btn_inventory.Visible = answer;
            btn_users.Visible = answer;
            btn_settings.Visible = answer;
            btn_finances.Visible = answer;
        }
        private void btn_inventory_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Inventaire";
            var fr = new uc_inventaire()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Approvisionnements";
            var fr = new uc_approvisionnement()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Ventes Services";
            var fr = new uc_ventes_services()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Clients";
            var fr = new uc_clients()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_articles_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Ventes articles";
            var fr = new uc_ventes_articles()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_users_Click_1(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Utilisateurs";
            var fr = new uc_utilisateurs()
            {
                Size = pnl_body.Size
            };
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fr = new frm_logins();
            fr.txt_password.Text = "";
            fr.Show();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Dashboard";
        }

        private void btn_finances_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Finances";
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            lbl_titre.Text = "Mercato - Paramètres";
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
