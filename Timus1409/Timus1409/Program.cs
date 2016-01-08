//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Timus1409
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Harry:");
//            int numberHarry = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Larry:");
//            int numberLarry = int.Parse(Console.ReadLine());
//            int numberBank = (numberHarry + numberLarry) - 1;
//            Console.WriteLine("Result Harry- {0} and Larry- {1}",numberBank-numberHarry,numberBank-numberLarry);
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1409
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            int numberBank = (ints[0] + ints[1]) - 1;
            Console.WriteLine("{0} {1}", numberBank - ints[0], numberBank - ints[1]);
            Console.ReadKey();
        }
    }
}
