using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence/phrase.");
            string a = Console.ReadLine();
            string fi = " "; // for final

            string[] s= a.Split(' ');  // divide wherever space occur
            string b = " ";     // create empty string
            
            for(int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine(s[i]);
                b = s[i];
                string r = b.ToUpper().Substring(0, 1) + b.Substring(1, b.Length - 1);   // first letter upper case

               // Console.WriteLine(r);
                fi = fi +r + " ";
            }
            
            string de = fi.Trim();
            Console.WriteLine(de);
        }
    }
}
