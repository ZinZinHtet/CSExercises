using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter One of Triangle Length. First one: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter One of Triangle Length . Second one:");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter One of Triangle Length . Third one:");
            int c = Convert.ToInt32(Console.ReadLine());

            // getting the length of triangle

            int d = (a + b + c);
            double s = d / 2;   // get s

            double a1 = s - a;
            double a2 = s - b;
            double a3 = s - c;

            double area = Math.Sqrt(s * a1 * a2 * a3);
            System.Console.WriteLine(" Area is " + area);


        }
    }
}