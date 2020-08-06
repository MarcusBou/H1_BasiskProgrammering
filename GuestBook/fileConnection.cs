using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;
using System.Xml.Serialization;

namespace GuestBook
{
    class fileConnection
    {
        static string folderPath = @"C:\Users\marc8847\Documents\GuestBook";
        static string filePath = @"C:\Users\marc8847\Documents\GuestBook\GuestBookFile.txt";
        static void createFolderAndFiles()
        {
            bool FileExist = false;
            do
            {
                if (Directory.Exists(folderPath))
                {
                    if (File.Exists(filePath))
                    {
                        FileExist = true;
                    }
                    else
                    {
                        File.Create(filePath);
                    }
                }
                else
                {
                    Directory.CreateDirectory(folderPath);
                }
            } while (FileExist == false);
        }

        static void addTofile()
        {

        }
    }
}
