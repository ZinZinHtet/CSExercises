using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i <= 10000; i++)
            {
                int k = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        k++;
                }

                if (k == 2)
                {
                    if (i >= 5)
                        Console.WriteLine("Prime number is " + i);
                }
            }


        }
    }
}
