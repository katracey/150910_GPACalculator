using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150910_GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates a student’s GPA on a 4.0 scale. Take user input.

            Console.WriteLine("Let's figure out your GPA.");
            Console.WriteLine("How many letter grades do you have total?");
            int amount = int.Parse(Console.ReadLine());
            int counter = 1;
            decimal dGrade = 0.0m;
            while (counter <= amount)
            {
                Console.Write(counter + ".");
                string sGrade = Console.ReadLine();
                counter++;
                if (sGrade == "A")
                {
                    dGrade += Convert.ToDecimal(4);
                }
                else if (sGrade == "B")
                {
                    dGrade += Convert.ToDecimal(3);
                }
                else if (sGrade == "C")
                {
                    dGrade += Convert.ToDecimal(2);
                }
                else if (sGrade == "D")
                {
                    dGrade += Convert.ToDecimal(1);
                }
                else if (sGrade == "F")
                {
                    dGrade += Convert.ToDecimal(0);
                }
                else
                {
                    Console.WriteLine("Please use valid format (A,B,C,D, or F).");
                    counter--;
                }
                  
            }
            decimal gpa = (dGrade / amount);
            Console.Write("Your GPA is: ");
            Console.WriteLine(gpa);

            //Console.Write("1.");
           // string firstGrade = Console.ReadLine();
            //Console.Write("2.");
            //string secondGrade = Console.ReadLine();
            //Console.WriteLine("3.");
            //if (English == "A")
            //in progress   
            //{ English = Convert.ToDecimal(4.0m);
            
              //      Console.WriteLine(English); 
            
            

         


        }
    }
}
