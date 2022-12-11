using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets /// Namespace shows where application resides.
{
    class Bulbasaur : PetInfo /// Comunicates with Bulbasaur.cs and PetInfo.cs files to get specific variables and assign them.
    {
        /// This is basic stats for Bulbasaur pet, and they connected with PetInfo.cs file.
        public Bulbasaur()
        {
            PetName = "Bulbasaur";
            PetType = "Grass";
            PetHealthPoints = 100;
            PetHungerLevel = 100;
            PetHappiness = 100;
            PetTemperature = 22.80;
        }
   

    }

}
