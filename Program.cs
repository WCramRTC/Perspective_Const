using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Perspective
            //            Calculate how many combinations of 5 numbers can be drawn from 69 unique numbers:
            int uniqueNumbers = 69; //!
            int chosenValues = 5; //!
            int perm = uniqueNumbers - chosenValues;

            double howMany = uniqueNumbers / chosenValues * (perm);
            int fiveFact = 4;
            int count = 5;
            Console.WriteLine(fiveFact);



            Console.WriteLine(Factorial(5));

        //    69!
        //5!(69 −5)!
        // Factorial(69) / Factorial(5) * Factorial(69 - 5 )
        } // main

        /*
            def ReverseFactorial(Start, Finish = 1):

                try:
                    total = 1
                    fin = Start - Finish if Finish != 1 else 1

                    for i in range(Start, fin, -1):
                        total *= i

                    return total;
                except ValueError:
                    return None;
         */

        public static double Factorial(double start, double end = 1)
        {

            double total = 1;
            double din = (start - end != 1) ? start - end : 1;

            for (double i = start; i >= end; i--)
            {
                total *= i;
                Console.WriteLine(i);
            }

            return total;
        }

    } // class

} // namespace
