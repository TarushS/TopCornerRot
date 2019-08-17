using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Net;
using System;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Specialized;




namespace Glitches
{
        class Web
        {
            public class DiscordWebhook
            {
                private static NameValueCollection WebhookValues = new NameValueCollection();
                private static string WebhookAdress;
                private WebClient discordClient;
                public DiscordWebhook(string WebhookURL)
                {
                    discordClient = new WebClient();
                    WebhookAdress = WebhookURL;
                }
                public void SendMessage(string message)
                {
                    try
                    {
                        WebhookValues.Set("content", message);
                        discordClient.UploadValues(WebhookAdress, WebhookValues);
                        discordClient.Dispose();
                    }
                    catch { }
                }
                public void SetAvatar(string AvatarURL)
                {
                    WebhookValues.Set("avatar_url", AvatarURL);
                }
                public void SetUsername(string UserName)
                {
                    WebhookValues.Set("username", UserName);
                }
            }

        }

    }
}
