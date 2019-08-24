using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.WriteLine("Enter your Height in inches: ");

            //validate
            while (!double.TryParse(Console.ReadLine(), out dblHeight) || dblHeight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }
            

            Console.WriteLine("Enter your Weight in pounds: ");
            //validate
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

            //calculation
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

            //issue result and message
            Console.WriteLine("Your BMI is " + dblBMI);

            if (dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5  - Underweight");
            }

            else if (dblBMI <= 24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9  - Normal");
            }

            else if (dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 - Overweight");
            }

            else 
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }

            Console.ReadLine();

        }
    }
}
