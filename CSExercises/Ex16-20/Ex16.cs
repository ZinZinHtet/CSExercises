using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type ur name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please type ur gender in M or F .");
            string gender =Convert.ToString(Console.ReadLine());
            if (gender == "M" )
            { Console.WriteLine("Good Morning Mr. " + name); }
            else
            { Console.WriteLine("Good Moring Ms. " + name); }
        }
    }
}