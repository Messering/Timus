using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus2012
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            if (f >= 1 && f <= 11) {
                if (4 * 60 >= (12 - f) * 45) { Console.WriteLine("YES"); }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }
    }
}
