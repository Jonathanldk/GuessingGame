using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesserGame
{
    class Program
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        //const int MaxTrials = 10;
        static int currentTrials = 9;

       
        static void Main(string[] args)
        {

            Console.WriteLine("Stop! Who would cross the Bridge of Death must answer me this one question, ere the other side he see.");

            Console.WriteLine("You have 10 guesses");

            while (true)
            {
                Console.WriteLine("What... is your name");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "Sir Arthur":
                        Console.WriteLine("Congratulation you may cross the brigde");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong answer try again:");

                        Console.WriteLine("Answers left:" + " " + currentTrials--);

                        break;
                }
                if (currentTrials == -1)
                {
                    Console.WriteLine("You are not worthy enough to cross the brigde");
                    Environment.Exit(0);

                }

            }
        }
    }
}
