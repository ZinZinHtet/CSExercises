using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer.");
            int n = Convert.ToInt32(Console.ReadLine());

            int x = 0;  // storage of sum
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {

                    x += i;
                }

            }
            if (x == n)
                Console.WriteLine(" The number is a Perfect Number.");
            else
                Console.WriteLine(" The number is Not Perfect Number.");

        }
    }
}
