using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Linq;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            double a;
            int f;
            Console.WriteLine("Enter the amount : ");
            a = Convert.ToDouble(Console.ReadLine());

    
            int b =Convert.ToInt32(a*100);   // getting the 100c
            //Console.WriteLine(b+"c");

            while( b>= 100)
            {
                b = b - 100;
                Console.WriteLine("100c");
            }

            //int d =Convert.ToInt32( (a - b)*100.00);
           
                     
           if ( b >= 50 )
           {
               b = b - 50;
               Console.WriteLine("50c");
               
           }
           while( b >= 20)
           {
               b = b - 20;
               Console.WriteLine("20c");
               
           }
            while( b >= 5 )
            {
                b = b - 5;
                Console.WriteLine("5c");
            }

        }
    }
}
