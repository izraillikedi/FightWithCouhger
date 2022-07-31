using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fight With Couhger!");

            Console.Write("Enter your name: ");
            string charName = Console.ReadLine();

            Console.WriteLine("Welcome " + charName + ".");
            Console.Write("Please enter your age (18/50): ");
            double charAge = Convert.ToDouble(Console.ReadLine());

            //char stats
            double charWisdom = charAge * 1.5;
            double charStr = 100 - charWisdom;
            double charHP = 150 - charWisdom;
            //Couhger stats
            double chgHP = 20;
            double chgAtk = 10;

            if (18 <= charAge && charAge <= 50)
            {
                Console.WriteLine("Your str is " + charStr + ", your wisdom is " + charWisdom + " and your HP is " + charHP);

                //char skills
                double fireballDmg = charWisdom * 0.2;
                double punch = charStr * 0.2;

                if (charHP > 0)
                {


                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine("You woke up in a dark place you can't see anything but a weak light source few meters further.");
                    Console.ReadKey();
                    Console.WriteLine("'Wait' and watch the light source from this place.");
                    Console.WriteLine("'Walk' to the light source.");

                    string answer1 = Console.ReadLine();
                    //Wait
                    if (answer1 == "Wait")
                    {
                        Console.WriteLine("You observed light source few minutes. Looks like it's coming from a adult male Couhger.");
                        Console.WriteLine("Go and 'attack' to Couhger. (will give you DMG for first attack)");
                        Console.WriteLine("'Look' for another way to escape");

                        string answer3 = Console.ReadLine();
                        //Wait - Attack
                        if (answer3 == "attack")
                        {
                            //fight with Cougher
                            Console.WriteLine("HP: " + charHP);
                            Console.WriteLine("Couhger hp: " + chgHP);
                            Console.ReadKey();
                            Console.WriteLine("You have adventage for the first attack.");
                            Console.ReadKey();
                            Console.WriteLine("Punch (dmg= " + punch * 2 + ")");
                            Console.WriteLine("Fire Ball (dmg= " + fireballDmg * 2 + ")");
                            string answer4= Console.ReadLine();
                            if (answer4 == "Punch")
                            {
                                while (chgHP > 0)
                                {
                                    chgHP = chgHP - (punch * 2);
                                    Console.WriteLine("Couhger lost it's " + punch * 2 + " hp");
                                    Console.ReadKey();

                                    if (chgHP <= 0)
                                    {
                                        Console.WriteLine("You defeated Couhger!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Couhger preparing for an attack");
                                        Console.ReadKey();
                                        charHP = charHP - chgAtk;
                                        Console.WriteLine("You lost " + chgAtk + " hp");
                                        Console.ReadKey();
                                        Console.WriteLine("What is your next attack?");
                                        Console.WriteLine("Punch (dmg= " + punch + ")");
                                        Console.WriteLine("Fire Ball (dmg= " + fireballDmg + ")");
                                        string answer5 = Console.ReadLine();
                                        if (answer5 == "Punch")
                                        {
                                            chgHP = chgHP - punch;
                                            Console.WriteLine("Couhger lost " + punch + " hp");
                                            Console.ReadKey();
                                        }
                                        else if (answer5 == "Fire Ball")
                                        {
                                            chgHP = chgHP - fireballDmg;
                                            Console.WriteLine("Couhger lost " + fireballDmg + " hp");
                                            Console.ReadKey();
                                        }
                                    }

                                }

                            }
                            else if (answer4 == "Fire Ball")
                            {
                                while (chgHP > 0)
                                {
                                    chgHP = chgHP - (fireballDmg * 2);
                                    Console.WriteLine("Couhger lost it's " + fireballDmg * 2 + " hp");
                                    Console.ReadKey();

                                    if (chgHP <= 0)
                                    {
                                        Console.WriteLine("You defeated Couhger!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Couhger preparing for an attack");
                                        Console.ReadKey();
                                        charHP = charHP - chgAtk;
                                        Console.WriteLine("You lost " + chgAtk + " hp");
                                        Console.ReadKey();
                                        Console.WriteLine("What is your next attack?");
                                        Console.WriteLine("Punch (dmg= " + punch + ")");
                                        Console.WriteLine("Fire Ball (dmg= " + fireballDmg + ")");
                                        string answer5 = Console.ReadLine();
                                        if (answer5 == "Punch")
                                        {
                                            chgHP = chgHP - punch;
                                            Console.WriteLine("Couhger lost " + punch + " hp");
                                            Console.ReadKey();
                                        }
                                        else if (answer5 == "Fire Ball")
                                        {
                                            chgHP = chgHP - fireballDmg;
                                            Console.WriteLine("Couhger lost " + fireballDmg + " hp");
                                            Console.ReadKey();
                                        }
                                    }

                                }
                            }
                        }else if (answer3 == "Look")
                        {
                            Console.WriteLine("Looks like there is another way to walk but there is so much blood on that path's floor.");
                            Console.ReadKey();
                            Console.WriteLine("Do you want to go that path? ");
                            Console.ReadKey();
                            Console.WriteLine("(Y) Go to that path");
                            Console.WriteLine("(N) Attack to Couhger with extra bonus dmg for first attack");
                            string answer6 = Console.ReadLine();
                            if (answer6 == "N")
                            {
                                //fight with Cougher
                                Console.WriteLine("HP: " + charHP);
                                Console.WriteLine("Couhger hp: " + chgHP);
                                Console.ReadKey();
                                Console.WriteLine("You have adventage for the first attack.");
                                Console.ReadKey();
                                Console.WriteLine("Punch (dmg= " + punch * 2 + ")");
                                Console.WriteLine("Fire Ball (dmg= " + fireballDmg * 2 + ")");
                                string answer4 = Console.ReadLine();
                                if (answer4 == "Punch")
                                {
                                    while (chgHP > 0)
                                    {
                                        chgHP = chgHP - (punch * 2);
                                        Console.WriteLine("Couhger lost it's " + punch * 2 + " hp");
                                        Console.ReadKey();

                                        if (chgHP <= 0)
                                        {
                                            Console.WriteLine("You defeated Couhger!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Couhger preparing for an attack");
                                            Console.ReadKey();
                                            charHP = charHP - chgAtk;
                                            Console.WriteLine("You lost " + chgAtk + " hp");
                                            Console.ReadKey();
                                            Console.WriteLine("What is your next attack?");
                                            Console.WriteLine("Punch (dmg= " + punch + ")");
                                            Console.WriteLine("Fire Ball (dmg= " + fireballDmg + ")");
                                            string answer5 = Console.ReadLine();
                                            if (answer5 == "Punch")
                                            {
                                                chgHP = chgHP - punch;
                                                Console.WriteLine("Couhger lost " + punch + " hp");
                                                Console.ReadKey();
                                            }
                                            else if (answer5 == "Fire Ball")
                                            {
                                                chgHP = chgHP - fireballDmg;
                                                Console.WriteLine("Couhger lost " + fireballDmg + " hp");
                                                Console.ReadKey();
                                            }
                                        }

                                    }

                                }
                                else if (answer4 == "Fire Ball")
                                {
                                    while (chgHP > 0)
                                    {
                                        chgHP = chgHP - (fireballDmg * 2);
                                        Console.WriteLine("Couhger lost it's " + fireballDmg * 2 + " hp");
                                        Console.ReadKey();

                                        if (chgHP <= 0)
                                        {
                                            Console.WriteLine("You defeated Couhger!");
                                        }else if (charHP <= 0)
                                        {
                                            Console.WriteLine("You died.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Couhger preparing for an attack");
                                            Console.ReadKey();
                                            charHP = charHP - chgAtk;
                                            Console.WriteLine("You lost " + chgAtk + " hp");
                                            Console.ReadKey();
                                            Console.WriteLine("What is your next attack?");
                                            Console.WriteLine("Punch (dmg= " + punch + ")");
                                            Console.WriteLine("Fire Ball (dmg= " + fireballDmg + ")");
                                            string answer5 = Console.ReadLine();
                                            if (answer5 == "Punch")
                                            {
                                                chgHP = chgHP - punch;
                                                Console.WriteLine("Couhger lost " + punch + " hp");
                                                Console.ReadKey();
                                            }
                                            else if (answer5 == "Fire Ball")
                                            {
                                                chgHP = chgHP - fireballDmg;
                                                Console.WriteLine("Couhger lost " + fireballDmg + " hp");
                                                Console.ReadKey();
                                            }
                                        }

                                    }

                                }
                            }else if (answer6 =="Y")
                            {
                                Console.WriteLine("You started walking in that way.");
                                Console.ReadKey();
                                Console.WriteLine("It's so dark in here you can't see anything.");
                                Console.ReadKey();
                                Console.WriteLine("You don't know how far you have walked but still nothing here.");
                                Console.ReadKey();
                                Console.WriteLine(".");
                                Console.ReadKey();
                                Console.WriteLine("..");
                                Console.ReadKey();
                                Console.WriteLine("...");
                                Console.ReadKey();
                                Console.WriteLine("Do you want to go back and fight with Couhger? (Y/N)");
                                string answer7 =Console.ReadLine();
                                if (answer7 == "Y")
                                {
                                    chgHP = chgHP * 2;
                                    chgAtk = chgAtk * 3;
                                    Console.WriteLine("When you turn your back for go back you saw there is a bigger Couhger behind you than you saw.");
                                    Console.ReadKey();
                                   
                                    Console.WriteLine("Female couhger HP: " + chgHP + " ," + " ATK: " + chgAtk);
                                    Console.ReadKey();
                                    Console.WriteLine("Couhger prepared for suprise attack!");
                                    Console.ReadKey();
                                    charHP = charHP - (chgAtk * 2);
                                    Console.WriteLine("You lost " + chgAtk * 2 + " hp" + "(" + charHP + ")");
                                    Console.ReadKey();

                                    if (charHP > 0)
                                    {
                                        while(chgHP > 0)
                                        {
                                            if (chgHP > 0)
                                            {
                                                Console.WriteLine("Looks like couhger used all of it's stamina for this attack. You can  attack now.");
                                                Console.ReadKey();
                                                Console.WriteLine("Punch (dmg = " + punch + ")");
                                                Console.WriteLine("Fire Ball (dmg= " + fireballDmg + ")");
                                                string answer9 = Console.ReadLine();
                                                if (answer9 == "Punch")
                                                {
                                                    chgHP = chgHP - punch;
                                                    Console.WriteLine("Couhger lost " + punch + " hp." + "(" + chgHP + ")");
                                                    Console.ReadKey();
                                                    charHP = charHP - chgAtk;
                                                    Console.WriteLine("Couhger attacked you and you lost " + chgAtk + " hp." + "(" + charHP + ")");
                                                    Console.ReadKey();


                                                }
                                                else if (answer9 == "Fire Ball")
                                                {
                                                    chgHP = chgHP - fireballDmg;
                                                    Console.WriteLine("Couhger lost " + fireballDmg + " hp." + "(" + chgHP + ")");
                                                    Console.ReadLine();
                                                    charHP = charHP - chgAtk;
                                                    Console.WriteLine("Couhger attacked you and you lost " + chgAtk + " hp." + "(" + charHP + ")");
                                                    Console.ReadKey();

                                                }
                                            }else if (charHP <= 0)
                                            {
                                                Console.WriteLine("You died.");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                Console.WriteLine("You killed couhger.");
                                                Console.ReadLine();
                                            }
                                            
                                        }

                                    }else if (charHP <= 0)
                                    {
                                        Console.WriteLine("Couhger's suprise attack killed you.");
                                        Console.ReadLine();
                                    }
                                }
                            }
                        }


                    }
                    //Walk
                    else if (answer1 == "Walk")
                    {
                        Console.WriteLine("The light was coming from a Couhger and looks like it saw you and preaparing for an attack.");
                        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||");

                        //fight with Couhger
                        Console.WriteLine("HP: " + charHP);
                        Console.WriteLine("Couhger hp: " + chgHP);
                        Console.ReadKey();
                        Console.WriteLine("Couhger has the adventage for first attack!");
                        Console.ReadKey();
                        charHP = charHP - 10;
                        Console.WriteLine("It attacked and you lost your 10 hp" + "(" + charHP + ")");
                        Console.ReadKey();
                        while (chgHP > 0)
                        {
                            Console.WriteLine("Fire ball (dmg= " + fireballDmg + ")");
                            Console.WriteLine("Punch (dmg= " + punch + ")");
                            string answer2 = Console.ReadLine();
                            if (answer2 == "Fire Ball")
                            {
                                chgHP = chgHP - fireballDmg;
                                Console.WriteLine("++Couhger lost " + fireballDmg + " hp." + "(" + chgHP + ")");
                                Console.ReadKey();
                                if (chgHP <= 0)
                                {
                                    Console.WriteLine("Couhger has been defeated.");
                                }
                                else {
                                    Console.WriteLine("Couhger preaparing for next attack!");
                                    Console.ReadKey();
                                    charHP = charHP - chgAtk;
                                    Console.WriteLine("--You lost " + chgAtk + " hp." + "(" + charHP + ")");

                                }
                                
                                

                            }
                            else if (answer2 == "Punch")
                            {
                                chgHP = chgHP - punch;
                                Console.WriteLine("++Couhger lost " + punch + " hp." + "(" + chgHP + ")");
                                Console.ReadKey();
                                if (chgHP <= 0)
                                {
                                    Console.WriteLine("Couhger has been defeated.");
                                }
                                else
                                {
                                    Console.WriteLine("Couhger preaparing for next attack!");
                                    Console.ReadKey();
                                    charHP = charHP - chgAtk;
                                    Console.WriteLine("--You lost " + chgAtk + " hp." + "(" + charHP + ")");
                                }

                                
                            }
                        }
                    }


                } else
                {
                    Console.WriteLine("You died please try again.");
                }

            }
            else
            {
                Console.WriteLine("Invalide age");
                Console.ReadLine();
            }


        }
    }
}
