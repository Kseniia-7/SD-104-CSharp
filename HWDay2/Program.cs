using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Larger number is: " + a);
            }

            else
            {
                Console.WriteLine("Larger number is: " + b);
            }

            Console.WriteLine("Enter first number: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            e = Convert.ToInt32(Console.ReadLine());

            if (c > d) 
            {
                if (c > e)

                {
                    Console.WriteLine("Larger number is: " + c);
                    if (e > d)
                    {
                        Console.WriteLine("Smaller number is: " + d);
                    }
                    else
                    {
                        Console.WriteLine("Smaller number is: " + e);
                    }
                }

                else
                {
                    Console.WriteLine("Larger number is: " + e);
                    Console.WriteLine("Smaller number is: " + d);
                }
            }

            else
            {

                if (d > e)
                {
                    Console.WriteLine("Larger number is: " + d);
                    if (e > c)
                    {
                        Console.WriteLine("Smaller number is: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Smaller number is: " + e);
                    }
                }
                else
                {
                    Console.WriteLine("Larger number is: " + e);
                }
                
            }
            Console.ReadLine();
        }
    }
}






           

          