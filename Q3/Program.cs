/*
 Name: Garry Ledwith
 Date: 18/05/24
 Description: Q3
 * Amend exercise 1 above to ask for higher or ordinary level
   and calculate the points accordingly.
 */


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Q3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise variables 
            int percentageMark, points;
            string grade, level;
            string higher = "h";
          
            // get info from user 
            Console.WriteLine(">> Enter 'H' for higher paper or 'O' for ordinary paper");
            level = Console.ReadLine().ToLower();

            Console.WriteLine(">> Please enter your final grade point : ");
            percentageMark = int.Parse(Console.ReadLine());

            // nested if statement 
            if (level == higher )
            {
                if (percentageMark >= 90 && percentageMark <= 100)
                {
                    grade = "H1";
                    points = 100;
                }
                else if (percentageMark >= 80 && percentageMark < 90)
                {
                    grade = "H2";
                    points = 88;
                }
                else if (percentageMark >= 70 && percentageMark < 80)
                {
                    grade = "H3";
                    points = 77;
                }
                else if (percentageMark >= 60 && percentageMark < 70)
                {
                    grade = "H4";
                    points = 66;
                }
                else if (percentageMark >= 50 && percentageMark < 60)
                {
                    grade = "H5";
                    points = 56;
                }
                else if (percentageMark >= 40 && percentageMark < 50)
                {
                    grade = "H6";
                    points = 46;
                }
                else if (percentageMark >= 30 && percentageMark < 40)
                {
                    grade = "H7";
                    points = 37;
                }
                else
                {
                    grade = "H8";
                    points = 0;
                }

            }
            else
            {
                if (percentageMark >= 90 && percentageMark <= 100)
                {
                    grade = "O1";
                    points = 56;
                }
                else if (percentageMark >= 80 && percentageMark < 90)
                {
                    grade = "O2";
                    points = 46; 
                }
                else if (percentageMark >= 70 && percentageMark < 80)
                {
                    grade = "O3";
                    points = 37; 
                }
                else if (percentageMark >= 60 && percentageMark < 70)
                {
                    grade = "O4";
                    points = 28; 
                }
                else if (percentageMark >= 50 && percentageMark < 60)
                {
                    grade = "O5";
                    points = 20; 
                }
                else if (percentageMark >= 40 && percentageMark < 50)
                {
                    grade = "O6";
                    points = 12; 
                }
                else if (percentageMark >= 30 && percentageMark < 40)
                {
                    grade = "O7";
                    points = 0; 
                }
                else
                {
                    grade = "O8";
                    points = 0; 
                }

                // refactored nested if statement using ternary statemtents 

            }
            // print out results 
            Console.WriteLine($"Your final grade is {grade} and your points are {points}");
        }
    }
}
