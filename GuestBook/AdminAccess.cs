using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    class AdminAccess
    {
        public void AdminLogin()
        {
            //let you log in to admin console
            Program backToGui = new Program();
            Console.Clear();
            Console.Write("Username: ");
            string username = Console.ReadLine();
            if (username == "adminUser")
            {
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (password == "adminpass1234")
                {
                    backToGui.AdminGui();
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
                Console.ReadKey();
            }
        }
    }
}
