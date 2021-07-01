using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void CheckingPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number");

            //getting number from the user
            int number = Convert.ToInt32(Console.ReadLine());

            //Doing for loop for checking divisors
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

            }
            //condition to check if its a perfect number
            if (sum == number)
            {
                Console.WriteLine("{0} is a Perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect number", number);
            }
        }
    }
}
