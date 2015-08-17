using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter 3 digit number. First digit ");
            int a = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(" Enter 3 digit number. Second digit ");
            int b = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(" Enter 3 digit number. Third digit ");
            int c = System.Convert.ToInt32(Console.ReadLine());
            // get 3 digit

            int d = (a * a * a) + (b * b * b) + (c * c * c);
            System.Console.WriteLine(" Output is " + d);


        }
    }
}