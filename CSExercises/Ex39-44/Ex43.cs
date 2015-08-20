using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string [] args)
        {
            Console.WriteLine(" Enter the integer for Hex ");
            int a = Convert.ToInt32(Console.ReadLine());

            string b = Hex(a);
            Console.WriteLine(" Hex : " + b);
         

            for (int j = 1; j < 101; j++)
            {
                string c = Hex(j);
                Console.WriteLine(" {0} of Hex is {1} ", j, c);
            }
        }

        public static string Hex(int i)
        {
            return i.ToString("X");

        }

        
    }
}
