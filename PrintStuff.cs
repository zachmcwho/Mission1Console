using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    public class Dice
    {
        public void CalculateThrows(int numThrows)
        {
            /*create an int array of length 12 */
            int[] rollValues = new int[12];
            var random = new Random();
            /*create a for loop that goes through all throws*/
            for (int i = 0; i < numThrows; i++)
            {
                /*create 2 random numbers and add them together*/
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int total = roll1 + roll2;
                /*increment the int in the array according to the value of the dice rolls*/
                rollValues[total - 1]++;
              
            }
            /*Print the values of the int in rollValues*/
            string astrics = "";
            double percent = 0.00;
            for (int i = 1; i < rollValues.Length; i++)
            {
                double rollTotal = rollValues[i];
                percent = (rollTotal / numThrows)* 100;
                percent = Math.Round(percent, 0, MidpointRounding.AwayFromZero);
                astrics = "";
                for (int j = 1; j < percent + 1; j++)
                {
                    astrics = astrics + '*';
                }

                Console.WriteLine("{1}: {0}", astrics, i + 1);
            }
              
        }
    }
}
