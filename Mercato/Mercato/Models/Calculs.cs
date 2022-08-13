using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Calculs
    {
        public decimal Prix_vente_dollars { get; set; }
        public decimal Prix_vente_fc { get; set; }
        public int Qte_initiale { get; set; }
        public int Qte_sortie { get; set; }
        public int Qte_disponible {get; set;}
    }
}
