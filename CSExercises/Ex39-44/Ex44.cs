using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string []args)
        {
            Console.WriteLine("Type sentence.");
            string a = Console.ReadLine();

            Console.WriteLine("Enter character that will remove from sentence.");
            char b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter character that will replace.");
            char c = Convert.ToChar(Console.ReadLine());

            string d = Substitute(a, b, c);
            Console.WriteLine(d);

        }
        public static string Substitute(string s, char c1, char c2)
        {
            string e = s.Replace(c1, c2);
            return e;

        }
    }
}
