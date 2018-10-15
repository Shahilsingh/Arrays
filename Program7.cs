using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program7
    {
        static void Main()
        {
            int[] A = new int[5] { 90, 11, 33, 44, 55 };
            int[] B = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("element of Array A are :");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n element of Array B are :");
            foreach (int i in B)
            {
                Console.Write(i + " ");
            }
            Array.Copy(A, B, 2);
            Console.WriteLine("\n element of Array B After copy  are :");
            foreach (int i in B)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
            
    }
}
