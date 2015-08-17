using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No.\t INVERSE\t SQUARE ROOT\t SQUARE ");
            Console.WriteLine("------------------------------------------");

            for (int i = 1 ; i < 11; i++)
            { double a = 1.0 / i ;
              double s = Math.Sqrt(i);
              double r = i*i;

                Console.Write("{0:#.0}\t ",i);
                Console.Write("{0:0.###}\t\t  ", a);
                Console.Write("{0:##.###}\t\t ", s);
                Console.Write("{0:###.0}", r);
                Console.WriteLine();

            }

        }
    }
}
