using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            List<int> b = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
                a[i] = r.Next(100);


            PrintIntArray(a);
            
        }

        private static void PrintIntArray(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
