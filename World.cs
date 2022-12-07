﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console; /// Removes need of Console. use. such as WriteLine(""); and not Console.WriteLine("");

namespace VirtualPets
{
    class World : Menu
    {
        public PetInfo pet;
        public World(PetInfo Pet) {
            pet = Pet;
        }
        public void setWorld(int choice)
        {
            while (true) 
            {




            /// Bulbasaur Gameplay starts HERE





            if (choice == 1)
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
                pet.PetGreeting();
                WriteLine("---------------------------------------------------------------");
                WriteLine("What would you like to do?");
                WriteLine("1 > Pet your Pokemon");
                WriteLine("2 > Inventory");
                WriteLine("3 > Go back to the Main Menu");
                WriteLine();
                string BulbasaurChoice = (Console.ReadLine());

                if (BulbasaurChoice == "1")
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
                    WriteLine("---------------------------------------------");
                    WriteLine("You Pet your Bulbasaur");
                    WriteLine("He seems to be happy (^_^)");
                    System.Threading.Thread.Sleep(5000);
                }

                else if (BulbasaurChoice == "2")
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
                    pet.PetGreeting();
                    WriteLine("---------------------------------------------------------------");
                    WriteLine("What would you like to do?");
                    WriteLine("1 > Give a Health Potion");
                    WriteLine("2 > Give some Food");
                    WriteLine("3 > Return");
                    WriteLine();
                    string InventoryBulbasaur = (Console.ReadLine());

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

                        if (pet.PetHealthPoints < 100)
                        {
                            pet.PetHealthPoints += 5;
                            WriteLine("You give your Bulbasaur a Health Potion + 5 Health Points...");
                            System.Threading.Thread.Sleep(3000);
                            setWorld(1);
                        }

                        else if (pet.PetHealthPoints == 100)
                        {
                            WriteLine("Your Bulbasaur is already at full health...");
                            System.Threading.Thread.Sleep(3000);
                        }

                        else
                        {
                                setWorld(1);
                        }


                    }

                    else if (InventoryBulbasaur == "2")
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
                            WriteLine("You try to give your Bulbasaur some food.");

                        if (pet.PetHungerLevel < 100)
                        {
                            pet.PetHungerLevel += 5;
                            WriteLine("You give your Bulbasaur some food, + 5 Hunger Points...");
                            System.Threading.Thread.Sleep(3000);
                            setWorld(1);
                        }

                        else if (pet.PetHungerLevel == 100)
                        {
                            WriteLine("Your Bulbasaur is not hungry...");
                            System.Threading.Thread.Sleep(3000);
                        }

                        else
                        {
                            setWorld(1);
                        }
                        }

                    else if (InventoryBulbasaur == "3")
                    {
                            setWorld(1);
                    }

                    else
                    {
                        WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                        System.Threading.Thread.Sleep(2000);

                    }


                }

                else if (BulbasaurChoice == "3")
                {
                    Run();
                }

                else
                {
                    WriteLine("!!! >>> Please choose an option from the list <<< !!!");
                    System.Threading.Thread.Sleep(2000);

                }



            }



            /// Squirtle Pokemon Starts HERE


                else if (choice == 2)
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
                                pet.PetHealthPoints += 5;
                                WriteLine("You give your Squirtle a Health Potion + 5 Health Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(1);
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
                                pet.PetHungerLevel += 5;
                                WriteLine("You give your Squirtle some food, + 5 Hunger Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(1);
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
                                pet.PetHealthPoints += 5;
                                WriteLine("You give your Charmander a Health Potion + 5 Health Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(1);
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
                                pet.PetHungerLevel += 5;
                                WriteLine("You give your Charmander some food, + 5 Hunger Points...");
                                System.Threading.Thread.Sleep(3000);
                                setWorld(1);
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
                choosePet();
            }

            }

        }

    }
}
