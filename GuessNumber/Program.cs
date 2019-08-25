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
            int userNumber;
            string strAnswer = "Y";
            int hidden;
            int minValue = 0;
            int maxValue = 100;

            Random rand = new Random();

            do
            {
                hidden = rand.Next(minValue,maxValue);
                Console.WriteLine("Please input an integer number between 0 and 100");
                while(!Int32.TryParse(Console.ReadLine(),out userNumber) || userNumber > 100 || userNumber < 0)
                {
                    Console.WriteLine("Not valid. Must be an integer between 0 and 100.");
                }

                while (userNumber != hidden)
                {
                    if (userNumber < hidden)
                    {
                        Console.WriteLine("Your number is too low. Please input another number.");
                        while (!Int32.TryParse(Console.ReadLine(), out userNumber) || userNumber > 100 || userNumber < 0)
                        {
                            Console.WriteLine("Not valid. Must be an integer between 0 and 100.");
                        }
                    }
                    if (userNumber > hidden)
                    {
                        Console.WriteLine("Your number is too high. Please input another number.");
                        while (!Int32.TryParse(Console.ReadLine(), out userNumber) || userNumber > 100 || userNumber < 0)
                        {
                            Console.WriteLine("Not valid. Must be an integer between 0 and 100.");
                        }
                    }
                }

                Console.WriteLine("You are a winner! Would you like to play once again? If yes, please input Y");
                    strAnswer = Console.ReadLine();
                    
                if (strAnswer != "Y")
                {
                    Console.WriteLine("Good bye!");
                    Console.ReadLine();
                }

            } while (strAnswer == "Y");

        }
    }
}

