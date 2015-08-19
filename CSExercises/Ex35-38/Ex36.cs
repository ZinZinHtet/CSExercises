using System;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a word/ phrase for testing \"Palindrome\" ");
            string c = Console.ReadLine();

            string b = c.ToLower();  // change to lower case
            string a = b.Replace(" ", "");  // remove the space
           // Console.WriteLine(a);
            int h = 0;
            int half = (a.Length+1)/2;  // get the limit of pointer

            for (int i = 0; i < half; i++ )
            {
                if (a[i] == a[a.Length - 1 - i])
                {
                     h++;
                }
                else
                { Console.WriteLine("Not Palindrome."); break; }

                
            }
            if (h > 1)
                Console.WriteLine("Palindrome.");

        }
    }
}
