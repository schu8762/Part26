//@author Jacob Schuller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] courses = new string[3];
            double[] coursenumb = new double[3];
            // double[] coursenumb = { };       
            //string coursenumb = Console.ReadLine();

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"Enter course subject ");
                courses[i] = Console.ReadLine();

                //Convert.ToString(courses)
                Console.WriteLine($"Enter course number ");
                coursenumb[i] = Convert.ToDouble(Console.ReadLine());

                //string courses = Console.ReadLine();
            }

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i] + coursenumb[i]);
            }


            Console.ReadLine();
        }
    }
}
