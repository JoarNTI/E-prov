using System;
using System.Collections.Generic;

namespace E_prov
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //Listan samt variabeln "n" som står för ReadLine
            List<string> names = new List<string>();
            int n;


            //Inledesfrågan om hur många som ska bokföras med loop
            Console.WriteLine("Enter the amount of students you want to send to hell 1-5 only");
            string s = Console.ReadLine();
            int.TryParse(s, out n);
            while (!(n > 1) || n > 5)
            {
                Console.WriteLine("You are pretty stupid huh? Try again and remember 1-5 only");
                s = Console.ReadLine();
                int.TryParse(s, out n);
            }


            names = NG(n);
        }

        //Metod NG för namnförfrågningarna
        static List<string> NG(int n)
        {
            List<string> names = new List<string>();
            for (int l = 0; l < n; l++)
            {

                //Frågan om förnamnet med loop
                int min = 2;
                int max = 12;


                string name = "";
                while (name.Length < min || name.Length > max)
                {
                    Console.Write("Firstname (2-12):");
                    name = Console.ReadLine();
                    if (name.Length <= min)
                    {
                        Console.WriteLine("Name is too short!");
                        Console.WriteLine("Firstname (2-12)");
                        name = Console.ReadLine();
                    }
                    else if (name.Length >= max)
                    {
                        Console.WriteLine("Name is too long!");
                        Console.WriteLine("Firstname (2-12)");
                        name = Console.ReadLine();
                    }

                }

                //Frågan om efternamnet med loop
                int min2 = 4;
                int max2 = 20;
                string lastName = "";

                while (lastName.Length < min2 || lastName.Length > max2)
                {
                    Console.Write("Lastname (8-20):");
                    lastName = Console.ReadLine();
                    if (lastName.Length <= min2)
                    {
                        Console.WriteLine("Name is too short!");
                        Console.WriteLine("Lastname (8-20)");
                        name = Console.ReadLine();
                    }
                    else if (lastName.Length >= max2)
                    {
                        Console.WriteLine("Lastname is too long!");
                        Console.WriteLine("Lastname (8-20)");
                        lastName = Console.ReadLine();
                    }
                }
                //Lägger till namnen som skrivits
                names.Add(name + " " + lastName);
                names.Add(name + " " + lastName);
                names.Add(name + " " + lastName);
                names.Add(name + " " + lastName);
                names.Add(name + " " + lastName);



            }

            return names;

        }

    }
}