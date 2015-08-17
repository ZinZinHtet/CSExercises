using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double D = 2.4;
            Console.WriteLine("Please type in the distance in km .");
            double dist = Convert.ToDouble(Console.ReadLine());     // get distance
            double DB = dist*10;            // change to meter
            double DA = Math.Ceiling(DB);    // Round up
          
            if ( DA >= 90)
            { D = D +  (85 * 0.04) + ((DA - 90) * 0.05);
            Console.WriteLine("Sum is ${0:###.#0}", D);
            }
            else
           { D = D + DA * 0.04;
           Console.WriteLine("Sum is ${0:###.#0}", D);
           }
            
          


        }
    }
}