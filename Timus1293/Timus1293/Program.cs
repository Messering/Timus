//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Timus1293
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter N, A, B:");
//            int N = int.Parse(Console.ReadLine()),
//                A = int.Parse(Console.ReadLine()),
//                B = int.Parse(Console.ReadLine());
//            if (N >= 0 && N <= 100 &&
//                 A >= 0 && A <= 100 &&
//                 B >= 0 && B <= 100) {
//                Console.WriteLine("Result: {0}", (N*(A* B))*2);
//            }
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Linq;

namespace Timus1293
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arg = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            Console.WriteLine("{0}", ((arg[1] * arg[2]) * 2) * arg[0]);
        }
    }
}