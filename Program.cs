//harold taylor CPS 3330_01 Lab2
using static System.Console;
namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int decison;
            double numOne, numTwo, numThree;
            
            Console.WriteLine("Are you averaging two or three numbers?");
            decison = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the first number");
                    numOne= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                    numTwo= Convert.ToInt32(Console.ReadLine());
           
            if(decison == 3 )
            {
                Console.WriteLine("Enter the third number");
                numThree = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The Average is {Average.GetAverage(numOne, numTwo, numThree)}");
            }
            else
            {
                Console.WriteLine($"The Average is {Average.GetAverage(numOne, numTwo)}");
            }
        }
    }
}