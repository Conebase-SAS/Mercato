﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Models
{
    class Approvisionnement
    {
        public int num_details { get; set; }
        public DateTime date_details { get; set; }
        public string Id_article { get; set; }
        public string Id_couleur { get; set; }
        public string Numero_serie { get; set; }
        public string Caracteristiques { get; set; }
        public decimal prix_achat_usd { get; set; }
        public decimal prix_achat_fc { get; set; }
        public decimal qte_entree { get; set; }
        public string ID_fournisseurs { get; set; }
        public DateTime Date_expriation { get; set; }
        public decimal prix_vente_usd { get; set; }
        public decimal prix_vente_fc { get; set; }
        public string ID_Depot { get; set; }
        public int points { get; set; }
        public string stats_vente { get; set; }
    }
}
