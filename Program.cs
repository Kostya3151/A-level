using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачки_ветвления_if___else__metanit_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите значение:");
          int a = Convert.ToInt32( Console.ReadLine());
          int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{a},{b}");
           
            Console.ReadKey();
        }
    }
}
