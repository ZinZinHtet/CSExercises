using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            int temp;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i+1 ; j <= A.Length-1 ; j++)
                {
                    if (A[i] < A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                      //  Console.Write ("\t temp " + temp);
                    }
                }
              
            }
                Console.Write("Descending order is :  ");
                for (int i = 0; i < A.Length; i++)
                    Console.Write(A[i] + "\t");
            
        }
    }
}
