using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("Please type in ur mark.");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 80 && mark <= 100)
            {
                grade = 'A';
                Console.WriteLine(" You scored " + mark + " marks which is " + grade + " grade.");
            }        // get A grade
            else if (mark >= 60 && mark <= 79)
            {
                grade = 'B';
                Console.WriteLine(" You scored " + mark + " marks which is " + grade + " grade.");
            }        // get B grade
            else if (mark >= 40 && mark <= 59)
            {
                grade = 'C';
                Console.WriteLine(" You scored " + mark + " marks which is " + grade + " grade.");
            }        // get C grade
            else if (mark >= 0 && mark <= 39)
            {
                grade = 'D';
                Console.WriteLine(" You scored " + mark + " marks which is " + grade + " grade.");
            }        // get D grade
            else if (mark < 0)
            { Console.WriteLine("**Error**"); }
            else
            { Console.WriteLine("**Error**"); }

        }
    }
}