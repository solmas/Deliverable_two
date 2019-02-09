using System;


namespace FunPlacesToGo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var activity = 0;
            var travelType = 0;
            

            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.Write("Here are your options:\n1) Action\n2) Chilling\n3) Danger\n4) Good Food\n\nPlease choose a number between 1 and 4\n");
            activity = Int16.Parse(Console.ReadLine());

            Console.WriteLine("And how many people will be coming with you?");
            travelType = Int16.Parse(Console.ReadLine());

            if (activity == 1)
            {
                Console.WriteLine("Okay if you're in the mood for action, then you should go see Stock Car Racing ");
            }

            else if (activity == 2)
            {
                Console.WriteLine("Alrighty, if you're in the chilling mood, then you should go Hiking ");
            }

            else if (activity == 3)
            {
                Console.WriteLine("Okey dokey, if danger is your middle name then you should go Skydiving ");
            }

            else if (activity == 4)
            {
                Console.WriteLine("If you're in the mood for good food then you should go to Taco Bell ");
            }

            else
            {
                Console.WriteLine("I'm sorry but I do not understand your input.");
            }


            if (travelType == 0)
            {
                Console.WriteLine("and hoof it!");
            }

            else if (travelType >= 1 && travelType < 4)
            {
                Console.WriteLine("and drive in a sedan to get there!");
            }

            else if (travelType <= 5 && travelType >= 10)
            {
                Console.WriteLine("and pile into a VW bus!");
            }

            else if (travelType > 11)
            {
                Console.WriteLine("and take a plane to get there!");
            }

            else
            {
                Console.WriteLine("I'm sorry but I don't understand how many people that is.");
            }

            Console.WriteLine("Thanks for using our app, goodbye!");
        }
    }
}
