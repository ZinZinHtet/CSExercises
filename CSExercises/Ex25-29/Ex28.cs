using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter an integer .");
            int n = Convert.ToInt32(Console.ReadLine());

            int k = 0;  // counter

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    k++;
            }
            if (k == 2)
                Console.WriteLine(" The Number is a Prime Number.");
            else
                Console.WriteLine(" The Number is a Not Prime Number.");

        }
    }
}
