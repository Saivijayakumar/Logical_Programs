using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void CheckingPrime()
        {
            int c = 0;
            Console.WriteLine("Enter a Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=number/2;i++)
            {
                if(number % i == 0)
                {
                    c++;
                    break;
                }
            }
            if(c == 0)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("{0} is Not a Prime Number", number);
            }

        }
    }
}
