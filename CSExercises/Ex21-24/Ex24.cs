using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Please input the number for finding the Square Root. ");
            int N = Convert.ToInt32(Console.ReadLine());        // get the number

            Random rd = new Random();
            double G = rd.Next(1, N + 1); // generating number
           // G = Math.Round(G, 5);
            Console.WriteLine("Random number is " + G);

           // double d = Math.Round(Math.Sqrt(N), 5); // getting the square root
           // Console.WriteLine("Square Root of ur number " + d);
            

             while(G*G!=N){
                 Console.WriteLine("product of guess number is"+G * G);
                double A = N / G;
                G = ( G + A )/ 2;
                G = Math.Round(G, 5);
               
                i++;                       
             } 
            
        
       Console.WriteLine("Correct!");
       Console.WriteLine("Attempt " + i);
            

            
        }
    }
}
