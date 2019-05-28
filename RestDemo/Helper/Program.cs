using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestDemo.Helper
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This program copies a folder under Inbox to Drafts");
            Console.WriteLine("Enter the name of the folder to be copied");
            string copyFolder = Console.ReadLine();

            var operations = new FolderOperations();
            string id = operations.FindFolder(copyFolder);

            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Cannot find the folder : " + copyFolder);
            }

            bool copySuccess = operations.CopyFolder(id, "drafts");

            Console.WriteLine(copySuccess
                ? $"Successfully copied over the folder '{copyFolder}' from Inbox to Drafts"
                : "Folder Copy Failed");
        }

    }
}
}