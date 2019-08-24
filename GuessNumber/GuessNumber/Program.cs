using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber, min, max;
            min = 1;
            max = 100;

            Console.WriteLine("Hey You! Give me a number!");
            userNumber = Convert.ToInt32(Console.ReadLine());
            RandomNumber(min, max);
        }

        static private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
