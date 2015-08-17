using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type ur name .");
            string name = Console.ReadLine();
            Console.WriteLine("Please type ur gender in M or F .");
            string gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please type ur age .");
            int age = Convert.ToInt32(Console.ReadLine());
            if (gender == "M" )
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Uncle " + name);   // Uncle if >=40
                else
                    Console.WriteLine("Good Morning Mr." + name);
            }
            else
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Aunty " + name);
                else
                    Console.WriteLine("Good Morning Ms." + name);
            }

        }
    }
}