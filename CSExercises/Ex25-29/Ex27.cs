using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
           int x = 0;
            int y = 0;
            String a = "*";
            Console.WriteLine("X \t Y");
            Console.WriteLine("------------------------------");
            for ( x = -5; x < 6; x++)
            {
                y = 2 * (x * x) - 4 * x + 3;

                Console.WriteLine(x + " \t {0:###.0}",y);
            }  

            for (x = -5; x < 6; x++)
            {
                for (int j = y; j > 0; j--)
                {
                    y = 2 * (x * x) - 4 * x + 3;
                    Console.Write(a);
                }
                Console.Write("\n");
            }
        }
    }
}
