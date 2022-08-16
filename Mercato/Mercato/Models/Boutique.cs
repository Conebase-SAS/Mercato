using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Boutique
    {
        public string Id_boutique { get; set; }
        public string Designation { get; set; }
        public string Password { get; set; }
        public string Id_compagnie { get; set; }
        public string Extension { get; set; }
        public string Admin_level { get; set; }
    }
}
