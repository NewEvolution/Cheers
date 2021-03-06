﻿using System;
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
            string name = NameCheer();
            BirthdayCheer(name);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static string NameCheer()
        {
            Console.WriteLine("Hello there! What's your name?");
            string name = Console.ReadLine();
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
            return name;
        }

        private static void BirthdayCheer(string name)
        {
            DateTime convertedBirthday;
            convertedBirthday = GetBirthday(name);
            DateTime today = DateTime.Today;
            if (convertedBirthday.Equals(today))
            {
                Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                if (convertedBirthday < today)
                {
                    convertedBirthday = convertedBirthday.AddYears(1);
                }
                Console.Write("Awesome! Your birthday is in " + convertedBirthday.Subtract(today).Days);
                Console.WriteLine(" days! Happy Birthday in advance!");
            }
        }

        private static DateTime GetBirthday(string name)
        {
            Console.WriteLine("Hey, " + name + ", what’s your birthday ? (MM/DD)");
            string birthday = Console.ReadLine();
            try
            {
                DateTime convertedBirthday = Convert.ToDateTime(birthday);
                return convertedBirthday;
            }
            catch
            {
                Console.WriteLine("That was not a valid birthday");
                return GetBirthday(name);
            }
        }
    }
}
