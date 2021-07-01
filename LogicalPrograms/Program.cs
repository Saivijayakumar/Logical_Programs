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
            Console.WriteLine("\t 1.Fibonacci Series\n\t 2.");
            Console.WriteLine("\t----------------------------------------------");
            Console.Write("\tEnter your choice : ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("\t Fibonacci Series Code Starts");
                    FibonacciSeries.ReadInput();
                    break;
            }

            Console.Read();
        }
    }
}
