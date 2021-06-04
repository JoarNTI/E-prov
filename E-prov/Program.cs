using System;
using System.Collections.Generic;

namespace E_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool g = true;
            int n;

            List<string> texts = new List<string>();


            Console.WriteLine("Enter the amount of students you want to send to hell 1-5 only");
            string s = Console.ReadLine();
            n = int.Parse(s);
            while (!(n > 1) || n > 5)
            {
                Console.WriteLine("You are pretty stupid huh? Try again and remember 1-5 only");
                Console.ReadLine();
                string s = Console.ReadLine();
                n = int.Parse(s);
            }

            int min = 3;
            int max = 12;

            for (int l = 0; l < n; l++)
            {


                string userInput = "";
                while (userInput.Length < min || userInput.Length > max)
                {
                    Console.Write("Firstname (3-12):");
                    userInput = Console.ReadLine();
                    if (userInput.Length <= min)
                    {
                        Console.WriteLine("Name is too short!");
                    }
                    else if (userInput.Length >= max)
                    {
                        Console.WriteLine("Name is too long!");
                    }

                }

                int min2 = 4;
                int max2 = 20;

                while (userInput.Length < min2 || userInput.Length > max2)
                {
                    Console.Write("Lastname (8-20):");
                    userInput = Console.ReadLine();
                    if (userInput.Length <= min2)
                    {
                        Console.WriteLine("Name is too short!");
                    }
                    else if (userInput.Length >= max2)
                    {
                        Console.WriteLine("Name is too long!");



                    }
                }
            }
        }
    }
}