using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please type in ur salary.");
            double a = System.Convert.ToDouble(System.Console.ReadLine());// get salary
            double b = a * 0.1;  // 10% housing allowance
            double c = a * 0.03;  // 3% transport allowance
            double d = a + b + c;
            System.Console.WriteLine(" Total Income is ${0:00000000.000}", d);
 
        }
    }
}
