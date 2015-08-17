using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" 4 real values. First Enter x1."); // get x1
            int x1 = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(" Second Enter y1."); // get y1
            int y1 = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(" Third Enter x2."); // get x2
            int x2 = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(" Forth Enter y2.");  // get y2
            int y2 = System.Convert.ToInt32(Console.ReadLine());

            double a = x2 - x1;
            a = a * a; // square of a
            double b = y2 - y1;
            b = b * b;  // square of b


            double d = System.Math.Sqrt(a + b);
            System.Console.WriteLine(" Distance is " + d);

   
        }
    }
}
