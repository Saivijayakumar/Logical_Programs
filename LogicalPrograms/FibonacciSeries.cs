using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void ReadInput()
        {
            int num1 = 0, num2 = 1, sum, range;
            Console.WriteLine("Enter the range ");

            //getting range from the user
            range = Convert.ToInt32(Console.ReadLine());

            //If range is Less than 2
            if (range == 1)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.Write("[");
                Console.Write(" "+num1);
                Console.Write(" "+num2);

                range -= 2;
                //Using while loop for generating fibbonacci series
                while (range > 0)
                {
                    sum = num1 + num2;
                    Console.Write(" "+sum);
                    num1 = num2;
                    num2 = sum;
                    range -= 1;
                }
                Console.Write(" ]");
            }
        }
    }
}
