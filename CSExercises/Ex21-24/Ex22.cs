using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number for A.");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number for B.");
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A * B;
            // getting a and b
            
            
            do{
            if (A > B)
               {
                    A = A - B;
                             }
            else
            
                B = B - A;

             }while(A!=B);
            
                int X = A;
                int l = C/X;
            Console.WriteLine("HCF: " + X);
            Console.WriteLine("LCM: " + l);
           
        }
    }
}
