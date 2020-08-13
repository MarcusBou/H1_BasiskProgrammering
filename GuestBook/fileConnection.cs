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
    /// <summary>
    /// Most of all the work is going in a list, and after every update in list
    /// it updates file.
    /// </summary>
    class fileConnection
    {
        //path ways
        static string folderPath = @"C:\Users\marc8847\Documents\GuestBook";
        static string filePath = @"C:\Users\marc8847\Documents\GuestBook\GuestBookFile.txt";
        static List<string> lineOutput = new List<string>();
        public void createFolderAndFiles()
        {
            //see if file exist
            bool FileExist = false;
            do
            {
                if (Directory.Exists(folderPath))
                {
                    if (File.Exists(filePath))
                    {
                        //if fileExist then input lines to a list.
                        FileExist = true;
                        lineOutput = File.ReadAllLines(filePath).ToList();
                    }
                    else
                    {
                        //if file and filepath doesnt exist, its creates it
                        File.Create(filePath);
                    }
                }
                else
                {
                    Directory.CreateDirectory(folderPath);
                }
            } while (FileExist == false);
        }

        public void fileOutput()
        {
            for (int i = 0; i < lineOutput.Count; i++)
            {
                if (lineOutput[i] != "")
                {
                    string[] represent = lineOutput[i].Split(',');
                    Console.WriteLine("[" + represent[0] + " |" + represent[1] + " |" + represent[2] + "]");
                }
            }
        }

        public void UpdateTextFile()
        {
            //Updating file
            File.WriteAllLines(filePath, lineOutput);
        }

        public void addTofile(string values)
        {
            //add to the file
            lineOutput.Add(values);
        }

        public string returnSearch(string searchValue)
        {
            //search in file, and return
            for (int i = 0; i < lineOutput.Count - 1; i++)
            {
                if (lineOutput[i].Contains(searchValue))
                {
                    return lineOutput[i];
                }
            }
            return "error: email not found";
        }

        public void updateComment(string valueNeeded, string searchedValue)
        {
            //updates Comments
            for (int i = 0; i < lineOutput.Count - 1; i++)
            {
                if (lineOutput[i].Contains(searchedValue))
                {
                    string[] replacement = lineOutput[i].Split(',');
                    replacement[2] = valueNeeded;
                    lineOutput[i] = replacement[0] + ", " + replacement[1] + ", " + replacement[2];

                }
            }
        }

        public void RemoveGuestFromFile(string nameSearch)
        {
            //admin removefrom file
            for (int i = 0; i < lineOutput.Count - 1; i++)
            {
                if (lineOutput[i].Contains(nameSearch))
                {
                    Console.Write("is this the Guest you will delete (y = yes/ n = no): ");
                    string yesOrNo = Console.ReadLine();
                    if (yesOrNo == "y")
                    {
                        lineOutput[i] = "";
                    }
                }
                else
                {
                    Console.WriteLine("name doesnt exist");
                }
            }
        }

        public void UpdateGuestFromFile(string name)
        {
            //admin updates whole guest
            for (int i = 0; i < lineOutput.Count - 1; i++)
            {
                if (lineOutput[i].Contains(name))
                {
                    Console.Write("is this the Guest you will Update (y = yes/ n = no): ");
                    string yesOrNo = Console.ReadLine();
                    if (yesOrNo == "y")
                    {
                        Console.Write("write like (ditNavn, din@email.dk, din Kommentar)> ");
                        string updatedGuest = Console.ReadLine();
                        lineOutput[i] = updatedGuest;
                    }
                }
                else
                {
                    Console.WriteLine("name doesnt exist");
                }
            }
        }
    }
}
