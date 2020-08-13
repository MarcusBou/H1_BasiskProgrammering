using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace GuestBook
{
    class Program
    {
        static fileConnection fc = new fileConnection();
        static AdminAccess AA = new AdminAccess();
        static bool shutdown = false;
        static void Main(string[] args)
        {
            fc.createFolderAndFiles();
            do
            {
                fc.UpdateTextFile();
                GUI();
            } while (shutdown == false);
        }

        public static void GUI()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Gæstebogen: \n");
            Console.WriteLine("1. Se Gæste Bogen");
            Console.WriteLine("2. Tilføj Gæst");
            Console.WriteLine("3. Søg efter Email/Slet og opdatere kommentar");
            Console.WriteLine("4. Admin Konsol");
            Console.WriteLine("5. End aplikation");

            Console.Write("Vælg en vej: ");
            Int32.TryParse(Console.ReadLine(), out int options) ;

            switch (options)
            {
                case 1:
                    showGuestBook();
                    break;
                case 2:
                    AddGuest();
                    break;
                case 3:
                    Search();
                    break;
                case 4:
                    AA.AdminLogin();
                    break;
                case 5:
                    shutdown = true;
                    break;
                default:
                    Console.WriteLine("You wrote something outta range");
                    break;
            }
        }

        public static void showGuestBook()
        {
            Console.Clear();
            Console.WriteLine("[-Name-----Email-----Comment-]");
            fc.fileOutput();
            Console.ReadKey();
        }

        public static void AddGuest()
        {
            Console.Clear();
            Console.WriteLine("Tilføj gæst i gæstebogen, skriv hilsen som så(ditNavn, din@email.dk, din Kommentar)");
            Console.Write("\n>");
            string output = Console.ReadLine();
            Console.WriteLine(output);
            fc.addTofile(output);
            Console.ReadKey();
        }

        public static void Search()
        {
            Console.Clear();
            Console.Write("Search for Email: ");
            string searchMail = Console.ReadLine();
            Console.WriteLine(fc.returnSearch(searchMail));
            Console.ReadKey();
            Console.Write("Vil du ændre Kommentaren for denne Gæst (yes = y/no = n): ");
            string change = Console.ReadLine();
            if (change == "y")
            {
                Console.Write("New Comment > ");
                string newComment = Console.ReadLine();
                fc.updateComment(newComment, searchMail);
                Console.WriteLine("comment " + newComment + " has been update for " + searchMail);
                Console.ReadKey();
            }
        }

        public void AdminGui()
        {
            bool endAdmin = false;
            do
            {
                Console.Clear();
                Console.WriteLine("[Velkommen til Admin Kontrollen af guestBook]\n");
                Console.WriteLine("1. Slet en gæst");
                Console.WriteLine("2. Opdater en hel gæst");
                Console.WriteLine("3. slut admin konsol\n");
                Console.Write("Your Choice: ");
                Int32.TryParse(Console.ReadLine(), out int aChoice);
                switch (aChoice)
                {
                    case 1:
                        RemoveGuest();
                        break;
                    case 2:
                        UpdateGuest();
                        break;
                    case 3:
                        endAdmin = true;
                        break;
                    default:
                        break;
                }
            } while (endAdmin == false);
        }

        public static void RemoveGuest()
        {

            Console.Write("Seach for guest name you will delete: ");
            string searchedUser = Console.ReadLine();
            fc.RemoveGuestFromFile(searchedUser);
            Console.ReadKey();
        }

        public static void UpdateGuest()
        {
            Console.Write("Seach for guest name you will Update: ");
            string searchUserForUpdate = Console.ReadLine();
            fc.UpdateGuestFromFile(searchUserForUpdate);
        }
    }
}
