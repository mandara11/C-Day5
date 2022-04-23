using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class EvenOdd
    {
        public static void evenodd()
        {
            int i;
            Console.WriteLine("Enter the number: ");
            i = int.Parse(Console.ReadLine());
            if (i %2 == 0)
            {
                Console.WriteLine("Enter the number is an even number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Enter the number is an odd number");
                Console.Read();
            }

        }
    }
}
