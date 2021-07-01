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
            Console.WriteLine("\t 1.Fibonacci Series\n\t 2.Perfect Number\n\t 3.");
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
                default:
                    Console.WriteLine("\t PLEASE ENTER A VALID OPTION");
                    break;
            }

            Console.Read();
        }
    }
}
