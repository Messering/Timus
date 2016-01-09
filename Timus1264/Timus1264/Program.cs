using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus1264
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            Console.WriteLine(date[0]*(date[1]+1));
            Console.ReadKey();
        }
    }
}
