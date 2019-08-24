using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppEmployee
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee myEmployee = new Employee();
            myEmployee.FirstName = "John";
            myEmployee.LastName = "Doe";
            myEmployee.Dept = null;

            AssignDept(myEmployee);
            myEmployee.SetNames();
            Console.WriteLine(myEmployee.Dept);

            myEmployee.SetNames();


        }


        static void AssignDept(Employee emp)
        {

            if (string.IsNullOrEmpty(emp.Dept))
            {


                emp.Dept = "Sales";

            }


        }

        class Employee 
        {

            public string FirstName;
            public string LastName;
            public string Dept;


         public void SetNames()
            {


            }




        }




    }
}
