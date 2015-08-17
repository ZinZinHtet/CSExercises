using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Type Temperature in Centigrade scale ");
            double a = System.Convert.ToDouble(System.Console.ReadLine()); // get temp 
            double b = 1.8 * a + 32; // convert to Fehrenheit
            System.Console.WriteLine(" Convert to Fehrenheit= " + b);


        }
    }
}
