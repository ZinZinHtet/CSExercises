using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Type the value of X.");
            int x = System.Convert.ToInt32(Console.ReadLine());
            double a = x * x;  // double the value of x
            double b = 4 * x;
            double y = 2 * a - b + 3;
            System.Console.WriteLine(" The value of Y =" + y);

        }
    }
}
