using System.Data.SqlClient;
using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Linq;
namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Square root of integers between 1 and 25 ");

            for(int i=1; i < 26 ; i++ )
            {
                double x = SQT(i);
                Console.WriteLine("Square root of " + i + " : " + x);
            }
        }

        public static double SQT(int y)
        {
            double a = Math.Sqrt(y);
            return a;
        }
    }
}
