using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter the distance in Kilometer.");
            double dist = System.Convert.ToDouble(Console.ReadLine());
            double total = 2.4 + 0.4 * dist;
            System.Console.WriteLine("Total fares is ${0:#######.##}", total);


   
        }
    }
}
