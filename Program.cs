using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numThrows = 0;
            numThrows = int.Parse(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n Each * represents 1 % of the total number of rolls. \nTotal number of rolls = {0}.", numThrows);

            /*create a new dice instance*/
            var dice = new Dice();

            /*calculate the throws and print the histogram*/
            dice.CalculateThrows(numThrows);


            Console.WriteLine("Enter any key to end program.");
            string pause = "";
            pause = Console.ReadLine();
        }
    }
}