﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    class  PetInfo
    {
        /// Creating a field name for a Pet, It's public to be accessed and reached from anywhere.
        public string PetName { get; set; }
        public string PetType { get; set; }
        public int PetHealthPoints { get; set; }
        public int PetHungerLevel { get; set; }

        public void PetGreeting()
        {
            WriteLine($"My name is {PetName}, and I'm {PetType} type Pokemon!");
            WriteLine($"Currently my HP is at {PetHealthPoints}/100, and my hunger level is at {PetHungerLevel}/100");
        }

    }

}
