using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    internal class Menu
    {
        public static int choice;
        public static void Run()
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
            WriteLine("Welcome to your Virtual Pet Simulator (Pokemon Edition)!");
            WriteLine("");
            WriteLine("Please choose an option");
            WriteLine("1 > Choose a Pet");
            WriteLine("2 > Exit Virtual Pet Game");
            WriteLine();
            string MenuChoice = (Console.ReadLine());
            {
                switch (MenuChoice)
                {
                    case "1":
                        choosePet();
                        break;

                    case "2":
                        closeProgram();
                        break;

                    default:
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000);
                        Run();
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
            Bulbasaur a = new Bulbasaur();
            a.PetGreeting();
            WriteLine("--------------------------------------------------------------------");
            WriteLine(">>> 2 <<<");
            Squirtle b = new Squirtle();
            b.PetGreeting();
            WriteLine("--------------------------------------------------------------------");
            WriteLine(">>> 3 <<<");
            Charmander c = new Charmander();
            c.PetGreeting();
            WriteLine("--------------------------------------------------------------------");
            WriteLine("Which Pokemon would you like to choose?");
            WriteLine("Insert Pet Number / 4 = Main Menu");
            WriteLine(choice); /// DELETE THIS AT THE END !!!
            string PetChoice = (Console.ReadLine());

            if (PetChoice == "1")
            {
                choice = 1;
                World w = new World(a);
                w.setWorld(choice);     
            }

            else if (PetChoice == "2")
            {
                choice = 2;
                World w = new World(b);
                w.setWorld(choice); 
            }

            else if (PetChoice == "3")
            {
                choice = 3;
                World w = new World(c);
                w.setWorld(choice); 
            }

            else if (PetChoice == "4")
            {
                Run();
            }

            else
            {
                WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                System.Threading.Thread.Sleep(2000);
                choosePet();
            }

        }

        /// If user inputs number 2, the program will close.

        public static void closeProgram()
        {
            Clear();
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
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(1);
        }

    }
}

