using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int i;
            do
            {
                Console.WriteLine("Please Enter an integer.");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i != 88);
            Console.WriteLine("Lucky you...");
        }
    }
}
