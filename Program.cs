using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 10, 20, 30, 40 };
            Console.WriteLine("element of array are :");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
