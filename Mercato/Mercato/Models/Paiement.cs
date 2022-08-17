using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Paiement
    {
        public Int32 Num_paiement { get; set; }
        public Int32 Num_vente { get; set; }
        public Decimal Montant_dollars { get; set; }
        public Decimal Montant_fc { get; set; }
        public Decimal Solde_restant { get; set; }
        public Decimal Taux { get; set; }
    }
}
