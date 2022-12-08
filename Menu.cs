using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks; /// Used for threading
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets /// Namespace shows where application resides.
{
    internal class Menu
    {
        public static int choice; /// Creates public integer Choice, this will be used to determine which pet user chooses and it will pass on to the other files.
        public static void Run() /// Saves Menu as a Run(), it's also a public so it provides easier acces from other files.
        {
            Clear();
            Title = ">>> Virtual Pet Simulator (Pokemon Edition) <<<"; /// Title of the Window
            WriteLine(@"
____   ____.__         __               .__    __________        __   
\   \ /   /|__|_______/  |_ __ _______  |  |   \______   \ _____/  |_ 
 \   Y   / |  \_  __ \   __\  |  \__  \ |  |    |     ___// __ \   __\
  \     /  |  ||  | \/|  | |  |  // __ \|  |__  |    |   \  ___/|  |  
   \___/   |__||__|   |__| |____/(____  /____/  |____|    \___  >__|  
                                      \/                      \/  
__________       __                                 
\______   \____ |  | __ ____   _____   ____   ____  
 |     ___/  _ \|  |/ // __ \ /     \ /  _ \ /    \ 
 |    |  (  <_> )    <\  ___/|  Y Y  (  <_> )   |  \
 |____|   \____/|__|_ \\___  >__|_|  /\____/|___|  /
                     \/    \/      \/            \/ 
            ");
            WriteLine("Welcome to your Virtual Pet Simulator (Pokemon Edition)!"); /// Main Menu 
            WriteLine("");
            WriteLine("Please choose an option");
            WriteLine("1 > Choose a Pet");
            WriteLine("2 > Exit Virtual Pet Game");
            WriteLine();
            string MenuChoice = (Console.ReadLine());
            {
                switch (MenuChoice)  /// Using Switch to get a response from the player/user on which option they want to choose. If the user input is not 1 or 2, it will inform the user to input a correct option from the menu.
                {
                    case "1":
                        choosePet(); // If user inserts "1! it will go to the choosePet Class
                        break;

                    case "2":
                        closeProgram(); // If user inserts "1! it will go to the closeProgram Class
                        break;

                    default:
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000);    /// Stops the console, for 2000 miliseconds.
                        Run(); /// Goes back to main menu start.
                        break;
                }
            }
        }
        /// Used for player to choose a pet.
        public static void choosePet()
        {
            Clear();
            choice = 0;
            WriteLine(">>> 1 <<<");
            Bulbasaur a = new Bulbasaur(); /// a is assigned as a new Bulbasaur from Bulbasaur.cs
            a.PetGreeting(); /// Does a pet greeting from pet a who is currently pet Bulbasaur
            WriteLine("--------------------------------------------------------------------");
            WriteLine(">>> 2 <<<");
            Squirtle b = new Squirtle(); /// b is assigned as a new Squirtle from Squirtle.cs
            b.PetGreeting(); /// Does a pet greeting from pet a who is currently pet Squirtle
            WriteLine("--------------------------------------------------------------------");
            WriteLine(">>> 3 <<<");
            Charmander c = new Charmander(); /// c is assigned as a new Charmander from Charmander.cs
            c.PetGreeting(); /// Does a pet greeting from pet a who is currently pet Charmander
            WriteLine("--------------------------------------------------------------------");
            WriteLine("Which Pokemon would you like to choose?");
            WriteLine("Insert Pet Number / 4 = Main Menu");
            WriteLine();
            string PetChoice = (Console.ReadLine()); /// Reads as a string which per user wants to choose OR go back to main menu.

            if (PetChoice == "1")
            {
                choice = 1; /// Saves choice as 1, in order to keep a track of which pet was chosen for World.cs
                World w = new World(a); /// 
                w.setWorld(choice);     
            }

            else if (PetChoice == "2")
            {
                choice = 2; /// Saves choice as 2, in order to keep a track of which pet was chosen for World.cs
                World w = new World(b);
                w.setWorld(choice); 
            }

            else if (PetChoice == "3")
            {
                choice = 3; /// Saves choice as 3, in order to keep a track of which pet was chosen for World.cs
                World w = new World(c);
                w.setWorld(choice); 
            }

            else if (PetChoice == "4")
            {
                Run(); /// Goes back to main menu start.
            }

            else
            {
                WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                System.Threading.Thread.Sleep(2000); /// Stops the console, for 2000 miliseconds.
                choosePet(); /// Goes back to choosing a pet menu.
            }

        }

        /// If user inputs number 2, the program will close.

        public static void closeProgram()
        {
            Clear(); /// Clears the console text
            WriteLine(@"
___________.__                   __     _____.___.             
\__    ___/|  |__ _____    ____ |  | __ \__  |   | ____  __ __ 
  |    |   |  |  \\__  \  /    \|  |/ /  /   |   |/  _ \|  |  \
  |    |   |   Y  \/ __ \|   |  \    <   \____   (  <_> )  |  /
  |____|   |___|  (____  /___|  /__|_ \  / ______|\____/|____/ 
                \/     \/     \/     \/  \/                    
___________                                                    
\_   _____/__________                                          
 |    __)/  _ \_  __ \                                         
 |     \(  <_> )  | \/                                         
 \___  / \____/|__|                                            
     \/                                                        
__________.__                .__                               
\______   \  | _____  ___.__.|__| ____    ____                 
 |     ___/  | \__  \<   |  ||  |/    \  / ___\                
 |    |   |  |__/ __ \\___  ||  |   |  \/ /_/  >               
 |____|   |____(____  / ____||__|___|  /\___  /                
                    \/\/             \//_____/                 
            ");
            System.Threading.Thread.Sleep(5000); /// Stops the console, for 5000 miliseconds.
            Environment.Exit(1); /// Closes the console
        }

    }
}

