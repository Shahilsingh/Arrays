using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program3
    {
        public static void Main()
        {
            int[][] A = new int[3][];
            A[0] = new int[4] { 10, 20, 30, 40 };
            A[1] = new int[3] { 10, 20, 30 };
            A[2] = new int[2] { 10, 20 };
            Console.WriteLine("element of jagged array are :");
            foreach (int[] r in A)
            {
                foreach (int c in r)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

             
    }
}
