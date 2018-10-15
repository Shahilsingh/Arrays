using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program1
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
