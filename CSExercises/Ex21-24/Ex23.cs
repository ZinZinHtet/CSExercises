using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random rd = new Random();
            int r = rd.Next(0, 10);  // generating from 0 to 9
            int i = 0; // assign the counter
            int g;

            do  // work if random no is not equal to guess no
            {
                Console.WriteLine("Guess the Number. ");   // input a no
                g = Convert.ToInt32(Console.ReadLine());
                i++;     // counting
                Console.WriteLine("Try again.");
            } while (r != g);
            Console.WriteLine("Congratulation!");
            Console.WriteLine("Ur attempt is " + i);

            if (i <= 2 )
            { Console.WriteLine("You are a Wizard!"); }
            else if (i > 3 && i <= 5 )
            { Console.WriteLine("You are a good guess."); }
            else
            { Console.WriteLine("You are lousy!"); }




        }
    }
}
