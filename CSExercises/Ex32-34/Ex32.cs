using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int total = 0 ;
            int[] A = new int[12];
 
            for (int i = 0 ; i < 12  ; i++ )
            {
                Console.WriteLine("Enter sales for the month {0}", i);
                A[i] = Convert.ToInt32(Console.ReadLine());
                total = total + A[i];

            }   // puting number into array

            int max = A.Max();      // find maxi
            int p = A.ToList().IndexOf(max);  // find location
            Console.WriteLine("Maximum Sales: " + p);

            int min = A.Min();          // find min
            int q = A.ToList().IndexOf(min);
            Console.WriteLine("Minimum Sales: " + q);

            int avg = total / 12 ;
            Console.WriteLine("Average Sales: " + avg);

        }
    }
}
