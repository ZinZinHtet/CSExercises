using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Text;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            char[] v = new char[] {'a','e','i','o','u'};
            int count = 0;

            Console.WriteLine("Please enter a phrase.");
            string a = Console.ReadLine();

            string b = a.ToLower();        // make the letter to small

            for(int i = 0; i < v.Length; i++ )
            {
                for(int j = 0; j < b.Length; j++ )  // b[] is character
                {
                    if (v[i] == b[j])
                        count++;
                }
            }
            Console.WriteLine("Total number of vowels : " + count);  // finished a part

           
            for (int i = 0; i < v.Length; i++)
            {
                int r = 0;
                for (int j = 0; j < b.Length; j++)  // b[] is character
                {
                    if (v[i] == b[j])
                    {
                        r++;
                    }
                }
                Console.WriteLine("Number of " + v[i] + " : " + r);
            }


        }
    }
}
