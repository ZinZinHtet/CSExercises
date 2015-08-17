using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV = 900;
            int DVD = 500;
            int MP = 700;

            Console.WriteLine(" If u didn't want to order the product, please type 0 for that product. ");

            Console.WriteLine("Enter the order quantity for TV product.");
            int t = Convert.ToInt32(Console.ReadLine());
            double tp = t * TV ;        // calculate the TV price

            Console.WriteLine("Enter the order quantity for DVD product.");
            int d = Convert.ToInt32(Console.ReadLine());
            double dp = d * DVD ;        // calculate DVD price

            Console.WriteLine("Enter the order quantity for MP3 product.");
            int m = Convert.ToInt32(Console.ReadLine());
            double mpp = m * MP;        // calculate MP3 price

            double total = tp + dp + mpp;  // total price for all

            if (total >= 5000 && total < 10000)           // if total exceed 5000, 10% dis
            {
                double a = (tp + dp) * 0.1;      // calculate %
                double q1 = total - a ;
                Console.WriteLine("Total price for this order is ${0:######.####}.", q1);
            }
            else if (total >= 10000)     // if total exceed 10000, 15% dis
            {
                double b = (tp + dp) * 0.15;        // calculate %
                double q2 = total -b ;
                Console.WriteLine("Total price for this order is ${0:######.####}.", q2);
            }

            else
                Console.WriteLine("Total price for this order is ${0:######.####}.", total);
            
        }
    }
}