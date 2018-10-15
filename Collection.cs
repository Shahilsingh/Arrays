using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Collection
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);al.Add(200); al.Add(100); al.Add(200); al.Add(200);
            Console.WriteLine(al.Capacity); //
            al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100);
            Console.WriteLine(al.Capacity);//
            al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100); al.Add(100);
            Console.WriteLine(al.Capacity);//16
            Console.WriteLine(al.Capacity);
            foreach (object obj in al)
                Console.Write(obj + " ");
            al.Insert(1, 200);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.ReadLine();

        }
    }
}
