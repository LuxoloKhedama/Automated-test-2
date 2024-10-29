using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome user, press 1 to log in or 2 to exit");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                string usename = "1";
                string password = "2";
                Console.WriteLine("Enter in  username and password"); 
                if(usename == "1" & password == "2")
                {
                    OPTIONS N = new OPTIONS();
                    N.chat();
                }
            }
            else if (a == 2)
            {
                Console.WriteLine("exiting....");
            }
            /*Console.WriteLine("Choose an option between 1 and 2");
            Console.WriteLine("1.Chat now or 2.Exit ");
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
            {
                CHAT N = new CHAT();
                N.chat();
            }
            else if (ans == 2)
            {
               
            }
            }*/
        }
    }
}

