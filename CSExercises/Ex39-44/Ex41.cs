using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex41
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter sentence A.");
            string c = Console.ReadLine();
            string a = c.ToLower().Replace(" ", "");

            Console.WriteLine(" Enter sentence B.");
            string d = Console.ReadLine();
            string b = d.ToLower().Replace(" ", "");

            bool f;

            f = InString(a, b);
            Console.WriteLine(f);

        }
        public static bool InString(string s1, string s2)
        {
            bool q;
            q = s1.Contains(s2);
            return q;

        }
    }
}