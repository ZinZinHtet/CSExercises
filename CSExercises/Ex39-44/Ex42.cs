using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex42
    {

       public static void Main(string[] args)
        {
            Console.WriteLine(" Enter sentence A.");
            string c = Console.ReadLine();
            string a = c.ToLower().Replace(" ", "");

            Console.WriteLine(" Enter sentence B.");
            string d = Console.ReadLine();
            string b = d.ToLower().Replace(" ", "");

            int f;

            f = FindWord(a, b);
            Console.WriteLine(f);

        }
       public static int FindWord(string s1, string s2)
       {
           bool q;
           q = s1.Contains(s2);
           if (q == true)
           {
               int x = s1.IndexOf(s2);
               return x;
           }
           else
               return -1;
       }
       
    }
}
