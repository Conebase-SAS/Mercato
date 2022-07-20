using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Ventes
    {
        public int Num_vente { get; set; }
        public string Vente_id { get; set; }
        public DateTime Date_vente { get; set; }
        public string Id_boutique { get; set; }
        public string Id_clients { get; set; }
        public string Description_ventes { get; set; }
    }
}
