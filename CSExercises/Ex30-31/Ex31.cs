using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int i, j;

            for (j = 1; j <= 1000; j++)
            {
                int x = 0;
                for (i = 1; i < j; i++)
                {
                    if (j % i == 0)
                        x = x + i;
                }



                if (x == j)
                { Console.WriteLine(" The number is a Perfect Number is " + j); }

            }  

        }
    }
}
