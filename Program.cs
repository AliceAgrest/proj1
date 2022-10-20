using System;

namespace proj 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            int tal, taltotal = 0, roi, roitotal = 0 , i;

            for(i = 1;1 <= 5;i+=1 )
            { 
                Console.WriteLine("Enter a Tal's score for the {0} game: ", i+1);
                tal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Roi's score for the {0} game: ", i + 1);
                roi = int.Parse(Console.ReadLine());

                if (tal > roi)
                    Console.WriteLine("Tal");
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

            //answer 3
            int num1 , total = 0;
            Random rnd = new Random();

            for(int a = 0;a <= 20; a+=1)
            {
                num1 = rnd.Next(100) + 1;
                //Console.WriteLine(" " + num1);
                if (num1 > 70)
                    Console.WriteLine("This number is bigger then 70: " + num1);

                total += num1;
            }
            total = total / 20;
            Console.WriteLine("Average of random numbers is "+ total);
            
            //answer 4
            int humen1 = 0, humen2 = 0;
            Random rnd1 = new Random();

            for (int c = 0; c < 3; c += 1)  
            {
                humen1 = rnd1.Next(6) + 1;
                Console.WriteLine(" " + humen1);
                humen2 = rnd1.Next(6) + 1;
                Console.WriteLine(" " + humen2);
            }
            if (humen1 > humen2)
                Console.WriteLine("The winner is the first humen");
            else
                Console.WriteLine("The winner is the second humen");

            //answer 5
            int n ,count5 = 0, count6 = 0, count7 = 0, total3 = 0;
            Random rnd2 = new Random();

            Console.WriteLine("Enter a number of loops: ");
            n = int.Parse(Console.ReadLine());

            for (int r = 0; r <= n;r++)
            {
                int x = rnd2.Next(5, 8);
                Console.WriteLine(" " + x);

                if (x == 5)
                    count5 += 1;

                else if (x == 6)
                    count6 += 1;

                else
                    count7 += 1;

                total3 += x;
            }
            if (count5 > count6 && count5 > count7)
                Console.WriteLine("The most drawed number is 5");
            else if (count6 > count5 && count6 > count7)
                Console.WriteLine("The most drawed number is 6");
            else
                Console.WriteLine("The most drawed number is 7");

            total3 = total3 / n;
            Console.WriteLine("The averege of all numbers is: " + total3);

            Console.WriteLine("The biggest number is 7");
            
            //answer 6
            int nume, nume2, totaln;
            Console.WriteLine("Enter the basis number ");
            nume = int.Parse(Console.ReadLine());
            totaln = nume;
            Console.WriteLine("Enter the estimator number ");
            nume2 = int.Parse(Console.ReadLine());

            for (int w = 0; w < nume2; w ++)
            {
                nume = nume + totaln;
                
            }
            Console.WriteLine("The exponent is " + nume);

            Console.ReadLine();
        }
    }
}
