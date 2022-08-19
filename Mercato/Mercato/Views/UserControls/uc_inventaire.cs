using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercato.Handlers;
using Mercato.Controllers;
using Mercato.Models;

namespace Mercato.Views.UserControls
{
    public partial class uc_inventaire : UserControl
    {
        Datalib datalib = new Datalib();
        clsApprovisionnements cls_approv = new clsApprovisionnements();
        clsDetails_Ventes cls_details_vente = new clsDetails_Ventes();
        Details_Ventes detail_vente = new Details_Ventes();
        Approvisionnement approv = new Approvisionnement();
        public uc_inventaire()
        {
            InitializeComponent();
            refresh();
        }
        private void refresh()
        {
            cls_approv.recuperer_inventaire(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
