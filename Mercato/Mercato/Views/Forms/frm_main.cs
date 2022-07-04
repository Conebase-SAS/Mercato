using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Views.UserControls;

namespace Mercato.Views.Forms
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void button6_Click(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
