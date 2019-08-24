using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_Array;
using Newtonsoft.Json;

namespace ConsoleApp_Array
{
    class Program
    {
        static void Main()
        {
            Student myStudent = new Student();
            myStudent.FirstName = "JOhn";
            myStudent.LastName = "Test";
            myStudent.IsEnrolled = false;

                 EnrollStudent(myStudent);


            Console.WriteLine(myStudent.IsEnrolled);
            Console.ReadLine();
        
        }
        static void EnrollStudent(Student myStudent2)
        {



            Console.WriteLine(myStudent2.FirstName);

            if (myStudent2.IsEnrolled)
            {
               
               
            }
            else
            {
                myStudent2.IsEnrolled = true;
            }

        }
           
        
    }

    class Student
    {
        public string FirstName;
        public string LastName;
        public bool IsEnrolled;
    }
}


    