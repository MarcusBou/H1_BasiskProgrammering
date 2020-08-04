using Microsoft.VisualBasic;
using System;

namespace Array_øvelse_1
{
    class Program
    {
        static string[] username = { "Root", "admin", "User", "Guest", "SystemAdmin"};
        static string[] password = { "root", "admincode", "user1234", "", "securepassword"};
        static string gUsername, gPassword;
        static int loginTry = 3;
        static bool wrongPass, wrongUser = true;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Username> ");
                gUsername = Console.ReadLine();
                //checker om den ingivne user er i Arrayet
                int indexSearch = Array.IndexOf(username, gUsername);
                if (indexSearch == -1)
                {
                    wrongPass = false;
                }
                else
                {
                    wrongPass = true;
                    wrongUser = false;
                }
                //checker om passwordet er korrekt til brugeren
                while (wrongPass == true)
                {
                    Console.Write("Password> ");
                    gPassword = Console.ReadLine();

                    if (gPassword == password[indexSearch])
                    {
                        Console.WriteLine("Velkommen til systemet");
                        wrongPass = false;
                    }
                    else if (loginTry > 1)
                    {
                        loginTry--;
                        Console.WriteLine("password is wrong you have " + loginTry + " trys left");
                    }
                    else if (loginTry == 1)
                    {
                        wrongPass = false;
                    }
                }
            } while (wrongUser == true);
        }
    }
}
