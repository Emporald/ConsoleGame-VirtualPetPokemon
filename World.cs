using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    class World : Menu
    {
        public static void setWorld()
        {
            WriteLine(choice);
            ReadLine();
        }

    }
}
