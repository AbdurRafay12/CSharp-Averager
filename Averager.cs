using System;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            var avgTotal = 0.0;
            var count = 0;
            Console.WriteLine("Welcome to averager");

            while(true)
            {
                Console.WriteLine("Please enter a number or type \"done\" when finished");
                var minutes =  Console.ReadLine();    

                if (minutes.ToLower() == "done")
                {
                    Console.WriteLine("The Average is " + (avgTotal/count));
                    Console.WriteLine("Would you like to take another average? Type n to exit.");
                    var choice = Console.ReadLine();
                    if (choice.ToLower() == "n" || choice.ToLower() == "no")
                    {
                        Console.Write("Program Exiting");
                        break;
                    }
                    else 
                    {
                        continue;
                    }  
                }

                try
                {
                    var avg = double.Parse(minutes);
                    
                    if (avg < 0)
                    {
                        Console.WriteLine ("This is not a valid input");
                        continue;
                    }

                        avgTotal += avg;
                        count += 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You cannot enter words or letters");
                    continue;
                }
            }
        }
    }
}
