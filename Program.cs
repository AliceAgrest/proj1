using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Tal's score for the {0} game: ", i+1);
                tal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Roi's score for the {0} game: ", i + 1);
                roi = int.Parse(Console.ReadLine());

                if (tal > roi)
                    Console.WriteLine(tal);
                else
                    Console.WriteLine("Roi");

                taltotal += tal;
                roitotal += roi;
            }

            if ( taltotal > roitotal)
                Console.WriteLine("Tal");
            else
                Console.WriteLine("Roi");

            //answer 2
            int num;

            for (num = 1; num<=100; num++)
            {
                if (num % 3 == 0)
                    Console.WriteLine(" " + num);
            }
            */
            //answer 3
            int s;
            Random rnd = new Random();

            s = rnd.Next(100)+1;

            Console.ReadLine();
        }
    }
}
