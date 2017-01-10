using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Fortune Teller express!\nPress on this crystal ball that so happens to say \"enter\".");
            Console.ReadLine();

            Console.WriteLine("\aAwesome! Please enter your first name.");

            string firstname = Console.ReadLine();

            Console.WriteLine("Next, enter your last name.");

            string lastname = Console.ReadLine();

            string fullname = firstname + " " + lastname;

            Console.WriteLine("Cool name! Sounds like Dothraki...\nHow old are you?");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Looking good for your age!\nWhat month were you born?");

            int mon = int.Parse(Console.ReadLine());

            Console.WriteLine("We have the same zodiac sign. This is meant to be!\nHow many siblings do you have?");

            int sib = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your favorite ROYGBIV color? \n\nIf you don't know the colors, I can cast a magic spell and show you a rainbow.\n Enter \"Help\" to see.");

            string color = Console.ReadLine();

            color = color.ToLower();
            if (color == "help")
            {
                Console.WriteLine("Here ya go: red, orange, yellow, green, blue, indigo, and violet");
                color = Console.ReadLine();
                color = color.ToLower();
            }

            switch (color)

            {

                case "red": 
                    color = "Batmobile";                   
                    break;

                case "orange":
                    color = "Millenium Falcon";
                    break;

                case "yellow":
                    color = "Planet Express ship";
                    break;

                case "green":
                    color = "hover board";
                    break;

                case "blue":
                    color = "giant hamster ball automobile";
                    break;

                case "indigo":
                    color = "Portal Gun";
                    break;

                case "violet":
                    color = "Planet Express ship";
                    break;

                default:
                    color = "Carboard box";
                    break;
            }

            Console.WriteLine("\nOk, now as I say this spell...press the ENTER button!\n\n\n\nFORTUNE-O REVEAL-O!");

            Console.ReadLine();

            Console.WriteLine(fullname + "\a "); // fullname result    


            int yearRetired = age % 2; //Age result

            if (yearRetired == 1)
            {
                Console.WriteLine("will retire in 11 years" + " ");
            }
            else
                Console.WriteLine("will retire in 22 years" + " ");


            if (mon <= 12 && mon >= 1) //Month result
            {

                if (mon < 12)
                {
                    Console.WriteLine("with $99,999," + " ");
                }
                else if (mon <= 8)
                {
                    Console.WriteLine("with $1,000,001," + " ");
                }
                else if (mon <= 4)
                {
                    Console.WriteLine("with $444,444," + " ");
                }
            }
            else
                Console.WriteLine("with $0.00." + " ");



            if (sib < 1)   // Sibling result
            {

                Console.WriteLine("a vacation home in New New York");

            }

            else if (sib == 1)

                Console.WriteLine("a vacation home in The Shire");

            else if (sib == 2)

                Console.WriteLine("a vacation home in Diagon Alley");

            else if (sib == 3)

                Console.WriteLine("a vacation home in Hyrule");

            else if (sib > 3)

                Console.WriteLine("a vacation home in Mushroom Kingdom");

            Console.WriteLine("and a stylish" + " " + color + " " + "to ride in! \n\n\n\nThanks for stopping in! ");      

            


          


            
            



          







        }
        }
        }

    

