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
            Console.WriteLine("Hey, " + name + ", what’s your birthday ? (MM/DD)");
            string birthday = Console.ReadLine();
            DateTime convertedDate = Convert.ToDateTime(birthday);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string aOrAn = "a...  ";
                    foreach (char nonvoiced in "halfnorsemix")
                    {
                        if (letter == nonvoiced)
                        {
                            aOrAn = "an... ";
                        }
                    }
                    Console.WriteLine("Give me " + aOrAn + letter);
                }
            }
            Console.WriteLine(name.ToUpper() + "'s just GRAND!");
            Console.WriteLine(convertedDate);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
