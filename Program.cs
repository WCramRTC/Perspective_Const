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

        factFiveLoop:;

            fiveFact *= count;

            if(count > 1)
            {
                count--;
            }
            else
            {
                goto breakOut;
            }

            goto factFiveLoop;
        breakOut:;

            Console.WriteLine(fiveFact);

        //    69!
        //5!(69 −5)!
        // Factorial(69) / Factorial(5) * Factorial(69 - 5 )
        } // main

    } // class

} // namespace
