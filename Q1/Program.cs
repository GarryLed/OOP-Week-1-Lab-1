/*
 Name: Garry Ledwith
 Date: 16/09/24
 Description: Q1
 * Selection - If
   Ask the user to enter a percentage grade and return the number of points. 
   Use the leaving cert points system and assume only higher paper (for now!)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // initialise variables 
            int percentageMark, points;
            string grade;

            // get info from user 
            Console.WriteLine(">> Please enter your final grade point : ");
            percentageMark = int.Parse(Console.ReadLine());

            // if statement 
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

            // print out results 
            Console.WriteLine($"Your final grade is {grade} and your points are {points}");
        }
    }
}
