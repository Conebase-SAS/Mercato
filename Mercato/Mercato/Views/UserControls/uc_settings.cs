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
    public partial class uc_settings : UserControl
    {
        
        public uc_settings()
        {
            InitializeComponent();
        }        

        private void btn_articles_Click(object sender, EventArgs e)
        {
            var fr = new uc_articles()
            {
                Size = pnl_content.Size
            };
            pnl_content.Controls.Clear();
            pnl_content.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {

        }
    }
}
