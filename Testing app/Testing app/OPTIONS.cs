using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app
{
    class OPTIONS
    {
        public void chat()
        {
            Console.WriteLine("Choose 1 and 2");
            Console.WriteLine("1.Chat now 2.Exit");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                CCHAT N = new CCHAT();
                N.BD();
            }
            else if (s == 2)
            {
               
            }
        }
    }
}
