using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Linq;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] a = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[50];
            int[] q = new int[10];
             Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                
                b[i] = r.Next(0, 10);
                Console.Write(b[i] + "\t");
            }
            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < 50; j++)
                {
                    if (b[j] == a[i])
                    { q[i] =count++; }
                        
                }
                Console.WriteLine("Number\t Count");
                Console.WriteLine("  {0}\t   {1}", a[i], q[i]);
              

            }
            Console.WriteLine("Number");
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j < q[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }         
        }
    }
}

        