using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleAppStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
          
           
            // step 1

            FileStream myFileStream = new FileStream("TestFile.txt", FileMode.Open, FileAccess.Read);

            // step 2
            StreamReader myFileReader = new StreamReader(myFileStream);

            // step 3

            Console.WriteLine(myFileReader.ReadLine());
          

            string var1, var2, var3 = "values";

            for (int i = 0; i < 10; i++)


            {
               

                var myVar = String.Format("name{0}", i.ToString());
                
            }



        }
    }
}
