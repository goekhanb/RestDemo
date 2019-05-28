using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RestDemo.Helper
{
    internal class FolderOperations
    {
        private string authToken;

        internal FolderOperations()
        {
            authToken = AuthHelper.GetAuthToken(Constants.Scopes);
        }

        internal string FindFolder(string folderName)
        {
            string response = HttpHelper.SendAsync(HttpMethod.Get, Constants.Inbox, authToken);
            if (response == null) return null;

            dynamic childfolders = JObject.Parse(response);
            foreach (var folder in childfolders.value)
            {
                string folderDisplayName = folder.DisplayName;
                if (folderDisplayName.Equals(folderName))
                {
                    return folder.Id;
                }
            }

            return null;
        }

        internal bool CopyFolder(string folderId, string destination)
        {
            string url = string.Format(Constants.CopyFolder, folderId);

            var content = new { DestinationId = destination };

            string response = HttpHelper.SendAsync(HttpMethod.Post, url, authToken, content);
            if (response == null) return false;

            return true;
        }
    }
}
}