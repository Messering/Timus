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
            //Console.WriteLine("Enter a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            ////int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            ////int.Parse(Console.ReadLine());
            //Console.WriteLine("a+b={0}",a+b);
            int[] argument = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            Console.WriteLine("{0}", argument[0] + argument[1]);
            Console.ReadKey();
        }
    }
}
