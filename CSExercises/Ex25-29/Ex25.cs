using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for Factorial .");
            int f = Convert.ToInt32(Console.ReadLine());
            int i,b, a = 1;
            for (i = 1; i <= f; i++)
            { a *= i; }     // using increasment 

            for (b = f; b >= 0; b-- )
            { Console.Write(b + " "); }   // using decrasement

            Console.WriteLine("Factorial is " + a);



        }
    }
}
