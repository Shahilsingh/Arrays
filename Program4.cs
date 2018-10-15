using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program4
    {
        static void Main()
        {
            char[][] ch = new char[5][];
            ch[0] = new char[4] { 'a', 'b', 'c', 'd'}; 
            ch[1] = new char[3] { 'a', 'b', 'c'};
            ch[2] = new char[2] { 'a', 'b'};
            ch[3] = new char[1] { 'a'};
            ch[4] = new char[3] { 'a', 'b', 'c' };
            Console.WriteLine("element of arrays are:");
            {
                foreach (char[] r in ch)
                {
                    foreach (char c in r)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine(); 
            }



        }
    }
}
