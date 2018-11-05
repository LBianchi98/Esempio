using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[10];
            for (int i = 0; i < 10; i++)
            {
                v[i] = r.Next(50);
            }
            Array.Sort(v);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.Write("\n");
            Console.WriteLine("Massimo: " + v.Max());
            Console.WriteLine("Minimo:" + v.Min());
            Console.ReadLine();
        }
    }
}