using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program2
    {
        static void Main()
        {
            int[][] A = new int[3][];
            A[0] = new int[4] { 10, 20, 30, 40 };
            A[1] = new int[3] { 50, 60, 70 };
            A[2] = new int[2] { 80, 90 };
            Console.WriteLine("element of jagged Array are :");
            for(int r = 0; r < A.Length; r++)
            {
                for(int c = 0; c < A[r] .Length; c++)
                {
                    Console.WriteLine(A[r] [c] + " ");
                }

                Console.WriteLine();


            }
                Console.ReadLine();

            
        }
    }
}
