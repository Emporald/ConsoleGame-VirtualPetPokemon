using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    class Bulbasaur : PetInfo
    {
        public Bulbasaur()
        {
            PetName = "Bulbasaur";
            PetType = "Grass";
            PetHealthPoints = 90;
            PetHungerLevel = 90;

        }
        

    }

}
