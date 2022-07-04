using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercato.Handlers
{
    class Datalib
    {
        Params prms = new Params();
        public Datalib()
        {
            prms.Serveur = Properties.Settings.Default.Server;
            prms.Base_de_donnees = Properties.Settings.Default.Database;
            prms.Nom_user = Properties.Settings.Default.Username;
            prms.Mot_de_passe = Properties.Settings.Default.Password;
        }
        public object getInstance()
        {
            return prms;
        }
    }
}
