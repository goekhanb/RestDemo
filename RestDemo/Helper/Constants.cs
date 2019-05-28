using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestDemo.Helper
{
    class Constants
    {
        internal const string ClientId = "ENTER_YOUR_CLIENT_ID_HERE";

        internal const string OutlookEndpoint = "https://outlook.office.com/";

        internal const string OutlookRestApiEndpoint = OutlookEndpoint + "api/v2.0/me/";

        internal const string Messages = OutlookRestApiEndpoint + "messages?$top=1";

        internal static readonly string[] Scopes = new string[] { OutlookEndpoint + "mail.readwrite" };

        internal const string Folders = OutlookRestApiEndpoint + "MailFolders/";

        internal const string Inbox = Folders + "inbox/childfolders";

        internal const string CopyFolder = Folders + "{0}/copy";
    }
}