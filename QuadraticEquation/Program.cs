using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        //public static double a;
        //public static double b;
        //public static double c;
        static void Main(string[] args)
        {
            int a, b, c;

            string appName = "QuadraticEquationSolver";
            string appVersion = "1.0.0";
            string authorName = "Atolagbe Muiz Olalekan";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}, Version {1} by {2}", appName, appVersion, authorName);

            //Reset text color
            Console.ResetColor();

            Console.ResetColor(); 
            //string option;
            double formula;
            
            


        //Collecting user input
            Console.WriteLine("Enter a");           
            a=int.Parse(Console.ReadLine());
            int valA = a;

            //Collecting user input
            Console.WriteLine("Enter b");
            b = Convert.ToInt16(Console.ReadLine());
            int ValB = b;

            //collecting user input
            Console.WriteLine("Enter c");            
            c = Convert.ToInt16(Console.ReadLine());
            int ValC = c;

            //calc the roots of the equation using quadratic formula
            double ValubSquare = ValB * ValB;
            double ValMulti = (4 * valA * ValC);

            double tot = (ValubSquare - ValMulti);
            double tot1 = Math.Sqrt(tot);
            formula = tot1;//Convert.ToDouble(Math.Sqrt(b * b - 4 * a * c));

            
            if (formula > 0)
            {
                
                double x1 = (-b + formula) / (2*a);
                double x2 = (-b - formula) / (2*a);
                Console.ReadLine();
                Console.WriteLine("x1=" +x1  +"x2=" +x2);
                
            }

            else
            {
                //change text color
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no roots");

                //reset text color
                Console.ResetColor();
            }










        }
    }
}
