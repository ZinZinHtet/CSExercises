using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex39
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number for the factorial.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Factorial(a);
            Console.WriteLine(b);

        }
        static double Factorial(double x)
        {
            double f = 1;
            for (double i = x; i > 0; i--)
            {
                f = f * i;
            }
            return f;
        }


    }

}
