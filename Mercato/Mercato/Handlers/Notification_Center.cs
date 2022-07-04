using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Mercato.Handlers
{
    class Notification_Center
    {
        public void notifier(string messages)
        {
            // Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
            new ToastContentBuilder()
                    .AddHeader("header", "MERCATO", "1")
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText(messages)
                    .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 5, your TFM must be net5.0-windows10.0.17763.0 or greater
                             //MessageBox.Show("");
        }
    }
}
