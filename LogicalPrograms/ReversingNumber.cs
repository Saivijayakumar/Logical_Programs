using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReversingNumber
    {
        public static void Reversing()
        {
            int rev = 0, rem;
            Console.WriteLine("Enter the number");

            //getting number from the user
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                //if we use % operater with 10 then we will get the last digit of the number
                rem = number % 10;//number is 1234 so if we do % for first rem will store 4 for next 3 and it goes unit nothing left

                rev = rev * 10 + rem;//0*10+4=4 , 4*10+3=43 , 43*10+2=432 , 432*10+1=4321

                //if we use / operater with 10 then we will get except last digit of the number.
                number /= 10;//number is 1234 so if we do / for first rem will store 123 for next 12 and it goes unit nothing left
            }

            Console.WriteLine("The reversed number is {0}", rev);
        }
    }
}
