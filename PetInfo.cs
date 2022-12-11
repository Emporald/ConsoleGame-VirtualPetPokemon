using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets /// Namespace shows where application resides.
{
    class  PetInfo
    {
        /// Creating a field name for a Pet, It's public to be accessed and reached from anywhere.
        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetHealthPoints { get; set; }
        public int PetHungerLevel { get; set; }
        public int PetHappiness { get; set; }
        public double PetTemperature { get; set;}
        public int PetCoins { get; set; }



        /// Pet greeting used for giving information to the player about the pet.
        public void PetGreeting()
        {
            WriteLine($"My name is {PetName}, and I'm {PetType} type Pokemon!");
            WriteLine($"Currently my HP is at ({PetHealthPoints}), and my hunger level is at ({PetHungerLevel})");
            WriteLine($"Currently my Happiness is at ({PetHappiness}), Room Temparature is ({PetTemperature}) degrees");
            WriteLine($"You Have ({PetCoins}) Coins with this pet");
        }

    }

}
