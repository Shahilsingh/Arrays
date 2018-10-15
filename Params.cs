using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Params
    {
        
        public void Show(params int[] val) 
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.Write(val[i]+" ");
            }
        }
        
        static void Main(string[] args)
        {
            Params program = new Params(); 
            program.Show(2, 4, 6, 8, 10, 12, 14);
            Console.ReadLine();
        }
    }
}  
   
