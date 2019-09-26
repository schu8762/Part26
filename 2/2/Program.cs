//@author Jacob Schuller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //Console.WriteLine("Please enter in your grade");
           // double grades = Convert.ToDouble(Console.ReadLine());
         
            List<double> userGrades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("Please enter in your grade");
                userGrades.Add(Convert.ToDouble(Console.ReadLine()));


                Console.WriteLine("Do you have another grade? y/n");
                answer = Console.ReadLine();


            } while (answer != "n");

            foreach (var grade in userGrades)
            {
                double sum = (grade + grade);
            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
