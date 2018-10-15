using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program6
    {
        static void Main()
        {
            int[] A = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("element of Array are :");
            foreach (int b in A)
            {
                Console.WriteLine(b + " ");
            }
            Console.WriteLine("\nEnter new size of the Array :");
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref A, N);
            Console.WriteLine("\nelement of the Array after resize are :");
            foreach (int b in A)
            {
                Console.WriteLine(b + " ");
            }
            Console.ReadLine();
        }
    }
}
