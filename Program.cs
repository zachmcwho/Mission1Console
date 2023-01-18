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
            /* PrintStuff ps;
             PrintStuff ps2 = new PrintStuff();
             string userName = "";

             Console.Write("Please enter a name: ");
             userName = Console.ReadLine();
             ps = new PrintStuff();
             ps.PrintName(userName);
             Console.Write("Please enter a name: ");
             string tacobell = "";
             tacobell = Console.ReadLine();*/
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int numThrows = 0;
            numThrows = int.Parse(Console.ReadLine());
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n Each * represents 1 % of the total number of rolls. \nTotal number of rolls = {0}.", numThrows);

            var dice = new Dice();

            dice.CalculateThrows(numThrows);


            Console.WriteLine("Enter any key to end program.");
            string pause = "";
            pause = Console.ReadLine();
        }
    }
}