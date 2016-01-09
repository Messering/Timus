using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1820
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] date = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => double.Parse(i)).ToArray<double>();

            if ((date[0] * 2) % date[1] != 0)
                Console.WriteLine((date[0] * 2) / date[0] + 1);
            else
                Console.WriteLine((date[0] * 2) / date[1]);

            Console.ReadKey();
        }
    }
}
