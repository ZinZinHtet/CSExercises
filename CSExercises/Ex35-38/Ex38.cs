using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] A = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] B = new int[] { 63, 29, 75, 82, 55 };

            Console.WriteLine("First Report : ");        // first part sort by marks

            string name = "Name";
            Console.Write(name.PadRight(15, ' '));
            string mark = "Mark";
            Console.Write(mark);

            Console.WriteLine("\n");
                       
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 1; i < B.Length; i++)
                {
                    //for (int j = 0; j < B.Length; j++ )
                    if (B[i - 1] < B[i])
                    {
                        int temp = B[i];
                        B[i] = B[i - 1];
                        B[i - 1] = temp;
                    }
                } // sorting in descending order
                Console.WriteLine(A[j].PadRight(15, ' ') + B[j]);

            }

            Console.WriteLine("\nSecond Report : ");        // second part sort by marks

            Console.Write(name.PadRight(15, ' '));
           
            Console.Write(mark);

            Console.WriteLine("\n");

            Array.Sort(A);
            for(int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i].PadRight(15, ' ') + B[i]);
            }
               
          

        }
    }
}
