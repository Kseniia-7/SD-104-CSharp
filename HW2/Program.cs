using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double sum;
            double product;
            double difference;
            double quotient;
    
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number:  ");
            b = Convert.ToInt32(Console.ReadLine());
            
            sum = a + b ;

            Console.WriteLine("Sum is " + sum);

            product = a * b;
            Console.WriteLine("Product is " + product);

            difference = Math.Abs(a - b);
            Console.WriteLine("Difference is " + difference);

            quotient = (double)a / b;
            Console.WriteLine("Quotient is " + quotient);
            Console.ReadLine();
               

        }
    }
}
