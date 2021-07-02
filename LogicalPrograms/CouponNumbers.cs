using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        public static void GeneratingCouponNumbers()
        {
            int lowerRange, higherRange, Coupon, couponCount = 0;

            Console.WriteLine("Enter start range of coupon number");
            lowerRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter End range of coupon number");
            higherRange = Convert.ToInt32(Console.ReadLine());

            //HashSet is a pre-defined class it has the properties like it will only store distinct vlaues in it and store it in hash table format
            HashSet<int> couponsList = new HashSet<int>();

            //Creating object for accessing random methods
            Random random = new Random();
            //up to the given range it runs the loop
            while (couponsList.Count <= Math.Abs(lowerRange - higherRange))
            {
                Coupon = random.Next(lowerRange, higherRange + 1);
                couponCount++;
                couponsList.Add(Coupon);//every time we add the random number into the list 
            }

            Console.WriteLine("The  distinct coupons are");
            //by using foreach only we can get the values in HashSet
            foreach (int i in couponsList)
            {
                Console.Write(i + " , ");
            }

            //Showing the count
            Console.WriteLine($"\t\nWe need {couponCount} Random number generate a coupon");
        }
    }
}
