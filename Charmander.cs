using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets /// Namespace shows where application resides.
{
    class Charmander : PetInfo /// Comunicates with Charmander.cs and PetInfo.cs files to get specific variables and assign them.
    {
        /// This is basic stats for Charmander pet, and they connected with PetInfo.cs file.
        public Charmander()
        {
            PetName = "Charmander";
            PetType = "Fire";
            PetHealthPoints = 100;
            PetHungerLevel = 100;
            PetHappiness = 100;
            PetTemperature = 22.80;
        }
        
    }
}
