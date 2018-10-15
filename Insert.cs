using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Insert
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100); al.Add(200); al.Add(300);
            Console.WriteLine(al.Capacity);
            al.Insert(1, 200);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.ReadLine();

        }
    }
}

    

