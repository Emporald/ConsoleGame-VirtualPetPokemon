using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    class Squirtle : PetInfo
    {
        public Squirtle()
        {
            PetName = "Squirtle";
            PetType = "Water";
            PetHealthPoints = 100;
            PetHungerLevel = 100;

        }
        
    }
}
