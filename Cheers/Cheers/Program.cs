using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            name = name.ToLower();
            foreach (char letter in name)
            {
                string aOrAn = "a";
                foreach (char nonvoiced in "halfnorsemix")
                {
                    if (letter == nonvoiced)
                    {
                        aOrAn = "an";
                    }
                }
                Console.WriteLine("Give me " + aOrAn + ".. " + letter);
            }
            name = name.ToUpper();
            Console.WriteLine(name + " is.. GRAND!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
