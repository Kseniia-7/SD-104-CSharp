using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int F0 = 0;
            int F1 = 1;
            int userF;

            Console.WriteLine("Enter a number in the Fibonacci sequence");
            while(!Int32.TryParse(Console.ReadLine(), out userInput) || userInput < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

            if (userInput == 0)
            {
                Console.WriteLine(userInput + " Fibonacci number is: " + F0);
            }
            else if (userInput == 1)
                    {
              
                    Console.WriteLine(userInput + " Fibonacci number is: " + F1);
                     }
            
            else
            { for (int i = 2; i <= userInput; i++)
                {
                    userF = F0 + F1;
                    F0 = F1;
                    F1 = userF;
                    Console.WriteLine(i + " Fibonacci number is: " + userF);
                }
            }

            Console.ReadLine();
        }
    }
}
