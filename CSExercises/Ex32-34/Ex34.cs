using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] A = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
           double classsum , totalmark, total = 0 , count = 0;

           //int Col = 12 ,  row = 4;

           for (int i = 0; i < 12; i++)
           {
               totalmark = 0;
               for (int j = 0; j < 4; j++)

               { totalmark = totalmark + A[i, j]; }
               Console.WriteLine("Total marks for each student : " + totalmark);

           }       // for the total

           Console.WriteLine();
           for (int i = 0; i < 4; i++)
           {
               classsum = 0;
               for (int j = 0; j < 12; j++)

               { classsum = classsum + A[j, i]; }
               Console.WriteLine("Class Average : " + classsum/12);

           }     // Average of sub 

           Console.WriteLine();
           for (int i = 0; i < 12; i++)
           {
              for (int j = 0; j < 4; j++)

               { total = total + A[i, j]; 
              count++;
              }
           }
               Console.WriteLine("Overall average mark : " + total/48);

                


        }
    }
}
