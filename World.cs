using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks; /// Used for threading this is used for dropping health and hunger for selected pet.
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets /// Namespace shows where application resides.
{
    class World : Menu /// Comunicates with World.cs and Menu.cs files to get specific variables.
    {
        public PetInfo pet; /// Creates a public pet class, with attributes from PetInfo
        public World(PetInfo Pet) { /// Assigns variables from PetInfo to pet, which talks through World.
            pet = Pet;
        }
        /// Creating a Thread for decreasing Health Points from PetInfo
        public void HealthDown() /// Creates a public void with the name of HealthDown to be called as a thread later on
        {
            for (int a = 0; a < 50; a--) /// Infinite loop for health to drop down
            {
                pet.PetHealthPoints -= 5; /// When the loop is going, PetHealthPoints will be minus by 5.
                Thread.Sleep(30000); /// Stops the thread, for 30000 miliseconds which is equal to 30 seconds.
            }
        }

        /// Creating a Thread for decreasing Hunger Level from PetInfo
        public void HungerDown() /// Creates a public void with the name of HungerDown to be called as a thread later on
        {
            for (int a = 0; a < 50; a--) /// Infinite loop for health to drop down
            {
                pet.PetHungerLevel -= 10; /// When the loop is going, PetHungerLevel will be minus by 10.
                Thread.Sleep(50000); /// Stops the thread, for 50000 miliseconds which is equal to 50 seconds.
            }
        }


        public void setWorld(int choice) /// creates a class of setWorld, which will work depending on choice gotten from Menu.cs
        {
            while (true) /// While Loop for inifnite looping until stopped.
            {




            /// Bulbasaur Gameplay starts HERE





            if (choice == 1) /// if choice was 1 from menu.cs it will start program from here.
            {
                Clear(); /// Clears the console
                Thread hp = new Thread(HealthDown); /// Creates a thread hp which links to HealthDown class
                Thread hl = new Thread(HungerDown); /// Creates a thread hl which links to HungerDown class
                hp.Start(); /// Calls HP thread and starts it
                hl.Start(); /// Calls HL thread and starts it
                WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@////&////////////&(&@@@@@@@@@@@@@@@@@@
@@@@@@@/////#//////////////@//@@@@@@@@@@@@@@@
@@@@@////////@/////@***@//@@%*****%@&****@@@@
@@@@//////////&///%/**************@%%****/@@@
@@@////////////&//(/************%%%%******@@@
@@/@/////////////@//*****@**/*%%*****@*@/@@@@
@((@///////////@*@//***( % %@******@%%@*@ @@@
@(((@///////@%%%&*****@ @% %%@**********@%@/*
@@((((&((@@%%%%@*******& @%%%@***************
@@@@@((******&*********@***********#****@(*@@
@@@@@********/*******@*****************@@@@@@
@@@@*@%%%@**&****@****///////////////****@@@@
@@@@***@@***@*@%%%****@/////////////****%*@@@
@@@@/*******@**@%%****@/////////@///***%%@*@@
@@@@@///////&/*******@/*****&@@@@@///******@@
@@@@@@@ (.@.#@/@&&/&@@@@@@@@@@@@@@@@%/@ @.@@@");
                WriteLine("---------------------------------------------------------------");
                pet.PetGreeting(); /// Pet information gathered from Bulbasaur.cs
                WriteLine("---------------------------------------------------------------");
                WriteLine("What would you like to do?");
                WriteLine("1 > Pet your Pokemon");
                WriteLine("2 > Inventory");
                WriteLine("3 > Go back to the Main Menu");
                WriteLine();
                string BulbasaurChoice = (Console.ReadLine()); /// Reads what user will input as a string it saves in as BulbasaurChoice

                if (BulbasaurChoice == "1") /// If the input is 1, then it will start this command line.
                {
                    Clear(); /// Clears console window
                    WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@////&////////////&(&@@@@@@@@@@@@@@@@@@
@@@@@@@/////#//////////////@//@@@@@@@@@@@@@@@
@@@@@////////@/////@***@//@@%*****%@&****@@@@
@@@@//////////&///%/**************@%%****/@@@
@@@////////////&//(/************%%%%******@@@
@@/@/////////////@//*****@**/*%%*****@*@/@@@@
@((@///////////@*@//***( % %@******@%%@*@ @@@
@(((@///////@%%%&*****@ @% %%@**********@%@/*
@@((((&((@@%%%%@*******& @%%%@***************
@@@@@((******&*********@***********#****@(*@@
@@@@@********/*******@*****************@@@@@@
@@@@*@%%%@**&****@****///////////////****@@@@
@@@@***@@***@*@%%%****@/////////////****%*@@@
@@@@/*******@**@%%****@/////////@///***%%@*@@
@@@@@///////&/*******@/*****&@@@@@///******@@
@@@@@@@ (.@.#@/@&&/&@@@@@@@@@@@@@@@@%/@ @.@@@");
                    WriteLine("---------------------------------------------");
                    WriteLine("You Pet your Bulbasaur");
                    WriteLine("He seems to be happy (^_^)");
                    System.Threading.Thread.Sleep(5000); /// Stops the system for 5000 miliseconds, so the user has time to read the console.
                }

                else if (BulbasaurChoice == "2") /// If the input is 2, then it will start this command line.
                {
                    Clear(); /// Clears console window
                    WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@////&////////////&(&@@@@@@@@@@@@@@@@@@
@@@@@@@/////#//////////////@//@@@@@@@@@@@@@@@
@@@@@////////@/////@***@//@@%*****%@&****@@@@
@@@@//////////&///%/**************@%%****/@@@
@@@////////////&//(/************%%%%******@@@
@@/@/////////////@//*****@**/*%%*****@*@/@@@@
@((@///////////@*@//***( % %@******@%%@*@ @@@
@(((@///////@%%%&*****@ @% %%@**********@%@/*
@@((((&((@@%%%%@*******& @%%%@***************
@@@@@((******&*********@***********#****@(*@@
@@@@@********/*******@*****************@@@@@@
@@@@*@%%%@**&****@****///////////////****@@@@
@@@@***@@***@*@%%%****@/////////////****%*@@@
@@@@/*******@**@%%****@/////////@///***%%@*@@
@@@@@///////&/*******@/*****&@@@@@///******@@
@@@@@@@ (.@.#@/@&&/&@@@@@@@@@@@@@@@@%/@ @.@@@");
                    WriteLine("---------------------------------------------------------------");
                    pet.PetGreeting(); /// Pet information gathered from Bulbasaur.cs
                    WriteLine("---------------------------------------------------------------");
                    WriteLine("What would you like to do?");
                    WriteLine("1 > Give a Health Potion");
                    WriteLine("2 > Give some Food");
                    WriteLine("3 > Return");
                    WriteLine();
                    string InventoryBulbasaur = (Console.ReadLine()); /// Reads what user will input as a string it saves in as InventoryBulbasaur

                        if (InventoryBulbasaur == "1")
                    {
                           Clear();
                           WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@////&////////////&(&@@@@@@@@@@@@@@@@@@
@@@@@@@/////#//////////////@//@@@@@@@@@@@@@@@
@@@@@////////@/////@***@//@@%*****%@&****@@@@
@@@@//////////&///%/**************@%%****/@@@
@@@////////////&//(/************%%%%******@@@
@@/@/////////////@//*****@**/*%%*****@*@/@@@@
@((@///////////@*@//***( % %@******@%%@*@ @@@
@(((@///////@%%%&*****@ @% %%@**********@%@/*
@@((((&((@@%%%%@*******& @%%%@***************
@@@@@((******&*********@***********#****@(*@@
@@@@@********/*******@*****************@@@@@@
@@@@*@%%%@**&****@****///////////////****@@@@
@@@@***@@***@*@%%%****@/////////////****%*@@@
@@@@/*******@**@%%****@/////////@///***%%@*@@
@@@@@///////&/*******@/*****&@@@@@///******@@
@@@@@@@ (.@.#@/@&&/&@@@@@@@@@@@@@@@@%/@ @.@@@");
                            WriteLine("---------------------------------------------------------------");
                            WriteLine("You try to give your Bulbasaur a Health Potion.");

                        if (pet.PetHealthPoints < 100) /// Checks if PetHealthPoints is lower than 100
                        {
                            pet.PetHealthPoints += 20; /// Addds 20 points to PetHealthPoints
                            WriteLine("You give your Bulbasaur a Health Potion + 20 Health Points...");
                            System.Threading.Thread.Sleep(3000); /// Sleeps the console for 3000 miliseconds
                            setWorld(1); /// Loops back to the world 1, which communicates with choice, and this will ensure that it goes back to the correct pet
                        }

                        else if (pet.PetHealthPoints == 100) /// checks If pethealthpoints == 100
                        {
                            WriteLine("Your Bulbasaur is already at full health...");
                            System.Threading.Thread.Sleep(3000); /// sleeps console for 3000 miliseconds
                        }

                        else
                        {
                                setWorld(1); /// Loops back to the world 1, which communicates with choice, and this will ensure that it goes back to the correct pet
                        }


                    }

                    else if (InventoryBulbasaur == "2") /// If user input was 2 for InventoryBulbasaur
                    {
                            Clear(); /// Clears the console
                            WriteLine(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@////&////////////&(&@@@@@@@@@@@@@@@@@@
@@@@@@@/////#//////////////@//@@@@@@@@@@@@@@@
@@@@@////////@/////@***@//@@%*****%@&****@@@@
@@@@//////////&///%/**************@%%****/@@@
@@@////////////&//(/************%%%%******@@@
@@/@/////////////@//*****@**/*%%*****@*@/@@@@
@((@///////////@*@//***( % %@******@%%@*@ @@@
@(((@///////@%%%&*****@ @% %%@**********@%@/*
@@((((&((@@%%%%@*******& @%%%@***************
@@@@@((******&*********@***********#****@(*@@
@@@@@********/*******@*****************@@@@@@
@@@@*@%%%@**&****@****///////////////****@@@@
@@@@***@@***@*@%%%****@/////////////****%*@@@
@@@@/*******@**@%%****@/////////@///***%%@*@@
@@@@@///////&/*******@/*****&@@@@@///******@@
@@@@@@@ (.@.#@/@&&/&@@@@@@@@@@@@@@@@%/@ @.@@@");
                            WriteLine("---------------------------------------------------------------");
                            WriteLine("You try to give your Bulbasaur some food.");

                        if (pet.PetHungerLevel < 100) /// Checks if PetHungerLevel is lower than 100
                        {
                            pet.PetHungerLevel += 30; /// adds 30 to PetHungerLevel
                            WriteLine("You give your Bulbasaur some food, + 30 Hunger Points...");
                            System.Threading.Thread.Sleep(3000); /// Sleeeps the console for 3000 miliseconds
                            setWorld(1); /// Loops back to the world 1, which communicates with choice, and this will ensure that it goes back to the correct pet
                        }

                        else if (pet.PetHungerLevel == 100) /// Checks if hunger is equal to 100, and if it is
                        {
                            WriteLine("Your Bulbasaur is not hungry...");
                            System.Threading.Thread.Sleep(3000); /// Sleeps console for 3000 miliseconds
                        }

                        else
                        {
                            setWorld(1); /// Loops back to the world 1, which communicates with choice, and this will ensure that it goes back to the correct pet
                        }
                        }

                    else if (InventoryBulbasaur == "3") 
                    {
                            setWorld(1); /// Loops back to the world 1, which communicates with choice, and this will ensure that it goes back to the correct pet
                    }

                    else /// If user inputs a value which not in the list, it get an error
                    {
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000); /// Sleeps the console for 2000 miliseconds

                    }


                }

                else if (BulbasaurChoice == "3")
                {
                    Run(); /// Goes back to the main menu from menu.cs
                }

                else
                {
                    WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                    System.Threading.Thread.Sleep(2000); /// Sleeps the console for 2000 miliseconds

                }



            }



            /// All comments ABOVE treats every Pokemon the same and has same commands. UNLESS COMMENTED
            /// Squirtle Pokemon Starts HERE
              





                else if (choice == 2)
                {
                    Thread hp = new Thread(HealthDown);
                    Thread hl = new Thread(HungerDown);
                    hp.Start();
                    hl.Start();
                    Clear();
                    WriteLine(@"@@@@@@@@@@@@@@*,,,%@@@@@@@@@@@@@@@@@@@@@  
@@@@@@@@@@,..,,**,**,**@@@@@@@@@@@@@@@@@  
@@@@@@@@@*,,**,*,@ @****@@@@@@@@@@@@@@@@  
@@@@@@@@#,,,*,,,&@%&/////@@@@@@@@@@@@@@@  
@@@@@@@%*****,,,,,,*/////@@@@@@@@@@@@@@@  
@@@@@@@@////////////////@@@@@@@@@@@@@@@@  
@@@@@@@@@@/&/////////(,,(*@@@@@@@@@@@@@@  
@@@@,,,,,%..,*****%.,,*//(@@@@@@@@@@@@@@  
@(/,*,,,....../@@,,,,,*///(/@@@@@@@@@@@@  
@@@/*/(@.......,%,//****,*/**@@@@@@@@@@@  
@@@@@@@#.....#.,,,#//**,,(//(@@@@@@@@@@@  
@@@@@@@@,,,,,@..,.,****&,&((@@@***,,*/(@  
@@@@@@,,,,...%..,**@,,,,**(@@////&/////&  
@@@@@,.,,*/****,#*/,,,,,,,(////////////@  
@@@@@#*/////@@@@@@@,*,*,,*///////////@@@  
@@@@@@@*@@@@@@@@@@@@///////@@@@@@@@@@@@@  
@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@");
                    WriteLine("---------------------------------------------------------------");
                    pet.PetGreeting();
                    WriteLine("---------------------------------------------------------------");
                    WriteLine("What would you like to do?");
                    WriteLine("1 > Pet your Pokemon");
                    WriteLine("2 > Inventory");
                    WriteLine("3 > Go back to the Main Menu");
                    WriteLine();
                    string SquirtleChoice = (Console.ReadLine());
                    if (SquirtleChoice == "1")
                    {
                        Clear();
                        WriteLine(@"@@@@@@@@@@@@@@*,,,%@@@@@@@@@@@@@@@@@@@@@  
@@@@@@@@@@,..,,**,**,**@@@@@@@@@@@@@@@@@  
@@@@@@@@@*,,**,*,@ @****@@@@@@@@@@@@@@@@  
@@@@@@@@#,,,*,,,&@%&/////@@@@@@@@@@@@@@@  
@@@@@@@%*****,,,,,,*/////@@@@@@@@@@@@@@@  
@@@@@@@@////////////////@@@@@@@@@@@@@@@@  
@@@@@@@@@@/&/////////(,,(*@@@@@@@@@@@@@@  
@@@@,,,,,%..,*****%.,,*//(@@@@@@@@@@@@@@  
@(/,*,,,....../@@,,,,,*///(/@@@@@@@@@@@@  
@@@/*/(@.......,%,//****,*/**@@@@@@@@@@@  
@@@@@@@#.....#.,,,#//**,,(//(@@@@@@@@@@@  
@@@@@@@@,,,,,@..,.,****&,&((@@@***,,*/(@  
@@@@@@,,,,...%..,**@,,,,**(@@////&/////&  
@@@@@,.,,*/****,#*/,,,,,,,(////////////@  
@@@@@#*/////@@@@@@@,*,*,,*///////////@@@  
@@@@@@@*@@@@@@@@@@@@///////@@@@@@@@@@@@@  
@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@");
                        WriteLine("---------------------------------------------");
                        WriteLine("You Pet your Squirtle");
                        WriteLine("She seems to be happy (^_^)");
                        System.Threading.Thread.Sleep(5000);
                    }

                    else if (SquirtleChoice == "2")
                    {
                        Clear();
                        WriteLine(@"@@@@@@@@@@@@@@*,,,%@@@@@@@@@@@@@@@@@@@@@  
@@@@@@@@@@,..,,**,**,**@@@@@@@@@@@@@@@@@  
@@@@@@@@@*,,**,*,@ @****@@@@@@@@@@@@@@@@  
@@@@@@@@#,,,*,,,&@%&/////@@@@@@@@@@@@@@@  
@@@@@@@%*****,,,,,,*/////@@@@@@@@@@@@@@@  
@@@@@@@@////////////////@@@@@@@@@@@@@@@@  
@@@@@@@@@@/&/////////(,,(*@@@@@@@@@@@@@@  
@@@@,,,,,%..,*****%.,,*//(@@@@@@@@@@@@@@  
@(/,*,,,....../@@,,,,,*///(/@@@@@@@@@@@@  
@@@/*/(@.......,%,//****,*/**@@@@@@@@@@@  
@@@@@@@#.....#.,,,#//**,,(//(@@@@@@@@@@@  
@@@@@@@@,,,,,@..,.,****&,&((@@@***,,*/(@  
@@@@@@,,,,...%..,**@,,,,**(@@////&/////&  
@@@@@,.,,*/****,#*/,,,,,,,(////////////@  
@@@@@#*/////@@@@@@@,*,*,,*///////////@@@  
@@@@@@@*@@@@@@@@@@@@///////@@@@@@@@@@@@@  
@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@");
                        WriteLine("---------------------------------------------------------------");
                        pet.PetGreeting();
                        WriteLine("---------------------------------------------------------------");
                        WriteLine("What would you like to do?");
                        WriteLine("1 > Give a Health Potion");
                        WriteLine("2 > Give some Food");
                        WriteLine("3 > Return");
                        WriteLine();
                        string InventorySquirtle = (Console.ReadLine());

                        if (InventorySquirtle == "1")
                        {
                            Clear();
                            WriteLine(@"@@@@@@@@@@@@@@*,,,%@@@@@@@@@@@@@@@@@@@@@  
@@@@@@@@@@,..,,**,**,**@@@@@@@@@@@@@@@@@  
@@@@@@@@@*,,**,*,@ @****@@@@@@@@@@@@@@@@  
@@@@@@@@#,,,*,,,&@%&/////@@@@@@@@@@@@@@@  
@@@@@@@%*****,,,,,,*/////@@@@@@@@@@@@@@@  
@@@@@@@@////////////////@@@@@@@@@@@@@@@@  
@@@@@@@@@@/&/////////(,,(*@@@@@@@@@@@@@@  
@@@@,,,,,%..,*****%.,,*//(@@@@@@@@@@@@@@  
@(/,*,,,....../@@,,,,,*///(/@@@@@@@@@@@@  
@@@/*/(@.......,%,//****,*/**@@@@@@@@@@@  
@@@@@@@#.....#.,,,#//**,,(//(@@@@@@@@@@@  
@@@@@@@@,,,,,@..,.,****&,&((@@@***,,*/(@  
@@@@@@,,,,...%..,**@,,,,**(@@////&/////&  
@@@@@,.,,*/****,#*/,,,,,,,(////////////@  
@@@@@#*/////@@@@@@@,*,*,,*///////////@@@  
@@@@@@@*@@@@@@@@@@@@///////@@@@@@@@@@@@@  
@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@");
                            WriteLine("---------------------------------------------");
                            WriteLine("You try to give your Squirtle a Health Potion.");

                            if (pet.PetHealthPoints < 100)
                            {
                                pet.PetHealthPoints += 20;
                                WriteLine("You give your Squirtle a Health Potion + 20 Health Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(2);
                            }

                            else if (pet.PetHealthPoints == 100)
                            {
                                WriteLine("Your Squirtle is already at full health...");
                                System.Threading.Thread.Sleep(3000);
                            }

                            else
                            {
                                setWorld(2);
                            }


                        }

                        else if (InventorySquirtle == "2")
                        {
                            Clear();
                            WriteLine(@"@@@@@@@@@@@@@@*,,,%@@@@@@@@@@@@@@@@@@@@@  
@@@@@@@@@@,..,,**,**,**@@@@@@@@@@@@@@@@@  
@@@@@@@@@*,,**,*,@ @****@@@@@@@@@@@@@@@@  
@@@@@@@@#,,,*,,,&@%&/////@@@@@@@@@@@@@@@  
@@@@@@@%*****,,,,,,*/////@@@@@@@@@@@@@@@  
@@@@@@@@////////////////@@@@@@@@@@@@@@@@  
@@@@@@@@@@/&/////////(,,(*@@@@@@@@@@@@@@  
@@@@,,,,,%..,*****%.,,*//(@@@@@@@@@@@@@@  
@(/,*,,,....../@@,,,,,*///(/@@@@@@@@@@@@  
@@@/*/(@.......,%,//****,*/**@@@@@@@@@@@  
@@@@@@@#.....#.,,,#//**,,(//(@@@@@@@@@@@  
@@@@@@@@,,,,,@..,.,****&,&((@@@***,,*/(@  
@@@@@@,,,,...%..,**@,,,,**(@@////&/////&  
@@@@@,.,,*/****,#*/,,,,,,,(////////////@  
@@@@@#*/////@@@@@@@,*,*,,*///////////@@@  
@@@@@@@*@@@@@@@@@@@@///////@@@@@@@@@@@@@  
@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@");
                            WriteLine("---------------------------------------------");
                            WriteLine("You try to give your Squirtle some food.");

                            if (pet.PetHungerLevel < 100)
                            {
                                pet.PetHungerLevel += 30;
                                WriteLine("You give your Squirtle some food, + 30 Hunger Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(2);
                            }

                            else if (pet.PetHungerLevel == 100)
                            {
                                WriteLine("Your Squirtle is not hungry...");
                                System.Threading.Thread.Sleep(3000);
                            }

                            else
                            {
                                setWorld(2);
                            }
                        }

                        else if (InventorySquirtle == "3")
                        {
                            setWorld(2);
                        }

                        else
                        {
                            WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                            System.Threading.Thread.Sleep(2000);

                        }


                    }

                    else if (SquirtleChoice == "3")
                    {
                        Run();
                    }

                    else
                    {
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000);

                    }

                }








             /// Charmander gameplay starts HERE








                else if (choice == 3)
                {
                    Thread hp = new Thread(HealthDown);
                    Thread hl = new Thread(HungerDown);
                    hp.Start();
                    hl.Start();
                    Clear();
                    WriteLine(@"@@@@@@@@@,,,(@@@@@@@@@@@@@@@@%%%%%%%    
@@@@@,..,,,,,,**@@@@@@@@@@@@@%%%%%%%    
@@@@,,**,,,*** #/@@@@@@@@@@@%%%%%%%%    
@@@% ,,,,,,,,(*@#&@@@@@@@@@#%%%%%%%%    
@@@#%,**,,,,,*////@@@@@@@@%%%%%%%%%%    
@@@(,,,,***,,*/@//@@@@@@@@%#%%%%(#%%    
@@@@@//(((*,,*//*@@@@@@@@@####%#//%%    
@@@@@@@@//*@////*,(@@@@@@@@#%%/*/./#    
@/,*,,,,,     ,,,,,*,,,,/@@@%./*/../    
@@****//    ..  *(***///@@@#%%.,../#    
@@@@@@@#    .... ,,,@@@@@@@###%#/%%%    
@@@@@@@,   .....  ,,,,@@@@@@@@@/,@@@    
@@@@@,,,,.....,,,,.,,,,@@@@@%//@@@@@    
@@@@.,,*/(,.,.,..,,,,,*//////,@@@@@@    
@@@@///////*@@@&,.//////@*%@@@@@@@@@    
@@ #. //&@@@@@@@@@@@/////@@@@@@@@@@@    
@@@@@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@");
                    WriteLine("---------------------------------------------------------------");
                    pet.PetGreeting();
                    WriteLine("---------------------------------------------------------------");
                    WriteLine("What would you like to do?");
                    WriteLine("1 > Pet your Pokemon");
                    WriteLine("2 > Inventory");
                    WriteLine("3 > Go back to the Main Menu");
                    WriteLine();
                    string CharmanderChoice = (Console.ReadLine());
                    if (CharmanderChoice == "1")
                    {
                        Clear();
                        WriteLine(@"@@@@@@@@@,,,(@@@@@@@@@@@@@@@@%%%%%%%    
@@@@@,..,,,,,,**@@@@@@@@@@@@@%%%%%%%    
@@@@,,**,,,*** #/@@@@@@@@@@@%%%%%%%%    
@@@% ,,,,,,,,(*@#&@@@@@@@@@#%%%%%%%%    
@@@#%,**,,,,,*////@@@@@@@@%%%%%%%%%%    
@@@(,,,,***,,*/@//@@@@@@@@%#%%%%(#%%    
@@@@@//(((*,,*//*@@@@@@@@@####%#//%%    
@@@@@@@@//*@////*,(@@@@@@@@#%%/*/./#    
@/,*,,,,,     ,,,,,*,,,,/@@@%./*/../    
@@****//    ..  *(***///@@@#%%.,../#    
@@@@@@@#    .... ,,,@@@@@@@###%#/%%%    
@@@@@@@,   .....  ,,,,@@@@@@@@@/,@@@    
@@@@@,,,,.....,,,,.,,,,@@@@@%//@@@@@    
@@@@.,,*/(,.,.,..,,,,,*//////,@@@@@@    
@@@@///////*@@@&,.//////@*%@@@@@@@@@    
@@ #. //&@@@@@@@@@@@/////@@@@@@@@@@@    
@@@@@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@");
                        WriteLine("---------------------------------------------");
                        WriteLine("You Pet your Charmander");
                        WriteLine("He seems to be happy (^_^)");
                        System.Threading.Thread.Sleep(5000);
                    }

                    else if (CharmanderChoice == "2")
                    {
                        Clear();
                        WriteLine(@"@@@@@@@@@,,,(@@@@@@@@@@@@@@@@%%%%%%%    
@@@@@,..,,,,,,**@@@@@@@@@@@@@%%%%%%%    
@@@@,,**,,,*** #/@@@@@@@@@@@%%%%%%%%    
@@@% ,,,,,,,,(*@#&@@@@@@@@@#%%%%%%%%    
@@@#%,**,,,,,*////@@@@@@@@%%%%%%%%%%    
@@@(,,,,***,,*/@//@@@@@@@@%#%%%%(#%%    
@@@@@//(((*,,*//*@@@@@@@@@####%#//%%    
@@@@@@@@//*@////*,(@@@@@@@@#%%/*/./#    
@/,*,,,,,     ,,,,,*,,,,/@@@%./*/../    
@@****//    ..  *(***///@@@#%%.,../#    
@@@@@@@#    .... ,,,@@@@@@@###%#/%%%    
@@@@@@@,   .....  ,,,,@@@@@@@@@/,@@@    
@@@@@,,,,.....,,,,.,,,,@@@@@%//@@@@@    
@@@@.,,*/(,.,.,..,,,,,*//////,@@@@@@    
@@@@///////*@@@&,.//////@*%@@@@@@@@@    
@@ #. //&@@@@@@@@@@@/////@@@@@@@@@@@    
@@@@@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@");
                        WriteLine("---------------------------------------------------------------");
                        pet.PetGreeting();
                        WriteLine("---------------------------------------------------------------");
                        WriteLine("What would you like to do?");
                        WriteLine("1 > Give a Health Potion");
                        WriteLine("2 > Give some Food");
                        WriteLine("3 > Return");
                        WriteLine();
                        string InventoryCharmander = (Console.ReadLine());

                        if (InventoryCharmander == "1")
                        {
                            Clear();
                            WriteLine(@"@@@@@@@@@,,,(@@@@@@@@@@@@@@@@%%%%%%%    
@@@@@,..,,,,,,**@@@@@@@@@@@@@%%%%%%%    
@@@@,,**,,,*** #/@@@@@@@@@@@%%%%%%%%    
@@@% ,,,,,,,,(*@#&@@@@@@@@@#%%%%%%%%    
@@@#%,**,,,,,*////@@@@@@@@%%%%%%%%%%    
@@@(,,,,***,,*/@//@@@@@@@@%#%%%%(#%%    
@@@@@//(((*,,*//*@@@@@@@@@####%#//%%    
@@@@@@@@//*@////*,(@@@@@@@@#%%/*/./#    
@/,*,,,,,     ,,,,,*,,,,/@@@%./*/../    
@@****//    ..  *(***///@@@#%%.,../#    
@@@@@@@#    .... ,,,@@@@@@@###%#/%%%    
@@@@@@@,   .....  ,,,,@@@@@@@@@/,@@@    
@@@@@,,,,.....,,,,.,,,,@@@@@%//@@@@@    
@@@@.,,*/(,.,.,..,,,,,*//////,@@@@@@    
@@@@///////*@@@&,.//////@*%@@@@@@@@@    
@@ #. //&@@@@@@@@@@@/////@@@@@@@@@@@    
@@@@@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@");
                            WriteLine("---------------------------------------------");
                            WriteLine("You try to give your Charmander a Health Potion.");

                            if (pet.PetHealthPoints < 100)
                            {
                                pet.PetHealthPoints += 20;
                                WriteLine("You give your Charmander a Health Potion + 20 Health Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(3);
                            }

                            else if (pet.PetHealthPoints == 100)
                            {
                                WriteLine("Your Charmander is already at full health...");
                                System.Threading.Thread.Sleep(3000);
                            }

                            else
                            {
                                setWorld(3);
                            }


                        }

                        else if (InventoryCharmander == "2")
                        {
                            Clear();
                            Clear();
                            WriteLine(@"@@@@@@@@@,,,(@@@@@@@@@@@@@@@@%%%%%%%    
@@@@@,..,,,,,,**@@@@@@@@@@@@@%%%%%%%    
@@@@,,**,,,*** #/@@@@@@@@@@@%%%%%%%%    
@@@% ,,,,,,,,(*@#&@@@@@@@@@#%%%%%%%%    
@@@#%,**,,,,,*////@@@@@@@@%%%%%%%%%%    
@@@(,,,,***,,*/@//@@@@@@@@%#%%%%(#%%    
@@@@@//(((*,,*//*@@@@@@@@@####%#//%%    
@@@@@@@@//*@////*,(@@@@@@@@#%%/*/./#    
@/,*,,,,,     ,,,,,*,,,,/@@@%./*/../    
@@****//    ..  *(***///@@@#%%.,../#    
@@@@@@@#    .... ,,,@@@@@@@###%#/%%%    
@@@@@@@,   .....  ,,,,@@@@@@@@@/,@@@    
@@@@@,,,,.....,,,,.,,,,@@@@@%//@@@@@    
@@@@.,,*/(,.,.,..,,,,,*//////,@@@@@@    
@@@@///////*@@@&,.//////@*%@@@@@@@@@    
@@ #. //&@@@@@@@@@@@/////@@@@@@@@@@@    
@@@@@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@");
                            WriteLine("---------------------------------------------");
                            WriteLine("You try to give your Charmander some food.");

                            if (pet.PetHungerLevel < 100)
                            {
                                pet.PetHungerLevel += 30;
                                WriteLine("You give your Charmander some food, + 30 Hunger Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(3);
                            }

                            else if (pet.PetHungerLevel == 100)
                            {
                                WriteLine("Your Charmander is not hungry...");
                                System.Threading.Thread.Sleep(3000);
                            }

                            else
                            {
                                setWorld(3);
                            }
                        }

                        else if (InventoryCharmander == "3")
                        {
                            setWorld(3);
                        }

                        else
                        {
                            WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                            System.Threading.Thread.Sleep(2000);

                        }


                    }

                    else if (CharmanderChoice == "3")
                    {
                        Run();
                    }

                    else
                    {
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000);

                    }
                }

                else
            {
                choosePet(); /// Goes back to selecting a pet again
            }

            }

        }

    }
}
