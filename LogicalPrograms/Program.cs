using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    /// <summary>
    /// ===========>WELCOME<=============
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWELCOME\n");
            Console.WriteLine("\tThese are the LIST of some Logical Programs");
            Console.WriteLine("\t----------------------------------------------");
            Console.WriteLine("\t 1.Fibonacci Series\n\t 2.Perfect Number\n\t 3.Prime Number\n\t 4.Reversing Number\n\t 5.Coupon Numbers\n\t 6.Stop Watch");
            Console.WriteLine("\t----------------------------------------------");
            Console.Write("\tEnter your choice : ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("\t Fibonacci Series Code Starts");
                    FibonacciSeries.ReadInput();
                    break;
                case 2:
                    Console.WriteLine("\t Perfect Number Code Starts");
                    PerfectNumber.CheckingPerfectNumber();
                    break;
                case 3:
                    Console.WriteLine("\t Prime Number Code Starts");
                    PrimeNumber.CheckingPrime();
                    break;
                case 4:
                    Console.WriteLine("\t Reversing Number Code Starts");
                    ReversingNumber.Reversing();
                    break;
                case 5:
                    Console.WriteLine("\t Coupon Number Code Starts");
                    CouponNumbers.GeneratingCouponNumbers();
                    break;
                case 6:
                    Console.WriteLine("\t Stop Watch Code Starts");
                    StopWatch.MeasuringTime();
                    break;
                default:
                    Console.WriteLine("\t PLEASE ENTER A VALID OPTION");
                    break;
            }

            Console.Read();
        }
    }
}
