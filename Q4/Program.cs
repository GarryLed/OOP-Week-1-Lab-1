/*
 Name: Garry Ledwith
 Date: 18/05/24
 Description: Q4
 * Add a for loop which will repeat 7 times and ask for results in each of 7 subjects. Keep a tally of the total number of points and display this at the end.  Normally Leaving Cert results are comprised of 6 subjects.
 * Amend so that the lowest number of points are discarded.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        // static variable for runnng total  
        static int runningTotal; 
        static void Main(string[] args)
        {
            // initialise variables 
            int percentageMark;
            int totalSubjects = 3;
            string grade;
            string level;
            string higher = "h";

            // initialise variables 
            int points = 0;
            string studentAnswer;

            // for loop 
            for (int i = 0; i < totalSubjects; i++)
            {
                // get info from user 
                Console.WriteLine("Enter 'H' for higher paper or 'O' for ordinary paper");
                level = Console.ReadLine().ToLower();

                Console.WriteLine(">> Please enter your final grade point : ");
                studentAnswer = (Console.ReadLine());

                switch (studentAnswer)
                {
                    case "h1":
                        points = 100;
                        runningTotal += points; // not adding running total to points 
                        //Console.WriteLine($"runing total is {runningTotal}");
                        break;
                    case "h2":
                        points = 88;
                        runningTotal += points;
                        break;
                    case "h3":
                        points = 77;
                        runningTotal += points;
                        break;
                    case "h4":
                        points = 66;
                        runningTotal += points;
                        break;
                    case "h5":
                        points = 56;
                        runningTotal += points;
                        break;
                    case "h6":
                        points = 46;
                        runningTotal += points;
                        break;
                    case "h7":
                        points = 37;
                        runningTotal += points;
                        break;
                    default:
                        points = 0;
                        break;
                }
                
            }
            // print out results 
            Console.WriteLine($"Your total points: {runningTotal}");
            


        }
    }
}
