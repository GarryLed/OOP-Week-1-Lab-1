/*
 Name: Garry Ledwith
 Date: 16/09/24
 Description: Q2
 * Selection – Switch
   Use a switch statement which accepts a grade such as H1 and returns the points.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // initialise variables 
            int points;
            string studentAnswer;

            // get info from user 
            Console.Write(">> Please enter your final letter grade (H1, H2, etc...) : ");
            studentAnswer = Console.ReadLine().ToLower();
            
            switch (studentAnswer)
            {
                case "h1":
                    points = 100;
                    break;
                case "h2":
                    points = 88;
                    break;
                case "h3":
                    points = 77;
                    break;
                case "h4":
                    points = 66;
                    break;
                case "h5":
                    points = 56;
                    break;
                case "h6":
                    points = 46;
                    break;
                case "h7":
                    points = 37;
                    break;
                default:
                    points = 0;
                    break;
            }

            // print out points 
            Console.WriteLine($"You have {points} points for a grade of {studentAnswer.ToUpper()}");
        }
    }
}
