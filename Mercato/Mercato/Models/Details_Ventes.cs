using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Details_Ventes
    {
        public int Num_details_vente { get; set; }
        public int Num_vente { get; set; }
        public DateTime Date_details_vente { get; set; }
        public int Num_details { get; set; }
        public int Qte_sortie { get; set; }
        public int Total_facture_dollars { get; set; }
        public int Total_facture_fc { get; set; }
    }
}
