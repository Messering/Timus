using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timuswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a+b={0}",a+b);
            Console.ReadKey();
        }
    }
}
